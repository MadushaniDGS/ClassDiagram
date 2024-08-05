using System;
namespace ClassDiagram
{
    public class University
    {
        public string Name { get; set; }
        public string Location { get; set; }
        private List<Department> Departments { get; set; }

        public University(string name, string location)
        {
            Name = name;
            Location = location;
            Departments = new List<Department>();
        }

        public void AddDepartment(Department dept)
        {
            Departments.Add(dept);
        }

        public List<Department> GetDepartments()
        {
            return Departments;
        }
    }
}

