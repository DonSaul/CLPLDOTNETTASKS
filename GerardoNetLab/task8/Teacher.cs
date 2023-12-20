using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Teacher: Staff
    {
        private string subject;
        public Teacher(string name, int salary, string subject) : base(name, salary)
        {
            this.subject = subject;
        }

        public override void Print()
        {
            Console.WriteLine("Teacher: {0}, has Salary: {1}, Teaches: {2}", Name, Salary, subject);
        }

    }
}
