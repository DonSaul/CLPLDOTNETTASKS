using System;

namespace Task8.Models
{
    public class Developer : Staff
    {
        private string level;

        public Developer(string name, int salary, string level) : base(name, salary)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine("Developer {0} is at level {1} and has salary: ${2}", Name, level, Salary);
        }
    }
}
