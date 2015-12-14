using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Server.Handlers
{
    class CrawlerHooks
    {
        internal static void CrawlerHandler()
        {
            Handle.GET("/StartCrawler", () =>
            {
                if (!IsCrawlerAlive)
                {
                    IsCrawlerAlive = true;
                    OneKey.Crawler.Start.Crawl();
                }
                return 200;
            });
        }

        public static bool IsCrawlerAlive { get; set; }
    }
}
