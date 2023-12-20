using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Developer:Staff
    {
        private string level;
        public Developer(string name, int salary, string level) : base(name, salary)
        {
            this.level = level;
        }

        public override void Print()
        {
            Console.WriteLine("Developer: {0}, has Salary: {1}, Level: {2}", Name, Salary, level);
        }

    }
}
