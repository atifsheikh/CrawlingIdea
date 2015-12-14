using System;
using Starcounter;

namespace OneKey.Database
{
    public class TestAppRequest : Concept
    {
        public string RequestUrl;
        public string RequestBody;
        public User User
        {
            get
            {
                //User this.RequestUrl or this.RequestBody to find the appropriate user
                return null;
            }
        }
        public ExternalFeature Feature
        {
            get
            {
                //User this.RequestUrl or this.RequestBody to find the feature that wants to be accessed by the user.
                return null;
            }
        }
        public void DealWithIncomingRequest() //Basically our servletendpoints: TestApp.Database.TestAppRequest.DealWithIncomingRequest()
        {
            //Create new TestAppRequest
            //this.User
            //this.Feature.
            //this.Feature.PerformFeature();
        }
    }
}
