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
        public Run Run;
        public string ColumnName;
        public string Value;
        public string UniqueID;
        public WebPublication WebPublication;

        public CrawlDataRow(string uniqueid, string columnname, string resultValue, WebPublication webPublication,Run run)
        {
            this.WebPublication = webPublication;
            this.UniqueID = uniqueid;
            this.ColumnName = columnname;
            this.Value = resultValue;
            this.Run = run;
        }
    }
}
