using System;
using System.Collections.Generic;
using System.Text;
using PaymentGateway.Core.Contract;
using Newtonsoft;
using PaymentGateway.Core.Contract;

namespace PaymentGateway.DI.JsonConvert
{
    public class NewtonsoftJsonConvert : IJsonConvert
    {

        public string JsonSerialize(object value)
        {
           return Newtonsoft.Json.JsonConvert.SerializeObject(value);
        }

        public T JsonDesrialize<T>(string value)
        {
           return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
        }

    }
}
