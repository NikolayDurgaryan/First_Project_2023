using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop
{
    public class Drink : Products
    {
        public Drink(string name, decimal price) : base(name, price)
        {

        }
        public override string Name { get; set; }
        public override decimal Price { get; set; }
        public override bool IsMaked { get; set; } = false;

        public override void MakeProces()
        {
            IsMaked = true;
            Console.WriteLine($"{Name} Is shaked");
        }
    }
}
