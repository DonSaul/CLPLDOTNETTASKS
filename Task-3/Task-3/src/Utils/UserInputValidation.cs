using System;
namespace Task_3.src.Util
{
    public class UserInputValidation
    {
        // Validates and parses an integer input
        public static int GetValidInteger()
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer:");
            }
            return value;
        }
        // Method to get a sequence of positive integers
        public static List<int> GetPositiveIntegersSequence()
        {
            var numbers = new List<int>();
            Console.WriteLine("Enter positive integers (negative number to stop):");
            while (true)
            {
                int num = GetValidInteger();
                if (num < 0) break;
                numbers.Add(num);
            }
            return numbers;
        }

        // Validates and gets a non-empty string
        public static string GetValidString()
        {
            string input;
            do
            {
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Input cannot be empty. Please enter a valid string:");
                }
            }
            while (string.IsNullOrWhiteSpace(input));
            return input;
        }

        // Validates and gets a valid string from a set of allowed options
        public static string GetValidStringFromOptions(string[] options)
        {
            string input;
            do
            {
                input = Console.ReadLine().ToLower();
                if (Array.IndexOf(options, input) == -1)
                {
                    Console.WriteLine($"Invalid option. Please enter one of the following: {string.Join(", ", options)}");
                }
            }
            while (Array.IndexOf(options, input) == -1);
            return input;
        }

      
    }
}
