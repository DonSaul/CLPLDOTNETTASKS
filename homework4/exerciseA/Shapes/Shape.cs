using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace
{
    //** Definimos la clase Shape.
    public class Shape
    {
        //** Definimos sus atributos.
        public string Name { get; set; };
        public double Area { get; protected set; };
        public double Perimeter { get; protected set; };

        //** Definimos funciones de la clase Shape
        public abstract void CalculateArea();
        public abstract void CalculatePerimeter();
    }
    //** Definimos la clase Circle como "Subclase" de Shape.
    public class Circle : Shape
    {
        //** Definimos sus atributos.
        public double Radius { get; set; };
        //** Definimos Circle
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
            CalculateArea();
            CalculatePerimeter();
        }
        //** Sobreescribimos las funciones de la clase Shape para Circle.
        public override void CalculateArea()
        {
            //** Calculamos el area del circulo.
            //** Formula: Area = PI * Radio^2
            Area = Math.PI * Math.Pow(Radius, 2);
        }
        public override void CalculatePerimeter()
        {
            //** Calculamos el perimetro del circulo.
            //** Formula: Perimetro = 2 * PI * Radio
            Perimeter = 2 * Math.PI * Radius;
        }
    }
    //** Definimos la clase Square como "Subclase" de Shape.
    public class Square : Shape
    {
        //** Definimos sus atributos.
        public double Side { get; set;}
        //** Definimos Square
        public Square()
        {
            Name = "Square";
            Side = side;
            CalculateArea();
            CalculatePerimeter();
        }
        //** Sobreescribimos las funciones de la clase Shape para Square.
        //** Debido a que sus fórmulas son distintas
        public override void CalculateArea()
        {
            //** Calculamos el area del cuadrado.
            //** Formula: Area = Lado^2
            Area = Math.Pow(Side, 2);
        }
        public override void CalculatePerimeter()
        {
            //** Calculamos el perimetro del cuadrado.
            //** Formula: Perimetro = 4 * Lado
            Perimeter = 4 * Side;
        }
    }
}