namespace StoreManagmentApplication.Models;

class Entity
{
    public int Id { get; protected set; }
}

class User : Entity
{
    private static int _autoIncrementId = 1;

    public User(string username, string password, UserType userType)
    {
        Username = username;
        Password = password;
        UserType = userType;
        Id = _autoIncrementId++;
    }

    public string Username { get;}
    public string Password { get;}
    public UserType UserType { get;}
}

enum UserType
{
    Admin,
    Client
}
