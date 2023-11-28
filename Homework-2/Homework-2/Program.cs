using System;

class Program
{
    enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        NotAcceptable = 406,
        ProxyAuthenticationRequired = 407,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        LengthRequired = 411,
        PreconditionFailed = 412,
        PayloadTooLarge = 413,
        URITooLong = 414,
        UnsupportedMediaType = 415,
        RangeNotSatisfiable = 416,
        ExpectationFailed = 417,
        ImATeapot = 418,
        MisdirectedRequest = 421,
        UnprocessableEntity = 422,
        Locked = 423,
        FailedDependency = 424,
        TooEarly = 425,
        UpgradeRequired = 426,
        PreconditionRequired = 428,
        TooManyRequests = 429,
        RequestHeaderFieldsTooLarge = 431,
        UnavailableForLegalReasons = 451,
        InternalServerError = 500,
        NotImplemented = 501,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504,
        HTTPVersionNotSupported = 505,
        VariantAlsoNegotiates = 506,
        InsufficientStorage = 507,
        LoopDetected = 508,
        NotExtended = 510,
        NetworkAuthenticationRequired = 511
    }


    struct Dog
    {
        public string Name { get; set; }
        public string Mark { get; set; }
        public int Age { get; set; }

        public override readonly string ToString()
        {
            return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
        }
    }

    static void Main(string[] args)
    {
        CheckFloatRange();
        FindMaxMinIntegers();
        DisplayHttpError();
        CreateAndDisplayDog();
    }

    private static void CheckFloatRange()
    {
        Console.WriteLine("Enter three float numbers (example:  3.14 -2.5 4):");

        float[] numbers = new float[3];
        for (int i = 0; i < 3; i++)
        {
            if (!float.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid float number.");
                return; // Exit the function if invalid input is detected
            }
        }

        if (AllNumbersInRange(numbers,-5,5))
        {
            Console.WriteLine("All numbers belong to the range [-5,5].");
        }
        else
        {
            Console.WriteLine("Not all numbers belong to the range [-5,5].");
        }
    }


    private static void FindMaxMinIntegers()
    {
        Console.WriteLine("Enter three integers (example: 5 12 13): ");
        try
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            int int3 = int.Parse(Console.ReadLine());

            int max = Math.Max(int1, Math.Max(int2, int3));
            int min = Math.Min(int1, Math.Min(int2, int3));

            Console.WriteLine($"Max: {max}, Min: {min}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter 3 integers (example: 5 12 13)");
        }
    }

    private static void DisplayHttpError()
    {
        Console.WriteLine("Enter HTTP Error number ");
        try
        {
            HTTPError error = (HTTPError)int.Parse(Console.ReadLine());
            Console.WriteLine($"El nombre del error es: {error}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid error number.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Invalid HTTP Error number.");
        }
    }

    private static void CreateAndDisplayDog()
    {
        Dog myDog = new Dog();
        Console.WriteLine("Enter dog's name, mark, and age:");
        myDog.Name = Console.ReadLine();
        myDog.Mark = Console.ReadLine();
        try
        {
            myDog.Age = int.Parse(Console.ReadLine());
            Console.WriteLine(myDog);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }

    /*
    Function checks whether all the numbers in the provided array fall within
    a specified range, inclusive of the range boundaries. 
    */
    private static bool AllNumbersInRange(float[] numbers, double minRange, double maxRange)
    {
        return numbers.All(num => num >= minRange && num <= maxRange);
    }
}
