public class Room<T> : ICloneable, IComparable<Room<T>> where T : IShape, ICloneable
{
    public double Height { get; set; }
    public T Floor { get; set; }

    public Room() { }

    public Room(double height, T floor)
    {
        Height = height;
        Floor = floor;
    }

    public double Volume()
    {
        return Floor.Area() * Height;
    }

    public object Clone()
    {
        return new Room<T>(Height, (T)Floor.Clone());
    }

    public int CompareTo(Room<T> other)
    {
        if (other == null) return 1;
        return this.Floor.Area().CompareTo(other.Floor.Area());
    }
}
