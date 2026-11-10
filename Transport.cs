using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public abstract class Transport
    {
        public string Name { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Transport(string name)//Конструктор класу Transport
        {
            Name = name;

        }
        public virtual bool CanTake(Order order)
        {
            return true;
        }

        public abstract double CalculateCost(Order order);

    }
}
