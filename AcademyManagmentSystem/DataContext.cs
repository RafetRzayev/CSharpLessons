using System.Security.Cryptography.X509Certificates;

namespace AcademyManagmentSystem;

internal class DataContext
{
    public Student[] Students { get; set; } = new Student[100];
    public Teacher[] Teachers { get; set; } = new Teacher[100];
    public Group[] Groups { get; set; } = new Group[100];

    private int _studentIndex = 0;
    private int _teacherIndex = 0;
    private int _groupIndex = 0;

    #region Student operations

    public void AddStudent()
    {
        Console.Write("Firstname:");
        string firstName = Console.ReadLine();
        Console.Write("Lastname:");
        string lastName = Console.ReadLine();
        Console.Write("Age:");
        int age = int.Parse(Console.ReadLine());

        //var student = new Student();
        //student.FirstName = firstName;
        //student.LastName = lastName;
        //student.Age = age;

        //var student = new Student
        //{
        //    FirstName = firstName,
        //    LastName = lastName,
        //    Age = age
        //};

        var student = new Student(firstName, lastName, age, _studentIndex);
        Students[_studentIndex++] = student;
    }

    public void PrintStudent()
    {
        Console.Write("Enter the student id:");
        string idInString = Console.ReadLine();
        
        Console.WriteLine(new string('-', 45));

        if (!int.TryParse(idInString, out int id) || !(id >= 0 && id < _studentIndex))
        {
            Console.WriteLine("Not found");
            return;
        }

        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}");

        var student = Students[id];
        Console.WriteLine($"{student.FirstName,-20}{student.LastName,-20}{student.Age,-5}");
        Console.WriteLine(new string('-', 45));
    }

    public void PrintStudents()
    {
        Console.WriteLine(new string('-', 55));
        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}{"Group",-10}");

        for (int i = 0; i < _studentIndex; i++)
        {
            var student = Students[i];

            if (student == null) continue;

            Console.WriteLine($"{student.FirstName,-20}{student.LastName,-20}{student.Age,-5}{student.Group, -10}");
        }
        Console.WriteLine(new string('-', 55));

        //foreach (var student in Students)
        //{
        //    if (student == null) continue;

        //    Console.WriteLine($"{student.FirstName,-20}{student.LastName,-20}{student.Age,-5}");
        //}
    }

    public void PrintStudents(Student[] students)
    {
        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}");
        foreach (var student in students)
        {
            if (student == null) continue;

            Console.WriteLine($"{student.FirstName,-20}{student.LastName,-20}{student.Age,-5}");
            Console.WriteLine(new string('-', 70));
        }
    }
    #endregion

    #region Teacher operations

    public void AddTeacher()
    {
        Console.Write("Firstname:");
        string firstName = Console.ReadLine();
        Console.Write("Lastname:");
        string lastName = Console.ReadLine();
        Console.Write("Age:");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Subject:");
        string subject = Console.ReadLine();

        var teacher = new Teacher(firstName, lastName, age, subject, _teacherIndex);
        Teachers[_teacherIndex++] = teacher;
    }

    public void PrintTeachers()
    {
        Console.WriteLine(new string('-', 65));
        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}{"Subject",-20}");

        for (int i = 0; i < _teacherIndex; i++)
        {
            var teacher = Teachers[i];
            Console.WriteLine($"{teacher.FirstName,-20}{teacher.LastName,-20}{teacher.Age,-5}{teacher.Subject, -20}");
        }
        Console.WriteLine(new string('-', 65));
    }

    public void PrintTeacher()
    {
        Console.Write("Enter the teacher id:");
        string idInString = Console.ReadLine();

        Console.WriteLine(new string('-', 65));

        if (!int.TryParse(idInString, out int id) || !(id >= 0 && id < _teacherIndex))
        {
            Console.WriteLine("Not found");
            return;
        }

        Console.WriteLine($"{"Firstname",-20}{"Lastname",-20}{"Age",-5}{"Subject", -20}");

        var teacher = Teachers[id];
        Console.WriteLine($"{teacher.FirstName,-20}{teacher.LastName,-20}{teacher.Age,-5}{teacher.Subject, -20}");
        Console.WriteLine(new string('-', 65));
    }

    #endregion

    #region Group operatins

    //Hekim
    //Xeste
    //Department
    //Seans - hekim-xeste - gun, saat
    //
    public void AddGroup()
    {
        Console.Write("Enter the name:");
        string name = Console.ReadLine();

        Console.WriteLine("Choose teacher from list given below");
        PrintTeachers();
        Console.Write("Enter the teacher id:");

        if (!int.TryParse(Console.ReadLine(), out int teacherId) || teacherId < 0 || teacherId >= _teacherIndex)
        {
            Console.WriteLine("Given teacher id is wrong!");
            return;
        }

        Console.WriteLine("Choose student from list given below");
        PrintStudents();
        Console.Write("Enter the students id with comma:");

        var studentIdentifiers = Console.ReadLine().Split(",");
        var students = new Student[studentIdentifiers.Length];

        for (int i = 0; i < students.Length; i++)
        {
            var studentId = int.Parse(studentIdentifiers[i]);
            students[i] = Students[studentId];
        }

        var teacher = Teachers[teacherId];
        var group = new Group(name, teacher, students, _groupIndex);

        Groups[_groupIndex++] = group;

        foreach (var student in students)
        {
            student.Group = group;
        }
    }

    public void PrintGroups()
    {
        foreach (var group in Groups)
        {
            if (group == null) continue;

            Console.WriteLine(new string('-', 70));
            Console.WriteLine("Name:" + group.Name);
            Console.WriteLine("Teacher:" + group.Teacher.FirstName);
            Console.WriteLine("Students:");
            
            PrintStudents(group.Students);
        }

    }

    #endregion
}
