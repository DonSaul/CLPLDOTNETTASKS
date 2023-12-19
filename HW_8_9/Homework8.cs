using HW_8_9;

class Homework8
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------Homework 8:--------");
        ShowHomework8();
        Console.WriteLine("--------Homework 9:--------");
    }

    private static void ShowHomework8()
    {
        List<Shape> shapes = [];
        Console.WriteLine("Ok, it's your turn to give the raduises and sides for 5 circles and 5 squares:");
        Console.WriteLine("If it's negative (why would you?), we'll ignore it and take the absolute value");
        for (int i = 0; i < 5; i++)
        {
            bool rez;
            double radius;
            do
            {
                Console.Write("Circle {0} > ", i + 1);
                string? s = Console.ReadLine();
                rez = Double.TryParse(s, out radius);
                if (!rez)
                {
                    Console.WriteLine("Not a number! Try again.");
                }
            } while (!rez);
            shapes.Add(new Circle("Circle " + i.ToString(), Math.Abs(radius)));
        }
        for (int i = 0; i < 5; i++)
        {
            bool rez;
            double side;
            do
            {
                Console.Write("Square {0} > ", i + 1);
                string? s = Console.ReadLine();
                rez = Double.TryParse(s, out side);
                if (!rez)
                {
                    Console.WriteLine("Not a number! Try again.");
                }
            } while (!rez);
            shapes.Add(new Circle("Square " + i.ToString(), Math.Abs(side)));
        }
        Console.WriteLine();

        Console.WriteLine("Great! Here are the shapes we've just created:");
        Console.WriteLine("Shape:         Area (u^2):    Perimeter:");
        double maxPerimeter = 0;
        sbyte maxIdx = -1;
        for (sbyte i = 0;i < shapes.Count;i++)
        {
            Shape shape = shapes[i];
            Console.WriteLine("{0,-15}{1,-15:F3}{2:F3}", shape.Name, shape.Area(), shape.Perimeter());
            if (shape.Perimeter() > maxPerimeter)
            {
                maxPerimeter = shape.Perimeter();
                maxIdx = i;
            }
        }
        Console.WriteLine();
        Console.WriteLine("And out of theese, {0} has the largest perimeter!", shapes[maxIdx].Name);
        Console.WriteLine();

        Console.WriteLine("Now, sorting theese shapes by its area (ascending)...");
        shapes.Sort();
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0}: {1:F3}", shape.Name, shape.Area());
        }
        Console.WriteLine("Done!!!");
    }
}