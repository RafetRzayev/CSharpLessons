using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLessons
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            Console.WriteLine("Animal consturctor");
        }

        public Animal(string name)
        {
            Name = name;
            Console.WriteLine($"{name}");
        }
    }


    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
           
        }

        public void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}