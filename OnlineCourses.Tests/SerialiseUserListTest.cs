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
    public class SerialiseUserListTest
    {
        [Test]
        public void SerialiseUserList_SerializesUserListToFile()
        {
            // Arrange
            var user1 = new User("john.doe", "password123", "john.doe@example.com", "student", "John", "Doe");
            var user2 = new User("jane.doe", "password456", "jane.doe@example.com", "teacher", "Jane", "Doe");
            var userList = new List<User> { user1, user2 };

            // Act
            CoursesMethod.SerialiseUserList(userList);

            // Assert
            Assert.That(File.Exists("users.xml"), Is.True);

            var deserializer = new XmlSerializer(typeof(List<User>));
            using var reader = new StreamReader("users.xml");
            var deserializedUserList = (List<User>)deserializer.Deserialize(reader);

            Assert.That(deserializedUserList.Count, Is.EqualTo(userList.Count));

            var deserializedUser1 = deserializedUserList[0];
            var deserializedUser2 = deserializedUserList[1];

            Assert.That(deserializedUser1.Id, Is.EqualTo(user1.Id));
            Assert.That(deserializedUser1.Name, Is.EqualTo(user1.Name));
            Assert.That(deserializedUser1.Surname, Is.EqualTo(user1.Surname));
            Assert.That(deserializedUser1.Login, Is.EqualTo(user1.Login));
            Assert.That(deserializedUser1.Password, Is.EqualTo(user1.Password));
            Assert.That(deserializedUser1.EMail, Is.EqualTo(user1.EMail));
            Assert.That(deserializedUser1.Role, Is.EqualTo(user1.Role));

            Assert.That(deserializedUser2.Id, Is.EqualTo(user2.Id));
            Assert.That(deserializedUser2.Name, Is.EqualTo(user2.Name));
            Assert.That(deserializedUser2.Surname, Is.EqualTo(user2.Surname));
            Assert.That(deserializedUser2.Login, Is.EqualTo(user2.Login));
            Assert.That(deserializedUser2.Password, Is.EqualTo(user2.Password));
            Assert.That(deserializedUser2.EMail, Is.EqualTo(user2.EMail));
            Assert.That(deserializedUser2.Role, Is.EqualTo(user2.Role));
        }
    }
    
}
