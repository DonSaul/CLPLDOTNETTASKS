using System;
using System.Reflection;
using System.Xml.Linq;

public static class UserInterface
{
    public static List<Shape> GetShapesFromUser()
    {
        List<Shape> shapes = new List<Shape>();
        Console.WriteLine("Enter each shape in the format 'ShapeType Dimension'.");
        Console.WriteLine("Example: 'Square 124.2'.");
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
        string dimension = GetDimensionString(shape);
        string area = $"{shape.Area():N2}"; // N2 for number formatting with commas and 2 decimal places
        string perimeter = $"{shape.Perimeter():N2}";

        return $"{index}. {type,-10} | {dimension,-20} | {area,-20} | {perimeter,-15}";
    }

    private static string GetDimensionString(Shape shape)
    {
        switch (shape)
        {
            case Circle c:
                return $"Radius: {c.Radius:N2}";
            case Square s:
                return $"Side: {s.Side:N2}";
            default:
                return "N/A";
        }
    }
}
