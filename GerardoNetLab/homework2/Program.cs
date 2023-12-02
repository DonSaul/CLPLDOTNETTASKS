//configurando valor regional para usar el punto como separador decimal.
using System;
using System.Globalization;

CultureInfo ci = new CultureInfo("en-US");
System.Threading.Thread.CurrentThread.CurrentCulture = ci;

////Ejercicio A: valores flotantes

//bool iteracion = true;
//int numIteracion = 0;
//List<float> listaFloat = new List<float>();
//Console.WriteLine("Ingresa 3 valores float: ");

//do
//{
//    float entradaValida = 0;
//    while (entradaValida == 0)
//    {
//        string input = Console.ReadLine();
//        entradaValida = float.TryParse(input, out float resultado)?resultado:0;
//        if (entradaValida!=0)
//        {
//            listaFloat.Add(entradaValida);
//            entradaValida = 1;
//            Console.WriteLine("Ingresar el siguiente valor: ");
//        }
//        else
//        {
//            Console.WriteLine($"Por favor ingresa un número válido, has ingresado {resultado}\n");
//        }
//    }
//    numIteracion = ++numIteracion;
//    iteracion = (numIteracion < 3);

//} while (iteracion);

//foreach (float number in listaFloat)
//{
//    if (Math.Abs(number)<5)
//    {
//        Console.WriteLine($"El número {number} está dentro del rango de -5 y 5");
//    }
//    else { Console.WriteLine($"El número {number} está fuera del rango de -5 y 5"); }
//}


////Ejercicio B: valores enteros

//bool iterando = true;
//int iteracion = 0;
//int numMayor = 0;
//int numMenor = 0;

//List<int> intNumeros = new List<int>();
//while (iterando)
//{
//    Console.WriteLine("Ingresa números enteros: ");
//    String entrada = Console.ReadLine();
//    int numero = int.TryParse(entrada, out int resultado) ? resultado : 0;
//    while (numero == 0)
//    {
//        Console.WriteLine("Ingresa números enteros validación: ");
//        entrada = Console.ReadLine();
//        numero = int.TryParse(entrada, out resultado) ? resultado : 0;
//    }
//    intNumeros.Add(numero);
//    Console.WriteLine($"Num ingresado {numero}");
//    iteracion++;
//    iterando = iteracion != 3;
//    Console.Clear();
//}

//foreach (var item in intNumeros)
//{
//    numMayor = intNumeros.Max();
//    numMenor = intNumeros.Min();
//}
//Console.WriteLine($"Número Mayor {numMayor} \nNúmero menor {numMenor}");

////Ejercicio C: errores http

//Console.WriteLine("Ingresa el código del error http: ");
//string codigo = Console.ReadLine();

//if (Enum.TryParse(typeof(HTTPerrores), codigo, out var codigoError))
//{
//    if (Enum.IsDefined(typeof(HTTPerrores), codigoError))
//    {
//    Console.WriteLine($"Codigo corresponde: {codigoError}");
//    }
//    else
//    {
//    Console.WriteLine("Codigo no valido");
//    }
//}
//else
//{
//Console.WriteLine("Codigo no valido");
//}


//public enum HTTPerrores
//{
//    NotFound = 404,                   // Recurso no encontrado
//    InternalServerError = 500,        // Error interno del servidor
//    Forbidden = 403,                  // Acceso prohibido
//    Unauthorized = 401,               // No autorizado
//    BadRequest = 400,                 // Solicitud incorrecta
//    Found = 302,                      // Redirección temporal
//    ServiceUnavailable = 503,         // Servicio no disponible
//    GatewayTimeout = 504,             // Tiempo de espera de puerta de enlace agotado
//    MethodNotAllowed = 405,           // Método no permitido
//    UnsupportedMediaType = 415        // Tipo de medio no admitido
//}

//////Ejercicio D: valores struct
//Console.WriteLine("Ingresa los datos de tu perro: ");
//Dog miPerro = new Dog();
//Console.WriteLine("Nombre:");
//miPerro.nombre = Console.ReadLine();
//Console.WriteLine("Raza:");
//miPerro.raza = Console.ReadLine();

//bool entradaValida = false;

//do
//{
//Console.WriteLine("Edad:");
//string input = Console.ReadLine();

//if (int.TryParse(input, out int edad))
//{
//miPerro.edad = edad;
//entradaValida = true;
//}
//else
//{
//Console.WriteLine("Edad inválida. Por favor, ingrese un número entero válido.");
//}

//} while (!entradaValida);
//Console.WriteLine(miPerro.ToString());

//struct Dog
//{

//    public string nombre;
//    public int edad;
//    public string raza;

//    public override string ToString()
//    {
//        return $"Nombre: {nombre} Edad: {edad} Raza: {raza}";
//    }
//}