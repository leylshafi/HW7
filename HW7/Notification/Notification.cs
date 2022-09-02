using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW7.UserNamespace;

namespace HW7.NotificationNamespace;

class Notification
{
    public readonly Guid Id;
    public string Text { get; set; }
    public readonly DateTime DateTime;
    public User FromUser { get; set; }
    public Notification(string? text, User fromuser)
    {
        Id = Guid.NewGuid();
        DateTime = DateTime.Now;
        Text = text;
        FromUser = fromuser;
    }


    public override string ToString()
    {
        return ($"Id {Id}," +
            $"Text {Text}," +
            $"DateTime {DateTime}," +
            $"FromUser {FromUser},");
    }
}

