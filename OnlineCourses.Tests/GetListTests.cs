using OnlineCourses.ClassFolder;
using OnlineCourses.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineCourses.Tests
{
    internal class GetListTests
    {
        [Test]
        public void GetList_ReturnsCorrectCourseList_ForExistingStudent()
        {
            // Arrange
            int studentId = 1;
            List<CourseList> courseLists = new List<CourseList>()
    {
        new CourseList(studentId)
        {
            Courses = new List<string> { "Math", "Physics", "Chemistry" }
        },
        new CourseList(2)
        {
            Courses = new List<string> { "English", "History" }
        }
    };
            CourseList.Serialise(courseLists);

            // Act
            CourseList result = CoursesMethod.GetList(studentId);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(studentId, result.StudentId);
            CollectionAssert.AreEqual(new List<string> { "Math", "Physics", "Chemistry" }, result.Courses);
        }
    }
}
