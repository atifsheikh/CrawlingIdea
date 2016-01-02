using OneKey.Database.CrawlData;
using Starcounter;
using System;
namespace OneKey.Database
{
    public class WebResource : Concept
    {
        public string Url;
        public DateTime Updated;
        public ExternalAction Action;

        public WebResource(string ResultValue, DateTime dateTime, ExternalAction action,Run run)
        {
            this.Url = ResultValue;
            this.Updated = dateTime;
            this.Action = action;
            DownloadQueue w = new DownloadQueue(ResultValue,action,run);
        }
    }
}
