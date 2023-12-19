using System;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Task8b
{
    abstract class Person
    {
        private string name;
        public Person(string name) { this.name = name; }
        virtual public string Name { get { return name; } }

        virtual public void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }


    }

    class Staff : Person
    {
        private int salary;
        public Staff(string name, int salary) : base(name)
        { this.salary = salary; }
        public int Salary { get { return salary; } } 
        public override string Name { get { return base.Name + " Staff"; } }
        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1}", Name, this.salary);
        }
    }

    class Student : Person
    {
        private GroupName groupName;

        public Student(string name, GroupName groupname) : base(name)
        { this.groupName = groupname; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Stuident of group: {0}", this.groupName);
        }

    }

    class Teacher : Staff
    {
        private Subject subject;
        public Teacher(string name, int salary , Subject subject) : base( name , salary )
        { this.subject = subject; }
        public override string Name { get { return base.Name + " " + subject + " Teacher"; } }

        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1}", Name, this.Salary);
        }

    }

    class Developer : Staff
    {
        private Level level;

        public Developer(string name, int salary, Level level) : base( name, salary )
        { this.level = level; }
        public override string Name { get { return base.Name + " "+ level +" Developer"; } }
        public override void Print()
        {
            Console.WriteLine("Person: {0} has salary: ${1}", Name, this.Salary);
        }
    }

    enum Level
    {
        Junior,
        MidLevel,
        Senior,
    }

    enum Subject
    {
        Maths,
        History,
        Grammar,
        Music,
    }

    enum GroupName 
    { 
        A1, A2, A3, A4, A5, A6,
        B1, B2, B3, B4, B5, B6,
    }

    static void Main()
    {
        //
        //Developer Javier = new Developer("Javier Saldias", 1200500, Level.Senior);
        //Javier.Print();
        //
        //Teacher Juan = new Teacher("Juan Perez", 2500700, Subject.Music );
        //Juan.Print();
        //
        //Staff Claudia = new Staff( "Claudia Rojas", 2300400 );
        //Claudia.Print();
        //
        //Student Pedro = new Student( "Pedro Jerez", GroupName.A3 );
        //Pedro.Print();      
        //
    }
}
