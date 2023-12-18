using System;
using System.Drawing;
using System.IO;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Homework4a1
{
    abstract class Shape
    {
        public abstract double Area
        {
            get;
        }

        public abstract string Name
        {
            get;
        }

    }

    class Square : Shape
    {
        public int Side;
        public Square(int L) => Side = Math.Abs(L);

        public override double Area { get => Side * Side; }

        public override string Name { get => "Square"; }

        public override string ToString()
        {
            return string.Format("Cuadrado de Side = {0}, area {1}", Side, Area.ToString());
        }
    }

    class Circle : Shape
    {
        public int Radius;
        public Circle(int R) => Radius = Math.Abs(R);

        public override double Area { get => Radius * Radius * Math.PI; }

        public override string Name { get => "Circle"; }

        public override string ToString()
        {
            return string.Format("Circulo de radius = {0}, area {1}", Radius, Area.ToString());
        }
    }


    static void Main()
    {

        try
        {


            int CantidadShapes = 6; 
            string TypeShape;
  
            List<Shape> Shapes = new List<Shape>();

            Console.WriteLine("Insert {0} Shapes", CantidadShapes);

            for (int i = 0; i < CantidadShapes; i++)
            {

                Console.WriteLine("Insert circle or square ");
                TypeShape = Console.ReadLine().ToLower();



                switch (TypeShape)
                {
                    case "circle":
                        Console.WriteLine("Insert the radius length of the circle");
                        Shapes.Add(new Circle(Convert.ToInt32(Console.ReadLine())));
                        break;
                    case "square":
                        Console.WriteLine("Insert the side length of the square");
                        Shapes.Add(new Square(Convert.ToInt32(Console.ReadLine())));
                        break;
                    default:
                        Console.WriteLine("!!!WRONG entry, #{0}¡¡ Please try to insert the correct data again. ( circle or square )", TypeShape);
                        i--;
                        break;
                }


            }

            foreach (Shape shape in Shapes)
            {
                Console.WriteLine(shape.ToString()); 
            }



        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }


    }




}