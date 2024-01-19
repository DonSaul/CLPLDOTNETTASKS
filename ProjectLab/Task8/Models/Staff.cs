using System;
using System.Xml.Linq;

namespace Task8.Models
{
    public class Staff : Person
    {
        private int salary;

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }
        public int Salary
        {
            get { return salary; }
        }

        public override string Name
        {
            get { return base.Name + " Staff"; }
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, salary);
        }
    }
}