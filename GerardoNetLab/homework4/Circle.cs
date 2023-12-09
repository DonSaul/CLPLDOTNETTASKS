﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4try
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string GetName()
        {
            return "Circle";
        }

        public override string ToString()
        {
            return $"{GetName()} - Radius: {Radius}, Area: {GetArea()}, Perimeter: {GetPerimeter()}";
        }
    }

}
