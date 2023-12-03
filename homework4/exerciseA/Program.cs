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
            //** 1.1) Llenamos la lista con 3 Circulos y 3 Cuadrados.
            //** 1.2) Los circulos tienen radio 3, 5 y 7.
            new Circle(3),
            new Circle(5),
            new Circle(7),
            //** 1.3) Los cuadrados tienen lado 2, 4 y 6.
            new Square(2),
            new Square(4),
            new Square(6)
        };
        //** 2) Encontrar y escribir en el archivo las formas con un área en el rango [10,100].
        //** 2.1) Realizamos una consulta utilizando funciones LINQ.
        var shapesWithAreaInRange = shapes.Where(s => s.Area >= 10 && s.Area <= 100);
        //** Creamos y escribimos en el archivo "shapes_rango.txt" las formas obtenidas enviando su nombre y su área.
        File.WriteAllLines("shapes_rango.txt", shapesWithAreaInRange.Select(s => s.Name + " " + s.Area));

        //** 3) Buscar y escribir en el fichero formas cuyo nombre contenga la letra 'a'.
        //** 3.1) Realizamos una consulta utilizando funciones LINQ.
        var shapesWithLetterA = shapes.Where(s => s.Name.Contains('a'));
        //** 3.2) Escribimos en el archivo shapes_letra.txt las formas obtenidas enviando su nombre y su área.
        File.WriteAllLines("shapes_letra.txt", shapesWithLetterA.Select(s => s.Name + " " + s.Area));

        //** 4) Encuentra y elimina de la lista todas las formas con perímetro menor que 5. Escribe la lista resultante en la consola
        //** 4.1) Realizamos una consulta utilizando funciones LINQ.
        shapes.RemoveAll(s => s.Perimeter < 5);
        //** 4.2) Imprimimos la lista resultante en la consola.
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Name + " " + shape.Area);
        }
    }
}