namespace AcademyManagmentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Commands
             * 1. add student
             * 2. print students
             * 3. print student
             * 4. add teacher
             * 5. print teachers
             * 6. print teacher
             * 7. add group
             * 8. print groups
             */
            string command;
            var dataContext = new DataContext();

            do
            {
                Console.Write("Enter command(exit for quit):");
                command = Console.ReadLine();

                switch (command.ToLower())
                {
                    case "add student":
                        dataContext.AddStudent();
                        break;
                    case "print student":
                        dataContext.PrintStudent();
                        break;
                    case "print students":
                        dataContext.PrintStudents(dataContext.Students);
                        break;
                    case "add teacher":
                        dataContext.AddTeacher();
                        break;
                    case "print teacher":
                        dataContext.PrintTeacher();
                        break;
                    case "print teachers":
                        dataContext.PrintTeachers();
                        break;
                    case "add group":
                        dataContext.AddGroup();
                        break;
                    case "print groups":
                        dataContext.PrintGroups();
                        break;
                    default:
                        Console.WriteLine("Enter the correct command");
                        break;
                }

            } while (command != "exit");
        }
    }
}
