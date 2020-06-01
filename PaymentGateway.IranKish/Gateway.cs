using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PaymentGateway.Core.Contract;
using PaymentGateway.Core.Models;
using TokenService;

namespace PaymentGateway.IranKish
{
    public class Gateway : IGateway
    {
        public IHttpClient httpClient { get; set; }
        public IJsonConvert jsonConvert { get; set; }

        public PaymentResponse PaymentRequest(GatewayInformation gatewayInfo)
        {
            TokenService.TokensClient tokenClient = new TokensClient();

            var response = tokenClient.MakeTokenAsync("1000", "AA6E", "54545545", "662584852", "",
                    "http://localhost:35521/verifypage.aspx", "Test Sample").ConfigureAwait(false);
            return null;


        }


        public async Task<PaymentResponse> PaymentRequestAsync(GatewayInformation gatewayInfo)
        {
            TokenService.TokensClient tokenClient = new TokensClient();

            var response =await tokenClient.MakeTokenAsync("1000", "AA6E", "54545545", "662584852", "",
                "http://localhost:35521/verifypage.aspx", "Test Sample").ConfigureAwait(false);
            return null;


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
