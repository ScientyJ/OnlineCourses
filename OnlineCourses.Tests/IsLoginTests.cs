using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class IsLoginTests
    {
        [Test]
        public void IsLogin_ExistingLogin_ReturnsTrue()
        {
            // Arrange
            string existingLogin = "johndoe";
            User user = new User(existingLogin, "password", "johndoe@example.com", "student", "John", "Doe");
            List<User> userList = new List<User> { user };
            CoursesMethod.SerialiseUserList(userList);

            // Act
            bool result = CoursesMethod.IsLogin(existingLogin);

            // Assert
            Assert.IsTrue(result);

            // Clean up
            File.Delete("users.xml");
        }
    }
}
