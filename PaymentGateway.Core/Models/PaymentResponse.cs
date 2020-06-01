using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Core.Models
{
    public class PaymentResponse
    {
        public bool Result { get; set; }
        public string Url { get; set; }
        public string Authority { get; set; }
        public string PostFormInfo { get; set; }
        public string Message { get; set; }

        public PaymentResponse(bool result,string message)
        {
            this.Message = message;
            this.Result = result;
        }
        public PaymentResponse(bool result, string url, string authority)
        {
            this.Authority = authority;
            this.Result = result;
            this.Url = url;
        }
        public PaymentResponse(bool result, string url, string authority, string postFormInfo, string message)
        {
            this.Authority = authority;
            this.Message = message;
            this.PostFormInfo = postFormInfo;
            this.Result = result;
            this.Url = url;
        }

    }
}
