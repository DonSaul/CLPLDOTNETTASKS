using System;
namespace Homework_4.src.Core.Entities
{
    public class Circle : Shape
    {
        // Field
        private double radius;

        // Property
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Constructor
        public Circle(double radius) : base("Circle")
        {
            this.Radius = radius;
        }

        // Overridden Area method
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        // Overridden Perimeter method
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}

