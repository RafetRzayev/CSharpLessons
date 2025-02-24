using System;

namespace CreditApplication
{
    //Itehlak krediti - 45%
    //Biznez krediti  - 70%
    internal class CreditRequestModel
    {
        public CreditRequestModel(Person person, decimal credit, int month)
        {
            Person = person;
            Credit = credit;
            Month = month;
        }

        protected Person Person { get; set; }
        public decimal Credit { get;  private set; }
        public int Month {  get; set; }

        public virtual bool CheckCredit(out string responseMessage)
        {
            decimal totalMonthlyExpenses = Person.MonthlyExpenses + Credit / Month;

            decimal maxIncome = Person.Salary * 0.45m;

            if (totalMonthlyExpenses > maxIncome)
            {
                responseMessage = "Ugurlu deyil";
                return false;
            }

            responseMessage = "Tebrikler, size kredit dusur";
            return true;
        }
    }

    internal class BusinessCreditRequestModel : CreditRequestModel
    {
        public BusinessCreditRequestModel(Person person, decimal credit, int month) : base(person, credit, month)
        {
        }

        public override bool CheckCredit(out string responseMessage)
        {
            decimal totalMonthlyExpenses = Person.MonthlyExpenses + Credit / Month;

            decimal maxIncome = Person.Salary * 0.7m;

            if (totalMonthlyExpenses > maxIncome)
            {
                responseMessage = "Ugurlu deyil";
                return false;
            }

            responseMessage = "Tebrikler, size kredit dusur";
            return true;
        }
    }

    internal class IstehlakCreditRequestModel : CreditRequestModel
    {
        public IstehlakCreditRequestModel(Person person, decimal credit, int month) : base(person, credit, month)
        {
        }
    }
}
