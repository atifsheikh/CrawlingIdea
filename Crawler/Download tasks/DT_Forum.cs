using OneKey.Database.Config;
using Starcounter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace OneKey.Crawler
{
	class DT_Forum : DT_Base
	{
        private Int64 _idF;
		private DQ_ParticularForum _queue;

        public DT_Forum(IDownloader downloader, Int64 idForum)
			: base(downloader)
		{
			_idF = idForum;
            Download();
		}

		#region DT_Base
		public override string Uri
		{
			get			// lazy : construct uri on first use
			{
				var u = base.Uri;
				if (String.IsNullOrEmpty(u))
				{
                    Forum f = Forum.Get(_idF);		// TODO: null? Handle it
					u = base.Uri = f.Url;
				}
				return u;
			}
		}
		#endregion

        public static BackgroundWorker bw = new BackgroundWorker();

        //public static void bw_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    BackgroundWorker worker = sender as BackgroundWorker;

        //    while(true)
        //    {
        //        if ((worker.CancellationPending == true))
        //        {
        //            e.Cancel = true;
        //            break;
        //        }
        //        else
        //        {
        //            // Perform a time consuming operation and report progress.
        //            categories = Category.GetAll(Convert.ToInt64( e.Argument));
        //            e.Result = categories;
        //        }
        //    }
        //}

        //public static IEnumerable<Category> categories;


		public override void Download()
		{

            //try
            //{
                //if (null == _queue) _queue = new DQ_ParticularForum(downloader: OneKey.Crawler.CommonClasses.NewInstance());

                //bw.WorkerSupportsCancellation = true;
                //bw.WorkerReportsProgress = true;
                //bw.RunWorkerAsync(_idF);
            // get all the categories
            
            //Variables.UISyncContext = System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext();             
			while (true)
			{
				var forum = Forum.Get(_idF);
                IEnumerable<Category> categories = Category.GetAll(_idF);
                var now = DateTime.UtcNow;
                var CrawlInterval = forum.CrawlInterval.Split(':');
                TimeSpan CrawlIntervalSpan = new TimeSpan(Convert.ToInt32(CrawlInterval[0]), Convert.ToInt32(CrawlInterval[1]), Convert.ToInt32(CrawlInterval[2]));
                if (forum.LatestCrawlTime + CrawlIntervalSpan >= now)
				{
					System.Threading.Thread.Sleep(forum.LatestCrawlTime +  CrawlIntervalSpan - now);
				}
				Download(categories);

                Db.Transaction(() => { 
				    forum.LatestCrawlTime = DateTime.UtcNow;
                });
                
			}
			// TODO: wait for results
		}

		private void Download(IEnumerable<Category> categories)
		{
            foreach (Category category in categories) // post all the categories and then start queue
			{
                //_queue.Enqueue(
					// TODO: handle forums with threads from oldest to newest 
                var task = new DT_Category(_queue.Downloader, category.Id, _idF, _queue, 1);
					// start with the first page: most of our forums have from newest to oldest sorting order
                    //);
				//break;	// HACK: only one category for debugging
			}
            //_queue.Start();
            //while (_queue.IsAlive)
            //{
            //    System.Threading.Thread.Sleep(200);
            //}

		}
	}

}
