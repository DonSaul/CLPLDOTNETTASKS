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
            new Circle("C3", 45),
            new Square("S1", 34),
            new Square("S2", 45.2),
            new Square("S3", 80.6)
        ];
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0}, perimeter & area {1:F3} & {2:F3}", shape.Name, shape.Perimeter(), shape.Area());
        }
        Console.WriteLine("Done.\n");


    }
}
