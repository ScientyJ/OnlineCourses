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
    public class AuthenticationTests
    {
        [Test]
        public void IsAuthenticated_ShouldReturnTrue_WhenValidCredentialsAreProvided()
        {
            // Arrange
            var userlist = new List<User>
        {
            new User("johndoe", "password", "johndoe@example.com", "student", "John", "Doe")
        };
            var login = "johndoe";
            var password = "password";


            CoursesMethod.SerialiseUserList(userlist);

            // Act
            var result = CoursesMethod.IsAuthenticated(login, password);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void IsAuthenticated_ShouldReturnFalse_WhenInvalidCredentialsAreProvided()
        {
            // Arrange
            var userlist = new List<User>
        {
            new User("johndoe", "password", "johndoe@example.com", "student", "John", "Doe")
        };
            var login = "janedoe";
            var password = "password";
            CoursesMethod.SerialiseUserList(userlist);

            // Act
            var result = CoursesMethod.IsAuthenticated(login, password);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
