using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExamples
{
    internal interface IDraw
    {
        void Draw();
        void Clear()
        {
            Console.WriteLine("Clearing...");
        }
    }

    internal interface ICalculation
    {
        double CalculatePerimetr();
    }

    internal class Triangle : IDraw, ICalculation
    {
        public double A {  get; set; }
        public double B {  get; set; }
        public double C {  get; set; }

        public double CalculatePerimetr()
        {
            return A + B + C;
        }

        //public void Draw()
        //{
        //    Console.WriteLine("Triangle");
        //}
        void IDraw.Draw()
        {
            Console.WriteLine("Triangle");
        }
    }

    internal class Rectangle : IDraw, ICalculation
    {
        public double A { get; set; }
        public double B { get; set; }

        public Rectangle()
        {
            A=default(double);
        }

        public double CalculatePerimetr()
        {
            return 2 * (A + B);
        }

        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
