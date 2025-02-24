
using static Delegates.Program;

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = [1, 3, 5, 7];
            
            List<Person> people = [new("kenan"), new("Eli")];

            var hasPerson = people.MyAll(person => person.Name == "Eli" && person.Id == 1);

            Console.WriteLine(hasPerson);
        }
    }

    public static class ExtensionMethods
    {
        public static bool MyAll<T>(this IEnumerable<T> items, Predicate<T> filterBy)
        {
            foreach (var item in items)
            {
                if (!filterBy.Invoke(item))
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Person
    {
        private static int _autoIncrementId = 0;

        public Person(string name)
        {
            Name = name;
            Id = _autoIncrementId++;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
