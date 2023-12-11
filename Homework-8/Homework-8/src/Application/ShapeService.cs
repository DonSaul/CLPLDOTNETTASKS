public static class ShapeService
{
    public static Shape FindShapeWithLargestPerimeter(List<Shape> shapes)
    {
        if (shapes == null || shapes.Count == 0)
            return null;

        return shapes.OrderByDescending(s => s.Perimeter()).FirstOrDefault();
    }

    public static List<Shape> SortShapesByArea(List<Shape> shapes)
    {
      
        shapes.Sort();
        return shapes;
    }
}
