public static class InputValidator
{
    public static bool IsValidShapeInput(string input)
    {

      // validate 3 parts
        var parts = input.Split(' ');
        if (parts.Length < 2 || parts.Length > 3) return false;

        string shapeType = parts[0].ToLower();

      // validate valid double
        if (!double.TryParse(parts[parts.Length - 1], out double dimension)) return false;

      // validate shape type and size
        return (shapeType == "circle" || shapeType == "square") && dimension > 0;
    }
}
