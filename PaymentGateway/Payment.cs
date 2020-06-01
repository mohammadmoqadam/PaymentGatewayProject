using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PaymentGateway.Core.Contract;
using PaymentGateway.Core.Models;

namespace PaymentGateway
{
    public class Payment
    {
        private readonly IGateway gateway;
        private readonly IHttpClient httpClient;
        private readonly IJsonConvert jsonConvert;
        public Payment(IGateway gateway, IHttpClient httpClient, IJsonConvert jsonConvert)
        {
            this.gateway = gateway;
            this.httpClient = httpClient;
            this.jsonConvert = jsonConvert;
            gateway.httpClient = httpClient;
            gateway.jsonConvert = jsonConvert;
        }

        public async Task<string> RequestToGateway(GatewayInformation gatewayInfo)
        {
            var paymentUrl = gateway.PaymentRequest(gatewayInfo);
            return paymentUrl.Url;
        }


    }
}
