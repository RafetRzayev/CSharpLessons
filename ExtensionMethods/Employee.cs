using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public enum WorkerType
    {
        Fulltime,
        Parttime
    }


    public class Employee
    {
        public string Name { get; set; }

        public WorkerType WorkerType { get; set; }
        public int Hour {  get; set; }
        public decimal HourlyRate {  get; set; }

        public decimal CalculateSalary()
        {
            switch (WorkerType)
            {
                case WorkerType.Fulltime:
                    return 1000;
                case WorkerType.Parttime:
                    return Hour * HourlyRate;
                default:
                    return -1;
            }
        }

    }
    //internal abstract class Employee
    //{
    //    public string Name { get; set; }

    //    public virtual decimal CalculateSalary()
    //    {
    //        Console.WriteLine("Salary calculating...");

    //        return 1000;
    //    }
    //}

    //internal class FullTimeEmployee : Employee
    //{

    //}

    //internal class PartTimeEmployee : Employee
    //{
    //    public int Hour { get; set; }
    //    public decimal HourlyRate {  get; set; }

    //    public override decimal CalculateSalary()
    //    {
    //        return Hour * HourlyRate;
    //    }
    //}
}
