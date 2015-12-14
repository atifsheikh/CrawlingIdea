using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Crawler
{
    class CommonClasses
    {
        public static IDownloader NewInstance()
        {
            // TODO: move downloader kind to .config
            // DT_Base.downloader = new Downloader_Direct();
            return new Downloader_DirectWithDelay(TimeSpan.FromSeconds(0.25));		// TODO: move delay to .config
        }

        public static string Cleanup(string messageText)
        {
            var s = messageText.Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace("&auml;", "ä").Replace("&aring;", "å").Replace("&ouml;", "ö").Replace("&Auml;", "Ä").Replace("&Aring;", "Å").Replace("&Ouml;", "Ö");
            int lenBefore;
            do
            {
                lenBefore = s.Length;
                s = s.Replace("  ", " ");
            } while (lenBefore > 0 && lenBefore > s.Length);
            return s;
        }
    }
}
