public class Rectangle : IShape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public double Area()
    {
        return Length * Width;
    }
}
