using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4try
{
    internal class Square: Shape
    {
        public double SideLength { get; set; }

        public Square(double sideLength)
        {
            SideLength = sideLength;
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public override string GetName()
        {
            return "Square";
        }

        public override string ToString()
        {
            return $"{GetName()} - Side Length: {SideLength}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
        }
    }
}
