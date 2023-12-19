using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Task8a
{
    abstract class Person
    {
        private string name;
        public Person( string name) { this.name = name; }
        virtual public string Name { get { return name; } }

        virtual public void Print() 
        { 
            Console.WriteLine( "Name: {0}", this.name );
        }


    }

    class Staff : Person
    {
        private int salary;
        public Staff(string name , int salary ) : base(name)
        { this.salary = salary; }
        public override string Name { get { return base.Name + " Staff"; } }
        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1}", Name, this.salary);
        }
    }

    class Student : Person
    {
        private string groupName;

        public Student( string name, string groupname) : base(name)
        { this.groupName = groupname; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Stuident of group: {0}", this.groupName);
        }
        
    }


    static void Main()
    {

        


    }
}
