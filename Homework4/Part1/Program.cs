internal class Program
{

  public abstract class Shape : IComparable<Shape>
  {
    public abstract string Name { get; set; }
    public abstract double Area();
    public abstract double Perimeter();

    public int CompareTo(Shape? other)
    {
      if (other == null) return 1;

      return Area().CompareTo(other.Area());
    }
  }

  public class Circle : Shape
  {
    public override string Name { get; set; } = "Circle";

    public double Radius { get; set; }

    public Circle(double radius)
    {
      Radius = radius;
    }

    public override double Area()
    {
      return Math.PI * Radius * Radius;
    }

    public override double Perimeter()
    {
      return 2 * Math.PI * Radius;
    }

  }

  public class Square : Shape
  {
    public override string Name { get; set; } = "Square";


    public double Side { get; set; }

    public Square(double side)
    {
      Side = side;
    }

    public override double Area()
    {
      return Side * Side;
    }

    public override double Perimeter()
    {
      return 4 * Side;
    }
  }
  private static void Main(string[] args)
  {
    string filepath = "./Shapes.txt";
    bool doesFileExist = File.Exists(filepath);

    if (!doesFileExist) File.Create("Shapes.txt");

    doesFileExist = File.Exists(filepath);


    var shapes = new List<Shape>();

    for (int i = 0; i < 3; i++)
    {
      do
      {
        Console.Write("Enter radius: ");
        bool parseR = double.TryParse(Console.ReadLine(), out double radius);
        if (parseR)
        {
          shapes.Add(new Circle(radius));
          break;
        }

      } while (true);

      do
      {
        Console.Write("Enter side: ");
        bool parseS = double.TryParse(Console.ReadLine(), out double side);
        if (parseS)
        {
          shapes.Add(new Square(side));
          break;
        }

      } while (true);
    }

    if (doesFileExist)
    {
      Console.Write("\nFile exists! Saving to file shapes with a name that contains the letter 'a', or have an area greater than 10 and lower than 100...");
      using StreamWriter sw = File.CreateText(filepath);
      foreach (var shape in shapes)
      {
        if (shape.Area() > 10 && shape.Area() < 100 || shape.Name.Contains('a'))
        {
          sw.Write(shape.Name + ",");
          sw.Write(Math.Round(shape.Area(), 2) + ",");
          sw.WriteLine(Math.Round(shape.Perimeter(), 2));
        }
      }

      shapes.RemoveAll(shape => shape.Perimeter() < 5);

      Console.WriteLine("\nShapes with a perimeter greater than 5: ");
      foreach (var shape in shapes)
      {
        Console.WriteLine(shape.Name + " " + Math.Round(shape.Area(), 2) + " " + Math.Round(shape.Perimeter(), 2));
      }

    }

  }
}