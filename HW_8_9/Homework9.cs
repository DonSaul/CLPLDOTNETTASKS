using HW_8_9;
using System.Linq;
internal class Homework9
{
    public void TaskA()
    {
        Console.WriteLine("Creating list of shapes...");
        List<Shape> shapes = [
            new Circle("C1", 6),
            new Circle("C2", 65),
            new Circle("C3", 4.5),
            new Square("S1", 34),
            new Square("S2", 45.2),
            new Square("S3", 8.6)
        ];
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0}, perimeter & area {1:F3} & {2:F3}", shape.Name, shape.Perimeter(), shape.Area());
        }
        Console.WriteLine("Done.\n");

        Console.WriteLine("Selecting shapes with perimeter between 10 and 100");
        var shapeQuery = from s in shapes where s.Perimeter() >= 10 && s.Perimeter() <= 100 select s;
        using (StreamWriter writer = new("shape_by_perimeter.txt", false))
        {
            foreach (Shape shape in shapeQuery)
            {
                Console.WriteLine(shape.Name);
                writer.WriteLine("{0}, {1}", shape.Name, shape.Perimeter());
            }
        }
        Console.WriteLine("Written to shape_by_perimeter.txt\n");
    }
}
