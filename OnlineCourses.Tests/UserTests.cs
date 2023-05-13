using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    [TestFixture]
    public class UserTests
    {
        [Test]
        public void Constructor_SetsPropertiesCorrectly()
        {
            // Arrange
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";

            // Act
            User user = new User(login, password, email, role, name, surname);

            // Assert
            Assert.AreEqual(login, user.Login);
            Assert.AreEqual(password, user.Password);
            Assert.AreEqual(email, user.EMail);
            Assert.AreEqual(role, user.Role);
            Assert.AreEqual(name, user.Name);
            Assert.AreEqual(surname, user.Surname);
        }

        [Test]
        public void Constructor_SetsUniqueId()
        {
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";
            // Act
            User user1 = new User(login, password, email, role, name, surname);
            User user2 = new User(login, password, email, role, name, surname);

            // Assert
            Assert.AreNotEqual(user1.Id, user2.Id);
        }

        [Test]
        public void Constructor_SetsUniqueIdPositive()
        {
            string login = "test_login";
            string password = "test_password";
            string email = "test_email@example.com";
            string role = "test_role";
            string name = "test_name";
            string surname = "test_surname";
            // Act
            User user = new User(login, password, email, role, name, surname);

            // Assert
            Assert.IsTrue(user.Id > 0);
        }
    }
}
