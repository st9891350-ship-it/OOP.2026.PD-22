using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryAPP1
{
    public class Bike : Transport // Клас для доставки на велосипеді
    {
        public Bike(string name = "Велосипед") : base(name)
        {
        }

        public override bool CanTake(Order order)
        {
            return order.Weight <= 10 && order.Distance <= 10;// Перевірка, чи може велосипед доставити замовлення (вага до 10 кг і відстань до 10 км)
        }
        public override double CalculateCost(Order order)
        {
            return 20 * order.Distance * 5;//
        }
    }
}