using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public class DeliveryService
    {
        private List<Transport> transports = new List<Transport>(); // Список зареєстрованих транспортів
        public void RegisterTransport(Transport transport)//Метод для реєстрації транспорту
        {
            transports.Add(transport); 
        }

        public void CreateDelivery(Order order, IPaymentMethod paymentMethod)//Метод для оформлення доставки  
        {
            Transport? availableTransport = null;//створення комірки куди покалдеться знайдений транспорт, який може взяти замовлення
            foreach (var t in transports)
            {
                if (t.CanTake (order)) 
                {
                    availableTransport = t; 
                    break;// зупиняємо пошук після знаходження першого доступного транспорту, якщо прибрати break, то буде шукати до кінця списку і вибере останній доступний транспорт(вантажівку)
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
            else // Якщо немає доступного транспорту виводить ↓
            {
                Console.WriteLine($"[Сервіс] На жаль, немає вільного транспорту для замовлення #{order.Number}.");
            }

        }
    }
}
