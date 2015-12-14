using OneKey.Database;
using Starcounter;

namespace OneKey.Server.Partials
{
    partial class WebPublicationView : Json, IBound<WebPublication>
    {
        void Handle(Input.AddVariables action)
        {
            //if (Name != null && Name != "")
            //{
            //    new WebPublicationVariable()
            //    {
            //        WebPublication = Data
            //    };
            //}
        }

        void Handle(Input.SaveVariables action)
        {
            if (Name == null || Name == "")
            { // A new invoice. 
                Name = "Name Required";
            }
            else
            {
                Transaction.Commit();
                ((WebPublicationsView)this.Parent).WebPublications = Db.SQL(
                  "SELECT i FROM WebPublication i"); //refresh WebPublications list
            }
        }
        //void Handle(Input.AddFeatureAction action)
        //{
        //    if (Name != null && Name != "")
        //    {
        //        new WebPublicationVariable()
        //        {
        //            WebPublication = Data
        //        };
        //    }
        //}

        //void Handle(Input.SaveFeatureAction action)
        //{
        //    if (Name == null || Name == "")
        //    { // A new invoice. 
        //        Name = "Name Required";
        //    }
        //    else
        //    {
        //        Transaction.Commit();
        //        ((WebPublicationsView)this.Parent).WebPublications = Db.SQL(
        //          "SELECT i FROM WebPublication i"); //refresh WebPublications list
        //    }
        //}

        void Handle(Input.Cancel action)
        {
            Transaction.Rollback();
            Data = new WebPublication();
        }

        void Handle(Input.Delete action)
        {
            if (Data == null) // Nothing to delete.
                return;

            foreach (var Variable in Data.WebPublicationVariables)
            {
                Variable.Delete();
            }
            Data.Delete();
            Transaction.Commit();
            ((WebPublicationView)this.Parent).WebPublicationVariables = Db.SQL(
              "SELECT i FROM WebPublicationVariables i WHERE i.WebPublication.Name=?",Name); //refresh WebPublicationVariable list
        }
    }
}
