using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Enter data for shape {i + 1}:");

                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Type (1) for Circle, (2) for Square: ");
                    int type = int.Parse(Console.ReadLine());

                    Shape shape = null;

                    switch (type)
                    {
                        case 1:
                            Console.WriteLine("Radius: ");
                            double radius = double.Parse(Console.ReadLine());
                            shape = new Circle(name, radius);
                            break;
                        case 2:
                            Console.WriteLine("Side: ");
                            double side = double.Parse(Console.ReadLine());
                            shape = new Square(name, side);
                            break;
                        default:
                            Console.WriteLine("Not a valid option. Skipping.");
                            break;
                    }

                    shapes.Add(shape);
                }
            } catch (Exception e)
            {
                Console.WriteLine("a fatal error ocurred: " + e.Message);
                Console.WriteLine("Press a key to retry");
                Console.ReadKey();
                Console.Clear();
                Main(args);
            }

            Console.WriteLine("");
            Console.WriteLine("Shapes Information:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name} = Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }

            Shape maxPerimeterShape = shapes[0];
            foreach (var shape in shapes)
            {
                if (shape.Perimeter() > maxPerimeterShape.Perimeter())
                {
                    maxPerimeterShape = shape;
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"Shape with the largest perimeter: {maxPerimeterShape.Name}, with a perimeter of {maxPerimeterShape.Perimeter()}");

            // Sort shapes by area
            shapes.Sort(new ShapeAreaComparer());
            Console.WriteLine("");
            Console.WriteLine("Shapes sorted by area:");
            foreach (var shape in shapes)
            {
                Console.WriteLine($"{shape.Name} - Area: {shape.Area()}, Perimeter: {shape.Perimeter()}");
            }
            Console.WriteLine("Press a key to exit");
            Console.ReadKey();
        }

        public class ShapeAreaComparer : IComparer<Shape>
        {
            public int Compare(Shape x, Shape y)
            {
                return x.Area().CompareTo(y.Area());
            }
        }
    }
}
