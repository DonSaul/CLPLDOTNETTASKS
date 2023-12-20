using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8.Models
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius
        {
            get => _radius;
            set
            {
                _radius = value;
            }
        }

        public Circle(string name, double radius) : base(name)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2); // Calculates the area of a circle.
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius; // Calculates the perimeter of a circle.
        }

        public override void PrintInfo()
        {
            // Prints information about the circle.
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Type: Circle");
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
            Console.WriteLine();
        }
    }
}
