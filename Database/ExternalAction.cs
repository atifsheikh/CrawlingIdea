using System;
using Starcounter;
using System.Collections.Generic;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Text;
using OneKey.Helpers;
using OneKey.Database.CrawlData;

namespace OneKey.Database
{
    public class ExternalAction : Concept
    {
        public ExternalFeature Feature; //E.g. new reply. View Thread
        public string ActionUrl; //E.g. domain + login.php
        public string HttpBody; //E.g. username={1}&password={2} etc
        public string HttpType; //E.g. GET / POST / DELETE / PUT
        public int OrderInFeature; // E.g. 1 (if this is the first action needed to perform feature)
        public bool Pagging;
        public int lastCrawledPage;
        public string PaggingUrlParameters;
        public QueryResultRows<ExternalVariable> Variables
        {
            get
            {
                return Db.SQL<ExternalVariable>("SELECT e FROM ExternalVariable e WHERE e.Action=?", this);
            }
        }

        public static HttpWebRequest GetNewRequest(ref CookieContainer SessionCookieContainer, string targetUrl, string HttpMethod, string HttpBody)
        {
            if (!targetUrl.StartsWith("http"))
            {
                targetUrl = "http://" + targetUrl;
            }
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(targetUrl);
            request.CookieContainer = SessionCookieContainer;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Method = HttpMethod;
            if (HttpMethod == "POST")
            {
                var postData = HttpBody;
                var data = Encoding.ASCII.GetBytes(postData);

                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            request.AllowAutoRedirect = false;
            return request;
        }


        public bool PerformAction(ref CookieContainer SessionCookieContainer, ref Dictionary<string, string> SessionVariableContainer, ref Dictionary<string, string> ReceivedHttpBody,Run run)
        {
            try
            {
                bool Pagination = this.Pagging;
                int PaginationCount = 0;
                int replaceCount = 0;
                string ConcatenatedActionUrl = "";
                string PaggingStringUrl = "";
                do
                {
                    //Update Pagging Url
                    ConcatenatedActionUrl = this.ActionUrl;
                    if (Pagination)
                    {
                        replaceCount = Convert.ToInt32(this.PaggingUrlParameters.Substring(this.PaggingUrlParameters.IndexOf('{') + 1, this.PaggingUrlParameters.IndexOf('}') - (this.PaggingUrlParameters.IndexOf('{') + 1)));
                        PaginationCount += replaceCount;
                        PaggingStringUrl = this.PaggingUrlParameters.Replace(replaceCount.ToString(), "0");
                        PaggingStringUrl = string.Format(PaggingStringUrl, PaginationCount.ToString());
                        ConcatenatedActionUrl += PaggingStringUrl;                            
                        //ConcatenatedActionUrl = string.Format(ConcatenatedActionUrl, PaginationCount.ToString());
                    }

                    //Update HttpBody
                    string ConcatenatedHttpBody = this.HttpBody;

                    //Concatinate Variables in Url
                    ConcatenatedActionUrl = ConcatenateVariables(ref SessionVariableContainer, ref ReceivedHttpBody, ConcatenatedActionUrl);
                    //Concatinate Variables in HttpBody
                    ConcatenatedHttpBody = ConcatenateVariables(ref SessionVariableContainer, ref ReceivedHttpBody, ConcatenatedHttpBody);

                    //for getting Redirect pages data and cookies
                    HttpWebResponse response = GetParseRequest(ref SessionVariableContainer, ref SessionCookieContainer, ConcatenatedActionUrl, ConcatenatedHttpBody, PaginationCount, ref Pagination,run);
                    if (response == null || (response.StatusCode != HttpStatusCode.OK && Pagination == true))
                    {
                        Pagination = false;
                        break;
                    }
                    while (response != null && response.StatusCode != HttpStatusCode.OK)
                    {
                        response.Close();
                        foreach (System.Net.Cookie c in response.Cookies)
                            SessionCookieContainer.Add(c);
                        response = GetParseRequest(ref SessionVariableContainer, ref SessionCookieContainer, response.Headers["Location"], ConcatenatedHttpBody, PaginationCount, ref Pagination, run);
                    }
                }
                while (Pagination);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return false;
            }
        }

        private string ConcatenateVariables(ref Dictionary<string, string> SessionVariableContainer, ref Dictionary<string, string> ReceivedHttpBody, string VariableConcatenatedString)
        {
            //ActionVariables saved in DB 
            foreach (var actionVariable in this.Variables)
            {
                try
                {
                    //Url
                    if (VariableConcatenatedString != null && VariableConcatenatedString.Contains("{") && VariableConcatenatedString.Contains("}"))
                    {
                        if (VariableConcatenatedString.Contains(("{" + actionVariable.Name + "}")))
                        {
                            if (SessionVariableContainer.Count > 0 && SessionVariableContainer.ContainsKey(actionVariable.Name))
                            {
                                VariableConcatenatedString = VariableConcatenatedString.Replace("{" + actionVariable.Name + "}", SessionVariableContainer[actionVariable.Name]);
                            }
                            else
                                VariableConcatenatedString = VariableConcatenatedString.Replace("{" + actionVariable.Name + "}", actionVariable.VariableValue);
                        }
                    }
                }
                catch (Exception ex)
                { }
            }

            //SessionVariables, parsed from previous communication with Website. variables like Cookies, SecurityTokens, PostHashes, etc
            foreach (var SessionVariables in SessionVariableContainer)
            {
                try
                {
                    //Url
                    if (VariableConcatenatedString != null && VariableConcatenatedString.Contains("{") && VariableConcatenatedString.Contains("}"))
                    {
                        if (VariableConcatenatedString.Contains(("{" + SessionVariables.Key + "}")) || VariableConcatenatedString.Contains(("{md5" + SessionVariables.Key + "}")))
                        {
                            if (SessionVariables.Key == "Password" && VariableConcatenatedString.Contains(("{md5Password}")))
                            {
                                VariableConcatenatedString = VariableConcatenatedString.Replace("{md5" + SessionVariables.Key + "}", CommonHelper.Encrypt(SessionVariables.Value));
                            }
                            else
                                VariableConcatenatedString = VariableConcatenatedString.Replace("{" + SessionVariables.Key + "}", SessionVariables.Value);
                        }
                    }
                }
                catch (Exception ex)
                { }
            }


            //RequestVariables received in request body
            foreach (var RequestVariables in ReceivedHttpBody)
            {
                try
                {
                    //Url
                    if (VariableConcatenatedString != null && VariableConcatenatedString.Contains("{") && VariableConcatenatedString.Contains("}"))
                    {
                        if (VariableConcatenatedString.Contains(("{" + RequestVariables.Key + "}")) || VariableConcatenatedString.Contains(("{md5" + RequestVariables.Key + "}")))
                        {
                            if (RequestVariables.Key == "Password" && VariableConcatenatedString.Contains(("{md5Password}")))
                            {
                                VariableConcatenatedString = VariableConcatenatedString.Replace("{md5" + RequestVariables.Key + "}", CommonHelper.Encrypt(RequestVariables.Value));
                            }
                            else
                                VariableConcatenatedString = VariableConcatenatedString.Replace("{" + RequestVariables.Key + "}", RequestVariables.Value);
                        }
                    }
                }
                catch (Exception ex)
                { }
            }


            return VariableConcatenatedString;
        }

        public HttpWebResponse GetParseRequest(ref Dictionary<string, string> SessionVariableContainer, ref CookieContainer SessionCookieContainer, string ConcatenatedActionUrl, string ConcatenatedHttpBody, int PaginationCount, ref bool Pagination,Run run)
        {
            HttpWebResponse response = null;
            QueryResultRows<Database.DownloadQueue> downloadQueueResults = null;
            List<Database.DownloadQueue> downloadQueue = new List<DownloadQueue>();
            if (ConcatenatedActionUrl == "<<DownloadQueue>>")
            {
                downloadQueueResults = Db.SQL<Database.DownloadQueue>("SELECT dq FROM OneKey.Database.DownloadQueue dq WHERE Action.Feature = ?", this.Feature);
                foreach (Database.DownloadQueue dq in downloadQueueResults)
                {
                    downloadQueue.Add(dq);
                }
            }

            do
            {
                if (downloadQueue != null && downloadQueue.Count > 0)
                {
                    ConcatenatedActionUrl = downloadQueue[0].Url;
                    downloadQueue.RemoveAt(0);
                }
                else if (string.IsNullOrEmpty(ConcatenatedActionUrl) || !ConcatenatedActionUrl.Contains("http"))
                {
                    break;
                }

                ///////////////
                //Send Page Request
                HttpWebRequest request = GetNewRequest(ref SessionCookieContainer, ConcatenatedActionUrl, this.HttpType, ConcatenatedHttpBody);
                response = (HttpWebResponse)request.GetResponse();

                //////////////
                //Scrap Data
                Functions.ScrapData.Start(response, this, ref SessionVariableContainer, PaginationCount, Pagination,run);
            } while (downloadQueue != null && downloadQueue.Count > 0);

            return response;
        }
    }
}
