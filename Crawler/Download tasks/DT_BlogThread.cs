using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Net;
using System.IO;
using System.Collections.Generic;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
    /// <summary>
    /// pages order assumed: newest messages on page with the greatest number
    /// </summary>
    class DT_BlogThread : DT_OfParticularForum
    {
        private readonly Thread _T;
        private readonly Forum _F;
        private readonly IDownloadQueue _q;

        public DT_BlogThread(IDownloader downloader, Thread _Thread, Forum _Forum, IDownloadQueue thisQ, int messageCount)
            : base(downloader)
        {
            _F = _Forum;
            _T = _Thread;
            _q = thisQ;
            ForceLoadAll = false;
            _messageCount = messageCount;
        }

        private int _messageCount;

        /// <summary>
        /// page from which to start
        /// </summary>
        private int _page = -1;

        private int Page2 = 0;

        public int Page
        {
            get
            {
                if (_page == -1)					// if page to crawl not set
                {
                    if (ForceLoadAll)
                    {
                        _page = 1;
                    }
                    else
                    {
                        if (_T != null)				// if already known page
                        {
                            _page = _T.Value.LastCrawledPage;
                            // TODO: parse paginator: test whether forum has new page: because last crawled page can has no new message but new page might appear
                        }
                        else
                        { _page = Convert.ToInt32(_F.StartCrawlPage); }
                    }
                }
                //if (_page <= 0)	_page = Convert.ToInt32(f.StartCrawlPage);		// start from first
                return _page;
            }
            set { _page = value; }
        }

        /// <summary>
        /// if true: force download and parse all the pages of category
        /// otherwise: download only pages only while new threads found
        /// </summary>
        public bool ForceLoadAll { get; set; }

        #region DT_Base
        public override string Uri
        {
            get			// lazy : construct uri on first use: since it might involve request to db
            {
                string u = base.Uri;
                if (String.IsNullOrEmpty(u))
                {
                    var t = _T;

                    if (_F.StringExternalIdThread == "1" && _F.thread.Url.Contains("{1}"))
                    {
                        var c = (Category)Globals.Db.Category.Get(t.CategoryId);
                        u = _F.Url + string.Format(_F.thread.Url, t.StringExternalId, Page);
                    }
                    else if (_F.StringExternalIdThread == "1" && _F.thread.Url.Contains("{2}"))
                    {
                        var c = (Category)Globals.Db.Category.Get(t.CategoryId);
                        u = _F.Url + string.Format(_F.thread.Url, c.StringExternalId, t.StringExternalId, Page);
                    }
                    else if (_F.thread.Url.Contains("{2}"))
                    {
                        var c = (Category)Globals.Db.Category.Get(t.CategoryId);
                        u = _F.Url + string.Format(_F.thread.Url, c.ExternalId, t.ExternalId, Page);
                    }
                    else
                    {
                        if (t.ExternalId != 0)
                        {
                            if (_F.thread.Url.Contains("http://"))
                                u = string.Format(_F.thread.Url, t.ExternalId, Page);
                            else
                                u = _F.Url + string.Format(_F.thread.Url, t.ExternalId, Page);
                        }
                        else
                        {
                            u = _F.Url + string.Format(_F.thread.Url, t.StringExternalId, Page);
                        }
                    }

                    _page = Page;

                    base.Uri = u;
                }
                return u;
            }
        }
        #endregion

        /// <summary>
        /// load thread page
        /// </summary>
        public override void Download()
        {
            try
            {
                CrawlMessages(_T, _F);
                //_q.Enqueue(new DT_BlogThread(Downloader, _T, _F , _q, _messageCount) { Page = _T.PageCount, ForceLoadAll = this.ForceLoadAll, });
            }
            catch (System.Net.WebException e)
            {
                //((App)App.Current).Log(e.ToString());	// TODO: log
                this.Status = StatusCode.UnknownError;
            }
        }

        internal static void CrawlMessages(Thread singleThread, Forum f)
        {
            try
            {
                if (singleThread.StringExternalId != null && singleThread.StringExternalId != "")
                {
                    var forumUri = new Uri(singleThread.StringExternalId);
                    var forumPageUri = new Uri(singleThread.StringExternalId, UriKind.Absolute);

                    //if statement is only to debug a page with Comments
                    //if (singleThread.StringExternalId == "http://www.herrochfrulagergren.se/?p=8608")
                    {
                        var SubBlogRssUri = new Uri(singleThread.StringExternalId.Replace(" ", "%20"));
                        //Process.Start(SubBlogRssUri.ToString());

                        //var blogPageUri = new Uri(string.Format(forum.category.Url,id), UriKind.Absolute);
                        //var blogPage = Download(MakeAbsolute(blogUri, blogPageUri), forum);
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(SubBlogRssUri);
                        request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/34.0.1847.116 Safari/537.36";

                        request.Headers.Add(HttpRequestHeader.AcceptEncoding, "gzip,deflate");
                        WebHeaderCollection Headers = new WebHeaderCollection();
                        Uri RedirectedUrl = new Uri(SubBlogRssUri.ToString());
                        string html = "";
                        using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                        {
                            Headers = response.Headers;
                            RedirectedUrl = response.ResponseUri;
                            html = DownloaderEncoding.ProcessContent(response);
                        }

                        //Get first message and update it
                        Message FirstMessage = GetFirstMessageOfBlog(f.Id, singleThread.Id);
                        if (FirstMessage != null)
                        {
                            if (FirstMessage.Created == DateTime.MinValue)
                            {
                                FirstMessage.Created = DateTime.Now;
                                Globals.Db.Messages.Update(FirstMessage);
                            }

                            //Just a check, When first message gets fetched from RSS its ExternalId is set to 0, and when its content is updated ExternalId is set to 1 Permanently
                            if (FirstMessage.ExternalId == 0)
                                FirstMessage.ExternalId = 1;

                            //Update Text of First Message (replace the Text from RSS feed)
                            var FirstMessageTextMatches = (new Regex(f.category.ThreadTitle, RegexOptions.Singleline)).Matches(html);
                            if (FirstMessageTextMatches.Count > 0 && FirstMessage.Text != FirstMessageTextMatches[0].Groups[1].ToString().Trim())
                            {
                                try
                                {
                                    FirstMessage.Text = FirstMessageTextMatches[0].Groups[1].ToString().Trim();
                                }
                                finally
                                {
                                    Globals.Db.Messages.Update(FirstMessage);
                                }
                            }

                            if (singleThread.Created == DateTime.MinValue || singleThread.Created != FirstMessage.Created)
                            {
                                singleThread.Created = FirstMessage.Created;
                                Globals.Db.Thread.Update(singleThread);
                            }
                        }
                        else
                        {
                            try
                            {
                                FirstMessage = new Message();
                                FirstMessage.Created = DateTime.Now;
                                FirstMessage.StringExternalId = singleThread.StringExternalId;
                                FirstMessage.ThreadId = singleThread.Id;
                                FirstMessage.ThreadTitle = singleThread.Title;
                                FirstMessage.CategoryId = singleThread.CategoryId;
                                FirstMessage.CategoryName = singleThread.CategoryName;
                                FirstMessage.ForumName = singleThread.ForumName;
                                FirstMessage.ForumId = singleThread.ForumId;
                                FirstMessage.ExternalId = 1;
                                var FirstMessageTextMatches = (new Regex(f.category.ThreadTitle, RegexOptions.Singleline)).Matches(html);
                                if (FirstMessageTextMatches.Count > 0 && FirstMessage.Text != FirstMessageTextMatches[0].Groups[1].ToString().Trim())
                                {
                                    FirstMessage.Text = FirstMessageTextMatches[0].Groups[1].ToString().Trim();
                                }
                            }
                            finally
                            {
                                Globals.Db.Messages.Set(FirstMessage);
                            }
                        }
                        try
                        {
                            if (f.thread.MessageCreated == "" || f.thread.MessageText == "" || f.thread.MessageUsername == "")
                                return;
                            var messageCreatedMatches = (new Regex(f.thread.MessageCreated, RegexOptions.Singleline)).Matches(html);
                            var messageTextMatches = (new Regex(f.thread.MessageText, RegexOptions.Singleline)).Matches(html);
                            var messageUsernameMatches = (new Regex(f.thread.MessageUsername, RegexOptions.Singleline)).Matches(html);

                            var messageIdMatches = messageTextMatches;//Just to Declare messageIdMatches 
                            //If There is no Message id, this is the syntax of MessageExternalId = ThreadDocument.StringExternalId + Comment# (i.e 1, 2, 3)
                            if (f.thread.MessageId != null && f.thread.MessageId != "")
                            {
                                messageIdMatches = (new Regex(f.thread.MessageId, RegexOptions.Singleline)).Matches(html);
                            }


                            if ((messageCreatedMatches.Count ^ messageIdMatches.Count ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                            {
                                string bugLog = "Error in Regex match of messages at url " + singleThread.StringExternalId + ":\r\nMsg Date :\t" + messageCreatedMatches.Count + "\r\nMsg ID :\t" + messageIdMatches.Count + "\r\nMsg Text :\t" + messageTextMatches.Count + "\r\nMsg Users :\t" + messageUsernameMatches.Count;
                                bugLog += "\r\nRegex:\r\nMsg Date :\t" + f.thread.MessageCreated + "\r\nMsg ID :\t" + f.thread.MessageId + "\r\nMsg Text :\t" + f.thread.MessageText + "\r\nMsg Users :\t" + f.thread.MessageUsername;
                                bugLog += "\r\n\r\nBody:\r\n" + html;
                                DateTime now = DateTime.Now;
                                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + f.Name + ".txt");
                                file.WriteLine(bugLog);
                                file.Close();
                                return;
                            }
                            if (messageTextMatches.Count == 0)
                                return;
                            int MessageIdMatchesCount = messageIdMatches.Count;
                            var newMessageCount = 0;
                            using (var se = Globals.Store.OpenSession())
                            {
                                var _Messages = se.Query<Message>("MessageIndex").Where(_m => _m.ThreadId == singleThread.Id && _m.ForumId == singleThread.ForumId);
                                var MessageArray = _Messages.ToList();
                                newMessageCount = MessageArray.Count();
                            }

                            //logic not for verification
                            //if ((MessageIdMatchesCount + 1) == newMessageCount)
                            //    return;

                            List<int> messageIdExternalId = new List<int>();
                            if (f.thread.MessageId == "")
                            {
                                MessageIdMatchesCount = messageTextMatches.Count;
                                for (int loop = 10; loop < (messageIdMatches.Count + 10); loop++)
                                {
                                    messageIdExternalId.Add(loop);
                                }
                            }


                            for (var i = 0; i < MessageIdMatchesCount; i += 1)
                            {
                                //External ID
                                int externalId = 0;
                                if (f.thread.MessageId == "")
                                    externalId = messageIdExternalId[i];
                                else
                                    externalId = Convert.ToInt32(messageIdMatches[i].Groups[1].Value);

                                ////Message Created String 
                                DateTime messageCreated = ParseMessageCreatedString(messageCreatedMatches, i, f);
                                if (messageCreated == DateTime.MinValue)
                                    messageCreated = DateTime.Now;
                                if (FirstMessage.Created > messageCreated)
                                {
                                    FirstMessage.Created = messageCreated.AddMinutes(-1);
                                    Globals.Db.Messages.Update(FirstMessage);
                                }
                                ////Message Text
                                string messageText = messageTextMatches[i].Groups[1].ToString();

                                ////messageUsername
                                string messageUsername = messageUsernameMatches[i].Groups[1].Value;

                                Message m = null;
                                bool MessageExists = Globals.Db.Messages.Exsist(externalId.ToString(), singleThread.Id, ref m);

                                //if message does not exist, Create it

                                if (!MessageExists)
                                {
                                    newMessageCount = CreateNewMessageinDB(m, externalId, messageCreated, messageText, messageUsername, singleThread, f, newMessageCount, i, RedirectedUrl.ToString());
                                }

                            } singleThread.MessageCount = newMessageCount;
                            singleThread.Updated = DateTime.Now;
                            Globals.Db.Thread.Update(singleThread);

                        }
                        catch (Exception ex)
                        { }
                    }
                }
                else
                {
                    Globals.Db.Thread.Delete(singleThread.Id);
                }
            }
            catch (Exception ex)
            { }
        }

        public static DateTime ParseMessageCreatedString(MatchCollection messageCreatedMatches, int i, Forum f)
        {
            var messageCreatedString = "";
            try
            {
                messageCreatedString = messageCreatedMatches[i].Groups[1] + (messageCreatedMatches[i].Groups[2].Success ? " " + messageCreatedMatches[i].Groups[2].ToString() : "");
            }
            catch (ArgumentOutOfRangeException e)
            {
                return DateTime.MinValue;
            }

            DateTime messageCreated;
            if (f.Name == "Alltomtradgard.se")
            {
                if (messageCreatedString.Contains("Zon"))
                {
                    var createdMatches = (new Regex(@"Zon.*?/\s*(.*)", RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(messageCreatedString);
                    messageCreatedString = createdMatches[0].Groups[1].ToString();
                }
            }


            if (!DateManagement.TryParseDateTime(messageCreatedString, f, out messageCreated))
            {
                try
                {
                    if (DateTime.TryParse(messageCreatedString, out messageCreated))
                    {
                        messageCreated = Convert.ToDateTime(messageCreatedString);
                    }
                    else //if (f.Id == 1988 || f.ForumType == "Episerver" || f.Id == 1121 || f.Id == 1204 || f.Id == 1203 || f.Id == 1209|| f.Id == 1224 || f.Id == 1225 || f.Id == 1226)
                    {
                        try
                        {//                                MessageBox.Show("Error in Date : " + messageCreatedString);
                            messageCreated = DateManagement.dateTimeConverter(messageCreatedString);
                        }
                        catch (Exception ex)
                        {
                            string bugLog = "Error in Date : " + ex.Message + "\r\n" + messageCreatedString;
                            DateTime now = DateTime.Now;
                            if (!Directory.Exists("C:\\Logs\\" + f.Name + "\\DateTimeError\\"))
                                Directory.CreateDirectory("C:\\Logs\\" + f.Name + "\\DateTimeError\\");
                            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + f.Name + "\\DateTimeError\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + f.Name + ".txt");
                            file.WriteLine(bugLog);
                            file.Close();
                            return DateTime.MinValue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    string bugLog = "Error in Date : " + ex.Message + "\r\n" + messageCreatedString;
                    DateTime now = DateTime.Now;
                    if (!Directory.Exists("C:\\Logs\\" + f.Name + "\\DateTimeError\\"))
                        Directory.CreateDirectory("C:\\Logs\\" + f.Name + "\\DateTimeError\\");
                    System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + f.Name + "\\DateTimeError\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + f.Name + ".txt");
                    file.WriteLine(bugLog);
                    file.Close();
                    return DateTime.MinValue;
                }
            }
            return messageCreated;
        }

        public static int CreateNewMessageinDB(Message m, int externalId, DateTime messageCreated, string messageText, string messageUsername, Thread t, Forum f, int newMessageCount, int i, string RedirectedUrl)
        {
            if (messageCreated == DateTime.MinValue)
                messageCreated = DateTime.Now;
            messageText = CommonClasses.Cleanup(messageText);
            var message = new Message
            {
                ForumId = f.Id,
                ExternalId = externalId,
                CategoryId = t.CategoryId,

                Text = messageText,
                Created = messageCreated,
                Url = RedirectedUrl,

                //UserExternalId = messageUserId,
                Author = messageUsername,

                Page = 1,
                ThreadId = t.Id,
                ThreadTitle = t.Title,
                ThreadExternalId = t.ExternalId,

                ForumUrl = t.ForumUrl,
                CategoryName = t.CategoryName,
                ForumName = t.ForumName,
                OrderNumber = t.MessageCount + i,

                LatestCrawlTime = DateTime.UtcNow,

            };
            //message = SemanticAnalysis.AddSemantics(message);
            //message = SemanticAnalysis.AddMoods(message);
            Globals.Db.Messages.Set(message);		// sequence is important: here set message.Id

            newMessageCount += 1;
            if (t.Created == DateTime.MinValue)
            {
                t.Created = message.Created;
            }
            // Todo: Add author!!
            if (t.Author == null)
            {
                t.Author = message.Author;
            }
            if (t.FirstMessageId == 0)
            {
                t.FirstMessageId = message.Id;
            }
            t.Updated = message.Created;
            t.LastAuthor = message.Author;
            t.LastMessageId = message.ExternalId;
            return newMessageCount;
        }

        public static void Delete(short id)
        {
            using (var se = Globals.Store.OpenSession())
            {
                var MessageDocumentQuery = se.Query<Message>("MessageIndex").Where(m => m.Id == id);

                se.Advanced.MaxNumberOfRequestsPerSession = 1073741000;
                se.Advanced.DocumentStore.DatabaseCommands.Delete("messages/" + id, null);
                //se.Delete(MessageDocumentQuery);
                //se.SaveChanges();
            }
        }

        internal static Message GetFirstMessageOfBlog(long ForumId, long ThreadId)
        {
            using (var session = Globals.Store.OpenSession())
            {
                var MessagesArray = session.Query<Message>("MessageIndex").Where(m => m.ForumId == ForumId && m.ThreadId == ThreadId).ToArray();
                if (MessagesArray.Count() > 0)
                {
                    int FirstMessageIndex = -1;
                    if (MessagesArray.Count() > 1)
                    {
                        bool IgnoreFirstMessage = false;
                        foreach (Message _Message in MessagesArray)
                        {
                            FirstMessageIndex++;
                            if (_Message.StringExternalId != null && _Message.StringExternalId != "")
                            {
                                if (IgnoreFirstMessage == false)
                                {
                                    IgnoreFirstMessage = true;
                                    continue;
                                }
                                Delete(_Message.Id);
                            }
                        }
                    }
                    return MessagesArray.FirstOrDefault(m => m.StringExternalId != null && m.StringExternalId != "");
                }
                else
                    return null;
            }
        }
    }
}
