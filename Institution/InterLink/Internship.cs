using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution.InterLink
{
    public class Internship
    {
        private string name;
        public List<Student> newInterns = new List<Student>();

        public Internship(string name)
        {
            this.name = name;
        }

        public string GetStudents()
        {
            string bestStudents = "";
            foreach (Student student in newInterns)
            {
                bestStudents += student.name + "\n";
            }
            return bestStudents;
        }
        public void AddStudent(Student student)
        {
            newInterns.Add(student);
        }
    }
}
