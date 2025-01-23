namespace CSharpLessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //123.456
            decimal d = decimal.Parse(Console.ReadLine());

            int real = (int)d;
            decimal fract = d  - real;
            Console.WriteLine(fract * 1000 + (decimal)real/1000);

            
        }
    }
}
