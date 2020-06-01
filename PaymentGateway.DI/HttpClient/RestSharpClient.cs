using System;
using System.Collections.Generic;
using System.Text;
using PaymentGateway.Core;
using RestSharp;
using PaymentGateway.Core.Contract;
using PaymentGateway.Core.Enums;



namespace PaymentGateway.DI.HttpClient
{
    public class RestSharpClient : IHttpClient
    {
        public string BaseUrl { get; set; }
        private RestClient client;
        public RestSharpClient(string baseUrl)
        {
            this.BaseUrl = baseUrl;
        }
        public RestSharpClient()
        {

        }

        public IJsonConvert jsonConvert { get; set; }

        public object HttpRequest(string url, HttpMethod method, object body = null)
        {
            RestSharp.RestRequest req = string.IsNullOrEmpty(url) ? new RestRequest() : new RestRequest(new Uri(url));
            RestSharp.Method meth;
            switch (method)
            {
                case HttpMethod.GET:
                    meth = Method.GET;
                    break;
                case HttpMethod.POST:
                    meth = Method.POST;
                    if (body != null)
                        req.AddJsonBody(jsonConvert.JsonSerialize(body));
                    break;
                case HttpMethod.PUT:
                    meth = Method.PUT;
                    break;
                case HttpMethod.DELETE:
                    meth = Method.DELETE;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(method), method, null);
            }

            client = !string.IsNullOrEmpty(BaseUrl) ? new RestClient(BaseUrl) : new RestClient();
            var response = client.Execute(req, meth);
            return response.Content;
        }



    }
}
