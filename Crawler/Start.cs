using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Net;
using System.Web;
using System.IO;
using System.ServiceModel.Syndication;
using Sloppycode.net;
using OneKey.Database.Config;
using Starcounter;
using System.Collections;

namespace OneKey.Crawler
{
    public static class Start
    {
        //static void callback_PushPost(object sender, PushPostEventArgs args)
        //{
        //    System.Console.WriteLine("{0} - Received update from hub!", DateTime.Now);
        //    try
        //    {
        //        SyndicationFeed _SyndicationFeed = args.Feed;
        //        SyndicationItem[] _SyndicationItems = _SyndicationFeed.Items.ToArray();
        //        string blogRssUrl = _SyndicationItems[0].Id;
        //        var StringExternalIdMatch = (new Regex("http://(.*?)\\.", RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(blogRssUrl);
        //        string StringExternalId = StringExternalIdMatch[0].Groups[1].ToString();
        //        Model.Category? c_Create = new Model.Category();
        //        var Forum_NameMatch = (new Regex("http://.*?\\.(.*?)\\.", RegexOptions.Singleline | RegexOptions.IgnoreCase)).Matches(blogRssUrl);
        //        string Forum_Name = Forum_NameMatch[0].Groups[1].ToString();
        //        string Title = _SyndicationItems[0].Title.Text;
        //        Model.Forum _F = (Model.Forum)Globals.Db.Forum.Get(Forum_Name);
        //        if (!Globals.Db.Category.Exsist(StringExternalId, ref c_Create))
        //        {
        //            long Forum_Id = _F.Id;

        //            var category = new Model.NoSql.Category()
        //            {
        //                ForumId = Forum_Id,
        //                StringExternalId = StringExternalId,
        //                Title = Title,
        //                ForumName = Forum_Name,
        //                ForumUrl = blogRssUrl,
        //                Level = 0
        //            };
        //            Globals.Db.Category.Set(category);
        //            c_Create = category;
        //        }
        //        var _q = new DQ_ParticularForum(downloader: Globals.NewInstance());
        //        _q.Enqueue(new DT_BlogCategory_PubSubHubBub(Globals.NewInstance(), _F, (Model.NoSql.Category)c_Create) { ForceLoadAll = false, });
        //        _q.Start();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Exception!\r\n{0}", ex);
        //    }
        //}

        //static void callback_PushVerify(object sender, PushVerifyEventArgs args)
        //{
        //    Console.WriteLine("{0} - Received verify message from hub.", DateTime.Now);
        //    // Verify all requests.
        //    args.Allow = true;
        //}

        //static bool StartListening()
        //{
        //    try
        //    {
        //        // So trace output will go to the console.
        //        //Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        //        //Debug.AutoFlush = true;
        //        var callback = new PushSubscriberCallback(SharingVariables.Variables.CallbackUrl);
        //        try
        //        {
        //            callback.Start();
        //            callback.PushPost += callback_PushPost;
        //            callback.PushVerify += callback_PushVerify;

        //            Console.WriteLine("Listening for connections from hub.");
        //            Console.ReadLine();
        //        }
        //        finally
        //        {
        //            callback.Stop();
        //            callback.Dispose();
        //        }
        //        //Debug.Flush();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    { return false; }
        //}

