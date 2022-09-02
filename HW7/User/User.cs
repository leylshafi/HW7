
namespace HW7.UserNamespace;
internal class User
{

    public readonly Guid Id;
    private string? email;
    public string? Email
    {
        get { return email; }
        init
        {

            if (value!.Length < 7 || !value.EndsWith(".com"))
                throw new ArgumentException("Invalid email");

            email = value;
        }
    }

    private string? username;

    public string? Username
    {
        get { return username; }
        set
        {
            if (value!.Length < 3)
                throw new ArgumentException("Unavailable username");

            username = value;
        }
    }

    private string? password;

    public string? Password
    {
        get { return password; }
        set
        {
            if (value!.Length < 6)
                throw new ArgumentException("Unavailable Password");

            password = value;
        }
    }

    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 3 || age > 100)
                throw new ArgumentOutOfRangeException("Incorrect age");

            age = value;
        }
    }

    public User(string? email, string? username, string? password, int age)
    {
        Id = Guid.NewGuid();
        Email = email;
        Username = username;
        Password = password;
        Age = age;
    }

    public override string ToString()
    {
        return ($"Id {Id}," +
            $"Username {Username}," +
            $"Password {Password}," +
            $"Age {Age}," +
            $"Email {Email}");
    }
}

