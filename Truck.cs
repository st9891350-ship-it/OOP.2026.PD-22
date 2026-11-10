using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public class Truck : Transport
    {
        public Truck(string name = "Truck") : base(name)
        {
        }

        public override bool CanTake(Order order)
        {
            return true;
        }

        public override double CalculateCost(Order order)
        {
            return 200 + (order.Distance * 15) + (order.Weight * 0.5);
        }
    }
}
