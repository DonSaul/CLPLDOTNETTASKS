public class Room<T> where T : IShape
{
    public double Height { get; set; }
    public T Floor { get; set; }

    public double Volume()
    {
        return Floor.Area() * Height;
    }
}
public class Room<T> : ICloneable where T : IShape, ICloneable
{
    public object Clone()
    {
        return new Room<T>
        {
            Height = this.Height,
            Floor = (T)this.Floor.Clone()
        };
    }
}
public class Room<T> : IComparable<Room<T>> where T : IShape
{
    public int CompareTo(Room<T> other)
    {
        return this.Floor.Area().CompareTo(other.Floor.Area());
    }
}