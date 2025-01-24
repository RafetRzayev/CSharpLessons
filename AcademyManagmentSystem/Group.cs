namespace AcademyManagmentSystem;

internal class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teacher Teacher { get; set; }
    public Student[] Students { get; set; } = new Student[20];

    public Group()
    {
        
    }

    public Group(string name, Teacher teacher, Student[] students, int id)
    {
        Name = name;
        Teacher = teacher;
        Students = students;
        Id = id;
    }

    public override string ToString()
    {
        return Name;
    }
}
