using OneKey.Database;
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

            //Main Page 
            Handle.GET("/OneKey", () =>
            {
                WebPublicationsViewNew _WebPublicationsView = new WebPublicationsViewNew()
                {
                    WebPublications = Db.SQL("SELECT i FROM OneKey.Database.WebPublication i"),
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
    }
}