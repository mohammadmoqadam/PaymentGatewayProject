using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Core.Contract
{
    public interface IJsonConvert
    {

        string JsonSerialize(object value);

        T JsonDesrialize<T>(string value);

    }
}
