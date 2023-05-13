using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    [TestFixture]
    public class TeacherTests
    {
        [Test]
        public void Constructor_SetsRoleToTeacher()
        {
            // Arrange
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";

            // Act
            Teacher teacher = new Teacher(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual("teacher", teacher.Role);
        }

        [Test]
        public void Constructor_SetsPropertiesInheritedFromUser()
        {
            // Arrange
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";

            // Act
            Teacher teacher = new Teacher(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual(login, teacher.Login);
            Assert.AreEqual(password, teacher.Password);
            Assert.AreEqual(email, teacher.EMail);
            Assert.AreEqual(name, teacher.Name);
            Assert.AreEqual(surname, teacher.Surname);
        }
    }
}
