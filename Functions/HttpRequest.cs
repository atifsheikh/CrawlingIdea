using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Web;

namespace OneKey.Functions
{
    class HttpRequest
    {
        public static string POST(string url, string attributes)
        {
            string response = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "POST";
            Stream postStream = request.GetRequestStream();
            var bytes1 = System.Text.Encoding.UTF8.GetBytes(attributes);
            postStream.Write(bytes1, 0, bytes1.Length);
            postStream.Close();

            // Get the response.
            WebResponse response1 = request.GetResponse();
            Stream dataStream = response1.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            response = reader.ReadToEnd();

            reader.Close();
            response1.Close();
            return response;
        }
        public static string GET(string url)
        {
            string response = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "GET";
            request.Timeout = 2147483647;
            WebResponse response1 = request.GetResponse();
            Stream dataStream = response1.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            response = reader.ReadToEnd();

            response = HttpUtility.HtmlDecode(response);

            reader.Close();
            response1.Close();
            return response;
        }

        public static string PUT(string url, string attributes)
        {
            string response = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Method = "PUT";
            Stream postStream = request.GetRequestStream();
            var bytes1 = System.Text.Encoding.UTF8.GetBytes(attributes);
            postStream.Write(bytes1, 0, bytes1.Length);
            postStream.Close();

            // Get the response.
            WebResponse response1 = request.GetResponse();
            Stream dataStream = response1.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            response = reader.ReadToEnd();

            reader.Close();
            response1.Close();
            return response;
        }
    }
}
