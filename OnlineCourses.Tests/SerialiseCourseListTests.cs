using OnlineCourses.ClassFolder;
using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class SerialiseCourseListTests
    {
        [Test]
        public void SerialiseCourseList_WritesCourseListToFile()
        {
            // Arrange
            List<Course> courses = new List<Course>
    {
        new Course("Math101", "Math", 12, 50.0, "Introduction to Calculus", 1),
        new Course("CS101", "Computer Science", 10, 40.0, "Introduction to Programming", 2),
        new Course("History101", "History", 8, 30.0, "World History", 3)
    };

            // Act
            CoursesMethod.SerialiseCourseList(courses);

            // Assert
            Assert.IsTrue(File.Exists("courses.xml"));

            // Cleanup
        }
    }
}
