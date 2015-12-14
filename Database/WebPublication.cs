using Starcounter;

namespace OneKey.Database
{
    public class WebPublication : Publication
    {
        public string Url;
        public string Description;
        
        // Parent for Root(Website/Forum/Blog) will be null
        public WebPublication Parent;//Can be a Forum or Thread or Category or Message or Sub-Message

        
        //Featrues like login, Post a thread, Post a  reply , View Categories , View Threads, View Messages
        public QueryResultRows<ExternalFeature> Features
        {
            get
            {
                return Db.SQL<ExternalFeature>("SELECT e FROM ExternalFeature e WHERE e.Site=?", this);
            }
        }

        //Variables like Type,Origin,Region,Language,Culture,TimeFormat,DateFormat,Encoding,
        //public QueryResultRows<WebPublicationVariable> WebPublicationVariables
        //{
        //    get
        //    {
        //        return Db.SQL<WebPublicationVariable>("SELECT e FROM WebPublicationVariable e WHERE e.WebPublication=?", this);
        //    }
        //}

    }
}
