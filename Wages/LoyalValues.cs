using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    static class LoyalValues
    {
        public const decimal IncomeTaxPercent2022 = 21;
        public const decimal IncomeTaxPercent2023 = 20;
        public const decimal SocialFeePersent2022 = 4.5m;
        public const decimal SocialFeePersent2023 = 5m;
        public const decimal SocialFeePersentGen = 10m;
        public const decimal SocialFeeDepPart2023 = 25000m;
        public const decimal SocialFeeDepPart2022 = 27500m;
        public const decimal MinimalWage2022 = 68000m;
        public const decimal MinimalWage2023 = 75000m;
        public const decimal SocLimit2022 = 1020000;
        public const decimal SocLimit2023 = 1125000;
        public static readonly DateTime BirthLimit = new DateTime(1974,1,1);
    }
}
