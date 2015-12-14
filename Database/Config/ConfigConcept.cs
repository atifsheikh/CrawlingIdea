using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.Config
{
    public class ConfigConcept : Concept
    {
        public Int64 Id { get; set; }
        public Int32 ExternalId { get; set; }
        public string StringExternalId { get; set; }
        public string Url { get; set; }
        public DateTime LatestCrawlTime { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
