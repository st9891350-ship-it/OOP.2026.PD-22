using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public class DeliveryService
    {
        private List<Transport> transports = new List<Transport>();
        public void RegisterTransport(Transport transport)//Метод для реєстрації транспорту
        {
            transports.Add(transport); 
        }

        public void CreateDelivery(Order order, IPaymentMethod paymentMethod)//Метод для оформлення доставки 
        {
            Transport? availableTransport = null;

            foreach (var t in transports)
            {
                if (t.IsAvailable && t.CanTake(order)) // 
                {
                    availableTransport = t;
                    break;
                }
            }

            if (availableTransport != null)
            {
                double cost = availableTransport.CalculateCost(order);
                availableTransport.IsAvailable = false;

                Console.WriteLine($"[Сервіс] Замовлення #{order.Number} ({order.Description}) призначено на {availableTransport.Name}.");
                Console.WriteLine($"[Сервіс] Вартість доставки: {cost} грн.");

                paymentMethod.Pay(cost);
            }
            else
            {
                Console.WriteLine($"[Сервіс] На жаль, немає вільного транспорту для замовлення #{order.Number}.");
            }

        }
    }
}
