using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Employee eOld = new Employee("Babken", "Doxalyan", "Suren", new DateTime(1975, 2, 3), 200000);
            Employee eTeen = new Employee("avid", "Harutyunyan", "Menak", new DateTime(2000, 2, 3), 200000);
              WageCalculate.BackCalc(eTeen, 100000);
            Console.WriteLine("------------");

            eOld.ChangeWage(500000);
            Console.WriteLine("------------");

               eOld.ChangeWage(750000);
            Console.WriteLine("------------");

            eOld.LastWage();
            Console.WriteLine("------------");
            Console.WriteLine(eOld.ChangeHistory);
            Console.WriteLine("-------------");
            WageCalculate.ClearWage(eOld);
        }
    }
}
