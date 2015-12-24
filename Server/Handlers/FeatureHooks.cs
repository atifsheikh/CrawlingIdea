using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace OneKey.Server.Handlers
{
    class FeatureHooks
    {
        internal static void Init()
        {
            //Execute a Feature
            Handle.GET("/OneKey/Set/{?}/{?}/{?}", (string WebPublicationName, string featureName, string ReceivedHttpBody) =>
            {
                WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
                featureName = HttpUtility.UrlDecode(featureName);
                ReceivedHttpBody = HttpUtility.UrlDecode(ReceivedHttpBody);

                OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;
                OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", featureName, WebPublicationResult).First;
                bool FeatureResult = ExternalFeatureResult.PerformFeature(ReceivedHttpBody);

                return 200;
            });

            Handle.GET("/OneKey/Get/{?}/{?}", (string WebPublicationName, string featureName) =>
            {
                WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
                featureName = HttpUtility.UrlDecode(featureName);

                OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;
                OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", featureName, WebPublicationResult).First;
                if (ExternalFeatureResult != null)
                {
                    bool FeatureResult = ExternalFeatureResult.PerformFeature("");
                    if (FeatureResult)
                    {
                        return "Success";
                    }
                    else
                    {
                        return "Something went wrong.";
                    }
                }
                else
                {
                    return "No Such Feature.";
                }
            }, new HandlerOptions() { SkipMiddlewareFilters = true });

            Handle.GET("/OneKey/Start-DownloadQueue", () =>
            {
                QueryResultRows<OneKey.Database.DownloadQueue> downloadQueueList = Db.SQL<OneKey.Database.DownloadQueue>("SELECT dq FROM OneKey.Database.DownloadQueue dq");
                foreach (OneKey.Database.DownloadQueue downloadQueue in downloadQueueList)
                {
                    Dictionary<string, string> SessionVariableContainer = null ;
                    CookieContainer SessionCookieContainer = null;
                    downloadQueue.Action.GetParseRequest(ref SessionVariableContainer, ref SessionCookieContainer, downloadQueue.Url, "");
                }
                return 200;
            }, new HandlerOptions() { SkipMiddlewareFilters = true });
        }
    }
}
