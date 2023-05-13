using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class GetRoleTests
    {
        [Test]
        public void GetRole_UserExists_ReturnsRole()
        {
            // Arrange
            var expectedRole = "student";
            var user = new User("testuser", "password", "testuser@example.com", "student", "Test", "User");
            var userList = new List<User> { user };
            CoursesMethod.SerialiseUserList(userList);

            // Act
            var actualRole = CoursesMethod.GetRole("testuser");

            // Assert
            Assert.AreEqual(expectedRole, actualRole);

            // Cleanup
            File.Delete("users.xml");
        }
    }
}
