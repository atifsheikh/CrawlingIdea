using System.Linq;
using OneKey.Database;
using Starcounter;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OneKey.Server.Partials
{
    //Main Json webpublicaion page
    [WebPublicationsViewNew_json]
    partial class WebPublicationsViewNew : Page
    {
        public IEnumerable WebPublications_
        {
            get
            {
                return Db.SQL<OneKey.Database.WebPublication>("SELECT i FROM OneKey.Database.WebPublication i ORDER BY i.Name fetch ? offset ?", this.FetchWebPublications+50, this.FetchWebPublications);
            }
        }

        public OneKey.Database.WebPublication SelectedWebPublication_
        {
            get
            {
                return Db.SQL<OneKey.Database.WebPublication>("SELECT i FROM OneKey.Database.WebPublication i where i.Obid = ?", this.SelectedWebPublicationID).First;
            }
        }

        public OneKey.Database.ExternalFeature SelectedFeature_
        {
            get
            {
                return Db.SQL<OneKey.Database.ExternalFeature>("SELECT i FROM OneKey.Database.ExternalFeature i where i.Obid = ?", this.SelectedFeatureID).First;
            }
        }

        public OneKey.Database.ExternalAction SelectedAction_
        {
            get
            {
                return Db.SQL<OneKey.Database.ExternalAction>("SELECT i FROM OneKey.Database.ExternalAction i where i.Obid = ?", this.SelectedActionID).First;
            }
        }

        public OneKey.Database.ExternalVariable SelectedVariable_
        {
            get
            {
                return Db.SQL<OneKey.Database.ExternalVariable>("SELECT i FROM OneKey.Database.ExternalVariable i where i.Obid = ?", this.SelectedVariableID).First;
            }
        }

        public IEnumerable NewFeatureNameList_
        {
            get
            {
                try
                {
                    var asdf =  Db.SQL<ExternalFeature>("SELECT ef FROM ExternalFeature ef").GroupBy(x => x.Name).Select(x => x.First());
                    return asdf;
                }
                catch
                {
                    return null;
                }
            }
        }

        public IEnumerable NewActionNameList_
        {
            get
            {
                try
                {
                    return Db.SQL<ExternalAction>("SELECT ea FROM ExternalAction ea ORDER BY ea.Name").GroupBy(x => x.Name).Select(x => x.First());
                }
                catch
                {
                    return null;
                }
            }
        }

        public IEnumerable NewVariableNameList_
        {
            get
            {
                try
                {
                    return Db.SQL<ExternalVariable>("SELECT ev FROM ExternalVariable ev ORDER BY ev.Name").GroupBy(x => x.Name).Select(x => x.First());
                }
                catch
                {
                    return null;
                }
            }
        }

        public IEnumerable NewVariableTypeList_
        {
            get
            {
                try
                {
                    return Db.SQL<ExternalVariable>("SELECT ev FROM ExternalVariable ev ORDER BY ev.VariableType").GroupBy(x => x.VariableType).Select(x => x.First());
                }
                catch
                {
                    return null;
                }
            }
        }


        void Handle(Input.AddWebSite action)
        {
            //add new
            if (this.SelectedWebPublicationID == "")
            {
                Db.Transact(() =>
                {
                    WebPublication wp = new WebPublication()
                    {
                        Name = this.NewWebPublicationName,
                        Url = this.NewWebPublicationUrl,
                        Description = this.NewWebPublicationDescription,
                    };
                });
                this.NewWebPublicationName = "";
                this.NewWebPublicationUrl = "";
                this.NewWebPublicationDescription = "";
            }
            //Update
            else
            {
                WebPublication _wp = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM WebPublication wp WHERE wp.Obid=?", this.SelectedWebPublicationID).First;
                Db.Transact(() =>
                {
                    _wp.Name = this.NewWebPublicationName;
                    _wp.Url = this.NewWebPublicationUrl;
                    _wp.Description = this.NewWebPublicationDescription;
                });
            }
        }

        void Handle(Input.DeleteWebSite action)
        {
            //Delete
            if (!string.IsNullOrEmpty(this.SelectedWebPublicationID))
            {
                WebPublication _wp = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM WebPublication wp WHERE wp.Obid=?", this.SelectedWebPublicationID).First;
                if (_wp != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalVariable WHERE Action.Feature.Site.Obid=?", this.SelectedWebPublicationID);
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalAction WHERE Feature.Site.Obid=?", this.SelectedWebPublicationID);
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalFeature WHERE Site.Obid=?", this.SelectedWebPublicationID);
                        Db.SlowSQL("DELETE FROM OneKey.Database.WebPublication WHERE Obid=?", this.SelectedWebPublicationID);
                    });
                }
            }
        }

        void Handle(Input.AddFeature action)
        {
            //Add New
            if (this.SelectedFeatureID == "")
            {
                var WP_Result = Db.SQL<OneKey.Database.WebPublication>("SELECT wp FROM OneKey.Database.WebPublication wp WHERE wp.Obid=?", this.SelectedWebPublicationID).First;
                if (WP_Result != null)
                {
                    Db.Transact(() =>
                    {
                        ExternalFeature ef = new ExternalFeature();
                        if (!string.IsNullOrEmpty(this.NewFeatureNameOther))
                        {
                            ef.Name = this.NewFeatureNameOther.Replace(" ","");
                        }
                        else if (!string.IsNullOrEmpty(this.NewFeatureName))
                        {
                            ef.Name = this.NewFeatureName;
                        }
                        ef.Site = WP_Result;
                    });
                }
                this.NewFeatureName = "";
            }
            //Update
            else
            {
                ExternalFeature ef = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Obid=?", this.SelectedFeatureID).First;

                if (ef != null)
                {
                    Db.Transact(() =>
                    {
                        if (!string.IsNullOrEmpty(this.NewFeatureNameOther))
                        {
                            ef.Name = this.NewFeatureNameOther.Replace(" ", "");
                        }
                        else if (!string.IsNullOrEmpty(this.NewFeatureName))
                        {
                            ef.Name = this.NewFeatureName;
                        }
                    });
                }
            }
        }

        void Handle(Input.PerformFeature action)
        {
            OneKey.Database.ExternalFeature ExternalFeatureResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.ObId=? ", action.App.Feature.ObId).First;
            if (ExternalFeatureResult != null)
            {
                DbSession dbSession = new DbSession();
                dbSession.RunAsync(() =>
                {
                    bool FeatureResult = ExternalFeatureResult.PerformFeature("");
                });
            }
        }
        void Handle(Input.DeleteFeature action)
        {
            //Add New
            if (!string.IsNullOrEmpty(this.SelectedFeatureID ))
            {
                ExternalFeature ef = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Obid=?", this.SelectedFeatureID).First;
                if (ef != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalVariable WHERE Action.Feature.Obid=?", this.SelectedFeatureID);
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalAction WHERE Feature.Obid=?", this.SelectedFeatureID);
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalFeature WHERE Obid=?", this.SelectedFeatureID);
                    });
                }
            }
        }
        void Handle(Input.AddAction action)
        {
            //Add new
            if (this.SelectedActionID == "")
            {
                var page = this;
                var EAResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Obid=?", this.SelectedFeatureID).First;
                if (EAResult != null)
                {
                    Db.Transact(() =>
                    {
                        ExternalAction ea = new ExternalAction()
                        {
                            ActionUrl = page.NewActionUrl,
                            HttpType = page.NewActionHttpType,
                            HttpBody = page.NewActionHttpBody,
                            OrderInFeature = (int)  page.NewActionOrderInFeature
                        };
                        if (!string.IsNullOrEmpty(page.NewActionNameOther))
                        {
                            ea.Name = page.NewActionNameOther;
                        }
                        else
                        {
                            ea.Name = page.NewActionName;
                        }
                        ea.Feature = EAResult;
                    });
                }
                this.NewActionName = "";
                this.NewActionUrl = "";
                this.NewActionHttpType = "";
                this.NewActionHttpBody = "";
                this.NewActionOrderInFeature = 0;
            }
            //Update
            else
            {
                var page = this;
                var EAResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ef FROM OneKey.Database.ExternalAction ef WHERE ef.Obid=?", this.SelectedActionID).First;
                if (EAResult != null)
                {
                    Db.Transact(() =>
                    {
                        if (!string.IsNullOrEmpty(page.NewActionNameOther))
                        {
                            EAResult.Name = page.NewActionNameOther;
                        }
                        else
                        {
                            EAResult.Name = page.NewActionName;
                        }
                        EAResult.ActionUrl = page.NewActionUrl;
                        EAResult.HttpType = page.NewActionHttpType;
                        EAResult.HttpBody = page.NewActionHttpBody;
                        EAResult.OrderInFeature = Convert.ToInt32(page.NewActionOrderInFeature);
                        EAResult.Pagging = Convert.ToBoolean(page.Pagging);
                        EAResult.PaggingUrlParameters = page.PaggingUrlParameters;
                    });
                }
            }
        }
        void Handle(Input.DeleteAction action)
        {
            //Add new
            if (!string.IsNullOrEmpty(this.SelectedActionID ))
            {
                var EAResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ef FROM OneKey.Database.ExternalAction ef WHERE ef.Obid=?", this.SelectedActionID).First;
                if (EAResult != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalVariable WHERE Action.Obid=?", this.SelectedActionID);
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalAction WHERE Obid=?", this.SelectedActionID);
                    });
                }
            }
        }

        void Handle(Input.AddVariable action)
        {
            //Add New
            if (this.SelectedVariableID == "")
            {
                var page = this;
                var AVResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ea FROM OneKey.Database.ExternalAction ea WHERE ea.Obid=?", this.SelectedActionID).First;

                if (AVResult != null)
                {
                    Db.Transact(() =>
                    {
                        ExternalVariable ev = new ExternalVariable()
                        {
                            Regex = page.NewVariableRegex,
                            VariableValue = page.NewVariableValue,
                        };
                        if (!string.IsNullOrEmpty(page.NewVariableNameOther))
                        {
                            ev.Name = page.NewVariableNameOther;
                        }
                        else
                        {
                            ev.Name = page.NewVariableName;
                        }

                        if (!string.IsNullOrEmpty(page.NewVariableNameOther))
                        {
                            ev.VariableType = page.NewVariableTypeOther;
                        }
                        else
                        {
                            ev.VariableType = page.NewVariableType;
                        }

                        ev.Action = AVResult;
                    });
                }
                page.NewVariableName = "";
                page.NewVariableType = "";
                page.NewVariableRegex = "";
                page.NewVariableValue = "";
            }
            //Update
            else
            {
                var page = this;
                var EVResult = Db.SQL<OneKey.Database.ExternalVariable>("SELECT ev FROM OneKey.Database.ExternalVariable ev WHERE ev.Obid=?", this.SelectedVariableID).First;

                if (EVResult != null)
                {
                    Db.Transact(() =>
                    {
                        if (!string.IsNullOrEmpty(page.NewVariableNameOther))
                        {
                            EVResult.Name = page.NewVariableNameOther;
                        }
                        else
                        {
                            EVResult.Name = page.NewVariableName;
                        }

                        if (!string.IsNullOrEmpty(page.NewVariableTypeOther))
                        {
                            EVResult.VariableType = page.NewVariableTypeOther;
                        }
                        else
                        {
                            EVResult.VariableType = page.NewVariableType;
                        }
                        EVResult.Regex = page.NewVariableRegex;
                        EVResult.VariableValue = page.NewVariableValue;
                    });
                }
            }
        }
        void Handle(Input.DeleteVariable action)
        {
            //Add New
            if (!string.IsNullOrEmpty(this.SelectedVariableID))
            {
                var EVResult = Db.SQL<OneKey.Database.ExternalVariable>("SELECT ev FROM OneKey.Database.ExternalVariable ev WHERE ev.Obid=?", this.SelectedVariableID).First;

                if (EVResult != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalVariable WHERE Obid=?", this.SelectedVariableID);
                    });
                }
            }
        }
    }

    [WebPublicationsViewNew_json.WebPublications]
    partial class WebPublicationObject : Json
    {
        void Handle(Input.Update Action)
        {
            WebPublicationsViewNew page = this.Parent.Parent as WebPublicationsViewNew;
            page.SelectedVariableID = "";
            page.NewVariableName = "";
            page.NewVariableType = "";
            page.NewVariableRegex = "";
            page.NewVariableValue = "";

            page.SelectedActionID = "";
            page.NewActionName = "";
            page.NewActionUrl = "";
            page.NewActionHttpBody = "";
            page.NewActionHttpType = "";
            page.NewActionOrderInFeature = 0;
            page.Pagging = false;
            page.PaggingUrlParameters = "";

            page.SelectedFeatureID = "";
            page.NewFeatureName = "";

            page.SelectedWebPublicationID = Action.App.ObId;
            page.NewWebPublicationName = Action.App.Name;
            page.NewWebPublicationUrl = Action.App.Url;
            page.NewWebPublicationDescription = Action.App.Description;
        }
    }

    [WebPublicationsViewNew_json.WebPublication.Features]
    partial class FeatureObject : Json
    {
        void Handle(Input.Update Action)
        {

            WebPublicationsViewNew page = this.Parent.Parent.Parent as WebPublicationsViewNew;
            page.SelectedVariableID = "";
            page.NewVariableName = "";
            page.NewVariableType = "";
            page.NewVariableRegex = "";
            page.NewVariableValue = "";

            page.SelectedActionID = "";
            page.NewActionName = "";
            page.NewActionUrl = "";
            page.NewActionHttpBody = "";
            page.NewActionHttpType = "";
            page.NewActionOrderInFeature = 0;
            page.Pagging = false;
            page.PaggingUrlParameters = "";

            page.SelectedFeatureID = Action.App.ObId;
            page.NewFeatureName = Action.App.Name;
        }
    }

    [WebPublicationsViewNew_json.Feature.Actions]
    partial class ActionObject : Json
    {
        void Handle(Input.Update Action)
        {
            WebPublicationsViewNew page = this.Parent.Parent.Parent as WebPublicationsViewNew;
            page.SelectedVariableID = "";
            page.NewVariableName = "";
            page.NewVariableType = "";
            page.NewVariableRegex = "";
            page.NewVariableValue = "";

            page.SelectedActionID = Action.App.ObId;
            page.NewActionName = Action.App.Name;
            page.NewActionUrl = Action.App.ActionUrl;
            page.NewActionHttpBody = Action.App.HttpBody;
            page.NewActionHttpType = Action.App.HttpType;
            page.NewActionOrderInFeature = Action.App.OrderInFeature;
            page.Pagging = Action.App.Pagging;
            page.PaggingUrlParameters = Action.App.PaggingUrlParameters;
        }
    }

    [WebPublicationsViewNew_json.Action.Variables]
    partial class VariableObject : Json
    {
        void Handle(Input.Update Action)
        {
            WebPublicationsViewNew page = this.Parent.Parent.Parent as WebPublicationsViewNew;
            page.SelectedVariableID = Action.App.ObId;
            page.NewVariableName = Action.App.Name;
            page.NewVariableType = Action.App.VariableType;
            page.NewVariableRegex = Action.App.Regex;
            page.NewVariableValue = Action.App.VariableValue;
        }
    }
}
