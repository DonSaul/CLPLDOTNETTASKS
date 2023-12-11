public abstract class Shape
{
     private string name;

    public double Name
    {
        get { return name; }
        set { name = value; }
    }

    public abstract double Area();
    public abstract double Perimeter();

    public override string ToString()
    {
        return $"Shape: {Name}";
    }

}

