using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Staff : Person
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }
        override public string Name { get { return base.Name; } }
        public int Salary
        {
            get { return salary; }
        }
        public override void Print()
        {
            Console.WriteLine("Person: {0}, has Salary: {1}", Name, this.salary);
        }
        
    }
}
