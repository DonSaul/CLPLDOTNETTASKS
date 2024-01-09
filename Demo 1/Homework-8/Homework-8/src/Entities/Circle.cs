public class Circle : Shape
{
    // Field
    private double radius;

    // Property
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    // Constructor with name
    public Circle(string name, double radius) : base(name)
    {
        Radius = radius;
    }

    // Constructor without name (name is optional)
    public Circle(double radius) : base("Circle")
    {
        Radius = radius;
    }

    public override string ToString()
    {
        return $"Circle (Name: {Name}, Radius: {Radius.ToString("F2")}, Area: {Area().ToString("F2")}, Perimeter: {Perimeter().ToString("F2")})";
    }
    // Overridden Area method
    public override double Area()
    {
        return Math.Round(Math.PI * Radius * Radius, 2);
    }

    public override double Perimeter()
    {
        return Math.Round(2 * Math.PI * Radius, 2);
    }
}


