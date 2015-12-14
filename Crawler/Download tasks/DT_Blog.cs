using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Diagnostics;
using System.Net;
using System.Web;
using System.IO;
using System.Threading;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
    class DT_Blog : DT_Base
    {
        private DQ_ParticularForum _queue;
        private Forum _F;

        public DT_Blog(IDownloader downloader, Forum idForum)
			: base(downloader)
		{
			_idF = idForum;
		}

        #region DT_Base
        public override string Uri
        {
            get			// lazy : construct uri on first use
            {
                var u = base.Uri;
                if (String.IsNullOrEmpty(u))
                {
                    var f = (Forum)Globals.Db.Forum.Get(_idF);		// TODO: null? Handle it
                    u = base.Uri = f.Url;
                }
                return u;
            }
        }
        #endregion

        public override void Download()
        {
            if (null == _queue) _queue = new DQ_ParticularForum(downloader: Globals.NewInstance());

            while (true)
            {
                _F = (Forum)Globals.Db.Forum.Get(_idF);                
                var now = DateTime.UtcNow;
                CrawlCategories(_F);

                var categories = Globals.Db.Category.GetAll(_idF);
                Download(categories);

                if (_F.LatestCrawlTime + _F.CrawlInterval >= now)
                {
                    Thread.Sleep(_F.LatestCrawlTime + _F.CrawlInterval - now);
                }

                _F.LatestCrawlTime = DateTime.UtcNow;
                Globals.Db.Forum.Set(_F);
            }
        }

        private void Download(IEnumerable<Category> categories)
        {
            foreach (Category CategorySingle in categories) // post all the categories and then start queue
            {
                _queue.Enqueue(
                    // TODO: handle forums with threads from oldest to newest 
                    new DT_BlogCategory(_queue.Downloader, CategorySingle , _F, _queue, 1)
                    // start with the first page: most of our forums have from newest to oldest sorting order
                    );
                //break;	// HACK: only one category for debugging
            }
            _queue.Start();
            while (_queue.IsAlive)
            {
                Thread.Sleep(200);
            }
        }

        static bool CrawlCategories(Forum forum)
        {
            try
            {
                var page = Download(forum.Url, forum);
                if (page == null)
                {
                    Console.WriteLine("Page not found. ");
                    return false;
                }
                //if(forum.CategoryPage_Url == null || forum.CategoryPage_Url == "")
                //var categorypage = FindCategoryPage(page, forumUri, forum);
                if (forum.UrlPage_Title == null || forum.UrlPage_Id == "")
                {
                    Console.WriteLine("forum.UrlPage_Title Regex is not populated");
                    return false;
                }

                var titles =
                    (new Regex(forum.UrlPage_Title, RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(page);
                var ids = (new Regex(forum.UrlPage_Id, RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(page);
                if ((titles.Count ^ ids.Count) != 0)
                {
                    return false;
                }

                for (var i = 0; i < ids.Count; i += 1)
                {
                    try
                    {
                        bool AlreadyUsedID = false;

                        var id = ids[i].Groups[1].ToString();
                        //code added by atif to delete multiple copies of same category
                        //to check if the ID is already entertained
                        for (int loop1 = 0; loop1 < i; loop1++)
                        {
                            var Check_id = ids[loop1].Groups[1].ToString();
                            if (id == Check_id)
                            {
                                AlreadyUsedID = true;
                                break;
                            }
                        }
                        if (AlreadyUsedID == true)
                            continue;
                        var title = titles[i].Groups[1].ToString();
                        //Ugly hack for familjeliv but it actually looks like this on the site so don't really know how to fix it. Create function of this at least.
                        title = swedishTitle(title);


                        ///////////////
                        var blogUri = new Uri(string.Format(forum.category.Url, id));
                        //var blogPageUri = new Uri(string.Format(forum.category.Url,id), UriKind.Absolute);
                        //var blogPage = Download(MakeAbsolute(blogUri, blogPageUri), forum);
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(blogUri);
                        request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.116 Safari/537.36";

                        request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                        WebHeaderCollection Headers = new WebHeaderCollection();
                        Uri RedirectedBlogUrl = new Uri(blogUri.ToString());
                        string blogRssUrl = "";
                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                        {
                            Headers = response.Headers;
                            RedirectedBlogUrl = response.ResponseUri;
                            var blogPage = DownloaderEncoding.ProcessContent(response);
                            //using (var client = new WebClient())
                            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                            doc.LoadHtml(blogPage);
                            var rssLinks = doc.DocumentNode.Descendants("link")
                                .Where(n => n.Attributes["type"] != null && n.Attributes["type"].Value == "application/rss+xml")
                                .Select(n => n.Attributes["href"].Value)
                                .ToArray();
                            if (rssLinks.Count() == 0)
                            {
                                rssLinks = doc.DocumentNode.Descendants("link")
                                .Where(n => n.Attributes["title"] != null && n.Attributes["title"].Value == "RSS")
                                .Select(n => n.Attributes["href"].Value)
                                .ToArray();
                            }
                            if (rssLinks.Count() > 0)
                                blogRssUrl = rssLinks[0];
                            else
                                continue;
                        }

                        ///////////////



                        if (!blogRssUrl.Contains("http://"))
                        {
                            blogRssUrl = RedirectedBlogUrl.ToString() + blogRssUrl.Replace("/", "");
                        }

                        Category c_Create = Globals.Db.Category.Get(id, forum.Id);
                        if (!Globals.Db.Category.Exsist(id, forum.Id, ref c_Create))
                        {
                            var category = new Category()
                            {
                                ForumId = forum.Id,
                                StringExternalId = id,
                                Title = title,
                                ForumName = forum.Name,
                                ForumUrl = blogRssUrl,
                                Level = 0
                            };
                            Globals.Db.Category.Set(category);
                        }
                    }
                    catch (Exception ex) { }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return true;
        }

        private static string swedishTitle(string title)
        {
            title = title.Replace("&amp;", "&"); title = title.Replace("&Aring;", "Å"); title = title.Replace("&aring;", "å"); title = title.Replace("&Auml;", "Ä"); title = title.Replace("&auml;", "ä"); title = title.Replace("&Ouml;", "Ö"); title = title.Replace("&ouml;", "ö");
            return title;
        }

        static string Download(string uri, Forum forum)
        {
            var html = DownloaderEncoding.GetPage(uri);
            return html;
        }

    }
}