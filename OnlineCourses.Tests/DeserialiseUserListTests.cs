using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnlineCourses.Tests
{
    internal class DeserialiseUserListTests
    {
        [Test]
        public void DeserialiseUserList_ShouldReturnListOfUsers()
        {
            // Arrange
            var expectedUsers = new List<User>()
    {
        new User("student1", "password", "student1@example.com", "student", "John", "Doe"),
        new User("teacher1", "password", "teacher1@example.com", "teacher", "Jane", "Doe"),
        new User("admin", "admin", "admin@example.com", "admin", "Admin", "Admin"),
    };
            CoursesMethod.SerialiseUserList(expectedUsers);

            // Act
            var actualUsers = CoursesMethod.DeserialiseUserList();

            // Assert
            Assert.IsInstanceOf<List<User>>(actualUsers);
            Assert.AreEqual(expectedUsers.Count, actualUsers.Count);

            for (int i = 0; i < expectedUsers.Count; i++)
            {
                Assert.AreEqual(expectedUsers[i].Name, actualUsers[i].Name);
                Assert.AreEqual(expectedUsers[i].Surname, actualUsers[i].Surname);
                Assert.AreEqual(expectedUsers[i].Login, actualUsers[i].Login);
                Assert.AreEqual(expectedUsers[i].Password, actualUsers[i].Password);
                Assert.AreEqual(expectedUsers[i].EMail, actualUsers[i].EMail);
                Assert.AreEqual(expectedUsers[i].Role, actualUsers[i].Role);
            }
        }
    }
}
