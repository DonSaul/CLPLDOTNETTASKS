using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        //** Creamos la lista de objetos de tipo Shape vacia.
        List<Shape> shapes = new List<Shape>();
        //** Le pedimos al usuario que ingrese 10 figuras (ya sean circulos o rectangulos)
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese el nombre de la figura: ");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo de figura (1 para circulo, 2 para rectangulo): ");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("Ingrese el radio del circulo: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                shapes.Add(new Circle(name, radius));
            }
            else if (type == 2)
            {
                Console.WriteLine("Ingrese el lado del rectangulo: ");
                double side = Convert.ToDouble(Console.ReadLine());
                shapes.Add(new Square(name, side));
            }
            else
            {
                Console.WriteLine("Tipo de figura invalido.");
            }
        }
        //** Imprimimos el area y perimetro de cada figura (Para DEBUGGING)
        // Console.WriteLine("---------------------Figuras---------------------");
        // foreach (Shape shape in shapes)
        // {
        //     Console.WriteLine("Figura: " + shape.Name);
        //     Console.WriteLine("Area: " + shape.Area());
        //     Console.WriteLine("Perimetro: " + shape.Perimeter());
        // }

        Console.WriteLine("---------------------Figura con mayor perimetro---------------------");
        // Encuentra la figura con el mayor perímetro e imprime su nombre
        Shape largestPerimeterShape = shapes.OrderByDescending(s => s.Perimeter()).First();
        Console.WriteLine("La figura con el mayor perímetro es: " + largestPerimeterShape.Name + " con un perímetro de: " + largestPerimeterShape.Perimeter());

        Console.WriteLine("---------------------Figuras ordenadas por area---------------------");
        // Ordena las figuras por área
        List<Shape> sortedShapes = shapes.OrderBy(s => s.Area()).ToList();

        // Imprime la lista de figuras ordenadas por área
        Console.WriteLine("Figuras ordenadas por área:");
        shapes.Sort();

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Name + ": " + shape.Area());
        }
    }
}