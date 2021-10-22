using System.Collections.Generic;
using InternshipTest.Person;

namespace InternshipTest.Institution
{
    public class University
    {
        private string name;
        private List<Student> studentsList = new List<Student>();

        public University(string name)
        {
            this.name = name;
        }
        public List<Student> GetStudents()
        {
            return studentsList;
        }

        public void AddStudent(Student student)
        {
            studentsList.Add(student);
        }
        public int GetAverage()
        {
            int counter = 0;
            int sum = 0;
            foreach (Student student in studentsList)
            {
                counter++;
                sum += student.knowledge.level;
            }
            return sum / counter;
        }
    }
}
