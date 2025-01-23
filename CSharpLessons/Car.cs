using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLessons
{
    internal class Car
    {
        //Fields
        private string _name;

        //Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length == 1)
                {
                    Console.WriteLine("Name must be min 2 length");
                    _name = "undefined";

                }
                else
                {
                    _name = value;
                }
            }
        }

        //Auto-implemented property
        public int Age { get; set; }

        public Car()
        {
            Console.WriteLine("Object created");
        }

        public Car(string name)
        {
            _name = name;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{_name}");
        }
    }

    public class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        public string FirstName
        {
            get
            {
                return $"{_firstName[0].ToString().ToUpper()}{_firstName.Substring(1).ToLower()}";
            }
            set => _firstName = value;
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int X { get; set; }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public static int StaticField;

        public Person()
        {
            _firstName = "John";
            _lastName = "Wick";
            _age = 45;
            Console.WriteLine("No, i am the first calling mehtod");
        }

        static Person()
        {
            Console.WriteLine("I am the first calling method");
        }

        public Person(string firstName)
        {
            this._firstName = firstName;
            _lastName = "Wick";
            _age = 45;
        }

        public Person(string firstName, string lastName) : this(firstName)
        {
            _lastName = lastName;
            _age = 45;
        }

        public Person(string firstName, string lastName, int age) : this(firstName, lastName)
        {
            _age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{_firstName} {_lastName} {_age}");
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Age}";
        }

        public static void StaticMethod()
        {
            Console.WriteLine("I am the static method");
        }
    }
}