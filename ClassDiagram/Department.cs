using System;
namespace ClassDiagram
{
    public class Department
    {
        public string Name { get; set; }
        public string Code { get; set; }
        private List<Course> Courses { get; set; }
        private List<Professor> Professors { get; set; }
        private List<Student> Students { get; set; }

        public Department(string name, string code)
        {
            Name = name;
            Code = code;
            Courses = new List<Course>();
            Professors = new List<Professor>();
            Students = new List<Student>();
        }

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }

        public void AddProfessor(Professor prof)
        {
            Professors.Add(prof);
        }

        public List<Professor> GetProfessors()
        {
            return Professors;
        }

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}

