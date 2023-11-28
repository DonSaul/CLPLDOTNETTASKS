// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione un ejercicio (1, 2, 3):");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option)
        {
            case 1:
                Exercise1();
                break;
            case 2:
                Exercise2();
                break;
            case 3:
                Exercise3();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
    //** Método que contiene el ejercicio 1
    public static void Exercise1()
    {
        //** Declaración de variables.
        int a;
        //** Ingreso de datos.
        try
        {
            //** Leer la variable por consola
            Console.WriteLine("Ingrese un número: ");
            a = Convert.ToInt32(Console.ReadLine());
            //** Validar que el número sea positivo y distinto de 0
            if(a <= 0)
            {
                throw new Exception("Error: Ingrese un número entero positivo");
            }
            //** Mostrar el resultado por consola
            Console.WriteLine("El área es: " + CalcularArea(a));
            Console.WriteLine("El perímetro es: " + CalcularPerimetro(a));
        }
        catch(FormatException) //** Manejo de excepciones
        {
            Console.WriteLine("Error: Ingrese un número entero");
        }
    }
    //** Método que calcula el area de un cuadrado
    public static int CalcularArea(int number)
    {
        return number * number;
    }
    //** Método que calcula el perímetro de un cuadrado
    public static int CalcularPerimetro(int number)
    {
        return number * 4;
    }
    //** Método que contiene el ejercicio 2
    public static void Exercise2()
    {
        //**    Definición de variables.    **//
        string name;
        int age;
        //**    Preguntar el nombre por consola.    **//
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        //**    Imprimimos el nombre y pregunta edad.    **//
        Console.WriteLine("How old are you, "+ name + "?");
        age = Convert.ToInt32(Console.ReadLine());
        //**    Imprimimos el nombre y la edad.    **//
        Console.WriteLine("Welcome " + name + ", you have " + age + " years old.");
    }
    //** Método que contiene el ejercicio 3
    public static void Exercise3()
    {
        //**    Definición de variables.    **//
        double r;
        //**    Manejo de excepciones    **//
        try
        {
            //**    Preguntar el radio por consola.    **//
            Console.WriteLine("Ingrese el radio del círculo: ");
            r = Convert.ToDouble(Console.ReadLine());
            //**    Calculamos el largo    **//
            Console.WriteLine("El largo del círculo es: " + CalcularLargo(r));
            //**    Calculamos el área    **//
            Console.WriteLine("El área del círculo es: " + CalcularArea(r));
            //**    Calculamos el volumen    **//
            Console.WriteLine("El volumen del círculo es: " + CalcularVolumen(r));
        }
        catch(FormatException)
        {
            Console.WriteLine("Error: Ingrese un número");
        }
    }
    //** Método para calcular el largo de un círculo
    public static double CalcularLargo(double r)
    {
        //**    Largo = 2 * PI * r    **//
        return 2 * Math.PI * r;
    }
    //** Método para calcular el área de un círculo
    public static double CalcularArea(double r)
    {
        //**    Área = PI * r^2    **//
        return Math.PI * Math.Pow(r, 2);
    }
    //** Método para calcular el volumen de un círculo
    public static double CalcularVolumen(double r)
    {
        //**    Volumen = (4/3) * PI * r^3    **//
        return (4 / 3) * Math.PI * Math.Pow(r, 3);
    }
}