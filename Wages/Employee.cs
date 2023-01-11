using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class Employee : IEmployee
    {
        public Employee(string FirstName, string LastNAme, string SurName, DateTime BirthDay, decimal Wage)
        {
            this.FirstName = FirstName;
            this.LastName = LastNAme;
            this.SurName = SurName;
            this.BirthDay = BirthDay;
            this.Wage = Wage;
        }
        public decimal ClearWageSum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SurName { get; set; }
        public DateTime BirthDay { get; set; }
        public decimal Wage { get; private set; }
        private DateTime _LastWageChangeDate;
        private decimal _LastWageChangeSum;
        public StringBuilder ChangeHistory { get; private set; } = new StringBuilder();
        public void ChangeWage(decimal NewWage)
        {
            _LastWageChangeSum = this.Wage;
            _LastWageChangeDate = DateTime.Today;
            this.Wage = NewWage;
            ChangeHistory.Append(_LastWageChangeDate + " - " + _LastWageChangeSum+"-->"+Wage);
        }
        
        public void LastWage()
        {
            Console.WriteLine($"Wage of {FirstName}  {LastName}  is {Wage}");
            Console.WriteLine($"Previous Wage of {FirstName}  {LastName} is {_LastWageChangeSum} in {_LastWageChangeDate}");

        }
    }
}
