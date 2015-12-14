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
        public ExternalAction Action;

        public DownloadQueue(string ResultValue,ExternalAction action)
        {
            this.Url = ResultValue;
            this.Action = action;
        }
    }
}
