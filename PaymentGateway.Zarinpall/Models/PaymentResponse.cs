using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Zarinpall.Models
{
   public class PaymentResponse
    {
        public String Authority { set; get; }
        public int Status { set; get; }
        public String PaymentURL { set; get; }
    }
}
