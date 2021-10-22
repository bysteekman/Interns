using InternshipTest;

namespace InternshipTest.Person
{
    public class Student
    {
        public string name;
        public Knowledge knowledge;
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, int knowledgeValue)
        {
            this.name = name;
            if(knowledgeValue != 0)
            {
            this.knowledge = new Knowledge(knowledgeValue);
            }
        }
        public void SetKnowledge(Knowledge knowledge)
        {
            this.knowledge = new Knowledge(knowledge.level);
        }
    }
}