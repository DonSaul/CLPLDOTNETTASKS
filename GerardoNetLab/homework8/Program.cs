using netLabHW8;

List<Shape> shapes = new List<Shape>();

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Ingresa los detalles para la figura {i + 1}:");
    Console.Write("Nombre: ");
    string name = Console.ReadLine();
    Console.Write("Tipos (1 Círculo, 2 Cuadrado): ");
    int type = int.Parse(Console.ReadLine());

    if (type == 1)
    {
        Console.Write("Radio: ");
        double radius = double.Parse(Console.ReadLine());
        shapes.Add(new Circle(name, radius));
    }
    else if (type == 2)
    {
        Console.Write("Lados: ");
        double side = double.Parse(Console.ReadLine());
        shapes.Add(new Square(name, side));
    }
    else
    {
        Console.WriteLine("Tipo inválido, ingresa 1 para círculo y 2 para cuadrado");
        i--;
    }
}

Console.WriteLine("\nInformación de figuras:");

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Nombre: {shape.Name}, Área: {shape.Area()}, Perímetro: {shape.Perimeter()}");
}

Shape maxPerimeterShape = shapes[0];

for (int i = 1; i < shapes.Count; i++)
{
    if (shapes[i].Perimeter() > maxPerimeterShape.Perimeter())
    {
        maxPerimeterShape = shapes[i];
    }
}

Console.WriteLine($"\nFigura con mayor perímetro: {maxPerimeterShape.Name}");

shapes.Sort();

Console.WriteLine("\nFiguras ordenadas por área:");

foreach (Shape shape in shapes)
{
    Console.WriteLine($"Nombre: {shape.Name}, Área: {shape.Area()}, Perímetro: {shape.Perimeter()}");
}