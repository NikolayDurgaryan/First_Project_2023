using System;
using System.Collections.Generic;
using System.Text;

namespace MiniShop
{
    public abstract class Products
    {
        public Products(string Name, decimal Price)
        {
            this.Price = Price;
            this.Name = Name;
        }
        public static DateTime OperDate = new DateTime(2023, 1, 1);
        public abstract string Name { get; set; }
        public abstract bool IsMaked { get; set; }
        public abstract decimal Price { get; set; }
        public abstract void MakeProces();
        public static Dictionary<DateTime, string> PurchaseHistory = new Dictionary<DateTime, string>();
        public static List<Products> SoldProducts = new List<Products>();
        public static void Sell(Products products)
        {
            if (products.IsMaked)
            {
                SoldProducts.Add(products);
                Console.WriteLine($"Is soled {products.Name}");
                products.IsMaked = false;
            }
            else
            {
                Console.WriteLine("Please make it");
            }
        }
        public static void PrintAllSoldProductToday()
        {
            foreach (var item in SoldProducts)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void ChangeDate()
        {
            StringBuilder history = new StringBuilder();
            foreach(var item in SoldProducts)
            {
                history.Append($" {item.Name} -->  {item.Price}");
            }
            PurchaseHistory.Add(OperDate, history.ToString());
            SoldProducts.Clear();
            OperDate = OperDate.AddDays(1);
            Console.WriteLine($"Date is {OperDate}");
        }
    }
}
