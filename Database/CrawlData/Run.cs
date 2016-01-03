using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.CrawlData
{
    public class Run : Concept
    {
        /// <summary>
        /// Time the run Started
        /// </summary>
        public DateTime StartTime;

        /// <summary>
        /// Time the Run Stopped
        /// </summary>
        public DateTime EndTime;

        /// <summary>
        /// Run is attached to a Feature
        /// </summary>
        public ExternalFeature Feature;
        
        /// <summary>
        /// 1. Scheduled
        /// 2. OnDemand
        /// </summary>
        public string RunType;

        public Run(ExternalFeature feature, string runtype)
        {
            // TODO: Complete member initialization
            this.Feature = feature;
            this.StartTime = DateTime.Now;
            this.RunType = runtype;
        }
    }
}
