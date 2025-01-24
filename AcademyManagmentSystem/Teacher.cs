namespace AcademyManagmentSystem;

internal class Teacher
{
    public int Id {  get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Subject {  get; set; }

    public Teacher()
    {
        
    }

    public Teacher(string firstName, string lastName, int age, string subject, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Subject = subject;
        Id = id;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {Age} {Subject}";
    }
}
