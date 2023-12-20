using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Staff : Person
    {
        private int salary;
        public Staff(string name, int salary) : base(name) 
        { 
            this.salary = salary;
        }

        public override string Name { get { return base.Name; } }
        public override void Print()
        {
            Console.WriteLine("{0} has salary of ${1}", Name, this.salary);
        }
    }
}