        public static void Crawl()
        {
            ////Thread to start the callback function for Blog's PubSubHubBub
            //System.Threading.ThreadStart Thread_ThreadCrawler = delegate
            //{
            //    StartListening();
            //};
            //new System.Threading.Thread(Thread_ThreadCrawler).Start();
            ///////////////////

            //try
            //{
            //    QueryResultRows<Category> Cats = Db.SQL<OneKey.Database.Config.Category>("SELECT c FROM OneKey.Database.Config.Category c WHERE c.Forum.Id = ?", 1102);
            //}
            //catch (Exception ex)
            //{ }
            int sync, asy;
            System.Threading.ThreadPool.GetMaxThreads(out sync, out asy);
            System.Threading.ThreadPool.SetMaxThreads(100, asy); // TODO: manage max thread: move to .config
            
            while (true)
            {
                // TODO: bootstrapper instead of dumb loop
                var forums = Forum.GetAll(0);

                // TODO: not implemented: different url merging over forums: e.g. www.forum.com and forum.com
                var uniqueForums = forums;
                //System.Collections.Queue q = new System.Collections.Queue();
                //var q = new DQ_AllForums();
                foreach (Forum forum in uniqueForums) // TODO: optimize: we have read all the forums already: maybe just ids?
                {
                    Console.WriteLine("ForumType = " + forum.Type + "\tForumName = " + forum.Name);
                    //HACK: to crawl only specific forums
                    if (forum.Id != 1218 && forum.Type != "blog")
                    {
                        // just post to all forums queue; queue will handle itself
                        var task = new DT_Forum(CommonClasses.NewInstance(), forum.Id);


                        //DbSession dbs = new DbSession();
                        //byte schedulerCount = Db.Environment.SchedulerCount;

                        //for (byte schedulerNo = 0; schedulerNo < schedulerCount; schedulerNo++)
                        //{
                        //    dbs.RunAsync(DoWork, schedulerNo);
                        //}

                        //q.Enqueue(task);
                    }
                    //else if (forum.Type == "blog")//&& (forum.Id == 1331||forum.Id==1332))
                    //{
                    //    var task = new DT_Blog(Globals.NewInstance(), (Rid)forum.Id);
                    //    q.Enqueue(task);
                    //}
                    // TODO: check state of halt flag
                    //break;	// HACK: only one forum for debugging
                }
                //Queue q_Synchronized = Queue.Synchronized(q);
                //q.Start();



                // TODO: wait some time; queue itself will handle too frequent crawling (using statistics)
                //System.Threading.Thread.Sleep(5 * 60 * 1000);
                break; // HACK: do not loop forever until waiting implemented
                // TODO: check state of halt flag
            } // TODO: replace next iterations with the timed queue in controller attached to statistics
        }

        public static void CrawlThread(long id)
        {
            try
            {
                var threadId = (int)id;
                Thread thread = Thread.Get(threadId);
                var forum = Forum.Get(thread.Forum.Id);

                var downloader = new Downloader_Direct();
                var priorityQueue = new DQ_ParticularForum(downloader);
                if (forum.Type != "blog")
                {
                    var downloadTask = new DT_ForumThread(downloader, (int)thread.ExternalId, (int)thread.Forum.Id, priorityQueue, 0);
                    priorityQueue.Enqueue(downloadTask);
                }
                //else if (forum.Type == "blog")
                //{
                //    var downloadTask = new DT_Verify_BlogThread(downloader, thread, forum, priorityQueue, 0);
                //    priorityQueue.Enqueue(downloadTask);
                //}
                //priorityQueue.Start();
            }
            catch (Exception ex)
            { }
        }

        //public static void Crawl_VerifyThread(long id)
        //{
        //    var threadId = new Rid { Id = id };
        //    var thread = (Thread)Globals.Db.Thread.Get(threadId);
        //    var forum = (Model.NoSql.Forum)Globals.Db.Forum.Get(thread.ForumId);

        //    var downloader = new Downloader_Direct();
        //    var priorityQueue = new DQ_ParticularForum(downloader);
        //    if (forum.Type != "Blog")
        //    {
        //        var downloadTask = new DT_Verify_ForumThread(downloader, (int)thread.ExternalId, (int)thread.ForumId, priorityQueue, 0);
        //        priorityQueue.Enqueue(downloadTask);
        //    }
        //    else if (forum.Type == "Blog")
        //    {
        //        var downloadTask = new DT_Verify_BlogThread(downloader, thread, forum, priorityQueue, 0);
        //        priorityQueue.Enqueue(downloadTask);
        //    }
        //    priorityQueue.Start();
        //}

        public static void CrawlCategory(int id, int page)
        {
            var category = Category.Get(id);
            var downloader = new Downloader_Direct();
            var priorityQueue = new DQ_ParticularForum(downloader);
            var downloadTask = new DT_Category(downloader, category.Id, category.Forum.Id, priorityQueue, page);
            priorityQueue.Enqueue(downloadTask);
            //priorityQueue.Start();
        }
    }
}
