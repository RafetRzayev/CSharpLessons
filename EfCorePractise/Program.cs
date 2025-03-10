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
                {"show groups",ShowGroups },
                {"show teachers",ShowTeachers },
                {"show teacher groups",ShowTeacherGroups },
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

            var students = dbContext.Students.Include(x => x.Group);

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.GroupId} {item.Group?.Name}");
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

        static void ShowGroups()
        {
            var dbContext = new AppDbContext();

            var groups = dbContext.Groups.Include(x => x.Students);

            foreach (var item in groups)
            {
                Console.WriteLine(item.Name);

                foreach (var student in item.Students)
                {
                    Console.WriteLine("--" + student.Name);
                }
            }
        }

        static void ShowTeachers()
        {
            var dbContext = new AppDbContext();

            var teachers = dbContext.Teachers.Include(x => x.TeacherGroups).ThenInclude(x => x.Group);

            foreach (var item in teachers)
            {
                Console.WriteLine(item.Name);

                foreach (var tg in item.TeacherGroups)
                {
                    Console.WriteLine(tg.GroupId + " " + tg.Group?.Name);
                }
            }
        }

        static void ShowTeacherGroups()
        {
            var dbContext = new AppDbContext();

            var teacherGroups = dbContext.TeacherGroups.Include(x => x.Group).Include(x => x.Teacher);

            foreach (var item in teacherGroups)
            {
                Console.WriteLine(item.Group.Name + " " + item.Teacher.Name);
            }
        }
    }
}
