//************************************--OCUPANDO PLANTILLA DE DOTNET: new console--******************************************
// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Ejercicio 1");
        Console.WriteLine("2. Ejercicio 2");
        Console.WriteLine("3. Ejercicio 3");
        Console.WriteLine("4. Ejercicio 4");

        try{
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion){
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
                case 3:
                    Exercise3();
                    break;
                case 4:
                    Exercise4();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }catch (FormatException){
            Console.WriteLine("El valor ingresado no es un número válido.");
        }
    }

    //******************--EJERCICIO 1 DE LA TASK 1--******************//
    public static void Exercise1()
    {
        //** Declaramos las variables a y b. **//
        int a, b;
        //** try-catch para manejo de excepciones. **//
        try{
            //** Pedimos el valor de a por consola. **//
            Console.WriteLine("Ingrese el valor de a: ");
            //** Convertimos el valor ingresado a entero y lo guardamos en a. **//
            a = Convert.ToInt32(Console.ReadLine());
            //** Pedimos el valor de b por consola
            Console.WriteLine("Ingrese el valor de b: ");
            //** Convertimos el valor ingresado a entero y lo guardamos en b. **//
            b = Convert.ToInt32(Console.ReadLine());
            Calcular(a, b);
        }catch(FormatException){
            Console.WriteLine("El valor ingresado no es un número entero");
        }
    }
    //******************--MÉTODO CALCULAR OPERACIONES--******************//
    public static void Calcular(int a, int b){
        string[] operaciones = {"Suma", "Resta", "Multiplicación", "División"};
        string[] resultados = new string[4];
        //**  Sumar  **//
        resultados[0] = (a+b).ToString();
        //**  Restar  **//
        resultados[1] = (a-b).ToString();
        //**  Multiplicar  **//
        resultados[2] = (a*b).ToString();
        //**  Dividir  **//
        resultados[3] = (a/b).ToString();
        //**  Mostrar resultados  **//
        Console.WriteLine("***Los resultados son***");
        //**  Se recorren los arreglos para mostrar los resultados  **//
        for(int i = 0; i < operaciones.Length; i++){
            Console.WriteLine(operaciones[i] + ": " + resultados[i]);
        }
    }
    //******************--EJERCICIO 2 DE LA TASK 1--******************//
    public static void Exercise2(){
        //** Imprimimos la pregunta por consola **//
        Console.WriteLine("How are you?");
        //** Declaramos la variable "respuesta" **//
        string respuesta;
        //** Leemos la respuesta por consola **//
        respuesta = Console.ReadLine();
        //** Manejo de excepciones para "respuesta"**//
        if(string.IsNullOrEmpty(respuesta)){
            Console.WriteLine("No se ingresó ninguna respuesta");
        }else{
            Console.WriteLine("You are " + respuesta);
        }
    }
    //******************--EJERCICIO 3 DE LA TASK 1--******************//
    public static void Exercise3(){
        //** try-catch para manejo de excepciones. **//
        try{
            //** Declaramos las variables first_char, second_char y third_char **//
            char first_char, second_char, third_char;
            //** Pedimos las variables por consola y las convertimos a Char **//
            Console.WriteLine("Ingrese el primer caracter: ");
            first_char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo caracter: ");
            second_char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer caracter: ");
            third_char = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enter: " + first_char + "," +second_char + "," + third_char);
        }catch(FormatException){
            Console.WriteLine("El valor ingresado no es un carácter");
        }
    }
    //******************--EJERCICIO 4 DE LA TASK 1--******************//
    public static void Exercise4(){
        //** Definimos las variables que almacenaran los números **//
        int a, b;
        try{
            //** Pedimos los números por consola **//
            Console.WriteLine("Ingrese el valor de a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de b:");
            b = Convert.ToInt32(Console.ReadLine());
            //** Verificar números **//
            Console.WriteLine("¿Son positivos los números ingresados? " + EsPositivo(a, b));
        }
        catch(FormatException)
        {
            Console.WriteLine("El valor ingresado no es un número");
        }
    }
    public static bool EsPositivo(int a, int b){
        if(a > 0 && b > 0){
            return true;
        }else{
            return false;
        }
    }
}