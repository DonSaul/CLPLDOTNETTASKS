using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Teacher : Staff
    {
        private string subject;
        public Teacher(string subject, string name, int salary) : base(name, salary)
        {
            this.subject = subject;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("{0} has {1} as subject", base.name, this.subject);
        }
    }
}
