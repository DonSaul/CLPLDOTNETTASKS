namespace HW_8_9
{
    class Circle(string name, double radius) : Shape(name)
    {
        private readonly double radius = radius;
        public override double Area()
        {
            return radius * radius * Math.PI;
        }
        public override double Perimeter()
        {
            return 2 * radius * Math.PI;
        }
    }
}
