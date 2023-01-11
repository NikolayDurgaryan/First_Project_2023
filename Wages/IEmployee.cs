using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    interface IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Wage { get;  }
    }
}
