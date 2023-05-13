using Microsoft.VisualBasic.Logging;
using OnlineCourses.ClassFolder;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnlineCourses.Method
{
    public static class CoursesMethod
    {
        public static void SerialiseUserList(List<User> userlist)
        {
            var serializer = new XmlSerializer(typeof(List<User>));
            using var writer = new StreamWriter("users.xml");
            serializer.Serialize(writer, userlist);
        }
        public static List<User> DeserialiseUserList()
        {
            if (File.Exists("users.xml"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<User>));

                using (FileStream fs = new FileStream("users.xml", FileMode.OpenOrCreate))
                {
                    return (List<User>)xml.Deserialize(fs);
                }
            }
            else throw new Exception("Missing file users.xml");

        }
        public static void SerialiseCourseList(List<Course> userlist)
        {
            var serializer = new XmlSerializer(typeof(List<Course>));
            using var writer = new StreamWriter("courses.xml");
            serializer.Serialize(writer, userlist);
        }
        public static List<Course> DeserialiseCourseList()
        {
            if (File.Exists("courses.xml"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Course>));

                using (FileStream fs = new FileStream("courses.xml", FileMode.OpenOrCreate))
                {
                    return (List<Course>)xml.Deserialize(fs);
                }
            }
            else throw new Exception("Missing file courses.xml");
        }

        public static bool IsLogin(string login)
        {
            if (File.Exists("users.xml"))
            {
                var userlist = DeserialiseUserList();
                if (userlist.Any(x => x.Login == login)) return true;
                else return false;
            }
            else return false;
        }
        public static bool IsAuthenticated(string login, string password)
        {
            var userlist = DeserialiseUserList();
            if (userlist.Any(x => x.Login == login && x.Password == password)) return true;
            else return false;

        }
        public static int GetId(string login)
        {
            var userlist = DeserialiseUserList();
            var user = userlist.Where(x => x.Login == login).FirstOrDefault();
            if (user == null) return 0;
            else return user.Id;

        }
        public static string GetRole(string login)
        {
            var userlist = DeserialiseUserList();
            var user = userlist.Where(x => x.Login == login).FirstOrDefault();
            if (user == null) return null;
            else return user.Role;
        }
        public static void DeleteCourse(string name)
        {
            var courselist = CoursesMethod.DeserialiseCourseList();
            courselist.RemoveAt(courselist.FindIndex(x => x.Id == CoursesMethod.GetCourseId(name)));
            CoursesMethod.SerialiseCourseList(courselist);

        }
        public static int GetCourseId(string name)
        {
            var courselist = DeserialiseCourseList();
            var course = courselist.Where(x => x.Name == name).FirstOrDefault();
            if (course == null) return 0;
            else return course.Id;
        }
        public static void UpdateCourse(Course course,string oldname)
        {
            CoursesMethod.DeleteCourse(oldname);
            var courselist = CoursesMethod.DeserialiseCourseList();
            courselist.Add(course);
            CoursesMethod.SerialiseCourseList(courselist);
        }
        public static Course GetCourse(string name)
        {
            var courselist = DeserialiseCourseList();
            return courselist.Where(x => x.Name == name).FirstOrDefault();

        }
        public static User GetTeacher(string name, string surname)
        {

            var userlist = DeserialiseUserList();
            var user = userlist.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
            return user;
        }
        public static User GetStudent(string name, string surname)
        {

            var userlist = DeserialiseUserList();
            var user = userlist.Where(x => x.Name == name && x.Surname == surname).FirstOrDefault();
            return user;
        }
        public static User GetUser(int id)
        {
            var userlist = DeserialiseUserList();
            var user = userlist.Where(x => x.Id == id).FirstOrDefault();
            return user;
        }
        public static CourseList GetList(int _id)
        {
            int id = _id;
            var courselist = CourseList.Deserialise();
            var courses = courselist.Where(x => x.StudentId.Equals(id)).FirstOrDefault();
            return courses;

        }

    }
}
