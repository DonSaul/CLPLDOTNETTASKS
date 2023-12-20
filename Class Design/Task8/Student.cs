using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Student : Person
    {
        private string groupName;

        public Student(string name, string groupName) : base(name) 
        { 
            this.groupName = groupName;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Student of group {0}", this.groupName);
        }
    }
}
