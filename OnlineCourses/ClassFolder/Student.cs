using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.UserFolder
{
    public class Student : User
    {
        public Student(string login, string password, string eMail, string role, string name, string surname) : base(login, password, eMail, role, name, surname)
        {
            Role = "student";
        }
        public Student()
        {
            
        }
        public static void Rate(string name)
        {
            var courselist = CoursesMethod.DeserialiseCourseList();
            var course = CoursesMethod.GetCourse(name);
            course.Rating++;
            CoursesMethod.UpdateCourse(course, course.Name);

        }
    }
}
