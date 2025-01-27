namespace StoreManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dataContext = new DataContext();

            dataContext.AddReceipt();    
        }
    }
}
