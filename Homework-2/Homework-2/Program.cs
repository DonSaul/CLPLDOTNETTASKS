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
        Console.WriteLine("Task #1:");
        Console.WriteLine("----------------------------");
        CheckFloatRange();

        Console.WriteLine("Task #2:");
        Console.WriteLine("----------------------------");
        FindMaxMinIntegers();

        Console.WriteLine("Task #3:");
        Console.WriteLine("----------------------------");
        DisplayHttpError();

        Console.WriteLine("Task #4:");
        Console.WriteLine("----------------------------");
        CreateAndDisplayDog();

        Console.WriteLine("\nMany thanks for trying this program! Have a good day! Process Terminated.");
    }

    private static void CheckFloatRange()
    {
        float[] numbers = new float[3];
        bool validInput = false;

        while (!validInput)
        {
            Console.WriteLine("Enter three float numbers separated by spaces (example: 3.14 -2.5 4):");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length == 3 && TryParseFloatArray(parts, out numbers))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 3 float numbers (example: 5 12 13)\n");
            }
        }

        if (AllNumbersInRange(numbers, -5, 5))
        {
            Console.WriteLine("Result: All numbers belong to the range [-5,5].\n");
        }
        else
        {
            Console.WriteLine("Not all numbers belong to the range [-5,5].\n");
        }
    }

    private static void FindMaxMinIntegers()
    {
        Console.WriteLine("Enter three integers separated by spaces (example: 5 12 13):");

     
        while (true)
        {
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            if (parts.Length == 3 && TryParseIntegerArray(parts, out int[] numbers))
            {
                int max = numbers.Max();
                int min = numbers.Min();

                Console.WriteLine($"Max: {max}, Min: {min} \n");
                break;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter 3 integer numbers separated by space (example: 5 12 13):");
            }
        }
    }

    private static void DisplayHttpError()
    {
        Console.WriteLine("Enter an HTTP Error number (e.g., 404, 500): ");

        try
        {
            string input = Console.ReadLine();
            if (!Enum.TryParse(input, out HTTPError error) || !Enum.IsDefined(typeof(HTTPError), error))
            {
                Console.WriteLine("Invalid HTTP error number.");
                return;
            }

            Console.WriteLine($"Result: The name of the error is: {error} \n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }

    private static void CreateAndDisplayDog()
    {
        Dog myDog = new Dog();
        Console.WriteLine("Enter dog's name, mark, and age:");

        Console.Write("Dog Name: ");
        myDog.Name = Console.ReadLine();

        Console.Write("Dog Mark: ");
        myDog.Mark = Console.ReadLine();

        Console.Write("Dog Age: ");
        try
        {
            myDog.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Dog data:");
            Console.WriteLine(myDog);
        }
        catch (FormatException)
        {
            Console.WriteLine("Result: Invalid input. Please enter a valid age.");
        }
    }




    /*UTIL FUNCTIONS*/
    private static bool TryParseFloatArray(string[] parts, out float[] numbers)
    {
        numbers = new float[3];
        for (int i = 0; i < parts.Length; i++)
        {
            if (!float.TryParse(parts[i], out numbers[i]))
            {
                return false;
            }
        }
        return true;
    }

    private static bool TryParseIntegerArray(string[] parts, out int[] numbers)
    {
        numbers = new int[3];
        for (int i = 0; i < parts.Length; i++)
        {
            if (!int.TryParse(parts[i], out numbers[i]))
            {
                return false;
            }
        }
        return true;
    }

    private static bool TryReadFloat(out float number)
    {
        return float.TryParse(Console.ReadLine(), out number);
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
