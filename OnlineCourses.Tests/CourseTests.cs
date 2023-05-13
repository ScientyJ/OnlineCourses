using OnlineCourses.ClassFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    [TestFixture]
    public class CourseTests
    {
        [Test]
        public void Constructor_SetsRatingTo100()
        {
            // Arrange
            string name = "test_name";
            string subject = "test_subject";
            int length = 10;
            double price = 20.5;
            string bio = "test_bio";
            int teacherId = 1;

            // Act
            Course course = new Course(name, subject, length, price, bio, teacherId);

            // Assert
            Assert.AreEqual(100, course.Rating);
        }
    }
}
