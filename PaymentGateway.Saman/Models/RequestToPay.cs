using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Saman.Models
{
    public class RequestToPay
    {
        public int Amount { get; set; }
        public string MID { get; set; }
        public string RedirectURL { get; set; }
        public string ResNum { get; set; }

        public RequestToPay(int amount, string mid, string redirectUrl, string resNum)
        {
            this.Amount = amount;
            this.MID = mid;
            this.RedirectURL = redirectUrl;
            this.ResNum = resNum;
        }


    }
}
