namespace AcademyManagmentSystem;

internal class Student
{
    public int Id { get; set; }

    private string _firstName;
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }

    private string _lastName;
    public string LastName
    {
        get => _lastName;
        set => _lastName = value; 
    }

    private int _age;
    public int Age
    {
        get => _age;
        set => _age = value;
    }

    private Group _group;
    public Group Group
    {
        get => _group;
        set => _group = value;
    }

    public Student()
    {

    }

    public Student(string firstName, string lastName, int age, int id)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        Id = id;
    }

    public Student(string firstName, string lastName, int age, Group group)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _group = group;
    }

    public override string ToString()
    {
        return $"{_firstName} {_lastName} {_age}";
    }
}
