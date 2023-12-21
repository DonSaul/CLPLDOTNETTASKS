class Homework8
{
    public abstract class Shape : IComparable<Shape>
    {
        private string name;
        
        public Shape(string name)
        { this.name = name; }

        virtual public string Name { get { return name; } }
        public abstract double Area();
        public abstract double Perimeter();

        // Implement the CompareTo method for sorting by area using IComparable
        public int CompareTo(Shape other)
        {
            if (other == null)
                return 1;
            return this.Area().CompareTo(other.Area());
        }
    }

    public class Circle : Shape
    {
        private double radius; 
        
        public Circle(double radius, string name) : base(name)
        {this.radius = radius; }

        public override double Area()
        {
            return (Math.PI * radius * radius);
        }

        public override double Perimeter()
        {
            return (2 * Math.PI * radius);
        }
    }


    public class Square : Shape
    {
        private double side;

        public Square(double side, string name) : base(name)
        { this.side = side; }

        public override double Area()
        {
            return (side * side);
        }

        public override double Perimeter()
        {
            return (side * 4);
        }
    }

    static void Main(string[] args)
    {

        //Homework 8
        //Part 1) Create abstract class Shape with field name and property Name.

        //Add constructor with 1 parameter and abstract methods Area() and Perimeter(),
        //which can return area and perimeter of shape; 

        //classes Circle, Square derived from Shape with field radius(for Circle) and side(for Square).
        //Add necessary constructors, properties to these classes, override methods from abstract class Shape. 

        Console.WriteLine("Homework8 ");
        Console.WriteLine("-----------------------------------------");

        //a) In Main() create list of Shape, then ask user to enter data of 10 different shapes.
        //Write name, area and perimeter of all shapes. 

        List<Shape> shapes = new List<Shape>();

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter value of shape {0}", 1 + i);

            string characterString = "";
            bool isValidInputString = false;

            //While loop until user enters a valid name 
            while (!isValidInputString)
            {
                Console.WriteLine("Enter C if its a circle or S if its a square: ");
                string inputString = Console.ReadLine();

                // Check if the string is valid:
                // - Ensure it is not null or has white spaces
                // - To ensure all values are letters 
                isValidInputString = !string.IsNullOrWhiteSpace(inputString) && inputString.All(char.IsLetter)
                    && (inputString.Equals("C") || inputString.Equals("S"));

                if (isValidInputString)
                {
                    characterString = inputString;
                }
            }

            double number = 0;
            bool isValidInputNumber = false;

            if (characterString.Equals("S"))
            {
                while (!isValidInputNumber)
                {
                    Console.WriteLine("Enter the side of the square: ");
                    string inputNumber = Console.ReadLine();
                    isValidInputNumber = double.TryParse(inputNumber, out number);
                }
                shapes.Add(new Square(number, $"Shape{1 + i}: Square"));
            }

            if (characterString.Equals("C"))
            {
                while (!isValidInputNumber)
                {
                    Console.WriteLine("Enter the radius of the circle: ");
                    string inputNumber = Console.ReadLine();
                    isValidInputNumber = double.TryParse(inputNumber, out number);
                }
                shapes.Add(new Circle(number, $"Shape{1 + i}: Circle"));
            }
            Console.WriteLine("-----------------------------------------");
        }

        foreach (var shape in shapes)
        {
            Console.WriteLine("{0} with values:", shape.Name);
            Console.WriteLine("Area: {0}", shape.Area());
            Console.WriteLine("Perimeter: {0}", shape.Perimeter());
            Console.WriteLine("-----------------------------------------");
        }

        //b)Find shape with the largest perimeter using LINQ
        Shape shapeWithLargestPerimeter = shapes.OrderByDescending(s => s.Perimeter()).FirstOrDefault();

        Console.WriteLine("{0} has the largest perimeter", shapeWithLargestPerimeter.Name);
        Console.WriteLine("The perimeter length is: {0}", shapeWithLargestPerimeter.Perimeter());
        Console.WriteLine("-----------------------------------------");

        //c)Sort shapes by area and print obtained list (Remember about IComparable)
        shapes.Sort();

        //Print the sorted list
        Console.WriteLine("Sorted shapes by area:");
        foreach (var shape in shapes)
        {
            Console.WriteLine("{0} with area: {1}", shape.Name, shape.Area());
        }

        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();
    }
}