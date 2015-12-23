using System.Linq;
using OneKey.Database;
using Starcounter;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OneKey.Server.Partials
{
    //Main Json webpublicaion page
    [WebPublicationsView_json]
    partial class WebPublicationsView : Page
    {
        public IEnumerable WebPublications_
        {
            get
            {
                return Db.SQL<OneKey.Database.WebPublication>("SELECT i FROM OneKey.Database.WebPublication i ORDER BY i.Name");
            }
        }

        public IEnumerable NewFeatureNameList_
        {
            get
            {
                try
                {
                    return Db.SQL<ExternalFeature>("SELECT ef FROM ExternalFeature ef").GroupBy(x => x.Name).Select(x => x.First());
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
                    var asdf =  Db.SQL<ExternalVariable>("SELECT ev FROM ExternalVariable ev ORDER BY ev.VariableType").GroupBy(x => x.VariableType).Select(x => x.First());
                    return asdf;
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
                //this.SelectedWebPublication.Name = "";
                //this.SelectedWebPublication.Url = "";
                //this.SelectedWebPublication.Description = "";
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
                        Db.SlowSQL("DELETE FROM OneKey.Database.WebPublication WHERE Obid=?", this.SelectedWebPublicationID);
                    });
                }
            }
        }

        void Handle(Input.AddFeature action)
        {
            //Add New
            if (this.SelectedWebPublication.SelectedFeatureID == "")
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
                ExternalFeature ef = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Obid=?", this.SelectedWebPublication.SelectedFeatureID).First;

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
                //this.NewFeatureName = "";
            }
        }

        void Handle(Input.DeleteFeature action)
        {
            //Add New
            if (!string.IsNullOrEmpty(this.SelectedWebPublication.SelectedFeatureID ))
            {
                ExternalFeature ef = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Obid=?", this.SelectedWebPublication.SelectedFeatureID).First;
                if (ef != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalFeature WHERE Obid=?", this.SelectedWebPublication.SelectedFeatureID);
                    });
                }
            }
        }
        void Handle(Input.AddAction action)
        {
            //Add new
            if (this.SelectedWebPublication.SelectedFeature.SelectedActionID == "")
            {
                var page = this;
                var EAResult = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Obid=?", this.SelectedWebPublication.SelectedFeatureID).First;
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
                var EAResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ef FROM OneKey.Database.ExternalAction ef WHERE ef.Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedActionID).First;
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
                //page.NewActionName = "";
                //page.NewActionUrl = "";
                //page.NewActionHttpType = "";
                //page.NewActionHttpBody = "";
                //page.NewActionOrderInFeature = 0;
            }
        }
        void Handle(Input.DeleteAction action)
        {
            //Add new
            if (!string.IsNullOrEmpty(this.SelectedWebPublication.SelectedFeature.SelectedActionID ))
            {
                var EAResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ef FROM OneKey.Database.ExternalAction ef WHERE ef.Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedActionID).First;
                if (EAResult != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalAction WHERE Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedActionID);
                    });
                }
            }
        }

        void Handle(Input.AddVariable action)
        {
            //Add New
            if (this.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariableId == "")
            {
                var page = this;
                var AVResult = Db.SQL<OneKey.Database.ExternalAction>("SELECT ea FROM OneKey.Database.ExternalAction ea WHERE ea.Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedActionID).First;

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
                var EVResult = Db.SQL<OneKey.Database.ExternalVariable>("SELECT ev FROM OneKey.Database.ExternalVariable ev WHERE ev.Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariableId).First;

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
            if (!string.IsNullOrEmpty(this.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariableId))
            {
                var EVResult = Db.SQL<OneKey.Database.ExternalVariable>("SELECT ev FROM OneKey.Database.ExternalVariable ev WHERE ev.Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariableId).First;

                if (EVResult != null)
                {
                    Db.Transact(() =>
                    {
                        Db.SlowSQL("DELETE FROM OneKey.Database.ExternalVariable WHERE Obid=?", this.SelectedWebPublication.SelectedFeature.SelectedAction.SelectedVariableId);
                    });
                }
            }
        }

    }

    //sub main page for 1 publication details
    [WebPublicationsView_json.SelectedWebPublication]
    partial class SelectedWebPublicationView : Json 
    {
    }

    //sub publication for all features
    [WebPublicationsView_json.SelectedWebPublication.Features]
    partial class FeaturesView : Json
    {
        public string SelectedWebPublicationName_
        {
            get
            {
                SelectedWebPublicationView webPublicationName = this.Parent.Parent as SelectedWebPublicationView;
                return webPublicationName.Name;
            }
        }
    }

    //sub publication for 1 feature
    [WebPublicationsView_json.SelectedWebPublication.SelectedFeature]
    partial class SelectedFeatureView : Json 
    {

    }
    

    //Sub publication for All actions
    [WebPublicationsView_json.SelectedWebPublication.SelectedFeature.Actions]
    partial class ActionsView : Json
    {
        public string SelectedWebPublicationName_
        {
            get
            {
                SelectedWebPublicationView webPublicationName = this.Parent.Parent.Parent as SelectedWebPublicationView;
                return webPublicationName.Name;
            }
        }
        public string SelectedFeatureName_
        {
            get
            {
                SelectedFeatureView featureName = this.Parent.Parent as SelectedFeatureView;
                return featureName.Name;
            }
        }
    }

    //Sub publication for 1 action Details
    [WebPublicationsView_json.SelectedWebPublication.SelectedFeature.SelectedAction]
    partial class SelectedActionView : Json
    {
    }

    //Sub publication for all Variables
    [WebPublicationsView_json.SelectedWebPublication.SelectedFeature.SelectedAction.Variables]
    partial class VariablesView : Json
    {
        public string SelectedWebPublicationName_
        {
            get
            {
                SelectedWebPublicationView webPublication = this.Parent.Parent.Parent.Parent as SelectedWebPublicationView;
                return webPublication.Name;
            }
        }
        public string SelectedFeatureName_
        {
            get
            {
                SelectedFeatureView feature = this.Parent.Parent.Parent as SelectedFeatureView;
                return feature.Name;
            }
        }
        public string SelectedActionName_
        {
            get
            {
                SelectedActionView action = this.Parent.Parent as SelectedActionView;
                return action.Name;
            }
        }
    }
}
