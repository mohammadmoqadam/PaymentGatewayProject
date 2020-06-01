using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PaymentGateway.Core.Contract;
using PaymentGateway.Core.Enums;
using PaymentGateway.Core.Models;

namespace PaymentGateway.Saman
{
    public class Gateway : IGateway
    {
        public IHttpClient httpClient { get; set; }
        public IJsonConvert jsonConvert { get; set; }


        public Gateway()
        {
          

        }

        public void ConfirmFromPaydoor()
        {
            throw new NotImplementedException();
        }

        public PaymentResponse PaymentRequest(GatewayInformation gatewayInfo)
        {
            httpClient.jsonConvert = jsonConvert;
            var requestModel = new Models.RequestToPay(gatewayInfo.Amount, gatewayInfo.MerchantID,
                gatewayInfo.CallbackURL, "12334");
            var resdata = httpClient.HttpRequest(Urls.BaseUrl, HttpMethod.POST, requestModel);
            return null;
        }

        public Task<PaymentResponse> PaymentRequestAsync(GatewayInformation gatewayInfo)
        {
            throw new NotImplementedException();
        }

        public void ResponseFromPaydoor()
        {
            throw new NotImplementedException();
        }
    }
}
