using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database.CrawlData
{
    public class DataRows
    {
        public List<DataRow> RowList;
        public DataRows(List<DataRow> p)
        {
            this.RowList = p;
        }

    }
    public class DataRow
    {
        public string Value;

        public DataRow(string p)
        {
            this.Value = p;
        }
    }
}
