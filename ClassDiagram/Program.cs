using ClassDiagram;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        University university = new University("Sample University", "City");
        Department compSciDept = new Department("Computer Science", "CS");
        Professor profSmith = new Professor("P123", "John Smith", "AI");
        Course aiCourse = new Course("CS101", "Introduction to AI", 4);
        Student studentJohn = new Student("S123", "John Doe", "CS");

        university.AddDepartment(compSciDept);
        compSciDept.AddProfessor(profSmith);
        compSciDept.AddCourse(aiCourse);
        compSciDept.AddStudent(studentJohn);
        aiCourse.SetProfessor(profSmith);
        aiCourse.EnrollStudent(studentJohn);
        studentJohn.EnrollInCourse(aiCourse);

        GraduateStudent gradStudentAlice = new GraduateStudent("G123", "Alice Johnson", "CS", "Machine Learning");
        compSciDept.AddStudent(gradStudentAlice);
        gradStudentAlice.ApplyForTA();

        Console.WriteLine(gradStudentAlice.Name);
        Console.WriteLine("Students in the Computer Science Department:");
        foreach (var student in compSciDept.GetStudents())
        {
            Console.WriteLine(student);
        }
        Console.WriteLine("Courses in the Computer Science Department:");
        foreach (var course in compSciDept.GetCourses())
        {
            Console.WriteLine(course);
        }

    }
}

