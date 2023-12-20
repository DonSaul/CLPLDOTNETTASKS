using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Models
{
    public abstract class Shape : IComparable<Shape>
    {
        public string Name { get; }

        public Shape(string name)
        {
            Name = name;
        }

        public abstract double Area(); // Abstract method to calculate the area of a shape.
        public abstract double Perimeter(); // Abstract method to calculate the perimeter of a shape.

        public int CompareTo(Shape? other)
        {
            if (other == null) return 1;
            return this.Area().CompareTo(other.Area());
        }

        public abstract void PrintInfo(); // Abstract method to print shape information.
    }
}
