using Starcounter;
using System;

namespace OneKey.Database
{
    public class WebPublicationFeatureAction : Concept
    {
        public WebPublication WebPublication;
        public WebPublicationFeature WebPublicationFeature;
        public string ActionUrl; //E.g. domain + login.php
        public string HttpBody; //E.g. username={1}&password={2} etc
        public string HttpType; //E.g. GET / POST / DELETE / PUT
        public Int16 OrderInFeature; // E.g. 1 (if this is the first action needed to perform feature)
    }
}
