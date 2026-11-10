using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace DeliveryAPP1//іменований простір - іменований контейнер для класів, інтерфейсів, структур, перерахувань та делегатів. Іменовані простори використовуються для організації коду та запобігання конфліктам імен( два телефони по різним кімнатам(просторам) .
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DeliveryService deliveryservice = new DeliveryService();
            Bike bike = new Bike();
            Car car = new Car();
            Truck truck = new Truck();

            deliveryservice.RegisterTransport(bike);
            deliveryservice.RegisterTransport(car);
            deliveryservice.RegisterTransport(truck);

            Console.WriteLine("---Перше замовлення--");
            Order order1 = new Order(1, "Котел", 200, 20);
            IPaymentMethod paymentMethod = new CardPayment();
            deliveryservice.CreateDelivery(order1, paymentMethod);

            Console.WriteLine("--------------------------");


            Console.WriteLine("---Друге замовлення--");
            Order order2 = new Order(2, "Ecoflow", 20.0, 100.0);
            IPaymentMethod cashmentMethod = new CashPayment();
            deliveryservice.CreateDelivery(order2, cashmentMethod);


            Console.WriteLine("--------------------------");


            Console.WriteLine("---Третє замовлення--");
            Order order3 = new Order(3, " Three Happy Meal", 1.25, 7.0);
            IPaymentMethod cachmentMethod = new CashPayment();
            deliveryservice.CreateDelivery(order3, cashmentMethod);



        }

    }
}







