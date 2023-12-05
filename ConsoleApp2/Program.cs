﻿

public class Program2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1) Floats in range");
        CheckForFloatsInRange();
        Console.WriteLine("2) Min/max of 3 ints");
        CheckMaxMinInts();
        Console.WriteLine("3) Http error code");
        CheckHttpErrorCode();
        Console.WriteLine("4) Create dog out of struct");
        CreateDogStruct();
    }

    private static void CheckForFloatsInRange()
    {
        Console.WriteLine("Type in 3 decimal numbers, please:");
        float[] floats = new float[3];
        for (int i = 0; i < floats.Length; i++)
        {
            Console.Write("{0}> ", (i + 1));
            string? s = Console.ReadLine();
            bool rez = float.TryParse(s, out float value);
            if (rez) { floats[i] = value; } else
            {
                Console.WriteLine("Sorry, that's not even a number!");
                return;
            }
        }
        foreach (float fl in floats)
        {
            string result = (fl >= -5 && fl <= 5) ? "INDEED" : "NOT";
            Console.WriteLine("{0:F2} is {1} within the range [-5, 5]", fl, result);
        }
    }

    private static void CheckMaxMinInts()
    {
        Console.WriteLine("Type in 3 entegers, please:");
        int min = int.MaxValue;
        int max = int.MinValue;
        for(int i = 0;i < 3; i++)
        {
            Console.Write("{0}> ", (i + 1));
            string? s = Console.ReadLine();
            bool rez = Int32.TryParse(s, out int value);
            if (rez)
            {
                max = int.Max(max, value);
                min = int.Min(min, value);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer!");
                return;
            }
        }
        Console.WriteLine("The max of those ints is {0}", max);
        Console.WriteLine("The min of those ints is {0}", min);
    }

    private static void CheckHttpErrorCode()
    {
        Console.WriteLine("Please, type in a small integer to see if it's a n HTTP code:");
        Console.Write("> ");
        string? s = Console.ReadLine();
        bool rez = Int16.TryParse(s, out short code);
        if (!rez)
        {
            Console.WriteLine("Sorry, that's not even a number! (or it's FAR too large)");
            return;
        }
        if (Enum.IsDefined(typeof(HTTPError), code))
        {
            Console.WriteLine("HTTP code {0} is: {1}", code, (HTTPError)code);
        }
        else
        {
            Console.WriteLine("Nope, that's not an HTTP code! At least not an official one...");
        }
    }

    private static void CreateDogStruct()
    {
        Dog myDog;
        Console.WriteLine("Type in the dog's name!");
        Console.Write("> ");
        myDog.name = Console.ReadLine();
        Console.WriteLine("Now, what breed is it?");
        Console.Write("> ");
        myDog.breed = Console.ReadLine();
        Console.WriteLine("Type in the dog's name!");
        Console.Write("> ");
        string? s = Console.ReadLine();
        bool rez = SByte.TryParse(s, out myDog.age);
        if (!rez)
        {
            Console.WriteLine("Sorry, that's not even a number! (or it's FAR too large)");
            return;
        }
        Console.WriteLine("Hey, look! It's {0}!", myDog);
    }

    private struct Dog
    {
        public string name;
        public string breed;
        public sbyte age;
        public override readonly string ToString()
        {
            return String.Format("{0}, a {1} year old {2}", name, age, breed);
        }
    }

    private enum HTTPError : short
    {
        Continue = 100,
        SwitchingProtocols = 101,
        Processing = 102,
        EarlyHints = 103,
        OK = 200,
        Created = 201,
        Accepted = 202,
        NonAuthoritativeInformation = 203,
        NoContent = 204,
        ResetContent = 205,
        PartialContent = 206,
        MultiStatus = 207,
        AlreadyReported = 208,
        IMUsed = 226,
        MultipleChoices = 300,
        MovedPermanently = 301,
        Found = 302,
        SeeOther = 303,
        NotModified = 304,
        UseProxy = 305,
        TemporaryRedirect = 307,
        PermanentRedirect = 308,
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
        RequestURITooLong = 414,
        UnsupportedMediaType = 415,
        RequestRangeNotSatisfiable = 416,
        ExpectationFailed = 417,
        IMATeapot = 418,
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
        BandwidthLimitExceeded = 509,
        NotExtended = 510,
        NetworkAuthenticationRequired = 511
    }
}
