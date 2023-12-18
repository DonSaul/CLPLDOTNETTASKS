public class Trapezoid : IShape
{
    public double Length1 { get; set; }
    public double Length2 { get; set; }
    public double Width { get; set; }

    public double Area()
    {
        return 0.5 * (Length1 + Length2) * Width;
    }
}
