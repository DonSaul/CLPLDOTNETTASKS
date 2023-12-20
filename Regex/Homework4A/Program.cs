using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle("Circle1", 0.3),
                new Circle("Circle2", 5),
                new Circle("Circle3", 7.8),
                new Square("Square1", 4),
                new Square("Square2", 1),
                new Square("Square3", 6.3)
            };

            var shapesInRange = shapes.Where(s => s.Area() >= 10 && s.Area() <= 100).ToList();
            WriteShapesToFile(shapesInRange, "ShapesInRange.txt");

            var shapesWithNameA = shapes.Where(s => s.Name.Contains("a")).ToList();
            WriteShapesToFile(shapesWithNameA, "ShapesWithNameA.txt");

            shapes = shapes.Where(s => s.Perimeter() >= 5).ToList();
            Console.WriteLine("Shapes with perimeter equal or bigger than 5:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name} - Perimeter: {shape.Perimeter()}, Area: {shape.Area()}");
            }

            Console.WriteLine("");
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        static void WriteShapesToFile(List<Shape> shapes, string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var shape in shapes)
                {
                    writer.WriteLine($"{shape.Name} - Perimeter: {shape.Perimeter()}, Area: {shape.Area()}");
                }
            }
        }
    }
}
            