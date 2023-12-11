public static class ShapeService
{
    public static Shape FindShapeWithLargestPerimeter(List<Shape> shapes)
    {
        if (shapes == null || shapes.Count == 0)
            return null;

        return shapes.OrderByDescending(s => s.Perimeter()).FirstOrDefault();
    }

    public static void PrintShapeWithLargestPerimeter(List<Shape> shapes)
    {
        var shapeWithLargestPerimeter = FindShapeWithLargestPerimeter(shapes);
        if (shapeWithLargestPerimeter != null)
            Console.WriteLine($"\nShape with the largest perimeter: {shapeWithLargestPerimeter.Name} ({shapeWithLargestPerimeter.Perimeter():F2})");
        else
            Console.WriteLine("No shapes to display.");
    }

    public static List<Shape> SortShapesByArea(List<Shape> shapes)
    {
      
        shapes.Sort();
        return shapes;
    }
}
