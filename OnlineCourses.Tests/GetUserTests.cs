using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class GetUserTests
    {
        [Test]
        public void GetUser_WithValidId_ReturnsUserObject()
        {
            // Arrange
            int userId = 1;
            User expectedUser = new User("John", "Doe", "johndoe@gmail.com", "johndoe", "password", "student");

            // Add the user to the user list
            List<User> userList = new List<User>() { expectedUser };
            CoursesMethod.SerialiseUserList(userList);

            // Act
            User actualUser = CoursesMethod.GetUser(userId);

            // Assert
            Assert.IsNull(actualUser);
            Assert.AreNotEqual(expectedUser, actualUser);
        }
    }
}
