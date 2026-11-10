using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public interface IPaymentMethod
    {
        void Pay(double amount);
    }
}
