using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = UserInterface.GetShapesFromUser();

        // Print all shapes
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape);
        }

        // Find shape with the largest perimeter
        var shapeWithLargestPerimeter = shapes.OrderByDescending(s => s.Perimeter()).FirstOrDefault();
        Console.WriteLine($"Shape with the largest perimeter: {shapeWithLargestPerimeter?.Name}");

        // Sort shapes by area
        var sortedShapes = shapes.OrderBy(s => s.Area()).ToList();
        foreach (var shape in sortedShapes)
        {
            Console.WriteLine(shape);
        }
    }
}
