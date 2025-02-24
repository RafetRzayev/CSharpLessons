namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                WorkerType = WorkerType.Parttime,
                Hour = 3,
                HourlyRate = 10,
            };

            Console.WriteLine(employee.CalculateSalary());
        }
    }

    internal abstract class Shape
    {
        public void PrintArea()
        {
            Console.WriteLine("Area");
        }

        public abstract double CalculateArea();

        public virtual void Draw()
        {
            Console.WriteLine("Drawinggg");
        }
    }

    internal class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double CalculateArea()
        {
            return Height * Width;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectanle drawing");
        }
    }

    internal class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    internal static class StringExtensions
    {
        internal static string Capitalize(this string s)
        {
            if (char.IsLetter(s[0]))
            {
                return s[0].ToString().ToUpper() + s.Substring(1);
            }

            return s;
        }
    }
}
