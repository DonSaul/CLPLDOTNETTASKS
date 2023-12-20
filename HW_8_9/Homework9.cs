using HW_8_9;
using System.Linq;
using System.Net;
internal class Homework9
{
    public static void TaskA()
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

        Console.WriteLine("Selecting shapes with area between 10 and 100");
        IEnumerable<Shape> shapeQuery = from s in shapes where s.Perimeter() >= 10 && s.Perimeter() <= 100 select s;
        using (StreamWriter writer = new("shapes_by_area.txt", false))
        {
            foreach (Shape shape in shapeQuery)
            {
                Console.WriteLine(shape.Name);
                writer.WriteLine("{0}, {1}", shape.Name, shape.Area());
            }
        }
        Console.WriteLine("Written to shapes_by_area.txt\n");

        Console.WriteLine("Selecting shapes with an 'a' in its name");
        shapeQuery = from s in shapes where s.Name.Contains('a') select s;
        using (StreamWriter writer = new("shapes_with_a.txt", false))
        {
            foreach (Shape shape in shapeQuery)
            {
                Console.WriteLine(shape.Name);
                writer.WriteLine(shape.Name);
            }
        }
        Console.WriteLine("Written to shapes_with_a.txt\n");

        Console.WriteLine("Filtering shapes by perimeter >= 5:");
        shapeQuery = from s in shapes where s.Perimeter() >=5 select s;
        shapes = shapeQuery.ToList();
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0}, {1:F3}", shape.Name, shape.Perimeter());
        }
        Console.WriteLine("Done!!!");
    }
    public static void TaskB()
    {
        string URL = "https://raw.githubusercontent.com/AcencioMauricioIcinf/DaoFactory/master/DaoDriver.java";
        string[] lines;

        Console.WriteLine("Reading from online file " + URL);
        using (HttpClient client = new())
        {
            lines = client.GetStringAsync(URL).Result.Split('\n');
        }
        Console.WriteLine("Done! Read a total of {0} lines of text, in fact:", lines.Length);

        //uint maxLen = 0, minLen = uint.MaxValue;
        //uint maxIdx = 0, minIdx = 0;
        //for (uint i = 0; i < lines.Length; i++)
        //{
        //    uint len = (uint)lines[i].Length;
        //    Console.WriteLine("Line {0} has {1} characters.", (i + 1), len);
        //    if (len > maxLen)
        //    {
        //        maxLen = len;
        //        maxIdx = i;
        //    }
        //    if (len < minLen)
        //    {
        //        minLen = len;
        //        minIdx = i;
        //    }
        //}

        var linesQuery = lines.Select((line, i) => new { Num = i, Count = line.Length });
        foreach (var line in linesQuery)
        {
            Console.WriteLine("Line {0} has {1} characters.", (line.Num), line.Count);
        }
        var maxLine = linesQuery.MaxBy(line => line.Count);
        var minLine = linesQuery.MinBy(line => line.Count);
        Console.WriteLine("Thus making lines {0} and {1} the longest and shortest of the file, respectively.", maxLine.Num, minLine.Num);

        var varLines = lines.Where(line => line.Trim() == "var");
        Console.WriteLine("\nAlso, there are {0} lines of only \"var\"", varLines.Count());
    }
}
