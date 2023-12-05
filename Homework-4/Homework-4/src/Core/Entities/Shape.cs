using System;
namespace Homework_4.src.Core.Entities
{
    public abstract class Shape
    {
        // Field
        private string name;

        // Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Constructor
        public Shape(string name)
        {
            this.Name = name;
        }

        // Abstract methods
        public abstract double Area();

        public abstract double Perimeter();
    }
}

