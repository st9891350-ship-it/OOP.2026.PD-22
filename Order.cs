using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DeliveryAPP1
{
    public class Order//Замовлення 
    {
        public int Number { get; set; }
        public string Description { get; set; }
        public double Weight { get; set; }
        public double Distance { get; set; }

        public Order(int number, string description, double weight, double distance)//Конструктор класу Order
        {
            Number = number;
            Description = description;
            Weight = weight;
            Distance = distance;
        }


    }

}
