using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = UserInterface.GetShapesFromUser();

        UserInterface.DisplayShapes(shapes);

        // Print the shape with the largest perimeter
        Shape largestShape = ShapeService.FindShapeWithLargestPerimeter(shapes);
        Console.WriteLine($"\nShape with the largest perimeter: {largestShape.Name} (perimeter: {largestShape.Perimeter():N2})");
        
        // Sort the shapes by area and get the sorted list
        List<Shape> sortedShapes = ShapeService.SortShapesByArea(shapes);

        // Display the sorted list of shapes
        Console.WriteLine("\nShapes sorted by area:");
        UserInterface.DisplayShapes(sortedShapes);
    }
}
