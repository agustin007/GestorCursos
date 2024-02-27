using Xunit;
using System;
using GestorCursos;

namespace GestorCursosTests
{
    public class CourseManagerTests
    {
        [Fact]
        public void RegisterStudent_UnderageStudent_ThrowsException()
        {
            var courseManager = new CourseManager();

            Assert.Throws<ArgumentException>(() => courseManager.RegisterStudent("John", 17));
        }

        [Fact]
        public void RegisterCourse_And_GetEnrollmentsBetweenDates()
        {
            var courseManager = new CourseManager();
            courseManager.RegisterCourse("Course A", 100, new DateTime(2024, 1, 1), new DateTime(2024, 2, 1));
            courseManager.RegisterCourse("Course B", 200, new DateTime(2024, 1, 15), new DateTime(2024, 2, 15));
            courseManager.RegisterStudent("John", 20);
            courseManager.EnrollStudentInCourse("John", "Course A");
            courseManager.EnrollStudentInCourse("John", "Course B");

            var enrollments = courseManager.GetEnrollmentsBetweenDates(new DateTime(2024, 1, 1), new DateTime(2024, 1, 31));

            Assert.Equal(2, enrollments.Count);
        }
    }

}

