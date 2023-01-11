using Newtonsoft.Json;
using System;
using System.IO;

namespace MiniShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string JsonFilePath = Environment.CurrentDirectory + @"\Files1.txt";
            Meal Angus = new Meal("Angus", 5200);
            Meal Shaurma = new Meal("Shaurma", 1500);
            Shaurma.MakeProces();
            Meal.Sell(Shaurma);
            Shaurma.MakeProces();
            Meal.Sell(Shaurma);
            Shaurma.MakeProces();
            Meal.Sell(Shaurma);
            Angus.MakeProces();
            Meal.Sell(Angus);
            Angus.MakeProces();
            Meal.Sell(Angus);
            Angus.MakeProces();
            Meal.Sell(Angus);
            Products.PrintAllSoldProductToday();
            Products.ChangeDate();
            Angus.MakeProces();
            Meal.Sell(Angus);
            Shaurma.MakeProces();
            Meal.Sell(Shaurma);
            Products.PrintAllSoldProductToday();
            Products.ChangeDate();
            if (Products.PurchaseHistory.TryGetValue(DateTime.Today, out string history))
            {
                Console.WriteLine(history);
            }
            string SoldHistory = JsonConvert.SerializeObject(Products.PurchaseHistory);
            if (File.Exists(JsonFilePath))
            {
                File.WriteAllText(JsonFilePath, SoldHistory);
            }


        }
    }
}
