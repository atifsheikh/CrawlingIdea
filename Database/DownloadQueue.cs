using OneKey.Database.CrawlData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database
{
    public class DownloadQueue : Concept
    {
        public string Url;
        public Run Run;
        public ExternalAction Action;
        public DownloadQueue(string ResultValue,ExternalAction action,Run run)
        {
            this.Url = ResultValue;
            this.Action = action;
            this.Run = run;
        }
    }
}
