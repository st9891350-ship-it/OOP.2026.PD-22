using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public class Car : Transport
    {
        public Car(string name = "Автомобіль") : base(name)
        {
        }

        public override bool CanTake(Order order)
        {
            return order.Weight <= 100 && order.Distance <= 50;
        }

        public override double CalculateCost(Order order)
        {
            return 50  + ( order.Distance * 8) + (order.Weight * 1);
        }
    }
}