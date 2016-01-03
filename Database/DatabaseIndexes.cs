using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Database
{
    class DatabaseIndexes
    {
        internal static void CreateIndexes()
        {
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "WebPublicationIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX WebPublicationIndex ON WebPublication (Name)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "WebResourceIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX WebResourceIndex ON WebResource (Url)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ExternalActionIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX ExternalActionIndex ON ExternalAction (Feature)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "ExternalVariableIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX ExternalVariableIndex ON ExternalVariable (Action)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "DownloadQueueIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX DownloadQueueIndex ON DownloadQueue (Action)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "CrawlDataRowIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX CrawlDataRowIndex ON CrawlDataRow (UniqueID, ColumnName)"); }
            if (Db.SQL("SELECT i FROM MaterializedIndex i WHERE Name = ?", "RunIndex").First == null) { Starcounter.Db.SQL("CREATE INDEX RunIndex ON Run (Feature)"); }
        }
    }
}
