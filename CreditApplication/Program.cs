namespace CreditApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Kenan", 3000, 1000);

            dynamic creditRequestModel = new IstehlakCreditRequestModel(person, 3500, 10);
            
            creditRequestModel.CheckCredit(out string responseMessag);

            Console.WriteLine(responseMessag);
            

            CreditRequestModel creditRequestModel1 = new BusinessCreditRequestModel(person, 10000, 10);

            creditRequestModel1.CheckCredit(out responseMessag);

            Console.WriteLine(responseMessag);
        }
    }
}
