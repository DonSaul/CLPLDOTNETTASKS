using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Models
{
    public class Square : Shape
    {
        private double _side;

        public double Side
        {
            get => _side;
            set
            {
                _side = value;
            }
        }

        public Square(string name, double side) : base(name)
        {
            Side = side;
        }

        public override double Area()
        {
            return Math.Pow(Side, 2); // Calculates the area of a square.
        }

        public override double Perimeter()
        {
            return 4 * Side; // Calculates the perimeter of a square.
        }

        public override void PrintInfo()
        {
            // Prints information about the square.
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: Square");
            Console.WriteLine($"Side length: {Side}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine();
        }
    }
}
