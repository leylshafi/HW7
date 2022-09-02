namespace HW7.AdminNamespace;
using PostNamespace;
using HW7.NotificationNamespace;
internal class Admin
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



    private string? password;

    public string? Password
    {
        get { return password; }
        set
        {
            if (value!.Length < 8)
                throw new ArgumentException("Invalid Password");

            password = value;
        }
    }

    private string? username;

    public string? Username
    {
        get { return username; }
        set
        {
            if (value!.Length < 3)
                throw new ArgumentException("Invalid Username");

            username = value;
        }
    }
    public readonly List<Post> Posts;
    public readonly List<Notification> Notifications;

    public Admin(string username, string email, string password)
    {
        Id = Guid.NewGuid();
        Username = username;
        Email = email;
        Password = password;
        Posts = new List<Post>();
        Notifications = new List<Notification>();
    }

    public void AddNewPost(string content, string owner)
    {
        Posts.Add(new Post(content));
    }

    public void SeeAllPosts()
    {
        foreach (var post in Posts)
        {
            Console.WriteLine(post);
            Console.WriteLine();
        }
    }

    public void SeeAllNotifications()
    {
        foreach (var notification in Notifications)
        {
            Console.WriteLine(notification);
        }
    }


    public override string ToString()
    {
        return ($"Id {Id}," +
            $"Username {Username}," +
            $"Email {Email}," +
            $"Password {Password}," );
    }


}


