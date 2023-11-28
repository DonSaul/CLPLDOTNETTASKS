using System;
class Program
{
    //**    ENUMS: Permite definir un conjunto de constantes con nombre. Mejora la claridad y seguridad del código.
    enum HTTPError{
        Continue = 100,
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404
    }
    //**    STRUCTS: Tipos de valor que pueden contener datos de diferentes tipos, A diferencia de las clases (tipos de referencia) los structs se utilizan para representar un registro pequeño de datos.
    struct Dog
    {
        //** Definición de variables para la struct Dog.
        public string Name, Mark;
        public int Age;
        //** Interpretamos nuestra propia definición del metodo ToString, para devolver los datos de la struct Dog.
        public override string ToString()
        {
            return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
        }
    }
    static void Main()
    {
        Console.WriteLine("Seleccione un ejercicio (1, 2, 3, 4):");
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
            case 4:
                Exercise4();
                break;
            default:
                Console.WriteLine("Opción no válida");
                break;
        }
    }
    //** Método que contiene el Ejercicio 1.
    public static void Exercise1()
    {
        //**    Definicion de los 3 numeros flotantes
        float a,b,c;
        //**    try-catch para manejo de excepciones
        try
        {
            //**    Ingreso de los 3 numeros flotantes
            Console.WriteLine("Ingrese el primer número: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            c = float.Parse(Console.ReadLine());
            //**    Se verifica que los números ingresados estén en el rango [-5,5].
            IsInRange(a,b,c);
        }
        catch (SystemException)
        {
            //**    En caso de error, se muestra el mensaje de error.
            Console.WriteLine("Error al ingresar los datos.");
        }
    }
    //** Método para el ejercicio 1 que valida que los números ingresados estén en el rango [-5,5].
    public static void IsInRange(float a, float b, float c)
    {
        //** Sentencia IF que verifica que los números ingresados estén en el rango [-5,5].
        if( ((a >= -5) && (a <= 5)) && ((b >= -5) && (b <= 5)) && ((c >= -5) && (c <= 5)) )
        {
            Console.WriteLine($"Todos los números ingresados [{a}, {b}, {c}] están en el rango [-5,5]");
        }else
        {
            Console.WriteLine($"No todos los números ingresados están en el rango [-5,5]");
        }
    }
    //** Método que contiene el ejercicio 2, Definir 3 enteros y devolver el minimo y maximo de ellos.
    public static void Exercise2()
    {
        //**    Definimos los 3 números enteros.
        int a,b,c;
        //**    try-catch para manejo de excepciones
        try
        {
            //**    Ingreso de los 3 números enteros.
            Console.WriteLine("Ingrese el primer número");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número");
            c = Convert.ToInt32(Console.ReadLine());

            //**    Calculamos cual de los 3 numeros es el mayor y cual es el menor utilizando los métodos de Math.Max y Math.Min.
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);

            //**    Mostramos por consola los numeros correspondientes.
            Console.WriteLine($"El número máximo es: {max}");
            Console.WriteLine($"El número mínimo es: {min}");
        }
        catch(FormatException)
        {
            Console.WriteLine("Se debe ingresar un número entero");
        }
    }
    //** Método que contiene el ejercicio 3 Declarar un enum para los errores HTTP, leer el codigo y devolver el nombre del error.
    public static void Exercise3()
    {
        //** Declaramos la variable que contendrá el código de error leido por la consola.
        HTTPError error;
        //** try-catch para manejo de excepciones
        try
        {
            //**    Ingreso del código de error.
            Console.WriteLine("Ingrese el código de HTTP: ");
            error = (HTTPError)Convert.ToInt32(Console.ReadLine());
            //**    Switch que verifica el código de error ingresado y muestra por consola el nombre del error.
            switch (error)
            {
                case HTTPError.Continue:
                    Console.WriteLine("Continue");
                    break;
                case HTTPError.BadRequest:
                    Console.WriteLine("Bad Request");
                    break;
                case HTTPError.Unauthorized:
                    Console.WriteLine("Unauthorized");
                    break;
                case HTTPError.PaymentRequired:
                    Console.WriteLine("Payment Required");
                    break;
                case HTTPError.Forbidden:
                    Console.WriteLine("Forbidden");
                    break;
                case HTTPError.NotFound:
                    Console.WriteLine("Not Found");
                    break;
                default:
                    Console.WriteLine("Código no registrado");
                    break;
            }
        }
        catch(FormatException)
        {
            Console.WriteLine("Se debe ingresar un número entero");
        }
    }
    //** Método que contiene el ejercicio 4, Definir una struct Dog con 3 variables, Name, Mark y Age. Ingresar los datos por consola y mostrarlos por consola.
    public static void Exercise4()
    {
        //**    Definimos una variable struct Dog
        Dog dog;
        //**    try-catch para manejo de excepciones
        try
        {
            //**    Ingreso de los datos de la struct Dog
            Console.WriteLine("Ingrese el nombre del perro: ");
            dog.Name = Console.ReadLine();
            Console.WriteLine("Ingrese la raza del perro: ");
            dog.Mark = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del perro: ");
            dog.Age = Convert.ToInt32(Console.ReadLine());
            //**    Mostramos por consola los datos de la struct Dog
            Console.WriteLine(dog.ToString());
        }
        catch (SystemException)
        {
            Console.WriteLine("Error al ingresar los datos.");
        }
    }
}