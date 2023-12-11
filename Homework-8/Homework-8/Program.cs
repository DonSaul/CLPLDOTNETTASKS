using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = UserInterface.GetShapesFromUser();

        UserInterface.DisplayShapes(shapes);

        // Print the shape with the largest perimeter
        ShapeService.PrintShapeWithLargestPerimeter(shapes);

        // Sort the shapes by area and get the sorted list
        List<Shape> sortedShapes = ShapeService.SortShapesByArea(shapes);

        // Display the sorted list of shapes
        Console.WriteLine("\nShapes sorted by area:");
        UserInterface.DisplayShapes(sortedShapes);
    }
}
