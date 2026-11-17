using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DeliveryAPP1
{
    public class Order// Клас бланку замовлення 
    {
        public int Number { get; set; }
        public string Description { get; set;}//Опис, що  веземо в посилці 
        public double Weight { get; set; }//Вага посилки
        public double Distance { get; set; } //Дистанція на яку веземо 

        public Order(int number, string description, double weight, double distance)//Конструктор класу Order
        {
            Number = number;
            Description = description;
            Weight = weight;
            Distance = distance;
        }


    }

}
