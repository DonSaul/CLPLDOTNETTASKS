using System;
using System.Reflection;
using System.Xml.Linq;

public static class UserInterface
{
    public static List<Shape> GetShapesFromUser()
    {
        List<Shape> shapes = new List<Shape>();
        Console.WriteLine("Enter each shape in the format 'ShapeType Dimension'.");
        Console.WriteLine("Examples: 'Square 124.2'.");
        Console.WriteLine("Type 'done' to finish.");


        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "done") break;

            if (InputValidator.IsValidShapeInput(input))
            {
                Shape shape = ShapeFactory.CreateShape(input);
                if (shape != null)
                {
                    shapes.Add(shape);
                }
                else
                {
                    Console.WriteLine("Invalid shape details. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input format. Please try again.");
            }
        }

        return shapes;
    }

    public static void DisplayShapes(List<Shape> shapes)
    {
        Console.WriteLine("List of Shapes:");
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        Console.WriteLine($" {"Type",-12} | {"Radius/Side",-22} | {"Area",-16} | {"Perimeter",-10}");
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
        for (int i = 0; i < shapes.Count; i++)
        {
            Console.WriteLine(DisplayShape(i + 1, shapes[i]));
        }
        Console.WriteLine("---------------------------------------------------------------------------------------------------");
    }
    private static string DisplayShape(int index, Shape shape)
    {
        string type = shape.GetType().Name;
        string name = shape.Name.Length > 15 ? shape.Name.Substring(0, 12) + "..." : shape.Name;
        string dimension = type == "Circle" ? $"Radius: {((Circle)shape).Radius:F2}" : $"Side: {((Square)shape).Side:F2}";
        return $"{index}. {type,-10} | {dimension,-22} | {shape.Area(),-16} | {shape.Perimeter(),-10}";
    }
}
