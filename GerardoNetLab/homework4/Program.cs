using HW4try;
Console.WriteLine("Hello, World!");

List<Shape> shapes = new List<Shape>
        {
            new Circle(5),
            new Square(3),
            new Circle(7),
            new Square(4),
            new Circle(3),
            new Square(0.1)
        };
// Find and write into the file shapes with area from range [10,100]
var filteredByArea = shapes.Where(shape => shape.GetArea() >= 10 && shape.GetArea() <= 100).ToList();
WriteShapesToFiles.WriteShapesToFile("ShapesByArea.txt", filteredByArea);

// Find and write into the file shapes which name contains the letter 'a'
var filteredByName = shapes.Where(shape => shape.GetName().Contains("a")).ToList();
WriteShapesToFiles.WriteShapesToFile("ShapesByName.txt", filteredByName);

// Find and remove from the list all shapes with perimeter less than 5. Write the resulting list into the Console.
shapes.RemoveAll(shape => shape.GetPerimeter() < 5);
Console.WriteLine("Shapes with perimeter greater than or equal to 5:");
foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}


Console.WriteLine("Sgundo hello world");
string filePath = "Program.cs";

// Read all lines from the file into an array of strings
string[] lines = File.ReadAllLines(filePath);

// Task 1: Count and write the number of symbols
SymbolCounter.CountAndWriteSymbols(lines);

// Task 2: Find the longest and shortest lines
LongestShortestFinder.FindLongestShortestLines(lines);

// Task 3: Find and write lines that consist of the word "var"
VarLineFinder.FindLinesWithVar(lines);
