namespace HW_8_9
{
    // Trying out Primary Constructor
    public abstract class Shape(string name): IComparable<Shape>
    {
        private readonly string name = name;
        public string Name { get { return name; } }
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Shape? other)
        {   
            if (other == null) return 1;
            return Area().CompareTo(other.Area());
        }
    }
}
