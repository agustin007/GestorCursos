using System;

namespace GestorCursos
{
    public class Enrollment
    {
        public Student Student { get; }
        public Course Course { get; }
        public DateTime EnrollmentDate { get; }

        public Enrollment(Student student, Course course, DateTime enrollmentDate)
        {
            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
    }
}
