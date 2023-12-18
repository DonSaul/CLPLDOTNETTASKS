namespace HW_8_9
{
    class Square(string name, double side) : Shape(name)
    {
        private double side = side;
        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return side * 4;
        }
    }
}
