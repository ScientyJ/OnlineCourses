using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.UserFolder
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
        public string Role { get; set; }
        public User(string login, string password, string eMail, string role, string name, string surname)
        {
            Id = Guid.NewGuid().GetHashCode();
            if (Id < 0) Id = Id * -1;
            Login = login;
            Password = password;
            EMail = eMail;
            Role = role;
            Name = name;
            Surname = surname;
        }
        public User()
        {
            
        }
    }
}
