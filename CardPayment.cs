using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public class CardPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {
         Console.WriteLine($"Оплачено {amount} за допомогою картки.");
        }
    }
}
