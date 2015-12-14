using System.Xml;
using OneKey.Database.Config;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OneKey.Crawler
{
    class CrawlForum
    {
        public static void StartCrawl()
        {
            try
            {
                bool result = Forum.Exists(1102);
                var _F = Db.SQL<Forum>("SELECT f FROM Forum f");
                foreach (var _f in _F)
                {
                    //Not for Blogs
                    if (_f.Type == "blog")
                        continue;
                    //bool Result_CrawlCategories = CrawlForCategories(_f);
                    bool Result_Crawls = CrawlForum(_f);
                }
            }
            finally
            {
                IsCrawlerAlive = false;
            }
        }
        //static bool CrawlCategories(Forum forum)
        //{
        //    try
        //    {
        //        {
        //            var forumUri = new Uri(forum.Url);
        //            var forumPageUri = new Uri(forum.Url, UriKind.Absolute);
        //            //if (forum.Type == "99mac")
        //            //{
        //            //    forumPageUri = new Uri(forumPageUri + "forum");
        //            //}
        //            var page = Download(MakeAbsolute(forumUri, forumPageUri), forum);
        //            if (page == null)
        //            {
        //                Console.WriteLine("Page not found. ");
        //                return false;
        //            }
        //            //if(forum.CategoryPage_Url == null || forum.CategoryPage_Url == "")
        //            //var categorypage = FindCategoryPage(page, forumUri, forum);
        //            if (forum.UrlPage_Title == null || forum.UrlPage_Id == "")
        //            {
        //                Console.WriteLine("forum.UrlPage_Title Regex is not populated");
        //                return false;
        //            }

        //            var titles =
        //                (new Regex(forum.UrlPage_Title, RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(page);
        //            var ids = (new Regex(forum.UrlPage_Id, RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(page);
        //            if ((titles.Count ^ ids.Count) != 0)
        //            {   
        //                return false;
        //            }

        //            for (var i = 0; i < ids.Count; i += 1)
        //            {
        //                bool AlreadyUsedID = false;
        //                if (forum.Id != 1103)
        //                {
        //                    var id = int.Parse(ids[i].Groups[1].ToString());
        //                    //code added by atif to delete multiple copies of same category
        //                    //to check if the ID is already entertained
        //                    for (int loop1 = 0; loop1 < i; loop1++)
        //                    {
        //                        var Check_id = int.Parse(ids[loop1].Groups[1].ToString());
        //                        if (id == Check_id)
        //                        {
        //                            AlreadyUsedID = true;
        //                            break;
        //                        }
        //                    }
        //                    if (AlreadyUsedID == true)
        //                        continue;
        //                    var title = titles[i].Groups[1].ToString();
        //                    //Ugly hack for familjeliv but it actually looks like this on the site so don't really know how to fix it. Create function of this at least.
        //                    title = swedishTitle(title);
        //                    //System.ing..Sleep(1000);
        //                    var results = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.ExternalId =? AND c.Forum.Id=?", id, forum.Id);
        //                    var category1 = results.Count();
        //                    if (category1 == 0)
        //                    {

        //                        Db.Transaction(() =>
        //                        {
        //                            var category = new OneKey.Database.Config.Category()
        //                            {
        //                                Id = forum.Id,
        //                                Forum = forum,
        //                                ExternalId = id,
        //                                Title = title,
        //                                Level = (short)(0)
        //                            };
        //                        });
        //                    }
        //                }
        //                else
        //                {
        //                    var id = ids[i].Groups[1].ToString();
        //                    //code added by atif to delete multiple copies of same category
        //                    //to check if the ID is already entertained
        //                    for (int loop1 = 0; loop1 < i; loop1++)
        //                    {
        //                        var Check_id = ids[loop1].Groups[1].ToString();
        //                        if (id == Check_id)
        //                        {
        //                            AlreadyUsedID = true;
        //                            break;
        //                        }
        //                    }
        //                    if (AlreadyUsedID == true)
        //                        continue;
        //                    var title = titles[i].Groups[1].ToString();
        //                    //Ugly hack for familjeliv but it actually looks like this on the site so don't really know how to fix it. Create function of this at least.
        //                    title = swedishTitle(title);
        //                    var results = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.StringExternalId  =? AND c.Forum.Id=?", id, forum.Id);
        //                    var category1 = results.Count();
        //                    if (category1 == 0)
        //                    {

        //                        Db.Transaction(() =>
        //                        {
        //                            var category = new OneKey.Database.Config.Category()
        //                            {
        //                                Id = forum.Id,
        //                                Forum = forum,
        //                                StringExternalId = id,
        //                                Title = title,
        //                                Level = (short)(0)
        //                            };
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //        return false;
        //    }
        //    return true;
        //}


        //private static bool CrawlForCategories(Forum forum)
        //{
        //    try
        //    {
        //        //Crawl categories
        //        CrawlCategories(forum);

        //        for (var u = 0; u < 3; u += 1)
        //        {
        //            try
        //            {
        //                // Get Categories. 
        //                Category[] categories = GetCategories(forum, u);

        //                // Crawl Categories
        //                CrawlSubCategories(forum, categories, u);
        //            }
        //            catch (Exception)
        //            { }
        //        }
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //static void CrawlSubCategories(Forum forum, Category[] categories, int level)
        //{
        //    try
        //    {
        //        for (var o = 0; o < categories.Count(); o += 1)
        //        {
        //            try
        //            {
        //                //System.ing..Sleep(300);
        //                //using (var session = Store.OpenSession())
        //                //{
        //                    try
        //                    {
        //                        //session.Advanced.MaxNumberOfRequestsPerSession = 1000;
        //                        string urlstring;
        //                        if (forum.Id != 1103)
        //                        {
        //                            urlstring = string.Format(forum.CategoryPage_Url, categories[o].ExternalId, 1);
        //                        }
        //                        else
        //                        {
        //                            if (categories[o].StringExternalId.Contains("/"))
        //                            {
        //                                string[] categoryIDsplit = categories[o].StringExternalId.Split('/');
        //                                urlstring = string.Format(forum.CategoryPage_Url, categoryIDsplit[0], categoryIDsplit[1], 1);
        //                            }
        //                            else
        //                                urlstring = string.Format("http://www.familjeliv.se/forum/{0}/latest/{1}", categories[o].StringExternalId, 1);
        //                        }

        //                        Uri url = new Uri(urlstring);
        //                        var page = Download(MakeAbsolute(url, url), forum);
        //                        if (page == null)
        //                        {
        //                            continue;
        //                        }
        //                        var titles =
        //                            (new Regex(forum.UrlPage_Title, RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(page);
        //                        var ids = (new Regex(forum.UrlPage_Id, RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(page);
        //                        if ((titles.Count ^ ids.Count) != 0)
        //                        {
        //                            return;
        //                        }
        //                        for (var i = 0; i < ids.Count; i += 1)
        //                        {

        //                            bool AlreadyUsedID = false;
        //                            if (forum.Id != 1103)
        //                            {
        //                                var id = int.Parse(ids[i].Groups[1].ToString());
        //                                //code added by atif to delete multiple copies of same category
        //                                //to check if the ID is already entertained
        //                                for (int loop1 = 0; loop1 < i; loop1++)
        //                                {
        //                                    var Check_id = int.Parse(ids[loop1].Groups[1].ToString());
        //                                    if (id == Check_id)
        //                                    {
        //                                        AlreadyUsedID = true;
        //                                        break;
        //                                    }
        //                                }
        //                                if (AlreadyUsedID == true)
        //                                    continue;
        //                                var title = titles[i].Groups[1].ToString();
        //                                title = swedishTitle(title);
        //                                var results = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.ExternalId =? AND c.Forum.Id=?",id , forum.Id);
        //                                var category1 = results.Count();
        //                                if (category1 == 0)
        //                                {

        //                                    Db.Transaction(() =>
        //                                    {
        //                                        var category = new OneKey.Database.Config.Category()
        //                                        {
        //                                            Id = forum.Id,
        //                                            Forum = forum,
        //                                            ExternalId = id,
        //                                            Title = title,
        //                                            Level = (short)(level + 1)
        //                                        };
        //                                    });
        //                                }
        //                            }
        //                            else
        //                            {
        //                                var id = ids[i].Groups[1].ToString();
        //                                var title = titles[i].Groups[1].ToString();
        //                                title = swedishTitle(title);
        //                                var results = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.StringExternalId =? AND C.ForumId =?", id, forum.Id);
        //                                var category1 = results.Count();
        //                                if (category1 == 0)
        //                                {
        //                                    Db.Transaction(()=>
        //                                    {
        //                                        var category = new OneKey.Database.Config.Category()
        //                                        {
        //                                            Id = forum.Id,
        //                                            Forum = forum,
        //                                            StringExternalId = id,
        //                                            Title = title,
        //                                            Level = (short)(level + 1)
        //                                        };
        //                                    });
        //                                }
        //                            }
        //                        }
        //                    }
        //                    catch (Exception)
        //                    { }
        //                //}
        //            }
        //            catch (Exception)
        //            { }
        //        }
        //    }
        //    catch (Exception)
        //    { }
        //}

        //        static Uri MakeAbsolute(Uri baseUri, Uri uri)
        //{
        //    Debug.Assert(baseUri.IsAbsoluteUri);
        //    return uri.IsAbsoluteUri ? uri : new Uri(baseUri + uri.ToString());
        //}
        //        static string Download(Uri uri, Forum forum)
        //        {
        //            var html = DownloaderEncoding.GetPage(uri.ToString());
        //            return html;
        //            //UTF8Encoding Encoding = new UTF8Encoding();
        //            //var bytes = Client.GetByteArrayAsync(uri).Result;
        //            //if(forum.Type == "99mac" || forum.Name == "Mammapappa.se")
        //            //{
        //            //    return Encoding.UTF8.GetString(bytes);
        //            //}
        //            //else
        //            //{
        //            //    return Encoding.Default.GetString(bytes);
        //            //}

        //        }



        //static Category[] GetCategories(Forum forum, int level)
        //{
        //    try
        //    {
        //        return Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.Forum.Id = ? AND c.Level = ?", forum.Id, level).ToArray();
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}


        //static bool CrawlFors(Forum f)
        //{
        //    try
        //    {
        //        int paging = 0;
        //        var CategoriesList = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.Forum.Id = ?", f.Id);//or we can use "WHERE c.Id = ?", f.Id too

        //        while (CategoriesList.Count() > 0)
        //        {
        //            foreach (OneKey.Database.Config.Category CategorySingle in CategoriesList)
        //            {
        //                try
        //                {
        //                    Crawls(CategorySingle, CategorySingle.Forum.StartCrawlPage);
        //                }
        //                catch (Exception ex) 
        //                { }
        //            }
        //        }
        //        return true;
        //    }
        //    catch (Exception ex)
        //    { return false; }
        //}



        //private static void Crawls(Category CategorySingle,int PageNumer)
        //{
        //    // download category main page
        //    try
        //    {
        //        var newThereadCount = 0;
        //        string categoryPage;
        //        //if (CategorySingle.Forum.Id != 1113) //Byggahus test
        //        //{
        //        string CategoryPageUrl = string.Format(CategorySingle.Forum.CategoryPage_Url, CategorySingle.ExternalId, PageNumer);
        //        categoryPage = DownloaderEncoding.GetPage(CategoryPageUrl);
        //        //}
        //        //else
        //        //{
        //        //    categoryPage = Downloader.Download(u1);
        //        //}

        //        // TODO: extract parser from here

        //        var reId = new Regex(CategorySingle.Forum.CategoryPage_Id, RegexOptions.Singleline | RegexOptions.IgnoreCase);
        //        var reTitle = new Regex(CategorySingle.Forum.CategoryPage_Title, RegexOptions.Singleline | RegexOptions.IgnoreCase);

        //        var IdMatches = reId.Matches(categoryPage);						   // Retrieve content from page.
        //        var TitleMatches = reTitle.Matches(categoryPage);
        //        //System.Diagnostics.Process.Start(u1);

        //        if ((TitleMatches.Count ^ IdMatches.Count) != 0)
        //        {
        //            string bugLog = TitleMatches.Count.ToString() + " " + TitleMatches.Count.ToString() + " " + CategoryPageUrl;
        //            // Write the string to a file.
        //            DateTime now = DateTime.Now;
        //            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + CategorySingle.Forum.Name + ".txt");
        //            file.WriteLine(bugLog);

        //            file.Close();
        //            return;
        //        }

        //        // Loop all retrieved content, and add new content to database.
        //        for (var i = 0; i < IdMatches.Count; i += 1)
        //        {
        //            try
        //            {
        //                var externalId = 0;
        //                var externalIdString = "";
        //                if (CategorySingle.Forum.Type == "Episerver")
        //                {
        //                    externalIdString = IdMatches[i].Groups[1].ToString();
        //                    var regex = new Regex(@"-(\d\d*)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
        //                    var test = regex.Matches(externalIdString);
        //                    if (test.Count != 0)
        //                    {
        //                        var test2 = test[0].Groups[1].ToString();
        //                        externalId = int.Parse(test2);
        //                    }
        //                    else
        //                    {
        //                        externalId = int.Parse(externalIdString);
        //                    }
        //                }
        //                else
        //                {
        //                    try
        //                    {
        //                        if (!int.TryParse(IdMatches[i].Groups[1].ToString(), out externalId))
        //                        {
        //                            if (CategorySingle.Forum.StringExternalId == false)
        //                            {
        //                                externalIdString = IdMatches[i].Groups[1].ToString();
        //                                var regex = new Regex(@"(\d+)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
        //                                externalId = int.Parse(regex.Match(externalIdString).ToString());
        //                            }
        //                            else
        //                            {
        //                                externalIdString = IdMatches[i].Groups[1].ToString();
        //                                externalId = 0;
        //                            }
        //                        }
        //                        //else
        //                        //    externalId = int.Parse(IdMatches[i].Groups[1].ToString());
        //                    }
        //                    catch (Exception)
        //                    { }
        //                }

        //                try
        //                {
        //                    var Title = TitleMatches[i].Groups[1].ToString();
        //                    Title = Cleanup(Title);

        //                    //code added by atif to delete multiple copies of same s
        //                    //to check if the ID is already entertained

        //                    //.GetAll(Rid parentEntity);
        //                    //need to check existing s from DB

        //                    bool AlreadyUsedTitle = false;
        //                    for (int loop1 = 0; loop1 < i; loop1++)
        //                    {
        //                        var Check_Title = TitleMatches[loop1].Groups[1].ToString();
        //                        Check_Title = Cleanup(Check_Title);
        //                        if (Title == Check_Title)
        //                        {
        //                            AlreadyUsedTitle = true;
        //                            break;
        //                        }
        //                    }
        //                    if (AlreadyUsedTitle == true)
        //                        continue;
        //                    /////////////////////////////////////////////////

        //                    //Todo: Duplication check
        //                    if (CategorySingle.Forum.StringExternalId == false)
        //                    {
        //                        try
        //                        {
        //                            var Exists = Db.SQL<OneKey.Database.Config.>("SELECT t FROM OneKey.Database.Config. t WHERE t.ExternalId = ?", externalId).First;
        //                            {
        //                                try
        //                                {
        //                                    newThereadCount += 1;
        //                                    var dtNow = DateTime.UtcNow;
        //                                    Db.Transaction(() =>
        //                                    {
        //                                        if (Exists == null)
        //                                        {
        //                                            OneKey.Database.Config. Commit = new OneKey.Database.Config.
        //                                            {
        //                                                ExternalId = externalId,
        //                                                StringExternalId = externalIdString,
        //                                                LatestCrawlTime = dtNow,
        //                                                Forum = CategorySingle.Forum,
        //                                                Category = CategorySingle,
        //                                                Title = Title,
        //                                                MessageCount = 0,
        //                                                FirstMessageId = 0,
        //                                                LastMessageId = 0,
        //                                                PageCount = 1,
        //                                                LastCrawledPage = Convert.ToInt16(CategorySingle.Forum.StartCrawlPage),
        //                                            };
        //                                            CrawlMessages(Commit, Commit.Category.PageCount);
        //                                        }
        //                                        else
        //                                        {
        //                                            Exists.LatestCrawlTime = DateTime.UtcNow;
        //                                        }
        //                                    });
        //                                    if (Exists == null)
        //                                    { 
        //                                    }
        //                                }
        //                                catch (Exception) 
        //                                { }
        //                            }
        //                        }
        //                        catch (Exception)
        //                        { }
        //                    }


        //                    if (externalId == 0 && CategorySingle.Forum.StringExternalId == true)
        //                    {
        //                        try
        //                        {
        //                            var Exists = Db.SQL<OneKey.Database.Config.>("SELECT t FROM OneKey.Database.Config. t WHERE t.externalIdString = ?", externalIdString).First();
        //                                newThereadCount += 1;
        //                                var dtNow = DateTime.UtcNow;
        //                                Db.Transaction(() =>
        //                                {
        //                                    if (Exists == null)
        //                                    {
        //                                        OneKey.Database.Config. Commit = new OneKey.Database.Config.
        //                                        {
        //                                            ExternalId = externalId,
        //                                            StringExternalId = externalIdString,
        //                                            LatestCrawlTime = dtNow,
        //                                            Forum = CategorySingle.Forum,
        //                                            Category = CategorySingle,
        //                                            Title = Title,
        //                                            MessageCount = 0,
        //                                            FirstMessageId = 0,
        //                                            LastMessageId = 0,
        //                                            PageCount = 1,
        //                                            LastCrawledPage = Convert.ToInt16(CategorySingle.Forum.StartCrawlPage)
        //                                        };
        //                                        CrawlMessages(Commit, Commit.Category.PageCount);
        //                                    }
        //                                    else
        //                                    {
        //                                        Db.Transaction(() =>
        //                                        {
        //                                            Exists.LatestCrawlTime = DateTime.UtcNow;
        //                                        });
        //                                    }
        //                                });                                    
        //                        }
        //                        catch (Exception)
        //                        { }
        //                    }
        //                }
        //                catch (Exception) 
        //                { }



        //                //_q.Enqueue(new DT_Forum(Downloader, externalId, forum.Id, _q, 0) { ForceLoadAll = ForceLoadAll, });

        //                // TODO: MessageCount
        //                // MessageCount += crawler.MessageCount;

        //                //break;	// HACK: only one category for debugging
        //            }
        //            catch (Exception ex)
        //            {
        //            }
        //        }

        //        try
        //        {
        //            if (CategorySingle.LastCrawledPage < PageNumer || newThereadCount > 0)
        //            {
        //                Db.Transaction(() =>
        //                {
        //                    CategorySingle.LastCrawledPage = (short)PageNumer;
        //                });
        //            }

        //            if (newThereadCount > 0 || (CategorySingle.LastCrawledPage <= CategorySingle.PageCount))
        //                Crawls(CategorySingle, ++PageNumer);
        //            //_q.Enqueue(new DT_Category(_q.Downloader, category.Id, _idF, _q, _page + Convert.ToInt32(forum.CrawlCategoryPageInterval)) { ForceLoadAll = ForceLoadAll, });	// TODO: parse page and determine what is the page count
        //        }
        //        catch (Exception ex)
        //        { }
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //}

        //private static void CrawlMessages( Commit, short PageNumer)
        //{
        //    try
        //    {
        //        var newMessageCount = 0;
        //        string html;
        //        //if (Commit.Forum.Name == "Odla.nu") //TODO: Add encoding attribute
        //        //{
        //        //    html = Downloader.Download(Uri);
        //        //}
        //        //else
        //        //{
        //        string PageUrl = string.Format(Commit.Forum.Page_Url , Commit.ExternalId, PageNumer);
        //        html = DownloaderEncoding.GetPage(PageUrl);

        //        //}
        //        // TODO: move away parser
        //        // Retrieve content from page.
        //        var messageCreatedMatches = (new Regex(Commit.Forum.Page_MessageCreated, RegexOptions.Singleline)).Matches(html);
        //        var messageIdMatches = (new Regex(Commit.Forum.Page_MessageId, RegexOptions.Singleline)).Matches(html);
        //        var messageTextMatches = (new Regex(Commit.Forum.Page_MessageText, RegexOptions.Singleline)).Matches(html);
        //        //var messageUserIdMatches = _messageUserIdRegex.Matches(requestBody);
        //        var messageUsernameMatches = (new Regex(Commit.Forum.Page_MessageUsername, RegexOptions.Singleline)).Matches(html);


        //        // TODO: message fields

        //        if ((messageCreatedMatches.Count ^ messageIdMatches.Count ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
        //        {
        //            if ((Commit.Forum.Type != "fairshopping" && Commit.Forum.Type != "autopower" && Commit.Forum.Type != "ungdomar")
        //                || (Commit.Forum.Type == "fairshopping" && (messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
        //                || (Commit.Forum.Type == "autopower" && (messageCreatedMatches.Count ^ (messageIdMatches.Count + 1) ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
        //                || (Commit.Forum.Type == "ungdomar" && (messageCreatedMatches.Count ^ (messageIdMatches.Count + 1) ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0))
        //            {
        //                string bugLog = "Error in Regex match of messages at url " + PageUrl + ":\r\nMsg Date :\t" + messageCreatedMatches.Count + "\r\nMsg ID :\t" + messageIdMatches.Count + "\r\nMsg Text :\t" + messageTextMatches.Count + "\r\nMsg Users :\t" + messageUsernameMatches.Count;
        //                bugLog += "\r\nRegex:\r\nMsg Date :\t" + Commit.Forum.Page_MessageCreated + "\r\nMsg ID :\t" + Commit.Forum.Page_MessageId + "\r\nMsg Text :\t" + Commit.Forum.Page_MessageText + "\r\nMsg Users :\t" + Commit.Forum.Page_MessageUsername;
        //                bugLog += "\r\n\r\nBody:\r\n" + html;
        //                DateTime now = DateTime.Now;
        //                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + Commit.Forum.Name + ".txt");
        //                file.WriteLine(bugLog);
        //                file.Close();
        //                return;
        //            }
        //        }

        //        // Loop all retrieved content, and add new content to database
        //        int MessageIdMatchesCount = messageIdMatches.Count;
        //        int MessageIdMatchesCountDifference = 0;
        //        if (Commit.Forum.Type == "fairshopping" || Commit.Forum.Type == "autopower" || Commit.Forum.Type == "ungdomar")
        //        {
        //            MessageIdMatchesCount = messageTextMatches.Count;
        //            MessageIdMatchesCountDifference = MessageIdMatchesCount - messageIdMatches.Count;
        //        }
        //        for (var i = 0; i < MessageIdMatchesCount; i += 1)
        //        {
        //            int externalId = 0;
        //            if (Commit.Forum.Type == "Episerver") // Episerver is still the only forum with a strange kind of hash id for messages so this is a hack to convert it to a unique int id.
        //            {
        //                var episerverMessageId = messageIdMatches[i].Groups[1].ToString();
        //                episerverMessageId = episerverMessageId.Replace("-", "").Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "").Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "").Replace("u", "").Replace("v", "").Replace("x", "").Replace("y", "").Replace("z", "");
        //                if (episerverMessageId.Length > 15)
        //                {
        //                    episerverMessageId = new string(episerverMessageId.Take(15).ToArray());
        //                }
        //                try
        //                {
        //                    var episerverMessageId2 = long.Parse(episerverMessageId);
        //                    episerverMessageId2 = episerverMessageId2 / 3780000;
        //                    externalId = int.Parse(episerverMessageId2.ToString());
        //                }
        //                catch (Exception e)
        //                {
        //                    return;
        //                }
        //            }
        //            else if (Commit.Forum.Type == "fairshopping" || Commit.Forum.Type == "autopower" || Commit.Forum.Type == "ungdomar")
        //            {
        //                var episerverMessageId = "";
        //                //initial 2 messages contain no ID. So assigning ExternalId (i.e 955) as first messageId and assinging (9551) as second message
        //                //First message
        //                if (i == 0)
        //                {
        //                    if (Commit.ExternalId.ToString() != "0")
        //                        episerverMessageId = Commit.ExternalId.ToString();
        //                    else
        //                    {
        //                        if (messageIdMatches.Count > 0)
        //                            episerverMessageId = ((Convert.ToInt32(messageIdMatches[i].Groups[1].ToString()) * 10) + i).ToString();
        //                        else
        //                        {
        //                            var unixTime = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        //                            episerverMessageId = ((long)unixTime.TotalSeconds).ToString();
        //                        }
        //                    }
        //                }
        //                //Second && 3rd message
        //                else if (i > 0 && i < MessageIdMatchesCountDifference)
        //                {
        //                    if (Commit.ExternalId != 0)
        //                        episerverMessageId = ((Convert.ToInt32(Commit.ExternalId.ToString()) * 10) + i).ToString();
        //                    else
        //                    {
        //                        episerverMessageId = ((Convert.ToInt32(messageIdMatches[i].Groups[1].ToString()) * 10) + i).ToString();
        //                    }
        //                }
        //                //Rest of the messages
        //                else
        //                {
        //                    episerverMessageId = messageIdMatches[i - MessageIdMatchesCountDifference].Groups[1].ToString();
        //                }
        //                externalId = Convert.ToInt32(episerverMessageId);
        //            }
        //            else
        //            {
        //                try
        //                { externalId = int.Parse(messageIdMatches[i].Groups[1].ToString()); }
        //                catch (FormatException e) { return; }

        //            }
        //            var messageText = "";
        //            try
        //            {
        //                messageText = messageTextMatches[i].Groups[1].ToString();
        //            }
        //            catch (ArgumentOutOfRangeException e)
        //            {

        //                return;
        //            }
        //            var messageCreatedString = "";
        //            try
        //            {
        //                messageCreatedString = messageCreatedMatches[i].Groups[1] + (messageCreatedMatches[i].Groups[2].Success ? " " + messageCreatedMatches[i].Groups[2].ToString() : "");
        //            }
        //            catch (ArgumentOutOfRangeException e)
        //            {

        //                return;
        //            }

        //            DateTime messageCreated;
        //            if (Commit.Name == "Alltomtradgard.se")
        //            {
        //                if (messageCreatedString.Contains("Zon"))
        //                {
        //                    var createdMatches = (new Regex(@"Zon.*?/\s*(.*)", RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(messageCreatedString);
        //                    messageCreatedString = createdMatches[0].Groups[1].ToString();
        //                }
        //            }

        //            if (!DateManagement.TryParseDateTime(messageCreatedString, Commit.Forum, out messageCreated))
        //            {
        //                try
        //                {
        //                    if (DateTime.TryParse(messageCreatedString, out messageCreated))
        //                    {
        //                        messageCreated = Convert.ToDateTime(messageCreatedString);
        //                    }
        //                    else //if (f.Id == 1988 || f.ForumType == "Episerver" || f.Id == 1121 || f.Id == 1204 || f.Id == 1203 || f.Id == 1209|| f.Id == 1224 || f.Id == 1225 || f.Id == 1226)
        //                    {
        //                        try
        //                        {//                                MessageBox.Show("Error in Date : " + messageCreatedString);
        //                            messageCreated = DateManagement.dateTimeConverter(messageCreatedString);
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            string bugLog = "Error in Date : " + ex.Message + "\r\n" + messageCreatedString;
        //                            DateTime now = DateTime.Now;
        //                            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + Commit.Name + ".txt");
        //                            file.WriteLine(bugLog);

        //                            file.Close();
        //                            continue;
        //                        }
        //                    }
        //                }
        //                catch (Exception ex)
        //                {
        //                    string bugLog = "Error in Date : " + ex.Message + "\r\n" + messageCreatedString;
        //                    DateTime now = DateTime.Now;
        //                    System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + Commit.Name + ".txt");
        //                    file.WriteLine(bugLog);

        //                    file.Close();
        //                    continue;
        //                }
        //            }
        //            //var messageUserId = (messageUserIdMatches.Count > 0) ? int.Parse(messageUserIdMatches[i].Groups[1].ToString()) : 0;
        //            string messageUsername;
        //            try
        //            {
        //                messageUsername = messageUsernameMatches[i].Groups[1].ToString();
        //            }
        //            catch (Exception)
        //            {

        //                messageUsername = "guest"; //Simply because some forums has impossible variations of users.
        //            }

        //            // Ugly hack for familjeliv
        //            if (Commit.Forum.Id == 1103)
        //            {
        //                messageUsername = messageUsername.Replace("+", " ");
        //            }

        //            OneKey.Database.Config.Message _m = Db.SQL<OneKey.Database.Config.Message>("SELECT m FROM OneKey.Database.Config.Message m WHERE m.ExternalId=?", externalId).First;
        //            if (_m == null)
        //            {
        //                messageText = Crawler.CrawlForum.Cleanup(messageText);
        //                var dtNow = DateTime.UtcNow;
        //                Db.Transaction(() =>
        //                    {
        //                        _m. = Commit;
        //                        _m.ExternalId = externalId;
        //                        _m.Text = messageText;
        //                        _m.Created = messageCreated;
        //                        //UserExternalId = messageUserId,
        //                        _m.Author = messageUsername;
        //                        _m.Page = PageNumer;
        //                        _m.LatestCrawlTime = dtNow;

        //                        newMessageCount += 1;
        //                        if (Commit.Created == DateTime.MinValue)
        //                        {
        //                            Commit.Created = _m.Created;
        //                        }
        //                        // Todo: Add author!!
        //                        if (Commit.Author == null)
        //                        {
        //                            Commit.Author = _m.Author;
        //                        }
        //                        if (Commit.FirstMessageId == 0)
        //                        {
        //                            Commit.FirstMessageId = (short)_m.Id;
        //                        }
        //                        Commit.Updated = _m.Created;
        //                        Commit.LastAuthor = _m.Author;
        //                        Commit.LastMessageId = _m.ExternalId;
        //                    });
        //            }
        //        }
        //        if (newMessageCount > 0			// do crawl if new message found
        //            || PageNumer < Commit.PageCount		// or if know that there are other pages
        //            || (PageNumer <= Commit.PageCount)
        //            )
        //        // TODO: parse paginator and get page count
        //        {
        //            Db.Transaction(() =>
        //                {
        //                    Commit.MessageCount += (short)newMessageCount;
        //                    Commit.LastCrawledPage = PageNumer;
        //                    Commit.PageCount = (short)(PageNumer + Convert.ToInt32(Commit.Forum.CrawlPageInterval));
        //                });

        //            // Do post request next page
        //            CrawlMessages(Commit, Commit.Category.PageCount);
        //            //_q.Enqueue(new DT_Forum(Downloader, _extIdForum, f.Id, _q, _messageCount + newMessageCount) { Page = t.PageCount, ForceLoadAll = this.ForceLoadAll, });
        //            // TODO: parse paginator: test whether forum has new page: because last crawled page can has no new message but new page might appear
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        //((App)App.Current).Log(e.ToString());	// TODO: log
        //        //this.Status = StatusCode.UnknownError;
        //    }
        //}

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

        public static string Cleanup(string messageText)
        {
            var s = messageText.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace("&auml;", "ä").Replace("&aring;", "å").Replace("&ouml;", "ö").Replace("&Auml;", "Ä").Replace("&Aring;", "Å").Replace("&Ouml;", "Ö");
            int lenBefore;
            do
            {
                lenBefore = s.Length;
                s = s.Replace("  ", " ");
            } while (lenBefore > 0 && lenBefore > s.Length);
            return s;
        }


        internal static void CrawlerHandler()
        {
            Handle.GET("/StartCrawler", () =>
            {
                if (!IsCrawlerAlive)
                {
                    IsCrawlerAlive = true;
                    StartCrawl();
                }
                return 200;
            });
        }

        public static bool IsCrawlerAlive { get; set; }
    }
}
