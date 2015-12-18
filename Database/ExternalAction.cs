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


        public bool PerformAction(ref CookieContainer SessionCookieContainer, ref Dictionary<string, string> SessionVariableContainer, ref Dictionary<string, string> ReceivedHttpBody)
        {
            try
            {
                bool Pagination = this.Pagging;
                int PaginationCount = 0;
                do
                {
                    //Update Pagging Url
                    string ConcatenatedActionUrl = this.ActionUrl;
                    if (Pagination)
                    {
                        PaginationCount++;
                        ConcatenatedActionUrl += this.PaggingUrlParameters;
                        ConcatenatedActionUrl = string.Format(ConcatenatedActionUrl, PaginationCount);
                    }

                    //Update HttpBody
                    string ConcatenatedHttpBody = this.HttpBody;

                    //Concatinate Variables in Url
                    ConcatenatedActionUrl = ConcatenateVariables(ref SessionVariableContainer, ref ReceivedHttpBody, ConcatenatedActionUrl);
                    //Concatinate Variables in HttpBody
                    ConcatenatedHttpBody = ConcatenateVariables(ref SessionVariableContainer, ref ReceivedHttpBody, ConcatenatedHttpBody);

                    //for getting Redirect pages data and cookies
                    HttpWebResponse response = GetParseRequest(ref SessionVariableContainer, ref SessionCookieContainer, ConcatenatedActionUrl, ConcatenatedHttpBody);
                    if (response == null ||(response.StatusCode != HttpStatusCode.OK && Pagination == true))
                    {
                        Pagination = false;
                        break;
                    }
                    while (response != null && response.StatusCode != HttpStatusCode.OK)
                    {
                        response.Close();
                        foreach (System.Net.Cookie c in response.Cookies)
                            SessionCookieContainer.Add(c);
                        response = GetParseRequest(ref SessionVariableContainer, ref SessionCookieContainer, response.Headers["Location"], ConcatenatedHttpBody);
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

        public HttpWebResponse GetParseRequest(ref Dictionary<string, string> SessionVariableContainer, ref CookieContainer SessionCookieContainer, string ConcatenatedActionUrl, string ConcatenatedHttpBody)
        {
            HttpWebResponse response = null;
            QueryResultRows<Database.DownloadQueue> downloadQueueObject = null;
            List<Database.DownloadQueue> downloadQueue = new List<DownloadQueue>();
            if (ConcatenatedActionUrl == "<<DownloadQueue>>")
            {
                downloadQueueObject = Db.SQL<Database.DownloadQueue>("SELECT dq FROM OneKey.Database.DownloadQueue dq WHERE Action.Feature = ?", this.Feature);
                foreach (Database.DownloadQueue dq in downloadQueueObject)
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
                else if (ConcatenatedActionUrl == null || !ConcatenatedActionUrl.Contains("http"))
                {
                    break;
                }
                HttpWebRequest request = GetNewRequest(ref SessionCookieContainer, ConcatenatedActionUrl, this.HttpType, ConcatenatedHttpBody);
                response = (HttpWebResponse)request.GetResponse();
                var encoding = ASCIIEncoding.ASCII;
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    string responseText = reader.ReadToEnd();
                    foreach (var actionVariable in this.Variables)
                    {
                        System.Text.RegularExpressions.MatchCollection RegexResultCollection = CommonHelper.GetAllMatches(responseText, actionVariable.Regex);
                        foreach (System.Text.RegularExpressions.Match RegexResult in RegexResultCollection)
                        {
                            string ResultValue = RegexResult.Groups[1].Value;
                            if (ResultValue != null && ResultValue != "")
                            {
                                if (actionVariable.VariableType == "Session")
                                {
                                    if (SessionVariableContainer.ContainsKey(actionVariable.Name))
                                    {
                                        SessionVariableContainer.Remove(actionVariable.Name);//, ResultValue);
                                    }
                                    SessionVariableContainer.Add(actionVariable.Name, ResultValue);
                                }
                                else if (actionVariable.VariableType == "Content")
                                {
                                    if (actionVariable.Name == "<<WebResource>>")
                                    {
                                        if (!ResultValue.Contains(this.Feature.Site.Name))
                                        {
                                            if (!ResultValue.StartsWith("/"))
                                            {
                                                ResultValue = "/" + ResultValue;
                                            }
                                            ResultValue = this.Feature.Site.Url + ResultValue;
                                        }

                                        WebResource w = Db.SQL<WebResource>("SELECT W FROM WebResource W WHERE Url=?", ResultValue).First;
                                        if (w == null)
                                        {
                                            Db.Transact(() =>
                                            {
                                                w = new WebResource(ResultValue, DateTime.Now, this);
                                            });
                                        }
                                    }
                                    else if (!string.IsNullOrEmpty(ResultValue))
                                    {
                                        CrawlDataColumn asdf = Db.SQL<CrawlDataColumn>("SELECT w FROM CrawlDataColumn w WHERE vehicles_url = ?", ConcatenatedActionUrl).First;
                                        Db.Transact(() =>
                                        {
                                            if (asdf == null)
                                            {
                                                asdf = new CrawlDataColumn();
                                                asdf.vehicles_url = ConcatenatedActionUrl;
                                            }
                                            switch (actionVariable.Name)
                                            {
                                                case "dealer":
                                                    asdf.dealer = ResultValue;
                                                    break;
                                                case "vehicles_url":
                                                    asdf.vehicles_url = ResultValue;
                                                    break;
                                                case "vehicles_year":
                                                    asdf.vehicles_year = ResultValue;
                                                    break;
                                                case "vehicles_make":
                                                    asdf.vehicles_make = ResultValue;
                                                    break;
                                                case "vehicles_model":
                                                    asdf.vehicles_model = ResultValue;
                                                    break;
                                                case "vehicles_trim":
                                                    asdf.vehicles_trim = ResultValue;
                                                    break;
                                                case "vehicles_msrp":
                                                    asdf.vehicles_msrp = ResultValue;
                                                    break;
                                                case "vehicles_drive":
                                                    asdf.vehicles_drive = ResultValue;
                                                    break;
                                                case "vehicles_mpg":
                                                    asdf.vehicles_mpg = ResultValue;
                                                    break;
                                                case "vehicles_features":
                                                    asdf.vehicles_features = ResultValue;
                                                    break;
                                                case "vehicles_miles":
                                                    asdf.vehicles_miles = ResultValue;
                                                    break;
                                                case "vehicles_intcolor":
                                                    asdf.vehicles_intcolor = ResultValue;
                                                    break;
                                                case "vehicles_extcolor":
                                                    asdf.vehicles_extcolor = ResultValue;
                                                    break;
                                                case "Vehicles_VIN":
                                                    asdf.Vehicles_VIN = ResultValue;
                                                    break;
                                                case "vehicles_engine":
                                                    asdf.vehicles_engine = ResultValue;
                                                    break;
                                                case "vehicles_price":
                                                    asdf.vehicles_price = ResultValue;
                                                    break;
                                                case "vehicles_image_url":
                                                    asdf.vehicles_image_url = ResultValue;
                                                    break;
                                                case "vehicles_comments":
                                                    asdf.vehicles_comments = ResultValue;
                                                    break;
                                            }
                                        });
                                    }

                                }
                            }
                        }
                    }
                }
            } while (downloadQueue != null && downloadQueue.Count > 0);
            return response;
        }
    }
}
