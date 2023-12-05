//** Librerías que se necesitan para compilar el programa **//
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("---------------ITEM A---------------");
        //** Leeremos todas las lineas del fichero creado con anterioridad **//
        //** Y las guardaremos en un array de strings **//
        string[] lineas = File.ReadAllLines("ficheroPreparado.txt");

        //** Se realiza conteo y se guarda la cantidad de simbolos por cada línea **//
        foreach(string linea in lineas)
        {
            //** Se imprime por consola la cantidad de simbolos por cada línea a través de la funcion Regex.Matches() **//
            //** Utilizando el patrón \W que indica que se buscan todos los símbolos (funcion por defecto)**//
            //!! Este REGEX cuenta espacios y simbolos especiales !!//
            int Conteo = Regex.Matches(linea, @"\W").Count;
            Console.WriteLine("La línea: " + linea + " tiene " + Conteo + " símbolos");
        }

        //** Item 2: Encontrar la línea con mayor y menor cantidad de texto **//
        Console.WriteLine("---------------ITEM B---------------");
        //** Definimos 2 variables que gracias a una consulta LINQ nos permitirán obtener la línea con mayor y menor cantidad de texto **//
        //** Se ordena de mayor a menor y se obtiene el primer elemento **//
        string lineaMayor = lineas.OrderByDescending(s => s.Length).First();
        //** Se ordena de menor a mayor y se obtiene el primer elemento **//
        string lineaMenor = lineas.OrderBy(s => s.Length).First();

        //** Se imprime por consola la línea con mayor y menor cantidad de texto **//
        Console.WriteLine("La línea con mayor cantidad de texto es: " + "'" + lineaMayor + "'");
        Console.WriteLine("La línea con menor cantidad de texto es: " + "'" + lineaMenor + "'");

        //** Item 3: Encontrar e imprimir las líneas que contengan la palabra "var" **//
        Console.WriteLine("---------------ITEM C---------------");
        //** Se define una variable que almacenará las líneas que contengan la palabra "var" **//
        //!! Consulta LINQ que busca todas las líneas que contengan la palabra "var" !!//
        string[] lineasConVar = lineas.Where(s => s.Contains("var")).ToArray();

        //** if-else que valida si se encontró alguna línea que contenga la palabra "var" **//
        if(!lineasConVar.Any())
        {
            Console.WriteLine("No se encontró nunguna línea que contenga la palabra 'var'");
        }
        else
        {
            //** Se imprime por consola las líneas que contienen la palabra "var" **//
            foreach(string linea in lineasConVar)
            {
            Console.WriteLine(linea);
            }
        }
    }
}