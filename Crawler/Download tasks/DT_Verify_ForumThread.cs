using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.IO;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
	/// <summary>
	/// pages order assumed: newest messages on page with the greatest number
	/// </summary>
	class DT_Verify_ForumThread : DT_OfParticularForum
	{
        public DT_Verify_ForumThread(IDownloader downloader, int extIdForumThread, long idForum		// TODO: idForum should be eliminated and thread contains id of its forum
			, IDownloadQueue thisQ, int messageCount
			)
			: base(downloader)
		{ 
			_extIdForumThread = extIdForumThread; 
			_idF = idForum;			
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

        public void setPage()
        {

        }

	    public int Page
		{ 
			get 
			{
                var f = Forum.Get(_idF);	
				if (_page == -1)					// if page to crawl not set
				{
					if (ForceLoadAll)
					{
						_page = 1;
					}
					else
					{
						Thread t = Thread.Get(_extIdForumThread, _idF);
                        if (t != null)				// if already known page
                        {
                            _page = t.Value.LastCrawledPage;
                            // TODO: parse paginator: test whether forum has new page: because last crawled page can has no new message but new page might appear
                        }
                        else
                        { _page = Convert.ToInt32(f.StartCrawlPage); }
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
					var f = (Forum)Forum.Get(_idF);										// TODO: null? Handle it
					var t = (Thread)Thread.Get(_extIdForumThread, _idF);		// TODO: null? Handle it

                    if (f.StringExternalIdThread == true && f.thread.Url.Contains("{1}"))
                    {
                        var c = (Category)Category.Get(t.CategoryId);
                        u = f.Url + string.Format(f.thread.Url, t.StringExternalId, Page);
                    }
                    else if (f.StringExternalIdThread == true && f.thread.Url.Contains("{2}"))
                    {
                        var c = (Category)Category.Get(t.CategoryId);
                        u = f.Url + string.Format(f.thread.Url, c.StringExternalId, t.StringExternalId, Page); 
                    }
                    else if (f.thread.Url.Contains("{2}"))
                    {
                        var c = (Category)Category.Get(t.CategoryId);
                        u = f.Url + string.Format(f.thread.Url, c.ExternalId, t.ExternalId, Page); 
                    }
                    else
                    {
                        if (t.ExternalId != 0)
                        {
                            if (f.thread.Url.Contains("http://"))
                                u = string.Format(f.thread.Url, t.ExternalId, Page);
                            else
                                u = f.Url + string.Format(f.thread.Url, t.ExternalId, Page);
                        }
                        else
                        {
                            u = f.Url + string.Format(f.thread.Url, t.StringExternalId, Page);
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
				var f = (Forum)Forum.Get(_idF);											// TODO: null? Handle it
				var t = new Thread();

                
                //get the thread's document's info as well as latest PageNumber
                try
				{
					t = (Thread)Thread.Get(_extIdForumThread, _idF);
                    
                    //Hack to start crawling from page 0, for data varification
                    if (_page == -1 )
                        _page = Convert.ToInt32(f.StartCrawlPage);
				}
				catch (InvalidOperationException exception)
				{
					return;
				}

                //Download HTML
				var newMessageCount = 0;
                var UpdateMessageCount = 0;
			    string html;
                if(Uri == "")
                {
                    return;
                }
			    if(f.Name == "Odla.nu") //TODO: Add encoding attribute
                {
                    html = Downloader.Download(Uri); 
                }
                else
                {
                    html = DownloaderEncoding.GetPage(Uri);
                }
				// TODO: move away parser
				// Retrieve content from page.
				var messageCreatedMatches = (new Regex(f.thread.MessageCreated, RegexOptions.Singleline)).Matches(html);
				var messageIdMatches = (new Regex(f.thread.MessageId, RegexOptions.Singleline)).Matches(html);
				var messageTextMatches = (new Regex(f.thread.MessageText, RegexOptions.Singleline)).Matches(html);
				//var messageUserIdMatches = _messageUserIdRegex.Matches(requestBody);
				var messageUsernameMatches = (new Regex(f.thread.MessageUsername, RegexOptions.Singleline)).Matches(html);
                
                
			    // TODO: message fields

                if ((messageCreatedMatches.Count ^ messageIdMatches.Count ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                {
                    if ((f.ForumType != "fairshopping" && f.ForumType != "autopower" && f.ForumType != "ungdomar") 
                        || (f.ForumType == "fairshopping" && (messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                        || (f.ForumType == "autopower"  && (messageCreatedMatches.Count ^ (messageIdMatches.Count + 1) ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                        || (f.ForumType == "ungdomar" && (messageCreatedMatches.Count ^ (messageIdMatches.Count + 1) ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0))
                    {
                        string bugLog = "Error in Regex match of messages at url " + Uri + ":\r\nMsg Date :\t" + messageCreatedMatches.Count + "\r\nMsg ID :\t" + messageIdMatches.Count + "\r\nMsg Text :\t" + messageTextMatches.Count + "\r\nMsg Users :\t" + messageUsernameMatches.Count;
                        bugLog += "\r\nRegex:\r\nMsg Date :\t" + f.thread.MessageCreated + "\r\nMsg ID :\t" + f.thread.MessageId + "\r\nMsg Text :\t" + f.thread.MessageText + "\r\nMsg Users :\t" + f.thread.MessageUsername;
                        bugLog += "\r\n\r\nBody:\r\n" + html;
                        DateTime now = DateTime.Now;
                        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + f.Name + ".txt");
                        file.WriteLine(bugLog);
                        file.Close();
                        return;
                    }
                }

				// Loop all retrieved content, and add new content to database
                int MessageIdMatchesCount = messageIdMatches.Count;
                int MessageIdMatchesCountDifference = 0;
                if (f.ForumType == "fairshopping" || f.ForumType == "autopower" || f.ForumType == "ungdomar")
                {
                    MessageIdMatchesCount = messageTextMatches.Count;
                    MessageIdMatchesCountDifference = MessageIdMatchesCount - messageIdMatches.Count;
                }
                for (var i = 0; i < MessageIdMatchesCount; i += 1)
				{
                    //External ID
                    int externalId = ParseMessageExternalId(messageIdMatches, i, f, MessageIdMatchesCountDifference);
                    if (externalId == 0)
                        return;

                    //Message Created String 
                    DateTime messageCreated = ParseMessageCreatedString(messageCreatedMatches, i, f);
                    if (messageCreated == DateTime.MinValue)
                        return;

                    //Message Text
                    string messageText = ParseMessageText(messageTextMatches[i].Groups[1].ToString());
                    
                    //messageUsername
                    string messageUsername = ParseMessageUsername(messageUsernameMatches,i,f);
                    
                    //var messageUserId = (messageUserIdMatches.Count > 0) ? int.Parse(messageUserIdMatches[i].Groups[1].ToString()) : 0;
                    
                    Message m = null;
                    bool MessageExists = Message.Exsist(externalId.ToString(), t.Id, ref m);

                    //if message does not exist, Create it
                    if (!MessageExists)
					{
                        newMessageCount = CreateNewMessageinDB(m, externalId, messageCreated, messageText, messageUsername, t, f, newMessageCount,i);
					}
                    //else if message exists, Verify its content
                    else if (MessageExists)     
                    {
                        //if content does not verify, Update it
                        if (!VerifyMessage(m, externalId, messageUsername, messageCreated, messageText, f))
                        {
                            UpdateMessageCount = UpdateExistingMessageinDB(m, externalId, messageCreated, messageText, messageUsername, t, f, UpdateMessageCount, i);
                        }
                    }
					this.Status = StatusCode.DownloadedOK;
				}

				if (Page < t.LastCrawledPage)
					// TODO: parse paginator and get page count
				{
                    t.UpdateDateTime = DateTime.Now;
					Thread.Update(t);

					// Do post request next page
                    _q.Enqueue(new DT_Verify_ForumThread(Downloader, _extIdForumThread, f.Id, _q, _messageCount + newMessageCount) { Page = Page+1, ForceLoadAll = this.ForceLoadAll, });
					// TODO: parse paginator: test whether forum has new page: because last crawled page can has no new message but new page might appear
				}
			}
			catch (System.Net.WebException e)
			{
				//((App)App.Current).Log(e.ToString());	// TODO: log
				this.Status = StatusCode.UnknownError;
			}
		}

        private int UpdateExistingMessageinDB(Message m, int externalId, DateTime messageCreated, string messageText, string messageUsername, Thread t, Forum f, int updateMessageCount, int i)
        {
            messageText = CommonClasses.Cleanup(messageText);

            //List<Model.Message> _m_all = Messages.GetAll(externalId, f.Id);

            m = Message.Get(externalId, t.Id);
            
            var message = new Message
            {
                Id = m.Id,
                Forum = m.Thread.Forum,
                ExternalId = externalId,
                Category = t.Category,
                Thread = t,
                Text = messageText,
                Created = messageCreated,


                //UserExternalId = messageUserId,
                Author = messageUsername,

                Page = Page,
                
                ThreadTitle = t.Title,
                ThreadExternalId = t.ExternalId,

                ForumUrl = t.ForumUrl,
                CategoryName = t.CategoryName,
                ForumName = t.ForumName,
                //OrderNumber = t.MessageCount + i,

                LatestCrawlTime = DateTime.UtcNow,

            };
            Message.Update(message);

            updateMessageCount += 1;
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
            return updateMessageCount;
        }

        private int CreateNewMessageinDB(Message m, int externalId, DateTime messageCreated, string messageText, string messageUsername, Thread t, Forum f, int newMessageCount, int i)
        {
            messageText = CommonClasses.Cleanup(messageText);
            var message = new Message
            {
                ForumId = f.Id,
                ExternalId = externalId,
                CategoryId = t.CategoryId,

                Text = messageText,
                Created = messageCreated,


                //UserExternalId = messageUserId,
                Author = messageUsername,

                Page = Page,
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
            Message.Set(message);		// sequence is important: here set message.Id

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

        private int ParseMessageExternalId(MatchCollection messageIdMatches, int i, Forum f, int MessageIdMatchesCountDifference)
        {
            int externalId = 0;
            if (f.ForumType == "Episerver") // Episerver is still the only forum with a strange kind of hash id for messages so this is a hack to convert it to a unique int id.
            {
                var episerverMessageId = messageIdMatches[i].Groups[1].ToString();
                episerverMessageId = episerverMessageId.Replace("-", "").Replace("a", "").Replace("b", "").Replace("c", "").Replace("d", "").Replace("e", "").Replace("f", "").Replace("g", "").Replace("h", "").Replace("i", "").Replace("j", "").Replace("k", "").Replace("l", "").Replace("m", "").Replace("n", "").Replace("o", "").Replace("p", "").Replace("q", "").Replace("r", "").Replace("s", "").Replace("t", "").Replace("u", "").Replace("v", "").Replace("x", "").Replace("y", "").Replace("z", "");
                if (episerverMessageId.Length > 15)
                {
                    episerverMessageId = new string(episerverMessageId.Take(15).ToArray());
                }
                try
                {
                    var episerverMessageId2 = long.Parse(episerverMessageId);
                    episerverMessageId2 = episerverMessageId2 / 3780000;
                    externalId = int.Parse(episerverMessageId2.ToString());
                }
                catch (Exception e)
                {
                    return 0;
                }
            }
            else if (f.ForumType == "fairshopping" || f.ForumType == "autopower" || f.ForumType == "ungdomar")
            {
                var episerverMessageId = "";
                //initial 2 messages contain no ID. So assigning ThreadExternalId (i.e 955) as first messageId and assinging (9551) as second message
                //First message
                if (i == 0)
                {
                    if (_extIdForumThread.ToString() != "0")
                        episerverMessageId = _extIdForumThread.ToString();
                    else
                    {
                        if (messageIdMatches.Count > 0)
                            episerverMessageId = ((Convert.ToInt32(messageIdMatches[i].Groups[1].ToString()) * 10) + i).ToString();
                        else
                        {
                            var unixTime = DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                            episerverMessageId = ((long)unixTime.TotalSeconds).ToString();
                        }
                    }
                }
                //Second && 3rd message
                else if (i > 0 && i < MessageIdMatchesCountDifference)
                {
                    if (_extIdForumThread != 0)
                        episerverMessageId = ((Convert.ToInt32(_extIdForumThread.ToString()) * 10) + i).ToString();
                    else
                    {
                        episerverMessageId = ((Convert.ToInt32(messageIdMatches[i].Groups[1].ToString()) * 10) + i).ToString();
                    }
                }
                //Rest of the messages
                else
                {
                    episerverMessageId = messageIdMatches[i - MessageIdMatchesCountDifference].Groups[1].ToString();
                }
                externalId = Convert.ToInt32(episerverMessageId);
            }
            else
            {
                try
                { externalId = int.Parse(messageIdMatches[i].Groups[1].ToString()); }
                catch (FormatException e) { return 0; }

            }
            return externalId;
        }

        private string ParseMessageUsername(MatchCollection messageUsernameMatches, int i,Forum f)
        {
            string messageUsername = "";
            try
            {
                messageUsername = messageUsernameMatches[i].Groups[1].ToString();
            }
            catch (Exception)
            {

                messageUsername = "guest"; //Simply because some forums has impossible variations of users.
            }

            // Ugly hack for familjeliv
            if (f.Id == 1103)
            {
                messageUsername = messageUsername.Replace("+", " ");
            }
            return messageUsername;
        }

        private DateTime ParseMessageCreatedString(MatchCollection messageCreatedMatches, int i, Forum f)
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

        private string ParseMessageText(string InputText)
        {
            try
            {
                return InputText;
            }
            catch (ArgumentOutOfRangeException e)
            {
                return null;
            }
        }

        private bool VerifyMessage(Message m, int externalId, string messageUsername, DateTime messageCreated, string messageText, Forum f)
        {
            string bugLog = "";
            if (m.Value.Author == messageUsername)
            {
                if (m.Value.Created == messageCreated)
                {
                    if (m.Value.Text != messageText)
                    {
                        bugLog = "Error in messageText : " + m.Value.Text + "\r\n\r\nOld messageText :\t" + messageText + "\r\n\r\n\r\n";
                        bugLog += "messageUsername : " + m.Value.Author + "\t\tOld messageUsername :\t" + messageUsername + "\r\n";
                        bugLog += "messageCreated : " + m.Value.Created + "\t\tOld messageCreated :\t" + messageCreated + "\r\n";
                        DateTime now = DateTime.Now;
                        if (!Directory.Exists("C:\\Logs\\Updates\\" + f.Name + "\\"))
                            Directory.CreateDirectory("C:\\Logs\\Updates\\" + f.Name + "\\"); 

                        System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\Updates\\" + f.Name + "\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".txt");
                        file.WriteLine(bugLog);
                        file.Close();

                        return false;
                    }
                }
                else
                {
                    bugLog = "Error in messageCreated : " + m.Value.Created + "\t\tOld messageCreated :\t" + messageCreated + "\r\n\r\n\r\n";
                    bugLog += "messageUsername : " + m.Value.Author + "\t\tOld messageUsername :\t" + messageUsername + "\r\n";
                    bugLog += "messageText : " + m.Value.Text + "\r\n\r\nOld messageText :\t" + messageText + "\r\n";
                    DateTime now = DateTime.Now;
                    if (!Directory.Exists("C:\\Logs\\Updates\\" + f.Name + "\\"))
                        Directory.CreateDirectory("C:\\Logs\\Updates\\" + f.Name + "\\"); 
                    System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\Updates\\" + f.Name + "\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".txt");
                    file.WriteLine(bugLog);
                    file.Close();

                    return false;
                }
            }
            else
            {
                bugLog = "Error in messageUsername : " + m.Value.Author + "\t\tOld messageUsername :\t" + messageUsername + "\r\n\r\n\r\n";
                bugLog += "messageCreated : " + m.Value.Created + "\t\tOld messageCreated :\t" + messageCreated + "\r\n";
                bugLog += "messageText : " + m.Value.Text + "\r\n\r\nOld messageText :\t" + messageText + "\r\n";
                DateTime now = DateTime.Now;
                if (!Directory.Exists("C:\\Logs\\Updates\\" + f.Name + "\\"))
                    Directory.CreateDirectory("C:\\Logs\\Updates\\" + f.Name + "\\");
                System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\Updates\\" + f.Name + "\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + ".txt");
                file.WriteLine(bugLog);
                file.Close();

                return false;
            }
            return true;
        }

		private readonly Int32 _extIdForumThread;
		private readonly long _idF;
		private IDownloadQueue _q;
    }
}
