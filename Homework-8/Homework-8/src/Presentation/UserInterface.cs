public static class UserInterface
{
    public static List<Shape> GetShapesFromUser()
    {
        List<Shape> shapes = new List<Shape>();
        Console.WriteLine("Enter each shape in the format 'ShapeType [Optional: Name] Dimension'.");
        Console.WriteLine("Examples: 'Circle MyCircle 1.5' or 'Square 124.2'.");
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
}
