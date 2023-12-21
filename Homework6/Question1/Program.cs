// using System.Collections.Generic;

namespace Solution
{
  public interface IShape
  {
    public double Area()
    {
      return 0;
    }
    public object Clone();

  }

  public class Rectangle : IShape
  {
    private double length;
    public double Length
    {
      get { return length; }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Length must be positive.");
        length = value;
      }
    }

    private double width;
    public double Width
    {
      get { return width; }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Width must be positive.");
        width = value;
      }
    }

    public object Clone()
    {
      return new Rectangle
      {
        Length = this.Length,
        Width = this.Width
      };
    }

    public double Area()
    {
      return this.Length * this.Width;
    }
  }

  public class Trapezoid : IShape
  {
    private double length1;
    public double Length1
    {
      get { return length1; }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Length must be positive");
        length1 = value;
      }
    }
    private double length2;
    public double Length2
    {
      get { return length2; }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Length must be positive");
        length2 = value;

      }
    }
    private double width;
    public double Width
    {
      get { return width; }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Length must be positive");

        width = value;
      }
    }

    public object Clone()
    {
      return new Trapezoid
      {
        Length1 = this.Length1,
        Length2 = this.Length2,
        Width = this.Width
      };
    }

    public double Area()
    {
      return (Length1 + Length2) / 2 * Width;
    }
  }

  public class Room<T> : ICloneable, IComparable where T : IShape
  {
    private double height;
    public double Height
    {
      get { return height; }
      set
      {
        if (value < 0)
          throw new ArgumentOutOfRangeException(nameof(value), "Length must be positive");

        height = value;
      }
    }
    public T? Floor { get; set; }

    public double Volume()
    {
      if (Floor == null)
      {
        throw new ArgumentNullException(nameof(Floor), "Floor must be defined");
      }
      return Floor.Area() * Height;
    }

    public object Clone()
    {
      if (Floor == null)
      {
        throw new ArgumentNullException(nameof(Floor), "Floor must be defined");
      }
      return new Room<T>
      {
        Height = this.Height,
        Floor = (T)this.Floor.Clone()
      };
    }

    public int CompareTo(object? obj)
    {
      if (obj == null) return 1;

      if (Floor == null || obj == null)
      {
        throw new ArgumentNullException(nameof(Floor), "Floor must be defined");
      }

      if (obj is Room<T> otherRoom && otherRoom.Floor != null)
        return this.Floor.Area().CompareTo(otherRoom.Floor.Area());
      else
        throw new ArgumentException("Object is not a Room");
    }
  }

  public class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
  {
    public int Compare(Room<T>? room1, Room<T>? room2)
    {
      if (room1 == null || room2 == null)
        throw new ArgumentException("Object is not a Room");

      return room1.Volume().CompareTo(room2.Volume());
    }
  }

}
