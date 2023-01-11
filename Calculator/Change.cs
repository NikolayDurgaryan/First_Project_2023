using System;
using System.Collections.Generic;
using System.Text;

namespace Accounting
{
    static class Change
    {
        public static decimal CurrencyChange(decimal sum, Curenncy curenncy)
        {
            Console.WriteLine(sum * ((decimal)curenncy));
            return sum * ((decimal)curenncy);
        }
    }
}
