using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Homework9A.Models;

namespace Homework9A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of shapes and fill it with Circle and Square instances
            List<Shape> shapes = new List<Shape>
            {
                new Circle("Circle 1", 3),
                new Circle("Circle 2", 5),
                new Square("Square 1", 4),
                new Square("Square 2", 2),
                new Circle("Circle 3", 6),
                new Square("Square 3", 3.5)
            };

            // Info off all shapes in the list
/*          Console.WriteLine("Info of all shapes in the list:");
            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }*/

            // Find shapes with area between 10 and 100 and write them to a file
            var shapesInRange = shapes.Where(shape => shape.Area() >= 10 && shape.Area() <= 100);
            WriteShapesToFile("ShapesInRange.txt", shapesInRange);

            // Find shapes whose names contain the letter 'a' and write them to a file
            var shapesWithNameA = shapes.Where(shape => shape.Name.Contains("a"));
            WriteShapesToFile("ShapesWithNameA.txt", shapesWithNameA);

            // Remove shapes with perimeter less than 5 and write the resulting list to the Console
            shapes.RemoveAll(shape => shape.Perimeter() < 5);
            Console.WriteLine("Shapes with perimeter >= 5:");
            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }
        }

        // Function to write shapes to a file
        static void WriteShapesToFile(string fileName, IEnumerable<Shape> shapes)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var shape in shapes)
                {
                    writer.WriteLine($"Name: {shape.Name}");
                    writer.WriteLine($"Type: {shape.GetType().Name}");
                    writer.WriteLine($"Area: {shape.Area()}");
                    writer.WriteLine($"Perimeter: {shape.Perimeter()}");
                    writer.WriteLine();
                }
            }
        }
    }
}