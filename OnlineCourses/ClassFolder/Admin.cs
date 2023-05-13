using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.UserFolder
{
    public class Admin : User
    {
        public Admin(string login, string password, string eMail, string role, string name, string surname) : base(login, password, eMail, role,  name,  surname)
        {
            Login = "admin";
            Password = "admin";
            Role = "admin";
        }
        public Admin()
        {
            
        }
    }
}
