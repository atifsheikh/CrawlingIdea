using OneKey.Database;
using Starcounter;

namespace OneKey.Server.Partials
{
    partial class WebPublicationFeatureView : Json, IBound<WebPublicationFeature>
    {
        void Handle(Input.AddFeatureVariables action)
        {
            if (Name != null && Name != "")
            {
                new WebPublicationVariable()
                {
                    WebPublicationFeature = Data
                };
            }
        }

        void Handle(Input.SaveFeatureVariables action)
        {
            if (Name == null || Name == "")
            { // A new invoice. 
                Name = "Name Required";
            }
            else
            {
                Transaction.Commit();
                ((WebPublicationFeaturesView)this.Parent).WebPublicationFeatures = Db.SQL(
                  "SELECT i FROM WebPublicationFeature i"); //refresh WebPublications list
            }
        }
    }
}
