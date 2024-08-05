using System;
namespace ClassDiagram
{
    public class Professor
    {
        public string ProfessorID { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        private List<Course> Courses { get; set; }

        public Professor(string professorId, string name, string specialization)
        {
            ProfessorID = professorId;
            Name = name;
            Specialization = specialization;
            Courses = new List<Course>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }
    }
}

