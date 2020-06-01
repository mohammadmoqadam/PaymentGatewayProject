using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Core.Contract
{
    public interface IHttpClient
    {
        string BaseUrl { get; set; }
        IJsonConvert jsonConvert { get; set; }
        object HttpRequest(string url, Enums.HttpMethod method, object body = null);

    }
}
