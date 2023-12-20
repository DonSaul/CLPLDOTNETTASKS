using System;

namespace Task8.Models
{
    public class Person
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public virtual string Name
        {
            get { return name; }
        }

        public virtual void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }
    }
}