using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.UserFolder
{
    public class Teacher : User
    {
        public Teacher(string login, string password, string eMail, string role, string name, string surname) : base(login, password, eMail, role, name, surname)
        {
            Role = "teacher";
        }
        public Teacher()
        {
            
        }
    }
}
