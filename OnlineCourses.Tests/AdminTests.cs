using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    [TestFixture]
    public class AdminTests
    {
        [Test]
        public void Constructor_SetsRoleToAdmin()
        {
            // Arrange
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";

            // Act
            Admin admin = new Admin(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual("admin", admin.Role);
        }

        [Test]
        public void Constructor_SetsAdminLoginAndPassword()
        {
            // Arrange
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";

            // Act
            Admin admin = new Admin(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual("admin", admin.Login);
            Assert.AreEqual("admin", admin.Password);
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
            Admin admin = new Admin(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual("admin", admin.Login);
            Assert.AreEqual("admin", admin.Password);
            Assert.AreEqual(email, admin.EMail);
            Assert.AreEqual(name, admin.Name);
            Assert.AreEqual(surname, admin.Surname);
        }
    }
}
