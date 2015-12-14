using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.IO;
using System.Net;
using System.Collections.Generic;
using OneKey.Database.Config;

namespace OneKey.Crawler
{
    /// <summary>
    /// pages order assumed: newest messages on page with the greatest number
    /// </summary>
    class DT_Verify_BlogThread : DT_OfParticularForum
    {
        public DT_Verify_BlogThread(IDownloader downloader, Thread _Thread, Forum _Forum		// TODO: idForum should be eliminated and thread contains id of its forum
            , IDownloadQueue thisQ, int messageCount
            )
            : base(downloader)
        {
            _T = _Thread;
            _F = _Forum;
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
                if (_page == -1)					// if page to crawl not set
                {
                    if (ForceLoadAll)
                    {
                        _page = 1;
                    }
                    else
                    {
                        if (_T.LastCrawledPage != null)				// if already known page
                        {
                            _page = _T.LastCrawledPage;
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
                    if (_F.StringExternalIdThread == "1" && _F.thread.Url.Contains("{1}"))
                    {
                        var c = (Category)Globals.Db.Category.Get(_T.CategoryId);
                        u = _F.Url + string.Format(_F.thread.Url, _T.StringExternalId, Page);
                    }
                    else if (_F.StringExternalIdThread == "1" && _F.thread.Url.Contains("{2}"))
                    {
                        var c = (Category)Globals.Db.Category.Get(_T.CategoryId);
                        u = _F.Url + string.Format(_F.thread.Url, c.StringExternalId, _T.StringExternalId, Page);
                    }
                    else if (_F.thread.Url.Contains("{2}"))
                    {
                        var c = (Category)Globals.Db.Category.Get(_T.CategoryId);
                        u = _F.Url + string.Format(_F.thread.Url, c.ExternalId, _T.ExternalId, Page);
                    }
                    else
                    {
                        if (_T.ExternalId != 0)
                        {
                            if (_F.thread.Url.Contains("http://"))
                                u = string.Format(_F.thread.Url, _T.ExternalId, Page);
                            else
                                u = _F.Url + string.Format(_F.thread.Url, _T.ExternalId, Page);
                        }
                        else
                        {
                            u = _F.Url + string.Format(_F.thread.Url, _T.StringExternalId, Page);
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
                if (_T.UpdateDateTime == DateTime.MinValue || _T.UpdateDateTime < DateTime.Now.AddDays(-1))
                {
                    var ThreadUpdateTime = _T;
                    ThreadUpdateTime.UpdateDateTime = DateTime.Now;
                    Globals.Db.Thread.Update(ThreadUpdateTime);
                    DT_BlogThread.CrawlMessages(ThreadUpdateTime, _F);
                }
            }
            catch (System.Net.WebException e)
            {
                //((App)App.Current).Log(e.ToString());	// TODO: log
                this.Status = StatusCode.UnknownError;
            }
        }




        private readonly Thread _T;
        private readonly Forum _F;
        private IDownloadQueue _q;
    }
}
