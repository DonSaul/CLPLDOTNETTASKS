class Homework4PartA
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;

        public Shape(string name)
        { this.name = name; }

        virtual public string Name { get { return name; } }
        public abstract double Area();
        public abstract double Perimeter();

        // Implement the CompareTo method for sorting by area using IComparable
        public int CompareTo(Shape other)
        {
            if (other == null)
                return 1;
            return this.Area().CompareTo(other.Area());
        }
    }

    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius, string name) : base(name)
        { this.radius = radius; }

        public override double Area()
        {
            return (Math.PI * radius * radius);
        }

        public override double Perimeter()
        {
            return (2 * Math.PI * radius);
        }

    }

    public class Square : Shape
    {
        private double side;

        public Square(double side, string name) : base(name)
        { this.side = side; }

        public override double Area()
        {
            return (side * side);
        }

        public override double Perimeter()
        {
            return (side * 4);
        }
    }

    // Helper method to write shapes to a file
    static void WriteShapesToFile(string fileName, List<Shape> shapes)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var shape in shapes)
            {
                writer.WriteLine($"{shape.Name}: Area = {shape.Area()}, Perimeter = {shape.Perimeter()}");
            }
        }
    }

    static void Main(string[] args)
    {
        // Homework 4 Part A 
        // Use classes Shape, Circle, Square
        // Use Linq and string functions to complete next tasks

        // Part 1: Create list of Shape and fill it with 6 different shapes (Circle and Square).
        Console.WriteLine("Homework 4 Part A:");
        Console.WriteLine("Part 1A: Create a list of Shape and fill it with 6 different shapes");
        Console.WriteLine("--------------------------");

        // Creating a list of Shape and fill it with 6 different shapes 
        List<Shape> shapesList = new List<Shape>();

        shapesList.Add(new Square(10, "Shape 1: Square"));
        shapesList.Add(new Square(1, "Shape 2: Square"));
        shapesList.Add(new Square(30, "Shape 3: Square"));

        shapesList.Add(new Circle(7, "Shape 4: Circle"));
        shapesList.Add(new Circle(14, "Shape 5: Circle"));
        shapesList.Add(new Circle(2, "Shape 6: Circle"));

        // Part 2: Find and write into the file shapes with area from range [10,100]

        var shapesInRange = shapesList.Where(shape => shape.Area() >= 10 && shape.Area() <= 100).ToList();
        WriteShapesToFile("ShapesInRange.txt", shapesInRange);

        // Part 3: Find and write into the file shapes which name contains letter 'a'

        var shapesWithNameContainingA = shapesList.Where(shape => shape.Name.Contains("a", StringComparison.OrdinalIgnoreCase)).ToList();
        WriteShapesToFile("ShapesWithNameContainingA.txt", shapesWithNameContainingA);

        // Part 4: Find and remove from the list all shapes with perimeter less than 5. Write the resulting list into Console

        shapesList.RemoveAll(shape => shape.Perimeter() < 5);
        Console.WriteLine("Shapes with perimeter greater than or equal to 5:");
        foreach (var shape in shapesList)
        {
            Console.WriteLine($"{shape.Name}: Area = {shape.Area()}, Perimeter = {shape.Perimeter()}");
        }

        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();
    }
}