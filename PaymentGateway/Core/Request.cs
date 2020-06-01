using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using static System.Net.SecurityProtocolType;

namespace PaymentGateway.Core
{
    public class Request
    {

        private readonly string _url;
        public Request(string url)
        {
            
            this._url = url;
        }

        public string HttpRequest(Enums.HttpMethod method)
         {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(_url);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = (Enum.GetName(typeof(Enums.HttpMethod),method )) ??  throw new InvalidOperationException("");
            ServicePointManager.SecurityProtocol = Tls12 | Tls11 | Tls | Ssl3;

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                if (method == Enums.HttpMethod.POST)
                {
                    string json = JsonConvert.SerializeObject("");
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream() ?? throw new InvalidOperationException("")))
            {
                var result = streamReader.ReadToEnd();
                return result.ToString();
            }
           
         }
    }
}
