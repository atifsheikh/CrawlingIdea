using System;
using System.Threading;

namespace OneKey.Crawler
{

	// TODO: make DQ_AllForums singleton unless we need several
	/// <summary>
	/// post download task for the eniry forum here
	/// </summary>
	class DQ_AllForums : IDownloadQueue
	{
		// TODO: load from .config : max threads

		// TOOD: DQ_AllForums: statistics

		#region IDownloadQueue
		public void Enqueue(DT_Base task)
		{
			// TODO: handle & log
            try
            {
                var t = (DT_Forum)task;		// ensure the task kind; fall into exception for now
                
                // TODO: handle too frequent crawling (using statistics)

                // TODO: just post to thread pool: one per process but we need only one DQ_AllForums

                // just use thread pool of the process
                // it will automatically queue forum crawl tasks
                // all the async tasks goe here! Do not interfere unless intended!
                if (task.ToString() == "Scraper.DT_Forum" || task.ToString() == "Scraper.DT_Blog")
                {
                    WaitHandle ForumCrawlerWaitHandle = new AutoResetEvent(false);
                    try
                    {
                        ThreadPool.RegisterWaitForSingleObject(ForumCrawlerWaitHandle, CrawlForum, task, new TimeSpan(1, 0, 0), false);
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    try
                    {
                        ThreadPool.QueueUserWorkItem(CrawlForum, task);
                    }
                    catch (Exception) { }
                }
            }
            catch (Exception)
            {
                try
                {
                    //var t = (DT_Blog)task;
                    //ThreadPool.QueueUserWorkItem(CrawlBlog, task);
                }
                catch (Exception)
                { 
                }
            }

		}

        //private void CrawlBlog(Object forum)
        //{
        //    var f = (DT_Blog)forum;
        //    f.Download();
        //    DQ_AllForums.IsAlive = false;
        //}

		#endregion 

		/// <summary>
		/// just put
		/// </summary>
		public void Start()
		{
			// TODO: advance scheduling: time

			// TODO: advance scheduling: result tracking

			// TODO: advance scheduling: use separate manager thread

			// _t = new System.Threading.Thread(CrawlForum);
			//_t.Start();


			
		}

		///// <summary>
		///// a separate thread that does posting tasks to the thread pool of the process; and manage then
		///// </summary>
		//private static void TasksManager()
		//{
 
		//}


		/// <summary>
		/// crawl the entire forum for now
		/// </summary>
		/// <param name="forum">DT_Forum itself, stores results into it</param>
        private static void CrawlForum(Object forum)
        {
            try
            {
                var f = (DT_Forum)forum;
                f.Download();
                DQ_AllForums.IsAlive = false;
            }
            catch (Exception)
            { }
        }

        private void CrawlForum(Object forum, bool timedOut)
        {
            CrawlForum(forum);
        }



        public static bool IsAlive { get; set; }
    }
}
