using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditApplication
{
    internal class Person
    {
        public Person(string name, decimal salary, decimal monthlyExpenses)
        {
            Name = name;
            Salary = salary;
            MonthlyExpenses = monthlyExpenses;
        }

        public string Name { get; set; }
        public decimal Salary {  get; set; }
        public decimal MonthlyExpenses {  get; set; }
    }
}
