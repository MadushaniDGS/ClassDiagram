using System;
using System.Xml.Linq;

namespace ClassDiagram
{
    public class Course
    {
        public string CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        private List<Student> Students { get; set; }
        public Professor Professor { get; private set; }

        public Course(string courseId, string title, int credits)
        {
            CourseID = courseId;
            Title = title;
            Credits = credits;
            Students = new List<Student>();
        }

        public void EnrollStudent(Student student)
        {
            Students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        public void SetProfessor(Professor prof)
        {
            Professor = prof;
        }

        public Professor GetProfessor()
        {
            return Professor;
        }
        //public override string ToString()
        //{
        //    return $"ID: {CourseID}";
        //}
    }
}

