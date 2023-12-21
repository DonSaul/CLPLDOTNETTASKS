namespace Entrypoint
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }
  }

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

  internal class Program
  {
    private static void Main(string[] args)
    {
      //   Part1.Functions.MainFunction(args);
      //   Part2.Functions.MainFunction(args);
      // string filepath = "./test.txt";
      // bool doesFileExist = File.Exists(filepath);
      // var people = new List<Person>();
      var shapes = new List<Shape>();

      for (int i = 0; i < 5; i++)
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
      Console.WriteLine();

      int highestPerimeterIndex = 0;

      foreach (Shape shape in shapes)
      {
        Console.WriteLine($"{shape.Name}. Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");

        if (shape.Perimeter() > shapes[highestPerimeterIndex].Perimeter())
        {
          highestPerimeterIndex = shapes.IndexOf(shape);
        }
      }

      Console.WriteLine($"\nThe shape with the highest perimeter is a {shapes[highestPerimeterIndex].Name} with a perimeter of {shapes[highestPerimeterIndex].Perimeter()}");

      shapes.Sort();

      Console.WriteLine("\nSorted by area:");
      foreach (Shape shape in shapes)
      {
        Console.WriteLine($"{shape.Name}. Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
      }


      // if (doesFileExist)
      // {
      //   Console.WriteLine("File exists!");

      //   string[] lines = File.ReadAllLines(filepath);
      //   if (lines.Length == 0)
      //   {
      //     Console.WriteLine("File is empty!");
      //   }
      //   else
      //   {
      //     // Console.WriteLine("File is not empty!");
      //     foreach (string line in lines)
      //     {
      //       people.Add(new Person(line.Split(',')[0], int.Parse(line.Split(',')[1])));
      //     }

      //     foreach (Person person in people)
      //     {
      //       Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
      //     }
      //   }
      // }
      // else
      // {
      //   Console.WriteLine("File does not exist! Creating file...");
      //   File.Create("test.txt");
      // }

    }

  }
}

