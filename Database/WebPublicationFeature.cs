using Starcounter;

namespace OneKey.Database
{
    public class WebPublicationFeature : Concept
    {
        public WebPublication WebPublication;

        public QueryResultRows<WebPublicationVariable> WebPublicationFeatureVariables
        {
            get
            {
                return Db.SQL<WebPublicationVariable>("SELECT e FROM WebPublicationVariable e WHERE WebPublicationFeature=?", this);
            }
        }

        public QueryResultRows<WebPublicationFeatureAction> WebPublicationFeatureActions
        {
            get
            {
                return Db.SQL<WebPublicationFeatureAction>("SELECT e FROM WebPublicationFeatureAction e WHERE WebPublicationFeature =?", this);
            }
        }
    }
}
