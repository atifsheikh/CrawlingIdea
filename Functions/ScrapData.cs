using OneKey.Database;
using OneKey.Database.CrawlData;
using OneKey.Helpers;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneKey.Functions
{
    public class ScrapData
    {
        internal static void Start(System.Net.HttpWebResponse response, Database.ExternalAction externalAction, ref Dictionary<string, string> SessionVariableContainer, int PaginationCount, bool Pagination, Run run)
        {
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                string responseText = reader.ReadToEnd();
                List<string> UniqueID = new List<string>();
                int newlyAddedDataRow = 0;
                foreach (var actionVariable in externalAction.Variables)
                {
                    System.Text.RegularExpressions.MatchCollection RegexResultCollection = CommonHelper.GetAllMatches(responseText, actionVariable.Regex);

                    for (int loop = 0; loop < RegexResultCollection.Count; loop++)
                    {
                        System.Text.RegularExpressions.Match RegexResult = RegexResultCollection[loop];
                        string ResultValue = RegexResult.Groups[1].Value;
                        if (!string.IsNullOrEmpty(ResultValue))
                        {
                            if (actionVariable.VariableType == "Session")
                            {
                                if (SessionVariableContainer.ContainsKey(actionVariable.Name))
                                {
                                    SessionVariableContainer.Remove(actionVariable.Name);//, ResultValue);
                                }
                                SessionVariableContainer.Add(actionVariable.Name, ResultValue);
                            }
                            else if (actionVariable.VariableType == "Content")
                            {
                                newlyAddedDataRow = ParseContent(externalAction,actionVariable, ResultValue, UniqueID, RegexResultCollection, loop, newlyAddedDataRow,run);
                            }
                        }
                    }
                }
                if (newlyAddedDataRow == 0)
                {
                    Db.Transact(() =>
                    {
                        externalAction.lastCrawledPage = PaginationCount;
                    });
                    Pagination = false;
                }
            }
        }

        private static int ParseContent(ExternalAction externalAction, ExternalVariable actionVariable, string ResultValue, List<string> UniqueID, System.Text.RegularExpressions.MatchCollection RegexResultCollection, int loop, int newlyAddedDataRow, Run run)
        {
            if (actionVariable.Name == "<<WebResource>>" || actionVariable.Name == "UniqueID")
            {
                if (!ResultValue.Contains(externalAction.Feature.Site.Name))
                {
                    if (!ResultValue.StartsWith("/"))
                    {
                        ResultValue = "/" + ResultValue;
                    }
                    ResultValue = externalAction.Feature.Site.Url + ResultValue;
                    if (actionVariable.Name == "UniqueID")
                    {
                        UniqueID.Add(ResultValue);
                    }
                }
            }
            else if (RegexResultCollection.Count != UniqueID.Count)
            {
                return newlyAddedDataRow;// "Regex Count Invalid... Please Contact Admin to recheck the regex for " + actionVariable.Name;
            }

            if (actionVariable.Name == "<<WebResource>>")
            {
                WebResource w = Db.SQL<WebResource>("SELECT W FROM WebResource W WHERE Url=?", ResultValue).First;
                if (w == null)
                {
                    Db.Transact(() =>
                    {
                        w = new WebResource(ResultValue, DateTime.Now, externalAction,run);
                    });
                }
            }
            else if (!string.IsNullOrEmpty(ResultValue))
            {
                CrawlDataRow cdr = Db.SQL<CrawlDataRow>("SELECT w FROM CrawlDataRow w WHERE UniqueID = ? and ColumnName = ?", UniqueID[loop], actionVariable.Name).First;
                //CrawlDataColumn crawlDataColumn = Db.SQL<CrawlDataColumn>("SELECT w FROM CrawlDataColumn w WHERE UniqueID = ?", UniqueID[loop]).First;
                if (cdr == null)
                {
                    Db.Transact(() =>
                    {
                        cdr = new CrawlDataRow(UniqueID[loop], actionVariable.Name, ResultValue, externalAction.Feature.Site,run);
                        newlyAddedDataRow++;
                        //crawlDataColumn = new CrawlDataColumn();
                        //crawlDataColumn.UniqueID = UniqueID[loop];
                    });
                }
            }
            return newlyAddedDataRow;
        }
    }
}
