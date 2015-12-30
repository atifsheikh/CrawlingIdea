using System;
using Starcounter;
using System.Collections.Generic;
using System.Net;

namespace OneKey.Database
{
    public class ExternalFeature : Concept
    {
        //Name e.g. Post a reply
        public WebPublication Site; //E.g Flashback.org.
        public QueryResultRows<ExternalAction> Actions {
            get
            {
                return Db.SQL<ExternalAction>("SELECT e FROM ExternalAction e WHERE e.Feature=?", this);
            }
        }

        public bool PerformFeature(string ReceivedHttpBodyVariables)
        {
            CookieContainer SessionCookieContainer = new CookieContainer();
            Dictionary<string, string> SessionVariableContainer = new Dictionary<string, string>();
            Dictionary<string, string> ReceivedHttpBody = new Dictionary<string, string>();
            string[] ReceivedHttpBodyVariablesSplited = ReceivedHttpBodyVariables.Split('&');
            foreach (string ReceivedHttpBodyVariable in ReceivedHttpBodyVariablesSplited)
            {
                string[] ReceivedHttpBodyVariableSplited = ReceivedHttpBodyVariable.Split('=');
                if (ReceivedHttpBodyVariableSplited.Length >= 2)
                {
                    ReceivedHttpBody.Add(ReceivedHttpBodyVariableSplited[0], ReceivedHttpBodyVariableSplited[1]);
                }
            }

            //for running session actions
            //ExternalFeature externalFeature = Db.SQL<OneKey.Database.ExternalFeature>("SELECT ef FROM OneKey.Database.ExternalFeature ef WHERE ef.Site = ? AND ef.Name = ?", this.Site, "Session").First;
            //if (externalFeature != null)
            //{
            //    foreach (var action in externalFeature.Actions)
            //    {
            //        if (!action.PerformAction(ref SessionCookieContainer, ref SessionVariableContainer, ref ReceivedHttpBody))
            //            return false;
            //    }
            //}



            //for running Post action
            foreach (var action in this.Actions)
            {
                if (!action.PerformAction(ref SessionCookieContainer,ref SessionVariableContainer,ref ReceivedHttpBody))
                    return false;
            }
            return true;
        }
    }
}
