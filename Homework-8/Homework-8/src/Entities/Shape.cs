
public abstract class Shape
{
    public string Name { get; protected set; }

    protected Shape(string name)
    {
        Name = name;
    }
     public int CompareTo(Shape other)
    {
        if (other == null) return 1;

        return Area().CompareTo(other.Area());
    }
    public abstract double Area();
    public abstract double Perimeter();

    public override string ToString()
    {
        return $"Shape: {Name}";
    }

}

