class Homework8b
{
    abstract class Shape : IComparable<Shape>
    {

        private string name;
        public Shape(string name) { this.name = name; }
        virtual public string Name { get { return name; } }
        public abstract double Area() ;
        public abstract double Perimeter();

        public int CompareTo(Shape? other)
        {
            if (this.Perimeter() < other.Perimeter()) return -1;
            if (this.Perimeter() == other.Perimeter()) return 0;
            return 1;
        }

    }

    class Square : Shape
    {
        private int side;

        public Square(string name, int side) : base(name)
        { this.side = side; }

        public int Side { get { return side; } }

        public override double Area() { return side * side; }

        public override double Perimeter() { return side * 4; }

        public override string Name => "Square." + base.Name;

    }

    class Circle : Shape
    {
        private int radius;

        public Circle(string name, int radius) : base(name)
        { this.radius = radius; }

        public int Radius { get { return radius; } }

        public override double Area() { return radius * radius * Math.PI ; }

        public override double Perimeter() { return 2 * radius * Math.PI; }

        public override string Name => "Circle." + base.Name;
    }


    static void Main()
    {

        try
        {
            int AmountShapes = 10;
            string TypeShape;

            List<Shape> Shapes = new List<Shape>();

            Console.WriteLine("Insert {0} Shapes", AmountShapes);

            for (int i = 0; i < AmountShapes; i++)
            {

                Console.WriteLine("Insert 'circle' or 'square' to choose the shape");
                TypeShape = Console.ReadLine().ToLower();

                string name;


                switch (TypeShape)
                {
                    case "circle":

                        Console.WriteLine("Insert the radius length of the circle");
                        int radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert the Name the circle");
                        name = Console.ReadLine();
                        Shapes.Add(new Circle(name, radius));
                        break;
                    case "square":

                        Console.WriteLine("Insert the side length of the square");
                        int Side = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Insert the Name the Square");
                        name = Console.ReadLine();
                        Shapes.Add(new Square( name , Side));

                        break;
                    default:
                        Console.WriteLine("!!!WRONG entry, #{0}¡¡ Please try to insert the correct data again. ( circle or square )", TypeShape);
                        i--;
                        break;
                }
            }


            for (int i = 0; 1 < Shapes.Count(); i++)
            {
                if (Shapes[0].CompareTo(Shapes[1]) == -1)
                { Shapes.Remove(Shapes[0]); }
                else
                { Shapes.Remove(Shapes[1]); }

            }

            Shape LargestPerimeter = Shapes.First();
            Console.WriteLine(" The Largest perimeter is ");
            Console.WriteLine("Name:{0}", LargestPerimeter.Name);

     
         
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }


    }


}



