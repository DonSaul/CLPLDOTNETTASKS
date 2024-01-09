public static class ShapeFactory
{
    public static Shape CreateShape(string input)
    {
        var parts = input.Split(' ');
        string shapeType = parts[0].ToLower();
        double dimension = double.Parse(parts[parts.Length - 1]);
        string name = parts.Length == 3 ? parts[1] : shapeType;

        switch (shapeType)
        {
            case "circle":
                return new Circle(name, dimension);
            case "square":
                return new Square(name, dimension);
            default:
                return null;
        }
    }
}
