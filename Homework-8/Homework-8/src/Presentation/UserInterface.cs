public static class UserInterface
{
    public static List<Shape> GetShapesFromUser()
    {
        List<Shape> shapes = new List<Shape>();
        Console.WriteLine("Enter shapes in the format: 'ShapeType Name Dimension'. For example, 'Circle LittleCircle 1.5' or 'ShapeType Dimension', for example: 'Square 124.2'. Type 'done' to finish.");

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
