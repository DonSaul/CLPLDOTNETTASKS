using System;
using System.Linq;

namespace Homework2
{
    // Enum for HTTP Errors
    public enum HTTPError
    {
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        MethodNotAllowed = 405,
        RequestTimeout = 408,
        Conflict = 409,
        Gone = 410,
        InternalServerError = 500,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504
    }

    // Struct for Dog
    public struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {
            return $"Name: {Name}, Mark: {Mark}, Age: {Age}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Check float numbers within range [-5,5]");
                Console.WriteLine("2. Find max and min of three integers");
                Console.WriteLine("3. Get HTTP Error name");
                Console.WriteLine("4. Input and display Dog details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CheckFloatNumbersInRange();
                            break;
                        case 2:
                            FindMaxAndMinOfIntegers();
                            break;
                        case 3:
                            GetHTTPErrorName();
                            break;
                        case 4:
                            InputAndDisplayDogDetails();
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
        }

        static void CheckFloatNumbersInRange()
        {
            float[] floatNumbers = new float[3];
            for (int i = 0; i < 3; i++)
            {
                float number;
                bool validInput = false;

                do
                {
                    Console.Write($"Enter float number {i + 1}: ");
                    string input = Console.ReadLine();

                    if (float.TryParse(input, out number))
                    {
                        floatNumbers[i] = number;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid float number.");
                    }
                } while (!validInput);
            }

            bool allInRange = true;
            foreach (float num in floatNumbers)
            {
                if (num < -5 || num > 5)
                {
                    allInRange = false;
                    break;
                }
            }
            Console.WriteLine($"Are all float numbers within the range [-5,5]? {allInRange}");
        }

        static void FindMaxAndMinOfIntegers()
        {
            int[] integers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int number;
                bool validInput = false;

                do
                {
                    Console.Write($"Enter integer {i + 1}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out number))
                    {
                        integers[i] = number;
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                } while (!validInput);
            }

            int max = integers.Max();
            int min = integers.Min();
            Console.WriteLine($"Max: {max}, Min: {min}");
        }

        static void GetHTTPErrorName()
        {
            int errorCode;
            bool validInput = false;

            do
            {
                Console.Write("Enter HTTP Error code: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out errorCode))
                {
                    if (Enum.IsDefined(typeof(HTTPError), errorCode))
                    {
                        HTTPError error = (HTTPError)errorCode;
                        Console.WriteLine($"Error Name: {error}");
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid HTTP Error code. Please enter a valid code.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            } while (!validInput);
        }

        static void InputAndDisplayDogDetails()
        {
            Dog myDog = new Dog(); // Inicializar la variable myDog

            do
            {
                Console.Write("Enter dog's name: ");
                myDog.Name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(myDog.Name));

            do
            {
                Console.Write("Enter dog's mark: ");
                myDog.Mark = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(myDog.Mark));

            int age;
            bool validAge = false;

            do
            {
                Console.Write("Enter dog's age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age) && age > 0)
                {
                    myDog.Age = age;
                    validAge = true;
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a valid positive integer.");
                }
            } while (!validAge);

            Console.WriteLine("Dog Details:");
            Console.WriteLine(myDog.ToString());
        }
    }
}
