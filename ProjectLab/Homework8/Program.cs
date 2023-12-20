using System;
using System.Collections.Generic;
using System.Linq;
using Homework8.Models;

namespace Homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            // Collect information for 10 different shapes.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter data for shape {i + 1}:");
                Console.Write("Enter shape type (Circle / Square): ");
                string shapeType = Console.ReadLine();

                Console.Write("Enter shape name: ");
                string name = Console.ReadLine();

                if (shapeType.ToLower() == "circle")
                {
                    Console.Write("Enter radius: ");
                    if (double.TryParse(Console.ReadLine(), out double radius) && radius>0)
                    {
                        Circle circle = new Circle(name, radius);
                        shapes.Add(circle);
                    }
                    else
                    {
                        Console.WriteLine("Invalid radius. Please enter a valid number.");
                        i--;
                    }
                }
                else if (shapeType.ToLower() == "square")
                {
                    Console.Write("Enter side length: ");
                    if (double.TryParse(Console.ReadLine(), out double side)&& side>0)
                    {
                        Square square = new Square(name, side);
                        shapes.Add(square);
                    }
                    else
                    {
                        Console.WriteLine("Invalid side length. Please enter a valid number.");
                        i--;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid shape type. Please enter Circle or Square.");
                    i--;
                }
            }

            Console.WriteLine("\nShapes Information:");
            // Print information of all shapes.
            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }

            // Find shape with the largest perimeter and print its name.
            var shapeWithLargestPerimeter = shapes.OrderByDescending(s => s.Perimeter()).FirstOrDefault();
            if (shapeWithLargestPerimeter != null)
            {
                Console.WriteLine($"Shape with largest perimeter: {shapeWithLargestPerimeter.Name}");
            }

            Console.WriteLine("\nShapes sorted by area:");
            // Sort shapes by area and then print the obtained list.
            shapes.Sort(); // This will sort the list of shapes using the CompareTo method of the Shape class.
            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }
        }
    }
}
