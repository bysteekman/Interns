using System;
using System.Collections.Generic;
using InternshipTest.Person;
using InternshipTest.Institution;
using InternshipTest.Institution.InterLink;

namespace InternshipTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student("Ihor");
            s.SetKnowledge(new Knowledge(12));
            University university = new University("CH.U.I.");
            university.AddStudent(new Student("Andrew Kostenko", 7));
            university.AddStudent(new Student("Julia Veselkina", 8));
            university.AddStudent(new Student("Maria Perechrest", 12));
            university.AddStudent(new Student("Steave Jobs", 5));
            university.AddStudent(new Student("Yan Hurov", 12));
            university.AddStudent(s);
            

            Internship internship = new Internship("Interlink");
            BestStudentsToInternship(university.GetStudents(), university.GetAverage(), internship);
            Console.WriteLine("List of internship's students:");
            Console.WriteLine(internship.GetStudents());
        }
        static void BestStudentsToInternship(List<Student> students, int average, Internship bestStudents)
        {
            foreach(Student student in students)
            {
                if(student.knowledge.level > average)
                {
                    bestStudents.AddStudent(student);
                }
            }
        }
    }
}
