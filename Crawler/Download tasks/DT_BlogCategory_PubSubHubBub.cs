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
    class DT_BlogCategory_PubSubHubBub : DT_Base
	{
		private Category _C;
		private readonly Forum _F;
		private DQ_ParticularForum _q;
		private int _page;

        public DT_BlogCategory_PubSubHubBub(IDownloader downloader, Forum _Forum,Category _Category)
			: base(downloader)
        { _F = _Forum; _C = _Category; ForceLoadAll = false; }

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
        const string FeedBaseName = "feed";
        const string FeedExtension = ".xml";

        public override void Download()
        {
            try
            {
                if (null == _q) 
                    _q = new DQ_ParticularForum(downloader: Globals.NewInstance());

                RssReader rssReader = new RssReader();
                rssReader.RdfMode = false;
                RssFeed feed = rssReader.Retrieve(_C.ForumUrl);

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


                    Thread t_Create = Globals.Db.Thread.Get(ThreadExternalIDstring, _C.ForumId);
                    if (!Globals.Db.Thread.Exsist(ThreadExternalIDstring, _C.ForumId, ref t_Create))
                    {
                        //newThereadCount += 1;
                        var dtNow = DateTime.UtcNow;
                        var t1 = new Thread
                        {
                            CategoryId = _C.Id,
                            StringExternalId = ThreadExternalIDstring,
                            //StringExternalId = externalIdString,
                            LatestCrawlTime = dtNow,

                            ForumId = _C.ForumId,
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
                            ForumUrl = _C.ForumUrl,
                            Created = messageCreated,
                            ForumName = _C.ForumName,

                        };
                        Globals.Db.Thread.Set(t1);

                        t_Create = (Thread)Globals.Db.Thread.Get(ThreadExternalIDstring, _C.ForumId);
                        _q.Enqueue(new DT_BlogThread(_q.Downloader, (Thread)t_Create, _F, _q, 0) { ForceLoadAll = ForceLoadAll, });
                    }
                    MessageExternalIdString = ThreadExternalIDstring;
                    Message m = Globals.Db.Messages.Get(MessageExternalIdString, _C.ForumId);
                    if (!Globals.Db.Messages.Exsist(MessageExternalIdString.ToString(), _C.ForumId, ref m))
                    {
                        //                    messageText = CommonClasses.Cleanup(messageText);
                        var message = new Message
                        {
                            CategoryId = _C.Id,
                            ForumId = _C.ForumId,
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
                            ForumName = _C.ForumName,

                            LatestCrawlTime = DateTime.UtcNow,

                        };
                        Globals.Db.Messages.Set(message);		// sequence is important: here set message.Id
                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}
