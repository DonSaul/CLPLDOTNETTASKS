public class Square : Shape
{
    private double side;

    public double Side
    {
        get { return side; }
        set { side = value; }
    }

    // Constructor with name
    public Square(string name, double side) : base(name)
    {
        Side = side;
    }

    // Constructor without name (name is optional)
    public Square(double side) : base("Square")
    {
        Side = side;
    }

    public override string ToString()
    {
        return $"Square (Name: {Name}, Side: {Side:F2}, Area: {Area():F2}, Perimeter: {Perimeter():F2})";
    }

    // Overridden Area method
    public override double Area()
    {
        return Side * Side;
    }


    // Overridden Perimeter method
    public override double Perimeter()
    {
        return 4 * Side;
    }
}


