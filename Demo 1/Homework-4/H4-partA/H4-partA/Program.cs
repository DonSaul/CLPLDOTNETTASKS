using Homework_4.src.Core.Application.Services;
using Homework_4.src.Core.Entities;
using Homework_4.src.Core.Presentation;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{

    static void Main(string[] args)
    {
        // 1) Create list of Shape
        var shapes = new List<Shape>
        {
            new Circle("Custom Circle", 1),
            new Circle(3),

            new Square("Custom Square", 1),
            new Square ("aBig Square",1),
            new Square("a", 2),
            new Square("Normal Square", 0.5),
        
        };


        var solver = new Solver();
        var userDisplay = new UserDisplay();


        // PART A
        // Filter and write shapes with area in range [10,100] to a file
        var shapesWithAreaInRange = solver.FilterShapesByArea(shapes, 10, 100);
        userDisplay.WriteShapesToFile("ShapesWithAreaInRange.txt", shapesWithAreaInRange);
        Console.WriteLine("\nFiltered shapes by area ranging between 10 and 100... Done.");
Console.WriteLine("\nResult saved in 'ShapesWithNameContainingA.txt'.");

        // Filter and write shapes with 'a' in their name to a file
        var shapesWithNameContainingA = solver.FilterShapesByName(shapes, "a");
        userDisplay.WriteShapesToFile("ShapesWithNameContainingA.txt", shapesWithNameContainingA);
        Console.WriteLine("\nFiltering shapes to find those with the letter 'a' in their name... Done.");
        Console.WriteLine("\nResult saved in 'ShapesWithNameContainingA.txt'.");


        Console.WriteLine("\nRemoving shapes with perimeter less than 5... Wait a moment please");

        // Display original list
        Console.WriteLine("\nOriginal List:");
        userDisplay.DisplayShapes(shapes);

        // Remove shapes with perimeter less than 5
        Console.WriteLine("\nRemoving shapes with perimeter less than 5... Wait a moment please");
        solver.RemoveShapesByPerimeter(ref shapes, 5);

        // Display result
        Console.WriteLine("\nResult:");
        userDisplay.DisplayShapes(shapes);

        Console.WriteLine("\nMany thanks for trying this program. Process terminated");


        // PART B

    }
}
