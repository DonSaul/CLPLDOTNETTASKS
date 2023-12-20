using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Developer : Staff
    {
        private string level;
        public Developer(string level, string name, int salary) : base(name, salary)
        {
            this.level = level;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("{0} is of level {1}", base.name, this.level);
        }
    }
}
