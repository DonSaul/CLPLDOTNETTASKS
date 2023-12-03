//** Librerias **//
using System; //** Libreria para usar Console.
using System.Collections.Generic; //** Libreria para usar Listas.
using System.Linq; //** Libreria para usar LINQ.
using System.IO; //** Libreria para usar File.

class Program
{
    static void Main()
    {
        //** 1) Creamos una lista de Shapes(formas) y llenarla.
        List<Shape> shapes = new List<Shape>()
        {
            new Circle(3),
            new Circle(5),
            new Circle(7),
            new Square(2),
            new Square(4),
            new Square(6)
        };
        //** 2) Encontrar y escribir en el archivo las formas con un área en el rango [10,100].
        //** 2.1) Realizamos una consulta utilizando funciones LINQ.
        var shapesWithAreaInRange = shapes.Where(s => s.Area >= 10 && s.Area <= 100);
        File.WriteAllLines("shapes_rango.txt", shapesWithAreaInRange.Select(s => s.Name + " " + s.Area)); //** Escribimos en el archivo shapes_rango.txt las formas obtenidas enviando su nombre y su área.
    }
}