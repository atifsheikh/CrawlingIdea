using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace OneKey.Server.Handlers
{
    class FeatureHooks
    {
        internal static void Init()
        {
            //Execute a Feature
            Handle.GET("/OneKeyDemo/Set/{?}/{?}/{?}", (string WebPublicationName, string featureName, string ReceivedHttpBody) =>
            {
                WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
                featureName = HttpUtility.UrlDecode(featureName);
                ReceivedHttpBody = HttpUtility.UrlDecode(ReceivedHttpBody);

                OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;
                OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", featureName, WebPublicationResult).First;
                bool FeatureResult = ExternalFeatureResult.PerformFeature(ReceivedHttpBody);

                return 200;
            });

            //Execute a Feature
            Handle.GET("/OneKeyDemo/Get/{?}/{?}", (string WebPublicationName, string featureName) =>
            {
                WebPublicationName = HttpUtility.UrlDecode(WebPublicationName);
                featureName = HttpUtility.UrlDecode(featureName);

                OneKey.Database.WebPublication WebPublicationResult = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Name=?", WebPublicationName).First;
                OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Name=? AND ef.Site = ? ", featureName, WebPublicationResult).First;
                bool FeatureResult = ExternalFeatureResult.PerformFeature("");

                return 200;
            });
        }
    }
}
