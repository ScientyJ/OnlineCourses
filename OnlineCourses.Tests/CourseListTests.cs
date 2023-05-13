using OnlineCourses.ClassFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    [TestFixture]
    public class CourseListTests
    {
        [Test]
        public void Serialise_Deserialise_RoundTrip()
        {
            // Arrange
            var expected = new List<CourseList>
        {
            new CourseList(1) { Courses = new List<string> { "Math", "English" } },
            new CourseList(2) { Courses = new List<string> { "Biology", "History" } },
        };

            // Act
            CourseList.Serialise(expected);
            var actual = CourseList.Deserialise();

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].StudentId, actual[i].StudentId);
                CollectionAssert.AreEqual(expected[i].Courses, actual[i].Courses);
            }
        }

        [Test]
        public void Add_AddsCourseToList_IfAlreadyExists()
        {
            // Arrange
            int id = 1;
            string name = "Math";
            var initial = new List<CourseList> { new CourseList(id) { Courses = new List<string> { name } } };
            CourseList.Serialise(initial);

            string name2 = "English";
            var expected = new List<CourseList> { new CourseList(id) { Courses = new List<string> { name, name2 } } };

            // Act
            CourseList.Add(id, name2);
            var actual = CourseList.Deserialise();

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].StudentId, actual[i].StudentId);
                CollectionAssert.AreEqual(expected[i].Courses, actual[i].Courses);
            }
        }

        [Test]
        public void RemoveCourse_RemovesCourseFromList()
        {
            // Arrange
            int id = 1;
            string name = "Math";
            string name2 = "English";
            var initial = new List<CourseList> { new CourseList(id) { Courses = new List<string> { name, name2 } } };
            CourseList.Serialise(initial);

            var expected = new List<CourseList> { new CourseList(id) { Courses = new List<string> { name2 } } };

            // Act
            CourseList.RemoveCourse(id, name);
            var actual = CourseList.Deserialise();

            // Assert
            Assert.AreEqual(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i].StudentId, actual[i].StudentId);
                CollectionAssert.AreEqual(expected[i].Courses, actual[i].Courses);
            }
        }
        [Test]
        public void IsCourseInCourseList_ReturnsTrue_IfCourseExists()
        {
            // Arrange
            int id = 1;
            string courseName = "Biology";
            CourseList.Add(id, courseName);

            // Act
            bool result = CourseList.IsCourseInCourseList(id, courseName);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
