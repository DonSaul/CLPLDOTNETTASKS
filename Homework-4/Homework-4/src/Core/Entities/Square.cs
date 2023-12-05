using System;
namespace Homework_4.src.Core.Entities
{
    public class Square : Shape
    {
        // Field
        private double side;

        // Property
        public double Side
        {
            get { return side; }
            set { side = value; }
        }

        // Constructor
        public Square(double side) : base("Square")
        {
            this.Side = side;
        }

        public override string ToString()
        {
            return $"Square with side {Side}, Area: {Area()}, Perimeter: {Perimeter()}";
        }

        // Overridden Area method
        public override double Area()
        {
            return Side * Side;
        }


        // Overridden Perimeter method
        public override double Perimeter()
        {
            return 4 * Side;
        }
    }
}

