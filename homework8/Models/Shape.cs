//**Creacion de clase abstracta Shape
public abstract class Shape : IComparable<Shape>
{
    //**Definicion de atributos
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    //**Constructor de la clase Shape con un solo parametro
    public Shape(string name)
    {
        this.name = name;
    }

    //**Metodo abstracto para calcular el area
    public abstract double Area();
    //**Metodo abstracto para calcular el perimetro
    public abstract double Perimeter();

    //**Metodo para comparar dos figuras por area
    public int CompareTo(Shape other)
    {
        if (other == null)
        {
            return 1;
        }
        else
        {
            return this.Area().CompareTo(other.Area());
        }
    }
}

//Creamos clase Circulo derivado de Shape
public class Circle : Shape
{
    //**Definicion de atributos
    private double radius;

    //**Constructor de la clase Circle con dos parametros
    public Circle(string name, double radius) : base(name)
    {
        this.radius = radius;
    }

    //Sobreescribimos metodo Area
    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    //Sobreescribimos metodo Perimeter
    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

//Creamos clase Rectangulo derivado de Shape
public class Square : Shape
{
    //**Definicion de atributos
    private double side;

    //**Constructor de la clase Square con dos parametros
    public Square(string name, double side) : base(name)
    {
        this.side = side;
    }

    //Sobreescribimos metodo Area
    public override double Area()
    {
        return Math.Pow(side, 2);
    }

    //Sobreescribimos metodo Perimeter
    public override double Perimeter()
    {
        return 4 * side;
    }
}
