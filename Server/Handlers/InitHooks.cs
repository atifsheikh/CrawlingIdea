using Newtonsoft.Json;
using OneKey.Database;
using OneKey.Database.CrawlData;
using OneKey.Server.Partials;
using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OneKey.Server.Handlers
{
    class InitHooks
    {
        internal static void Init()
        {

            //Data Page
            Handle.GET("/OneKey/DataView?SiteID={?}", (string WebPublicationObId) =>
            {
                WebPublication webPublication = Db.SQL<OneKey.Database.WebPublication>("SELECT c FROM OneKey.Database.WebPublication c WHERE ObId = ? ", WebPublicationObId).First;
                List<DataRows> DataGridColumns = null;
                List<DataRows> DataGrid = GetDataRows(ref DataGridColumns, webPublication);

                ResultsView resultsView = new ResultsView();
                resultsView.WebPublication = webPublication.Name;
                resultsView.RowsList.Data = DataGrid;
                resultsView.ColumnsList.Data = DataGridColumns;

                resultsView.Html = "/Client/DataView.html";
                return resultsView;
            });


            //Main Page 
            Handle.GET("/OneKey", () =>
            {
                WebPublicationsViewNew _WebPublicationsView = new WebPublicationsViewNew()
                {
                    //WebPublications = Db.SQL("SELECT i FROM OneKey.Database.WebPublication i"),
                    Html = "/Client/WebPublicationsNew.html"
                };
                return _WebPublicationsView;
            });
            //WebPublication Page
            //    Handle.GET("/OneKey/{?}", (string WebPublicationName) =>
            //    {
            //        WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);

            //        OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;

            //        WebPublicationsView _WebPublicationsView = new WebPublicationsView()
            //        {
            //            Html = "/Client/WebPublications.html",
            //            WebPublications = Db.SQL("SELECT i FROM OneKey.Database.WebPublication i")
            //        };
            //        if (WebPublicationResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.Data = WebPublicationResult;
            //            _WebPublicationsView.SelectedWebPublicationID = WebPublicationResult.ObId;
            //            _WebPublicationsView.NewWebPublicationName = _WebPublicationsView.SelectedWebPublication.Name;
            //            _WebPublicationsView.NewWebPublicationUrl = _WebPublicationsView.SelectedWebPublication.Url;
            //            _WebPublicationsView.NewWebPublicationDescription = _WebPublicationsView.SelectedWebPublication.Description;
            //        }

            //        return _WebPublicationsView;
            //    });

            //    //Feature Page
            //    Handle.GET("/OneKey/{?}/{?}", (string WebPublicationName, string FeatureName) =>
            //    {
            //        WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
            //        FeatureName = HttpUtility.UrlDecode(FeatureName);

            //        OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;
            //        OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", FeatureName, WebPublicationResult).First;

            //        WebPublicationsView _WebPublicationsView = new WebPublicationsView()
            //        {
            //            Html = "/Client/WebPublications.html",
            //            WebPublications = Db.SQL("SELECT i FROM OneKey.Database.WebPublication i")
            //        };
            //        if (WebPublicationResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.Data = WebPublicationResult;
            //            _WebPublicationsView.SelectedWebPublicationID = WebPublicationResult.ObId;
            //            _WebPublicationsView.NewWebPublicationName = _WebPublicationsView.SelectedWebPublication.Name;
            //            _WebPublicationsView.NewWebPublicationUrl = _WebPublicationsView.SelectedWebPublication.Url;
            //            _WebPublicationsView.NewWebPublicationDescription = _WebPublicationsView.SelectedWebPublication.Description;
            //        }

            //        if (ExternalFeatureResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.Data = ExternalFeatureResult;
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeatureID = ExternalFeatureResult.ObId;
            //            _WebPublicationsView.NewFeatureName = _WebPublicationsView.SelectedWebPublication.SelectedFeature.Name;
            //        }

            //        return _WebPublicationsView;
            //    });

            //    //Action Page
            //    Handle.GET("/OneKey/{?}/{?}/{?}", (string WebPublicationName, string FeatureName, string ActionName) =>
            //    {
            //        WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
            //        FeatureName = HttpUtility.UrlDecode(FeatureName);
            //        ActionName = HttpUtility.UrlDecode(ActionName);

            //        OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName.Replace("%20"," ")).First;
            //        OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", FeatureName.Replace("%20", " "), WebPublicationResult).First;
            //        OneKey.Database.ExternalAction ExternalActionResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ea FROM OneKey.Database.ExternalAction ea WHERE ea.Name=? AND ea.Feature = ?", ActionName.Replace("%20", " "), ExternalFeatureResult).First;

            //        WebPublicationsView _WebPublicationsView = new WebPublicationsView()
            //        {
            //            Html = "/Client/WebPublications.html",
            //            WebPublications = Db.SQL("SELECT i FROM OneKey.Database.WebPublication i")
            //        };

            //        if (WebPublicationResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.Data = WebPublicationResult;
            //            _WebPublicationsView.SelectedWebPublicationID = WebPublicationResult.ObId;
            //            _WebPublicationsView.NewWebPublicationName = _WebPublicationsView.SelectedWebPublication.Name;
            //            _WebPublicationsView.NewWebPublicationUrl = _WebPublicationsView.SelectedWebPublication.Url;
            //            _WebPublicationsView.NewWebPublicationDescription = _WebPublicationsView.SelectedWebPublication.Description;
            //        }

            //        if (ExternalFeatureResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.Data = ExternalFeatureResult;
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeatureID = ExternalFeatureResult.ObId;
            //            _WebPublicationsView.NewFeatureName = _WebPublicationsView.SelectedWebPublication.SelectedFeature.Name;
            //        }

            //        if (ExternalActionResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.Data = ExternalActionResult;
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedActionID = ExternalActionResult.ObId;
            //            _WebPublicationsView.NewActionName = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.Name;
            //            _WebPublicationsView.NewActionUrl = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.ActionUrl;
            //            _WebPublicationsView.NewActionHttpBody = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.HttpBody;
            //            _WebPublicationsView.NewActionHttpType = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.HttpType;
            //            _WebPublicationsView.NewActionOrderInFeature = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.OrderInFeature;
            //            _WebPublicationsView.Pagging = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.Pagging;
            //            _WebPublicationsView.PaggingUrlParameters = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.PaggingUrlParameters;
            //        }
            //        return _WebPublicationsView;
            //    });


            //    //Variable Page
            //    Handle.GET("/OneKey/{?}/{?}/{?}/{?}", (string WebPublicationName, string FeatureName, string ActionName, string VariableName) =>
            //    {
            //        WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
            //        FeatureName = HttpUtility.UrlDecode(FeatureName);
            //        ActionName = HttpUtility.UrlDecode(ActionName);
            //        VariableName = HttpUtility.UrlDecode(VariableName);

            //        OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;
            //        OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", FeatureName, WebPublicationResult).First;
            //        OneKey.Database.ExternalAction ExternalActionResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ea FROM OneKey.Database.ExternalAction ea WHERE ea.Name=? AND ea.Feature = ?", ActionName, ExternalFeatureResult).First;
            //        OneKey.Database.ExternalVariable ExternalVariableResult = Db.SQL<OneKey.Database.ExternalVariable>("SELECT ev FROM OneKey.Database.ExternalVariable ev WHERE ev.Name=? AND ev.Action = ?", VariableName, ExternalActionResult).First;

            //        WebPublicationsView _WebPublicationsView = new WebPublicationsView()
            //        {
            //            Html = "/Client/WebPublications.html",
            //            WebPublications = Db.SQL("SELECT i FROM OneKey.Database.WebPublication i")
            //        };

            //        if (WebPublicationResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.Data = WebPublicationResult;
            //            _WebPublicationsView.SelectedWebPublicationID = WebPublicationResult.ObId;
            //            _WebPublicationsView.NewWebPublicationName = _WebPublicationsView.SelectedWebPublication.Name;
            //            _WebPublicationsView.NewWebPublicationUrl = _WebPublicationsView.SelectedWebPublication.Url;
            //            _WebPublicationsView.NewWebPublicationDescription = _WebPublicationsView.SelectedWebPublication.Description;
            //        }

            //        if (ExternalFeatureResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.Data = ExternalFeatureResult;
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeatureID = ExternalFeatureResult.ObId;
            //            _WebPublicationsView.NewFeatureName = _WebPublicationsView.SelectedWebPublication.SelectedFeature.Name;
            //        }

            //        if (ExternalActionResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.Data = ExternalActionResult;
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedActionID = ExternalActionResult.ObId;

            //            _WebPublicationsView.NewActionName = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.Name;
            //            _WebPublicationsView.NewActionUrl = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.ActionUrl;
            //            _WebPublicationsView.NewActionHttpBody = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.HttpBody;
            //            _WebPublicationsView.NewActionHttpType = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.HttpType;
            //            _WebPublicationsView.NewActionOrderInFeature = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.OrderInFeature;
            //        }

            //        if (ExternalVariableResult != null)
            //        {
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariable.Data = ExternalVariableResult;
            //            _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariableId = ExternalVariableResult.ObId;

            //            _WebPublicationsView.NewVariableName = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariable.Name;
            //            _WebPublicationsView.NewVariableType = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariable.VariableType;
            //            _WebPublicationsView.NewVariableRegex = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariable.Regex;
            //            _WebPublicationsView.NewVariableValue = _WebPublicationsView.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariable.VariableValue;
            //        }
            //        return _WebPublicationsView;
            //    });
        }

        private static dynamic GetDataRows(ref List<DataRows> DataGridColumns, WebPublication webPublication)
        {
            List<DataRow> dataRow = new List<DataRow>();
            List<DataRows> DataGrid = new List<DataRows>();
            //List<string> DataRow = new List<string>();
            QueryResultRows<string> AllUniqueIds = Db.SQL<string>("Select value from OneKey.Database.CrawlData.CrawlDataRow where Columnname = ? and webPublication = ? order by Uniqueid, Columnname", "UniqueId", webPublication);
            List<string> asdf = AllUniqueIds.ToList();
            QueryResultRows<dynamic> ColumnList = Db.SQL<dynamic>("Select ColumnName from OneKey.Database.CrawlData.CrawlDataRow where UniqueId = ? and webPublication = ? order by Uniqueid, Columnname", AllUniqueIds.First, webPublication);
            int AllUniqueIdsCount = 0;
            foreach (dynamic ColumnName in ColumnList)
            {
                dataRow.Add(new DataRow(ColumnName));
            }
            AllUniqueIdsCount = 0;
            DataGrid.Add(new DataRows(dataRow));
            DataGridColumns = DataGrid;
            DataGrid = new List<DataRows>();
            dataRow = new List<DataRow>();

            QueryResultRows<dynamic> cdr_List = Db.SQL<dynamic>("Select c from OneKey.Database.CrawlData.CrawlDataRow c Where webPublication = ? order by Uniqueid, Columnname",webPublication);

            foreach (CrawlDataRow cdr in cdr_List)
            {
                if (cdr.UniqueID.ToString() == asdf[AllUniqueIdsCount])
                {
                    dataRow.Add(new DataRow(cdr.Value));
                }
                else
                {
                    DataGrid.Add(new DataRows(dataRow));
                    dataRow = new List<DataRow>();
                    dataRow.Add(new DataRow(cdr.Value));
                    AllUniqueIdsCount++;
                }
            }
            return (dynamic)DataGrid;
        }

        private static dynamic GetDataRowsNew(Arr<ResultsView.RowsListElementJson> arr)
        {
            ResultsView.RowsListElementJson dataRow = new ResultsView.RowsListElementJson();
            Arr<ResultsView.RowsListElementJson> DataGrid = new Arr<ResultsView.RowsListElementJson>();
            //List<string> DataRow = new List<string>();
            QueryResultRows<string> AllUniqueIds = Db.SQL<string>("Select value from OneKey.Database.CrawlData.CrawlDataRow where Columnname = ? order by Uniqueid, Columnname", "UniqueId");
            List<string> asdf = AllUniqueIds.ToList();
            QueryResultRows<dynamic> ColumnList = Db.SQL<dynamic>("Select ColumnName from OneKey.Database.CrawlData.CrawlDataRow where UniqueId = ? order by Uniqueid, Columnname", AllUniqueIds.First);
            int AllUniqueIdsCount = 0; 
            foreach (dynamic ColumnName in ColumnList)
            {
                dataRow.RowList.Add(ColumnName);
            }
            AllUniqueIdsCount = 0;
            DataGrid.Add(dataRow);
            dataRow = new ResultsView.RowsListElementJson();

            QueryResultRows<dynamic> cdr_List = Db.SQL<dynamic>("Select c from OneKey.Database.CrawlData.CrawlDataRow c order by Uniqueid, Columnname");
            
            foreach (CrawlDataRow cdr in cdr_List)
            {
                if (cdr.UniqueID.ToString() == asdf[AllUniqueIdsCount])
                {
                    //dataRow.RowList.Add(cdr.Value.ToString());
                }
                else
                {
                    DataGrid.Add(dataRow);
                    dataRow = new ResultsView.RowsListElementJson();
                    //dataRow.Add(cdr.Value);
                    AllUniqueIdsCount++;
                }
            }
            return (dynamic)DataGrid;
        }
    }
}