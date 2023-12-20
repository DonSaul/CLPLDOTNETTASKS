using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Person
    {
        public string name { get; set; }

        public Person(string name) 
        { 
            this.name = name;
        }
        public virtual string Name { get { return name; } }
        public virtual void Print() 
        {
            Console.WriteLine("Name : {0}", this.name);
        }
    }
}
