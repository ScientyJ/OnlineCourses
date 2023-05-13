using OnlineCourses.ClassFolder;
using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class GetCourseTests
    {
        [Test]
        public void GetCourse_ReturnsCorrectCourse()
        {
            // Arrange
            var course1 = new Course("Mathematics 101", "Mathematics", 8, 99.99, "Introduction to basic mathematics", 1);
            var course2 = new Course("English 101", "English", 10, 149.99, "Introduction to basic English", 2);
            var courseList = new List<Course> { course1, course2 };
            CoursesMethod.SerialiseCourseList(courseList);

            // Act
            var result = CoursesMethod.GetCourse("English 101");

            // Assert
            Assert.AreEqual("English 101", result.Name);
            Assert.AreEqual("English", result.Subject);
            Assert.AreEqual(10, result.Length);
            Assert.AreEqual(149.99, result.Price);
            Assert.AreEqual("Introduction to basic English", result.Bio);
            Assert.AreEqual(2, result.TeacherId);
            Assert.AreEqual(100, result.Rating);
            Assert.IsEmpty(result.Subscribers);

            // Clean up
            File.Delete("courses.xml");
        }
    }
}
