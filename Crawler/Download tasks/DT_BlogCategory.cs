using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using Sloppycode.net;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
	class DT_BlogCategory : DT_OfParticularForum
	{
		private Category _C;
		private readonly Forum _F;
		private readonly DQ_ParticularForum _q;
		private int _page;

		public DT_BlogCategory(IDownloader downloader, Category _Category, Forum _Forum, DQ_ParticularForum q, int page)
			: base(downloader)
		{ _C = _Category; _F = _Forum; _q = q; _page = page; ForceLoadAll = false; }

		#region DT_Base
		public override string Uri
		{
			get			// lazy : construct uri on first use: since it might involve request to db
			{
				var u = base.Uri;  
			    u = string.Empty;
			    if (String.IsNullOrEmpty(u))
				{
                    if(_page == 1)
                    {
                        _page = Convert.ToInt32(_F.StartCrawlPage); // 1 blir 0 på phpBB, Invision och 1 blir 1 på vBulletin, SMF
                    }
                    if (_F.StringExternalIdCategory == "1")
                    {
                        string sId = "";
                        {
                            sId = _C.StringExternalId.Replace("-", "/");
                            u = /*forum.Url + */String.Format(_F.category.Url, sId, _page);
                        }
                    }
					base.Uri = u;
				}
				return u;
			}
		}
		#endregion

		/// <summary>
		/// if true: force download and parse all the pages of category
		/// otherwise: download only pages only while new threads found
		/// </summary>
		public bool ForceLoadAll { get; set; }
        
       
		public override void Download()
		{
			// download category main page
			try
			{
				var newThereadCount = 0;
				var u1 = Uri;
                string categoryPage;
                if (Uri == "")
                {
                    return;
                }
                categoryPage = DownloaderEncoding.GetPage(u1);
                //categoryPage = Downloader.Download(u1);

                if (!_C.Subscribed)
                    CrawlThreads_NonPubSubHubBub(_C); 
                    //CrawlThreads(_C);

                var _C_Modify = (Category)_C;
			    if (_C.LastCrawledPage < _page || newThereadCount > 0)
				{
                    _C_Modify.LastCrawledPage = _page;
                    _C_Modify.ForumName = _C.ForumName;
                    _C_Modify.ForumUrl = _C.ForumUrl;
                    _C_Modify.LatestCrawlTime = DateTime.UtcNow;
                    _C_Modify.ThereadCount += newThereadCount;
                    _C_Modify.StringExternalId = _C.StringExternalId;
                    Globals.Db.Category.Update(_C_Modify);
				}

                if (newThereadCount > 0 || (ForceLoadAll && _C.LastCrawledPage <= _C.PageCount))
                {
                    _q.Enqueue(new DT_BlogCategory(_q.Downloader, _C_Modify, _F, _q, _page) { ForceLoadAll = ForceLoadAll, });
                }

			}
			catch (System.Net.WebException e)
			{
				;	// TODO: log
				Status = StatusCode.UnknownError;	// TODO: handle error kind
			}

		}

        const string FeedBaseName = "feed";
        const string FeedExtension = ".xml";
        public bool CrawlThreads_NonPubSubHubBub(Category CategorySingle)
        {
            try
            {
                RssReader rssReader = new RssReader();
                rssReader.RdfMode = false;

                //Process.Start(CategorySingle.ForumUrl);
                RssFeed feed = rssReader.Retrieve(CategorySingle.ForumUrl);
                if (feed.Hub != null && feed.Hub != "")
                {
                    if (!CategorySingle.Subscribed)
                    {
                        string FeedToSubscribe = CategorySingle.ForumUrl;
                        string HubUrl = feed.Hub;

                        // Subscribe to a feed
                        Console.WriteLine("Subscribing to {0}", FeedToSubscribe);
                        var statusCode = PushSubscriber.Subscribe(
                            feed.Hub,
                            Variables.CallbackUrl,
                            CategorySingle.ForumUrl,
                            PushVerifyType.Sync,
                            0,
                            "VerifyToken",
                            null);
                        CategorySingle.Subscribed = true;
                        Globals.Db.Category.Update(CategorySingle);
                    }
                    return true;
                }
                

                foreach (RssItem item in feed.Items)
                {
                    String AuthorName = item.Author;
                    String category = item.Category;
                    //String CommentsLink = item.Comments;
                    String messageText = item.Description;
                    Uri _tempuri;
                    if (item.Guid != "")
                    {
                        _tempuri = new Uri(item.Guid);
                    }
                    else
                    {
                        _tempuri = new Uri(item.Link);
                    }
                    string ThreadExternalIDstring = _tempuri.ToString();

                    string MessageExternalIdString = ThreadExternalIDstring;


                    String PageLink = item.Link;
                    DateTime messageCreated = Convert.ToDateTime(item.Pubdate);
                    if (messageCreated == DateTime.MinValue)
                        messageCreated = DateTime.Now;

                    String ThreadTitle = item.Title;

                    //need to crawl the thread page if any of the following keys are missing
                    //if (AuthorName == null || messageCreated == DateTime.MinValue || messageText == "" || ThreadExternalID == "")


                    Thread t_Create = Globals.Db.Thread.Get(ThreadExternalIDstring, CategorySingle.ForumId);
                    if (!Globals.Db.Thread.Exsist(ThreadExternalIDstring, CategorySingle.ForumId, ref t_Create))
                    {
                        //newThereadCount += 1;
                        var dtNow = DateTime.UtcNow;
                        var t1 = new Thread
                        {
                            CategoryId = CategorySingle.Id,
                            StringExternalId = ThreadExternalIDstring,
                            //StringExternalId = externalIdString,
                            LatestCrawlTime = dtNow,

                            ForumId = CategorySingle.ForumId,
                            //CategoryId = _idC,

                            Title = ThreadTitle,

                            MessageCount = 1,
                            FirstMessageId = 0,
                            LastMessageId = 0,

                            PageCount = 1,

                            //LastCrawledPage = Convert.ToInt32(forum.StartCrawlPage),
                            Created = messageCreated,
                            //Fields = fi,
                            Author = AuthorName,
                            CategoryName = category,
                            ForumUrl = CategorySingle.ForumUrl,
                            ForumName = CategorySingle.ForumName,

                        };
                        Globals.Db.Thread.Set(t1);
                        t_Create = (Thread)Globals.Db.Thread.Get(ThreadExternalIDstring, CategorySingle.ForumId);
                        _q.Enqueue(new DT_BlogThread(_q.Downloader, (Thread)t_Create, _F, _q, 0) { ForceLoadAll = ForceLoadAll, });
                    }
                    MessageExternalIdString = ThreadExternalIDstring;
                    Message m = Globals.Db.Messages.Get(MessageExternalIdString, CategorySingle.ForumId);
                    if (!Globals.Db.Messages.Exsist(MessageExternalIdString.ToString(), CategorySingle.ForumId, ref m))
                    {
                        //                    messageText = CommonClasses.Cleanup(messageText);
                        var message = new Message
                        {
                            CategoryId = CategorySingle.Id,
                            ForumId = CategorySingle.ForumId,
                            StringExternalId = MessageExternalIdString,

                            Author = AuthorName,
                            CategoryName = category,
                            Text = messageText,
                            Created = messageCreated,

                            //Page = Page,
                            //ThreadId = ThreadExternalID,
                            ThreadTitle = ThreadTitle,
                            ThreadId = t_Create.Value.Id,
                            //ThreadExternalIdString = t.ThreadExternalIdString,
                            //ForumUrl = t.ForumUrl,
                            ForumName = CategorySingle.ForumName,

                            LatestCrawlTime = DateTime.UtcNow,

                        };
                        Globals.Db.Messages.Set(message);		// sequence is important: here set message.Id
                    }
                }
            }
            catch (Exception ex) { return false; }
            return true;
        }
        public void CrawlThreads(Category CategorySingle)
        {
            try
            {
                RssReader rssReader = new RssReader();
                rssReader.RdfMode = false;
                //rssReader.FeedLoaded += new EventHandler(rssReader_FeedLoaded);
                //rssReader.ItemAdded  += new EventHandler(rssReader_ItemAdded);
                //rssReader.Error      += new RssReaderErrorEventHandler(rssReader_Error);

                //Process.Start(CategorySingle.ForumUrl);
                RssFeed feed = rssReader.Retrieve(CategorySingle.ForumUrl);


                //Uri uri = new Uri(url);
                //System.Console.WriteLine("Hello");
                //Raccoom.Xml.RssChannel myRssChannel = new Raccoom.Xml.RssChannel(uri);
                //// write the channel title to the standard output stream.
                //System.Console.WriteLine(myRssChannel.Title);
                //// write each item's title to the standard output stream.
                ////foreach (Raccoom.Xml.RssItem item in myRssChannel.Items)
                ////{
                ////    System.Console.WriteLine(item.Title);
                ////}

                foreach (RssItem item in feed.Items)
                {
                    String AuthorName = item.Author;
                    String category = item.Category;
                    //String CommentsLink = item.Comments;
                    String messageText = item.Description;
                    Uri _tempuri;
                    if (item.Guid != "")
                    {
                        _tempuri = new Uri(item.Guid);
                    }
                    else
                    {
                        _tempuri = new Uri(item.Link);
                    }
                    string ThreadExternalIDstring = _tempuri.ToString();

                    string MessageExternalIdString = ThreadExternalIDstring;


                    String PageLink = item.Link;
                    DateTime messageCreated = Convert.ToDateTime(item.Pubdate);
                    String ThreadTitle = item.Title;

                    //need to crawl the thread page if any of the following keys are missing
                    //if (AuthorName == null || messageCreated == DateTime.MinValue || messageText == "" || ThreadExternalID == "")


                    Thread t_Create = Globals.Db.Thread.Get(ThreadExternalIDstring, CategorySingle.ForumId);
                    if (!Globals.Db.Thread.Exsist(ThreadExternalIDstring, CategorySingle.ForumId, ref t_Create))
                    {
                        //newThereadCount += 1;
                        var dtNow = DateTime.UtcNow;
                        var t1 = new Thread
                        {
                            CategoryId = CategorySingle.Id,
                            StringExternalId = ThreadExternalIDstring,
                            //StringExternalId = externalIdString,
                            LatestCrawlTime = dtNow,

                            ForumId = CategorySingle.ForumId,
                            //CategoryId = _idC,

                            Title = ThreadTitle,

                            MessageCount = 1,
                            FirstMessageId = 0,
                            LastMessageId = 0,

                            PageCount = 1,

                            //LastCrawledPage = Convert.ToInt32(forum.StartCrawlPage),

                            //Fields = fi,
                            Author = AuthorName,
                            CategoryName = category,
                            ForumUrl = CategorySingle.ForumUrl,
                            ForumName = CategorySingle.ForumName,

                        };
                        Globals.Db.Thread.Set(t1);
                        t_Create = (Thread)Globals.Db.Thread.Get(ThreadExternalIDstring, CategorySingle.ForumId);
                        _q.Enqueue(new DT_BlogThread(_q.Downloader, (Thread)t_Create, _F, _q, 0) { ForceLoadAll = ForceLoadAll, });
                    }
                    MessageExternalIdString = ThreadExternalIDstring;
                    Message m = Globals.Db.Messages.Get(MessageExternalIdString, CategorySingle.ForumId);
                    if (!Globals.Db.Messages.Exsist(MessageExternalIdString.ToString(), CategorySingle.ForumId, ref m))
                    {
                        //                    messageText = CommonClasses.Cleanup(messageText);
                        var message = new Message
                        {
                            CategoryId = CategorySingle.Id,
                            ForumId = CategorySingle.ForumId,
                            StringExternalId = MessageExternalIdString,

                            Author = AuthorName,
                            CategoryName = category,
                            Text = messageText,
                            Created = messageCreated,

                            //Page = Page,
                            //ThreadId = ThreadExternalID,
                            ThreadTitle = ThreadTitle,
                            ThreadId = t_Create.Value.Id,
                            //ThreadExternalIdString = t.ThreadExternalIdString,
                            //ForumUrl = t.ForumUrl,
                            ForumName = CategorySingle.ForumName,

                            LatestCrawlTime = DateTime.UtcNow,

                        };
                        Globals.Db.Messages.Set(message);		// sequence is important: here set message.Id
                    }

                }
            }
            catch (Exception ex)
            { }
        }
    }
}
