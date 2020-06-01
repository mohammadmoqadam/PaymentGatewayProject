using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PaymentGateway.Core;
using PaymentGateway.Core.Contract;
using PaymentGateway.Core.Models;
using PaymentGateway.Core.Enums;

namespace PaymentGateway.Zarinpall
{
   public class Gateway:IGateway
    {

        public IHttpClient httpClient { get; set; }
        public IJsonConvert jsonConvert { get; set; }

        public async Task<PaymentResponse> PaymentRequestAsync(GatewayInformation gatewayInfo)
        {
            return null;
        }

        public PaymentResponse PaymentRequest(GatewayInformation gatewayInfo)
        {
            httpClient.jsonConvert = jsonConvert;
            var urlInfo = new Configurations.URLs(true);
            httpClient.BaseUrl = urlInfo.GetPaymentRequestURL();
            var data = httpClient.HttpRequest("", HttpMethod.POST, gatewayInfo);
            var response = jsonConvert.JsonDesrialize<Models.PaymentResponse>((string)data);
            if (response.Status == 100)
                return new PaymentResponse(true, urlInfo.GetPaymenGatewayURL(response.Authority), response.Authority);
            return new PaymentResponse(false, $"ErrorCode: {response.Status.ToString()}");
        }

        public void ResponseFromPaydoor()
        {
            throw new NotImplementedException();
        }

        public void ConfirmFromPaydoor()
        {
            throw new NotImplementedException();
        }

    }
}
