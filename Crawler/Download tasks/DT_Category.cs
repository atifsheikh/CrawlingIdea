using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
	class DT_Category : DT_OfParticularForum
	{
		private readonly long _idC;
		private readonly long _idF;
        private readonly DQ_ParticularForum _q; 
		private int _page;

        public DT_Category(IDownloader downloader, long idC, long idF, DQ_ParticularForum q, int page)
            : base(downloader)
        {
            _idC = idC; _idF = idF; _q = q; _page = page; ForceLoadAll = false;
            Download();
        }

		#region DT_Base
		public override string Uri
		{
			get			// lazy : construct uri on first use: since it might involve request to db
			{
				var u = base.Uri;  
			    u = string.Empty;
			    if (String.IsNullOrEmpty(u))
				{
					var f = Forum.Get(_idF);				// TODO: null? Handle it
					//if (f == null)
					//{
					//	return "";
					//}
					var c = Category.Get(_idC);		// TODO: null? Handle it
					//if (c == null)
					//{
					//	return "";
					//}
					var forum = (Forum) f;
					var category = (Category) c;
                    if(_page == 1)
                    {
                        _page = Convert.ToInt32(forum.StartCrawlPage); // 1 blir 0 på phpBB, Invision och 1 blir 1 på vBulletin, SMF
                    }
                    if (forum.StringExternalIdCategory == true)
                    {
                        string sId = "";
                        if (category.Forum.Name == "fairshopping")
                        {
                            if (category.StringExternalId == null)
                            {
                                sId = category.ExternalId.ToString();
                                u = /*forum.Url + */String.Format(forum.CategoryPage_Url, sId, _page);
                            }
                            else if (category.StringExternalId != null)
                            {
                                sId = category.ExternalId.ToString();
                                u = forum.Url + sId;
                            }
                        }
                        else
                        {
                            sId = category.StringExternalId.Replace("-", "/");
                            u = /*forum.Url + */String.Format(forum.CategoryPage_Url, sId, _page);
                        }
                    }
                    else
                    {
                        u = /*forum.Url + */String.Format(forum.CategoryPage_Url, category.ExternalId, _page);
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
                if(_idF != 1113) //Byggahus test
                {
                    categoryPage = DownloaderEncoding.GetPage(u1);
                }
                else
                {
                    categoryPage = Downloader.Download(u1);
                }

				// TODO: extract parser from here
				var c = Category.Get(_idC);
				if (c == null)
				{
					return;
				}
				var category = (Category)c;		
				var f = Forum.Get(_idF);
  				if (f == null)
  				{
  					return;
  				}
				var forum = (Forum)f;
			    
			    /*if (forum.ForumType == "phpBB" || forum.ForumType == "99mac" || forum.ForumType == "Startaeget")// TODO: Add forum attribute with encoding
                {
                    byte[] bytes = Encoding.Default.GetBytes(categoryPage);
                    categoryPage = Encoding.UTF8.GetString(bytes);
                }*/
			    var reId = new Regex(forum.CategoryPage_ThreadId, RegexOptions.Singleline | RegexOptions.IgnoreCase);
				var reTitle = new Regex(forum.CategoryPage_ThreadId, RegexOptions.Singleline | RegexOptions.IgnoreCase);

				var threadIdMatches = reId.Matches(categoryPage);						   // Retrieve content from page.
				var threadTitleMatches = reTitle.Matches(categoryPage);
                //System.Diagnostics.Process.Start(u1);

                if ((threadTitleMatches.Count ^ threadIdMatches.Count) != 0)
				{
                    string bugLog = threadTitleMatches.Count.ToString() + " " + threadTitleMatches.Count.ToString() + " " + u1;
                    // Write the string to a file.
                    DateTime now = DateTime.Now;
                    System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\Logs\\" + now.Month.ToString() + now.Day.ToString() + now.Hour.ToString() + now.Minute.ToString() + now.Second.ToString() + forum.Name + ".txt");
                    file.WriteLine(bugLog);

                    file.Close();
                    return;
                }

				// custom fields
                //var fieldAllParseResult = new Dictionary<string, MatchCollection>();
                //foreach (var fl in forum.fields.Thread)
                //{
                //    string k = fl.Key; string v = fl.Value;
                //    var re = new Regex(v, RegexOptions.IgnoreCase);
                //    var matches = re.Matches(categoryPage);
                //    fieldAllParseResult[k] = matches;
                //}

				// TODO: custom fields of category itself

				// Loop all retrieved content, and add new content to database.
				for (var i = 0; i < threadIdMatches.Count; i += 1)
				{
 				    var externalId = 0;
				    var externalIdString = "";
                    if (forum.Type == "Episerver")
                    {
                        externalIdString = threadIdMatches[i].Groups[1].ToString();
                        var regex = new Regex(@"-(\d\d*)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                        var test = regex.Matches(externalIdString);
                        if (test.Count != 0)
                        {
                            var test2 = test[0].Groups[1].ToString();
                            externalId = int.Parse(test2);
                        }
                        else
                        {
                            externalId = int.Parse(externalIdString);
                        }
                    }
                    else
                    {
                        if (!int.TryParse(threadIdMatches[i].Groups[1].ToString(), out externalId))
                        {
                            if (f.StringExternalIdThread != true)
                            {
                                externalIdString = threadIdMatches[i].Groups[1].ToString();
                                var regex = new Regex(@"(\d+)", RegexOptions.Singleline | RegexOptions.IgnoreCase);
                                externalId = int.Parse(regex.Match(externalIdString).ToString());
                            }
                            else
                            {
                                externalIdString = threadIdMatches[i].Groups[1].ToString();
                                externalId = 0;
                            }
                        }
                        //else
                        //    externalId = int.Parse(threadIdMatches[i].Groups[1].ToString());
                    }
                        
                    var threadTitle = threadTitleMatches[i].Groups[1].ToString();
                    threadTitle = CommonClasses.Cleanup(threadTitle);

                    //code added by atif to delete multiple copies of same threads
                    //to check if the ID is already entertained
                    
                    //Thread.GetAll(Rid parentEntity);
                    //need to check existing threads from DB

                    bool AlreadyUsedthreadTitle = false;
                    for (int loop1 = 0; loop1 < i; loop1++)
                    {
                        var Check_Title = threadTitleMatches[loop1].Groups[1].ToString();
                        Check_Title = CommonClasses.Cleanup(Check_Title);
                        if (threadTitle == Check_Title)
                        {
                            AlreadyUsedthreadTitle = true;
                            break;
                        }
                    }
                    if (AlreadyUsedthreadTitle == true)
                        continue;
                    /////////////////////////////////////////////////



                    //var fi = new Dictionary<string, string>();		// parsed fields
                    //try
                    //{
                    //    foreach (var field_AllMatches in fieldAllParseResult)
                    //        fi[field_AllMatches.Key] = field_AllMatches.Value[i].Groups[1].ToString();		// TODO: parsing method
                    //}
                    //catch (Exception ex)
                    //{
                    //    // actually this is a parsing metadata error: different counts got
                    //    ;	// TODO: Log
                    //}

					// do force update forum thread: assume some field might be updated
					Thread t = null;
                    if (f.StringExternalIdThread != true && (!Thread.Exsist(externalId.ToString(),forum.Id, ref t)))
					{
						newThereadCount += 1;
						var dtNow = DateTime.UtcNow;
						var t1 = new Thread
						{
							ExternalId = externalId,
                            StringExternalId = externalIdString,
							LatestCrawlTime = dtNow,

							Forum = f,
							Category = c,

							Title = threadTitle,
		
							MessageCount = 0, 
							FirstMessageId = 0,
							LastMessageId = 0,
		
							PageCount = 1,
							LastCrawledPage = (short)forum.StartCrawlPage,										
                            //Fields = fi,
						};
						Thread.Set( t1);
					}
                    else if ((externalId == 0 && f.StringExternalIdThread == true) && (!Thread.Exsist(externalIdString, forum.Id, ref t)))
                    {
                        newThereadCount += 1;
                        var dtNow = DateTime.UtcNow;
                        var t1 = new Thread
                        {
                            ExternalId = externalId,
                            StringExternalId = externalIdString,
                            LatestCrawlTime = dtNow,

                            Forum = f,
                            Category = c,

                            Title = threadTitle,

                            MessageCount = 0,
                            FirstMessageId = 0,
                            LastMessageId = 0,

                            PageCount = 1,

                            LastCrawledPage = (short)(forum.StartCrawlPage),

                            //Fields = fi,

                            //CategoryName = category.Title,
                            //ForumUrl = forum.Url,
                            //ForumName = forum.Name,

                        };
                        Thread.Set(t1);
                    }
                    else
					{
						var t1 = t;
                        //t1.Fields = fi;
						t1.Title = threadTitle;
						t1.LatestCrawlTime = DateTime.UtcNow;
						Thread.Update( t1);
					}

                    //_q.Enqueue(
                        var task = new DT_ForumThread(Downloader, externalId, forum.Id, _q,0);// { ForceLoadAll = ForceLoadAll, });
                    // TODO: MessageCount
                    // MessageCount += crawler.MessageCount;
                    
                    //break;	// HACK: only one category for debugging
				}


			    if (category.LastCrawledPage < _page || newThereadCount > 0)
				{
					category.LastCrawledPage = (short)_page;
				    category.Forum.Name = forum.Name;
				    category.Forum.Url = forum.Url;
					category.LatestCrawlTime = DateTime.UtcNow;
					category.ThereadCount += (short)newThereadCount;
                    category.StringExternalId = category.StringExternalId;
					Category.Update( category);
				}

				if ( newThereadCount > 0 || (ForceLoadAll && category.LastCrawledPage <= category.PageCount))
                    //_q.Enqueue(
                    new DT_Category(_q.Downloader, category.Id, _idF, _q, _page + Convert.ToInt32(forum.CrawlCategoryPageInterval));// { ForceLoadAll = ForceLoadAll, });	// TODO: parse page and determine what is the page count
			}
			catch (System.Net.WebException e)
			{
				;	// TODO: log
				Status = StatusCode.UnknownError;	// TODO: handle error kind
			}
		}
	}
}
