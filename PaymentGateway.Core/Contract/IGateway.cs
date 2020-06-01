using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using PaymentGateway.Core.Models;

namespace PaymentGateway.Core.Contract
{
    public interface IGateway
    {
        IHttpClient httpClient { get; set; }
        IJsonConvert jsonConvert { get; set; }
        Task<PaymentResponse> PaymentRequestAsync(GatewayInformation gatewayInfo);
        Models.PaymentResponse PaymentRequest(GatewayInformation gatewayInfo);
        void ResponseFromPaydoor();
        void ConfirmFromPaydoor();

    }
}
