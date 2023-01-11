using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    static class WageCalculate
    {
        static private int _CalculateYear = 2022;

        public static decimal IncomeTax(Employee employee)
        {
            decimal taxPercent;
            decimal incomeTax;
            if (_CalculateYear == 2022)
            {
                taxPercent = LoyalValues.IncomeTaxPercent2022;
            }
            else
            {
                taxPercent = LoyalValues.IncomeTaxPercent2023;
            }
            incomeTax = employee.Wage * taxPercent / 100;
            Console.WriteLine(nameof(incomeTax) + "-->" + incomeTax);
            return incomeTax;
        }
        public static decimal SocialFee(Employee employee)
        {
            if (employee.BirthDay >= LoyalValues.BirthLimit)
            {
                decimal socialFeePersent;
                decimal socialFee;
                decimal socialLimit;
                decimal socialFeeDepPart;
                if (_CalculateYear == 2022)
                {
                    socialFeePersent = LoyalValues.SocialFeePersent2022;
                    socialLimit = LoyalValues.SocLimit2022;
                    socialFeeDepPart = LoyalValues.SocialFeeDepPart2022;
                }
                else
                {
                    socialFeePersent = LoyalValues.SocialFeePersent2023;
                    socialLimit = LoyalValues.SocLimit2023;
                    socialFeeDepPart = LoyalValues.SocialFeeDepPart2023;
                }
                if (employee.Wage <= 500000)
                {
                    socialFee = employee.Wage * socialFeePersent / 100;
                }
                else if (500000 < employee.Wage && employee.Wage <= socialLimit)
                {
                    socialFee = employee.Wage * LoyalValues.SocialFeePersentGen / 100 - socialFeeDepPart;
                }
                else
                {
                    socialFee = socialLimit * LoyalValues.SocialFeePersentGen / 100 - socialFeeDepPart;
                }
                Console.WriteLine(nameof(socialFee) + "-->" + socialFee);
                return socialFee;
            }
            else
            {
                return 0;
            }
        }
        public static decimal SoldFee(Employee employee)
        {
            decimal soldFee;
            decimal minimumWage;
            if (_CalculateYear == 2022)
            {
                minimumWage = LoyalValues.MinimalWage2022;
            }
            else
            {
                minimumWage = LoyalValues.MinimalWage2023;
            }

            if (employee.Wage >= minimumWage && employee.Wage <= 100000)
            {
                soldFee = 1500;
            }
            else if (employee.Wage > 100000 && employee.Wage <= 200000)
            {
                soldFee = 3000;
            }
            else if (employee.Wage > 200000 && employee.Wage <= 500000)
            {
                soldFee = 5500;
            }
            else if (employee.Wage > 500000 && employee.Wage <= 1000000)
            {
                soldFee = 8500;
            }
            else
            {
                soldFee = 15000;
            }
            Console.WriteLine(nameof(soldFee) + "-->" + soldFee);
            return soldFee;
        }
        public static decimal ClearWage(Employee employee)
        {
            decimal clearWage = employee.Wage - SocialFee(employee) - SoldFee(employee) - IncomeTax(employee);
            Console.WriteLine(nameof(clearWage) + "-->" + clearWage);
            return clearWage;
        }
        //Հետ հաշվարկ
        public static decimal BackCalcSoldFee(Employee employee, decimal clearWage)
        {
            decimal BackCalcSoldFee = 0;
            if (employee.BirthDay >= LoyalValues.BirthLimit)
            {
                if (clearWage <= 73500)
                {
                    BackCalcSoldFee = 1500;
                }
                else if (73500 < clearWage && clearWage <= 147000)
                {
                    BackCalcSoldFee = 3000;
                }
                else if (147000 < clearWage && clearWage <= 369500)
                {
                    BackCalcSoldFee = 5500;
                }
                else if (369500 < clearWage && clearWage <= 716500)
                {
                    BackCalcSoldFee = 8500;
                }
                else
                {
                    BackCalcSoldFee = 15000;
                }
            }
            else
            {
                if (clearWage <= 78500)
                {
                    BackCalcSoldFee = 1500;
                }
                else if (78500 < clearWage && clearWage <= 157000)
                {
                    BackCalcSoldFee = 3000;
                }
                else if (157000 < clearWage && clearWage <= 394500)
                {
                    BackCalcSoldFee = 5500;
                }
                else if (394500 < clearWage && clearWage <= 791500)
                {
                    BackCalcSoldFee = 8500;
                }
                else
                {
                    BackCalcSoldFee = 15000;
                }

            }
            Console.WriteLine(BackCalcSoldFee);
            return BackCalcSoldFee;

        }



        public static decimal BackCalcSocialFee(Employee employee, decimal clearWage)
        {
            if (employee.BirthDay <= LoyalValues.BirthLimit)
            {
                return 0;
            }
            else
            {
                decimal onePersent = (clearWage + BackCalcSoldFee(employee, clearWage)) / (100 - LoyalValues.IncomeTaxPercent2023 - LoyalValues.SocialFeePersent2023);
                decimal socialFee;
                if (367000 >= clearWage)
                {
                    socialFee = onePersent * LoyalValues.SocialFeePersent2023;
                }
                else if (797500 <= clearWage && clearWage >= 367000)
                {
                    socialFee = onePersent * LoyalValues.SocialFeePersentGen - LoyalValues.SocialFeeDepPart2023;
                }
                else
                {
                    socialFee = LoyalValues.SocLimit2023 * LoyalValues.SocialFeePersentGen / 100 - LoyalValues.SocialFeeDepPart2023;
                }
                Console.WriteLine(nameof(BackCalcSoldFee) + " --> " + socialFee);
                return socialFee;
            }

        }
        public static decimal BackCalcInComeTax(Employee emloyee, decimal clearWage)
        {
            decimal onePersent = (clearWage + BackCalcSoldFee(emloyee, clearWage)) / (100 - LoyalValues.IncomeTaxPercent2023 - LoyalValues.SocialFeePersent2023);

            Console.WriteLine(nameof(BackCalcInComeTax) + "-->" + (onePersent * LoyalValues.IncomeTaxPercent2023));
            return onePersent * LoyalValues.IncomeTaxPercent2023;
        }
        public static decimal BackCalc(Employee employee, decimal clearWage)
        {
            decimal dirtyWage = clearWage + BackCalcSoldFee(employee, clearWage) + BackCalcSocialFee(employee, clearWage) + BackCalcInComeTax(employee, clearWage);
            Console.WriteLine(nameof(BackCalc) + "-->" + dirtyWage);
            return dirtyWage;
        }

    }
}
