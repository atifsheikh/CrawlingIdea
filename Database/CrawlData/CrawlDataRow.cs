using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.CrawlData
{
    public class CrawlDataRow : Concept
    {
        public string ColumnName;
        public string Value;
        public string UniqueID;
        public WebPublication WebPublication;

        public CrawlDataRow(string p1, string p2, string ResultValue, WebPublication webPublication)
        {
            this.WebPublication = webPublication;
            this.UniqueID = p1;
            this.ColumnName = p2;
            this.Value = ResultValue;
        }
    }
}
