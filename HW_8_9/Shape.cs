namespace HW_8_9
{
    // Trying out Primary Constructor
    public abstract class Shape(string name)
    {
        private string name = name;
        public string Name { get { return name; } }
        public abstract double Area();
        public abstract double Perimeter();
    }
}
