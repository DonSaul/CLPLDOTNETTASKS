using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    internal class Student : Person
    {
        private string groupName;
        public Student (string name, string groupName) : base(name)
        {
            this.groupName = groupName;
        }
        public override void Print()
        {
            
            Console.WriteLine("Student: {0} , student of group: {1}",Name, groupName);
        }
    }
}
