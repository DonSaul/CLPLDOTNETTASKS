internal class Program
{
  // un par de codigos en el enum
  public enum HTTPError
  {
    BadRequest = 400,
    Unauthorized = 401,
    PaymentRequired = 402,
    Forbidden = 403,
    NotFound = 404,
    ImATeapot = 418
  }

  // definicion de struct de perro - no utilizo private porque aun desconozco como funciona la encapsulacion en c#
  public struct Dog
  {
    public string Name;
    public string Breed;
    public int Age;

  }

  private static void Main(string[] args)
  {

    Console.WriteLine("Sub-tasks:\n");
    Console.WriteLine("1. Float numbers in range [-5,5]");
    Console.WriteLine("2. Min and max of 3 integers");
    Console.WriteLine("3. Name of HTTP Error Code [400-404]");
    Console.WriteLine("4. Create a dog!");
    Console.Write("\nPlease enter your choice: ");

    // validacion inicial de op para el switch
    bool parseOp = int.TryParse(Console.ReadLine(), out int op);

    while (!parseOp || op > 4 || op < 0)
    {
      Console.Write("Invalid input, try again: ");
      parseOp = int.TryParse(Console.ReadLine(), out op);
    }

    switch (op)
    {
      case 1:
        float float1;
        float float2;
        float float3;

        // pedir value de float1 y validarlo
        Console.WriteLine("Please enter a number. It may have decimals:");
        bool parseFloat1 = float.TryParse(Console.ReadLine(), out float1);

        while (!parseFloat1)
        {
          Console.WriteLine("Invalid input, try again:");
          parseFloat1 = float.TryParse(Console.ReadLine(), out float1);
        }

        // pedir value de float2 y validarlo
        Console.WriteLine("Please enter a second number. It may have decimals:");
        bool parseFloat2 = float.TryParse(Console.ReadLine(), out float2);

        while (!parseFloat2)
        {
          Console.WriteLine("Invalid input, try again:");
          parseFloat2 = float.TryParse(Console.ReadLine(), out float2);
        }

        // pedir value de float3 y validarlo
        Console.WriteLine("Please enter a third number. It may have decimals:");
        bool parseFloat3 = float.TryParse(Console.ReadLine(), out float3);

        while (!parseFloat3)
        {
          Console.WriteLine("Invalid input, try again:");
          parseFloat3 = float.TryParse(Console.ReadLine(), out float3);
        }

        // check si float1 pertenece al rango
        if (float1 >= -5 && float1 <= 5)
        {
          Console.WriteLine("Float 1 belongs in range [-5,5]");
        }
        else
        {
          Console.WriteLine("Float 1 does not belong in range [-5,5]");
        }

        // check si float2 pertenece al rango
        if (float2 >= -5 && float2 <= 5)
        {
          Console.WriteLine("Float 2 belongs in range [-5,5]");
        }
        else
        {
          Console.WriteLine("Float 2 does not belong in range [-5,5]");
        }

        // check si float3 pertenece al rango
        if (float3 >= -5 && float3 <= 5)
        {
          Console.WriteLine("Float 3 belongs in range [-5,5]");
        }
        else
        {
          Console.WriteLine("Float 3 does not belong in range [-5,5]");
        }

        break;

      case 2:
        int int1;
        int int2;
        int int3;

        // se repite lo mismo que para los floats del case anterior, pero con ints
        Console.WriteLine("Please enter an integer:");
        bool parseInt1 = int.TryParse(Console.ReadLine(), out int1);

        while (!parseInt1)
        {
          Console.WriteLine("Invalid input, try again:");
          parseInt1 = int.TryParse(Console.ReadLine(), out int1);
        }


        Console.WriteLine("Please enter a second integer:");
        bool parseInt2 = int.TryParse(Console.ReadLine(), out int2);

        while (!parseInt2)
        {
          Console.WriteLine("Invalid input, try again:");
          parseInt2 = int.TryParse(Console.ReadLine(), out int2);
        }


        Console.WriteLine("Please enter a third integer:");
        bool parseInt3 = int.TryParse(Console.ReadLine(), out int3);

        while (!parseInt3)
        {
          Console.WriteLine("Invalid input, try again:");
          parseInt3 = int.TryParse(Console.ReadLine(), out int3);
        }

        // utilizando int.Min e int.Max podemos sacar el min/max entre dos numeros
        // si lo usamos dos veces, anidado, podemos sacar el min/max entre 3 numeros
        int min = int.Min(int.Min(int1, int2), int3);
        int max = int.Max(int.Max(int1, int2), int3);

        Console.WriteLine("The min is: " + min);
        Console.WriteLine("The max is: " + max);

        break;

      case 3:
        // solicitando codigo HTTP y validandolo
        Console.WriteLine("Please enter an HTTP error code:");
        bool parseHTTP = int.TryParse(Console.ReadLine(), out int http);

        while (!parseHTTP || http > 404 || http < 400)
        {
          Console.WriteLine("Invalid input, try again: ");
          parseHTTP = int.TryParse(Console.ReadLine(), out http);
        }

        // Enum.GetName pide el TIPO del enum que necesitamos y el valor que buscamos
        // Enum.GetName puede retornar null, asi que el string debe ser nullable
        string? statusCodeName = Enum.GetName(typeof(HTTPError), http);
        Console.WriteLine($"The error name for error {http} is '{statusCodeName}'");

        break;

      case 4:
        Dog newDog;
        Console.WriteLine("Thanks for creating a dog. New dogs are always welcome.");
        Console.WriteLine("\nPlease enter a name for your new dog:");

        // ya clasico input y validacion
        string? dogName = Console.ReadLine();

        while (string.IsNullOrEmpty(dogName))
        {
          Console.WriteLine("\nPlease actually enter a name this time:");
          dogName = Console.ReadLine();
        }

        newDog.Name = dogName;

        // como el problema no especifica como utilizar estas variables, hay espacio para divertirse
        Console.WriteLine($"\nWonderful name! Please enter {newDog.Name}'s age:");
        bool parseAge = int.TryParse(Console.ReadLine(), out int dogAge);

        if (!parseAge)
        {
          Console.WriteLine("Nice one. I don't think you deserve a dog.");
          return;
        }

        newDog.Age = dogAge;

        // ._.
        Console.WriteLine("\nGiven the circumstances, we can only produce new dogs of the following breeds:");
        Console.WriteLine("1. German Shepherd");
        Console.WriteLine("2. Border Collie");
        Console.WriteLine("3. Shiba Inu");
        Console.WriteLine("\nPlease enter a number corresponding to your choice:");

        bool parseOption = int.TryParse(Console.ReadLine(), out int option);

        if (!parseOption || option < 1 || option > 3)
        {
          Console.WriteLine($"\nYou failed a simple option selection process. You are not fit to create {newDog.Name}.");
          return;
        }

        // esto es un switch en su modo expresion. se ve bonito.
        newDog.Breed = option switch
        {
          1 => "German Shepherd",
          2 => "Border Collie",
          3 => "Shiba Inu",
          _ => "Dog",     // en teoria no se puede acceder a esto, porque el if anterior retorna si se falla al elegir.
        };                  // sin embargo, mas abajo el compilador molesta porque newDog.Breed puede no tener un valor

        // tampoco piden validar edad, asi que agrego un poquito de fun
        if (newDog.Age < 0)
        {
          Console.WriteLine($"\nCongratulations, your new {newDog.Breed}, {newDog.Name}, will be ready for shipping in {-newDog.Age} years.");
        }
        if (newDog.Age >= 0)
        {
          Console.WriteLine($"\nCongratulations, your new {newDog.Breed} of {newDog.Age} years, {newDog.Name}, has been created.");
        }
        if (newDog.Age > 20)
        {
          Console.WriteLine($"\nYour WWII Veteran Dog, {newDog.Name}, a seasoned {newDog.Breed} of {newDog.Age} years, has been created.");
        }

        break;
    }

  }
}