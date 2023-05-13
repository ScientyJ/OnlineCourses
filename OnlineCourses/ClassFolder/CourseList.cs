using Microsoft.VisualBasic.Devices;
using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnlineCourses.ClassFolder
{
    public class CourseList
    {
        public int StudentId { get; set; }
        public List<string> Courses { get; set; } = new List<string>();
        public CourseList()
        {

        }
        public CourseList(int studentId)
        {
            StudentId = studentId;
        }
        public static void Serialise(List<CourseList> courses)
        {

            var serializer = new XmlSerializer(typeof(List<CourseList>));
            using var writer = new StreamWriter("students_courses.xml");
            serializer.Serialize(writer, courses);

        }
        public static List<CourseList> Deserialise()
        {
            if (File.Exists("students_courses.xml"))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<CourseList>));

                using (FileStream fs = new FileStream("students_courses.xml", FileMode.OpenOrCreate))
                {
                    return (List<CourseList>)xml.Deserialize(fs);
                }
            }
            else throw new Exception("Missing file students_courses.xml");

        }

        public static void Add(int id, string name)
        {
            var courselist = new List<CourseList>();
            var course = new CourseList();
            if (File.Exists("students_courses.xml"))
            {

                courselist = CourseList.Deserialise();
                if (courselist.Any(x => x.StudentId == id))
                {
                    course = courselist.Where(x => x.StudentId == id).FirstOrDefault();
                    RemoveCourseList(id);
                    var index = courselist.FindIndex(x => x.StudentId == id);
                    if (index != -1) courselist.RemoveAt(index);
                }
                else course = new CourseList(id);



            }
            else 
            {
                course = new CourseList(id);
            }
            course.Courses.Add(name);
            courselist.Add(course);
            Serialise(courselist);


        }
        private static void RemoveCourseList(int id)
        {
            var courselist = Deserialise();
            var index = courselist.FindIndex(x => x.StudentId == id);
            if (index != -1)
            {
                courselist.RemoveAt(index);
                Serialise(courselist);
            }
            else MessageBox.Show("ERROR");

        }

        public static void RemoveCourse(int id, string name)
        {
            var courselist = CourseList.Deserialise();
            var course = courselist.Where(x => x.StudentId == id).FirstOrDefault();
            courselist.RemoveAt(courselist.FindIndex(x => x.StudentId == id));
            course.Courses.RemoveAt(course.Courses.FindIndex(x => x.Equals(name)));
            courselist.Add(course);
            CourseList.Serialise(courselist);
        }
        public static bool IsCourseInCourseList(int id, string name)
        {
            var courselist = CourseList.Deserialise();
            var course = courselist.Where(x => x.StudentId == id).FirstOrDefault();
            return course.Courses.Any(x => x == name);
        }
    }
}








