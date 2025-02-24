namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            Save(dog1);
        }

        static void Save<T>(T animal) where T : Animal, new()
        {
            var dog = animal as Dog;

            Console.WriteLine(dog.Name);
        }
    }

    internal abstract class Animal
    {
        public string Name { get; set; }
        public Animal()
        {
            
        }

        public Animal(string name)
        {
            Name = name;
        }
    }

    internal class Dog : Animal
    {
        public Dog() : base()
        {
            
        }

        public Dog(string name) : base(name)
        {
        }
    }
}
