using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop
{
    public class Meal : Products
    {
        public Meal(string name,decimal price):base (name,price)
        {

        }
        public override string Name { get ; set ; }
        public override decimal Price { get; set; }
        public override bool IsMaked { get; set ; }

        public override void MakeProces()
        {
            IsMaked = true;
            Console.WriteLine($"{Name} is cooked");
        }
    }
}
