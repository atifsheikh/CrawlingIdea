using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
	/// <summary>
	/// pages order assumed: newest messages on page with the greatest number
	/// </summary>
	class DT_ForumThread : DT_OfParticularForum
	{
		public DT_ForumThread(IDownloader downloader, int extIdForumThread, long idForum		// TODO: idForum should be eliminated and thread contains id of its forum
			, IDownloadQueue thisQ, int messageCount
			)
			: base(downloader)
		{ 
			_extIdForumThread = extIdForumThread; 
			_idF = idForum;			
			_q = thisQ;
			ForceLoadAll = false;
			_messageCount = messageCount;
            Download();
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
                            _page = t.LastCrawledPage;
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

                    if (f.StringExternalIdThread == true && f.ThreadPage_Url.Contains("{1}"))
                    {
                        var c = (Category)Category.Get(t.Category.Id);
                        u = f.Url + string.Format(f.ThreadPage_Url, t.StringExternalId, Page);
                    }
                    else if (f.StringExternalIdThread == true && f.ThreadPage_Url.Contains("{2}"))
                    {
                        var c = (Category)Category.Get(t.Category.Id);
                        u = f.Url + string.Format(f.ThreadPage_Url, c.StringExternalId, t.StringExternalId, Page); 
                    }
                    else if (f.ThreadPage_Url.Contains("{2}"))
                    {
                        var c = (Category)Category.Get(t.Category.Id); ;
                        u = f.Url + string.Format(f.ThreadPage_Url, c.ExternalId, t.ExternalId, Page); 
                    }
                    else
                    {
                        if (t.ExternalId != 0)
                        {
                            if (f.ThreadPage_Url.Contains("http://"))
                                u = string.Format(f.ThreadPage_Url, t.ExternalId, Page);
                            else
                                u = f.Url + string.Format(f.ThreadPage_Url, t.ExternalId, Page);
                        }
                        else
                        {
                            u = f.Url + string.Format(f.ThreadPage_Url, t.StringExternalId, Page);
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
				try
				{
					t = (Thread)Thread.Get(_extIdForumThread, _idF);
				}
				catch (InvalidOperationException exception)
				{
					return;
				}


				var newMessageCount = 0;
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
				var messageCreatedMatches = (new Regex(f.ThreadPage_MessageCreated, RegexOptions.Singleline)).Matches(html);
				var messageIdMatches = (new Regex(f.ThreadPage_MessageId, RegexOptions.Singleline)).Matches(html);
				var messageTextMatches = (new Regex(f.ThreadPage_MessageText, RegexOptions.Singleline)).Matches(html);
				//var messageUserIdMatches = _messageUserIdRegex.Matches(requestBody);
				var messageUsernameMatches = (new Regex(f.ThreadPage_MessageUsername, RegexOptions.Singleline)).Matches(html);
                
                
			    // TODO: message fields

                if ((messageCreatedMatches.Count ^ messageIdMatches.Count ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                {
                    if ((f.Type != "fairshopping" && f.Type != "autopower" && f.Type != "ungdomar") 
                        || (f.Type == "fairshopping" && (messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                        || (f.Type == "autopower"  && (messageCreatedMatches.Count ^ (messageIdMatches.Count + 1) ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0)
                        || (f.Type == "ungdomar" && (messageCreatedMatches.Count ^ (messageIdMatches.Count + 1) ^ messageTextMatches.Count ^ messageUsernameMatches.Count) != 0))
                    {
                        string bugLog = "Error in Regex match of messages at url " + Uri + ":\r\nMsg Date :\t" + messageCreatedMatches.Count + "\r\nMsg ID :\t" + messageIdMatches.Count + "\r\nMsg Text :\t" + messageTextMatches.Count + "\r\nMsg Users :\t" + messageUsernameMatches.Count;
                        bugLog += "\r\nRegex:\r\nMsg Date :\t" + f.ThreadPage_MessageCreated + "\r\nMsg ID :\t" + f.ThreadPage_MessageCreated + "\r\nMsg Text :\t" + f.ThreadPage_MessageText + "\r\nMsg Users :\t" + f.ThreadPage_MessageUsername;
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
                if (f.Type == "fairshopping" || f.Type == "autopower" || f.Type == "ungdomar")
                {
                    MessageIdMatchesCount = messageTextMatches.Count;
                    MessageIdMatchesCountDifference = MessageIdMatchesCount - messageIdMatches.Count;
                }
                for (var i = 0; i < MessageIdMatchesCount; i += 1)
				{
				    int externalId=0;
                    if (f.Type == "Episerver") // Episerver is still the only forum with a strange kind of hash id for messages so this is a hack to convert it to a unique int id.
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
                            return;
                        }
                    }
                    else if (f.Type == "fairshopping" || f.Type == "autopower" || f.Type == "ungdomar")
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
                        catch (FormatException e) { return; }

                    }
				    var messageText = "";
				    try
				    {
                        messageText = messageTextMatches[i].Groups[1].ToString();
                    }
                    catch (ArgumentOutOfRangeException e)
                    {

                        return;
                    }
				    var messageCreatedString = "";
				    try
				    {
                        messageCreatedString = messageCreatedMatches[i].Groups[1] + (messageCreatedMatches[i].Groups[2].Success ? " " + messageCreatedMatches[i].Groups[2].ToString() : "");
				    }
				    catch (ArgumentOutOfRangeException e)
				    {
				        
				        return;
				    }
					
					DateTime messageCreated;
                    if(f.Name == "Alltomtradgard.se")
                    {
                        if(messageCreatedString.Contains("Zon"))
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
                            else //if (f.Id == 1988 || f.Type == "Episerver" || f.Id == 1121 || f.Id == 1204 || f.Id == 1203 || f.Id == 1209|| f.Id == 1224 || f.Id == 1225 || f.Id == 1226)
                            {
                                try
                                {//                                MessageBox.Show("Error in Date : " + messageCreatedString);
                                    messageCreated = DateManagement.dateTimeConverter(messageCreatedString);
                                }
                                catch (Exception ex)
                                {
                                    string bugLog = "Error in Date : " + ex.Message + "\r\n" + messageCreatedString;
                                    DateTime now = DateTime.Now;
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + f.Name + ".txt");
                                    file.WriteLine(bugLog);

                                    file.Close();
                                    continue;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            string bugLog = "Error in Date : " + ex.Message + "\r\n" + messageCreatedString;
                            DateTime now = DateTime.Now;
                            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + f.Name + ".txt");
                            file.WriteLine(bugLog);

                            file.Close();
                            continue;
                        }
                    }
					//var messageUserId = (messageUserIdMatches.Count > 0) ? int.Parse(messageUserIdMatches[i].Groups[1].ToString()) : 0;
                    string messageUsername;
                    try
                    {
                        messageUsername = messageUsernameMatches[i].Groups[1].ToString();
                    }
                    catch (Exception)
                    {

                        messageUsername = "guest"; //Simply because some forums has impossible variations of users.
                    }
                    
                    // Ugly hack for familjeliv
                    if(f.Id == 1103)
                    {
                        messageUsername = messageUsername.Replace("+", " ");
                    }
				    Message m= new Message();
					if (!Message.Exsist(externalId.ToString(), t.Id, ref m))
					{
						messageText = CommonClasses.Cleanup(messageText);
                        Message message = new Message
						{
                            Thread = t,
							ExternalId = externalId,

							Text = messageText,
							Created = messageCreated,
							//UserExternalId = messageUserId,
							Author = messageUsername,									
							Page = (short)Page,
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
					}
					this.Status = StatusCode.DownloadedOK;
				}
				if (newMessageCount > 0			// do crawl if new message found
					|| Page < t.PageCount		// or if know that there are other pages
					|| (ForceLoadAll && Page <= t.PageCount)
					)
					// TODO: parse paginator and get page count
				{
                    t.MessageCount += (short)newMessageCount;
                    t.LastCrawledPage = (short)Page;
                    t.PageCount = (short)(Page + Convert.ToInt32(f.CrawlThreadPageInterval));
					Thread.Update(t);

					// Do post request next page
                    //_q.Enqueue(
                        new DT_ForumThread(Downloader, _extIdForumThread, f.Id, _q, _messageCount + newMessageCount);// { Page = t.PageCount, ForceLoadAll = this.ForceLoadAll, });
					// TODO: parse paginator: test whether forum has new page: because last crawled page can has no new message but new page might appear
				}
			}
			catch (System.Net.WebException e)
			{
				//((App)App.Current).Log(e.ToString());	// TODO: log
				this.Status = StatusCode.UnknownError;
			}
		}

		private readonly Int32 _extIdForumThread;
		private readonly long _idF;
		private IDownloadQueue _q;

	}
}
