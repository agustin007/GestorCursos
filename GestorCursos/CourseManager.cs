using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorCursos
{
    public class CourseManager
    {
        private readonly List<Student> students;
        private readonly List<Course> courses;
        private readonly List<Enrollment> enrollments;

        public CourseManager()
        {
            students = new List<Student>();
            courses = new List<Course>();
            enrollments = new List<Enrollment>();
        }

        public void RegisterStudent(string name, int age)
        {
            if (age >= 18)
            {
                students.Add(new Student(name, age));
            }
            else
            {
                throw new ArgumentException("Only adult students are allowed.");
            }
        }

        public void RegisterCourse(string name, decimal registrationFee, DateTime startDate, DateTime endDate)
        {
            courses.Add(new Course(name, registrationFee, startDate, endDate));
        }

        public void EnrollStudentInCourse(string studentName, string courseName)
        {
            var student = students.FirstOrDefault(s => s.Name == studentName);
            var course = courses.FirstOrDefault(c => c.Name == courseName);

            if (student != null && course != null)
            {
                enrollments.Add(new Enrollment(student, course, DateTime.Now));
            }
            else
            {
                throw new ArgumentException("Student or course not found.");
            }
        }

        public List<Enrollment> GetEnrollmentsBetweenDates(DateTime startDate, DateTime endDate)
        {
            return enrollments.Where(e => e.EnrollmentDate >= startDate && e.EnrollmentDate <= endDate).ToList();
        }
    }
}
