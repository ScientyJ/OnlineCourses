using OnlineCourses.ClassFolder;
using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class DeleteCourseTests
    {
        [Test]
        public void DeleteCourse_RemovesCourseFromList()
        {
            // Arrange
            var courseList = new List<Course>
    {
        new Course("Test Course 1", "Test Subject", 10, 100.0, "Test Bio", 1),
        new Course("Test Course 2", "Test Subject", 15, 150.0, "Test Bio", 2)
    };
            CoursesMethod.SerialiseCourseList(courseList);

            // Act
            CoursesMethod.DeleteCourse("Test Course 1");
            var updatedCourseList = CoursesMethod.DeserialiseCourseList();

            // Assert
            Assert.AreEqual(1, updatedCourseList.Count);
            Assert.AreEqual("Test Course 2", updatedCourseList[0].Name);
        }

    }
}
