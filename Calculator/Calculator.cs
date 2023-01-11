using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting
{
    public static class Calculator
    {
        static decimal Add(decimal value1, decimal value2)
        {
            return value1 + value2;
        }
        static decimal Product(decimal value1, decimal value2)
        {
            return value1 * value2;
        }
        static decimal Distinct(decimal value1, decimal value2)
        {
            return value1 - value2;
        }
        static decimal Divide(decimal value1, decimal value2)
        {
            try
            {
                return value1 / value2;
            }
            catch (DivideByZeroException de)
            {

                Console.WriteLine("Please only not 0");
                Console.WriteLine(de.Data);
            }
            return 0;
        }
        public static decimal Calc()
        {
            decimal Value1 = 0;
            decimal Value2 = 0;
            string action = "";
            Console.WriteLine("Please enter a number");
            if (decimal.TryParse(Console.ReadLine(), out decimal ConsValue1))
            {
                Value1 = ConsValue1;
            }
            else
            {
                return 0;
                Console.WriteLine("It is not number");
            }
            for (; ; )
            {
                Console.WriteLine("Please enter action");
                action = Console.ReadLine();
                if (action == "=")
                {

                    Console.WriteLine(Value1);
                    return Value1;

                }
                Console.WriteLine("Please enter a number");
                if (decimal.TryParse(Console.ReadLine(), out decimal ConsValue2))
                {
                    Value2 = ConsValue2;
                }
                else
                {
                    return 0;
                    Console.WriteLine("It is not number");
                }
                switch (action)
                {
                    case "+":
                        Value1 = Add(Value1, Value2);
                        break;
                    case "-":
                        Value1 = Distinct(Value1, Value2);
                        break;
                    case "/":
                        Value1 = Divide(Value1, Value2);
                        break;
                    case "*":
                        Value1 = Product(Value1, Value2);
                        break;
                    default:
                        {
                            Console.WriteLine("It is not wright action");
                            return 0;
                        }
                        break;
                }
            }

        }
    }
}


