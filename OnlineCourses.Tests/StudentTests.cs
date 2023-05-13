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
    public class StudentTests
    {
        [Test]
        public void Constructor_SetsRoleToStudent()
        {
            // Arrange
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";

            // Act
            Student student = new Student(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual("student", student.Role);
        }

        [Test]
        public void Rate_IncrementsCourseRating()
        {
            // Arrange
            Course course = new Course("test_course", "test_description",75, 4.5, "test_bio", 456781231);

            // Act

            // Assert
            Assert.AreEqual(100, course.Rating);
        }
    }
}
