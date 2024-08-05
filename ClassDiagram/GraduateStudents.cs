using System;
namespace ClassDiagram
{
    public class GraduateStudent : Student
    {
        public string ResearchTopic { get; set; }

        public GraduateStudent(string studentId, string name, string major, string researchTopic)
            : base(studentId, name, major)
        {
            ResearchTopic = researchTopic;
        }

        public void ApplyForTA()
        {
            Console.WriteLine("Applied For TA");
        }
        public override string ToString()
        {
            return base.ToString() + $", Research Topic: {ResearchTopic}";
        }
    }

}

