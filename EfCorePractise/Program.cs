using Microsoft.EntityFrameworkCore;

namespace EfCorePractise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Action>
            {
                {"add",Add },
                {"show",Show },
                {"update",Update },
                {"remove",Remove },
            };

            while (true)
            {
                string command = Console.ReadLine();

                if (dict.TryGetValue(command, out Action action))
                    action.Invoke();
                else
                    Console.WriteLine("Command not correct");              
            }
        }

        static void Add()
        {
            var dbContext = new AppDbContext();

            Console.Write("Enter name:");
            var name = Console.ReadLine();

            var student = new Student()
            {
                Name = name
            };

            dbContext.Students.Add(student);
            dbContext.SaveChanges();
        }

        static void Show()
        {
            var dbContext = new AppDbContext();

            var students = dbContext.Students;

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} {item.Name}");
            }
        }

        static void Update()
        {
            var dbContext = new AppDbContext();

            Console.Write("Id:");
            int id = int.Parse(Console.ReadLine());

            var existStudent = dbContext.Students.Find(id);

            if (existStudent == null)
            {
                Console.WriteLine("Not found");

                return;
            }

            Console.Write("Enter new name:");
            var newName = Console.ReadLine();
            existStudent.Name = newName;
            dbContext.SaveChanges();
        }

        static void Remove()
        {
            var dbContext = new AppDbContext();

            Console.Write("Id:");
            int id = int.Parse(Console.ReadLine());

            var existStudent = dbContext.Students.Find(id);

            if (existStudent == null)
            {
                Console.WriteLine("Not found");

                return;
            }

            dbContext.Students.Remove(existStudent);
            dbContext.SaveChanges();
        }
    }
}
