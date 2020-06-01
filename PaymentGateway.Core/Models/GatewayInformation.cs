using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Core.Models
{
    public class GatewayInformation
    {

        public string CallbackURL { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string MerchantID { get; set; }

        public GatewayInformation(int amount, string merchantId, string callbackUrl, string description)
        {
            this.Amount = amount;
            this.CallbackURL = callbackUrl;
            this.Description = description;
            this.MerchantID = merchantId;
        }
    }
}
