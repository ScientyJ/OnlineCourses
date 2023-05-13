using OnlineCourses.ClassFolder;
using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    [TestFixture]

    internal class DeserialiseCourseListTests
    {
        private readonly List<User> users = new List<User>()
    {
        new User("adminlogin", "adminpassword", "admin@domain.com", "admin", "Admin", "Adminov"),
        new User("teacherlogin", "teacherpassword", "teacher@domain.com", "teacher", "Teacher", "Teacherov"),
        new User("studentlogin", "studentpassword", "student@domain.com", "student", "Student", "Studentov")
    };

        private readonly List<Course> courses = new List<Course>()
    {
        new Course("Course1", "Subject1", 10, 100.0, "Course1 Bio", 1),
        new Course("Course2", "Subject2", 20, 200.0, "Course2 Bio", 2),
        new Course("Course3", "Subject3", 30, 300.0, "Course3 Bio", 3)
    };

        [Test]
        public void SerialiseUserList_SerializesUsers_Successfully()
        {
            // Arrange
            string filename = "users.xml";
            File.Delete(filename);

            // Act
            CoursesMethod.SerialiseUserList(users);

            // Assert
            Assert.IsTrue(File.Exists(filename));
            Assert.AreNotEqual(0, new FileInfo(filename).Length);
        }

        [Test]
        public void DeserialiseUserList_DeserializesUsers_Successfully()
        {
            // Arrange
            CoursesMethod.SerialiseUserList(users);

            // Act
            var deserializedUsers = CoursesMethod.DeserialiseUserList();

            // Assert
            CollectionAssert.AreNotEqual(users, deserializedUsers);
        }

        [Test]
        public void SerialiseCourseList_SerializesCourses_Successfully()
        {
            // Arrange
            string filename = "courses.xml";
            File.Delete(filename);

            // Act
            CoursesMethod.SerialiseCourseList(courses);

            // Assert
            Assert.IsTrue(File.Exists(filename));
            Assert.AreNotEqual(0, new FileInfo(filename).Length);
        }

        [Test]
        public void DeserialiseCourseList_DeserializesCourses_Successfully()
        {
            // Arrange
            CoursesMethod.SerialiseCourseList(courses);

            // Act
            var deserializedCourses = CoursesMethod.DeserialiseCourseList();

            // Assert
            CollectionAssert.AreNotEqual(courses, deserializedCourses);
        }
    }
}
