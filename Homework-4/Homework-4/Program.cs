using Homework_4.src.Core.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1) Create list of Shape
        List<Shape> shapes = new List<Shape>
        {
            new Circle(2), 
            new Square(3), 
        };

        // 2) Find shapes with area in range [10,100] and write to a file
        var shapesWithAreaInRange = shapes.Where(s => s.Area() >= 10 && s.Area() <= 100).ToList();
        File.WriteAllLines("ShapesWithAreaInRange.txt", shapesWithAreaInRange.Select(s => s.ToString()));

        // 3) Find shapes with 'a' in their name and write to a file
        var shapesWithNameContainingA = shapes.Where(s => s.Name.Contains('a')).ToList();
        File.WriteAllLines("ShapesWithNameContainingA.txt", shapesWithNameContainingA.Select(s => s.ToString()));

        // 4) Remove shapes with perimeter less than 5 and write the remaining list to the console
        shapes.RemoveAll(s => s.Perimeter() < 5);
        shapes.ForEach(s => Console.WriteLine(s.ToString()));

        Console.WriteLine("Many thanks for trying this program. Process terminated");
    }
}
