using System;
namespace ClassDiagram
{
    public class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Major { get; set; }
        private List<Course> Courses { get; set; }

        public Student(string studentId, string name, string major)
        {
            StudentID = studentId;
            Name = name;
            Major = major;
            Courses = new List<Course>();
        }

        public void EnrollInCourse(Course course)
        {
            Courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }
        public override string ToString()
        {
            return $"ID: {StudentID}, Name: {Name}, Major: {Major}";
        }
    }
}

