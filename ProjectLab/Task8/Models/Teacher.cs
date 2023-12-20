using System;

namespace Task8.Models
{
    public class Teacher : Staff
    {
        private string subject;

        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine("Teacher {0} teaches {1} and has salary: ${2}", Name, subject, Salary);
        }
    }
}
