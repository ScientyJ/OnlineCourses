using OnlineCourses.Method;
using OnlineCourses.UserFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class GetTeacherTests
    {
        [TestFixture]
        public class UsersMethodTests
        {
            [Test]
            public void GetTeacher_ReturnsCorrectUser_WhenNameAndSurnameMatch()
            {
                // Arrange
                var users = new List<User>
        {
            new User("johndoe","password","@email",  "teacher", "John", "Doe"),
            new User("janedoe" , "@email", "password", "student", "Jane", "Doe"),
            new User ("bobsmith","@email", "password", "teacher", "Bob", "Smith")
        };
                var expectedTeacher = new User("bobsmith", "@email", "password", "teacher", "Bob", "Smith");
                CoursesMethod.SerialiseUserList(users);
               // Act
               var actualTeacher = CoursesMethod.GetTeacher(expectedTeacher.Name, expectedTeacher.Surname);

                // Assert
                Assert.AreEqual(expectedTeacher.Name, actualTeacher.Name);
                Assert.AreEqual(expectedTeacher.Surname, actualTeacher.Surname);
                Assert.AreEqual(expectedTeacher.Role, actualTeacher.Role);
                Assert.AreEqual(expectedTeacher.EMail, actualTeacher.EMail);
                Assert.AreNotEqual(expectedTeacher.Id, actualTeacher.Id);


            }

            [Test]
            public void GetTeacher_ReturnsNull_WhenNoUserMatchesNameAndSurname()
            {
                // Arrange
                var users = new List<User>
        {
            new User("John", "Doe", "johndoe","@email", "password", "teacher"),
            new User("Jane", "Doe", "janedoe","@email", "password", "student"),
            new User("Bob", "Smith", "bobsmith","@email", "password", "teacher")
        };
                CoursesMethod.SerialiseUserList(users);

                // Act
                var actualTeacher = CoursesMethod.GetTeacher("John", "Smith");

                // Assert
                Assert.IsNull(actualTeacher);
            }
        }
    }
}
