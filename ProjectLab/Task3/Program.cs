using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Count integers divisible by 3 in a range");
                Console.WriteLine("2. Print every second character in a string");
                Console.WriteLine("3. Print drink name and price");
                Console.WriteLine("4. Calculate arithmetic average of positive integers");
                Console.WriteLine("5. Check if a year is a leap year");
                Console.WriteLine("6. Calculate sum of digits of an integer");
                Console.WriteLine("7. Check if an integer contains only odd numbers");
                Console.WriteLine("8. Exit");
                Console.Write("Enter your choice (1-8): ");

                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 8)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 8.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        CountIntegersDivisibleBy3();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 2:
                        Console.Clear();
                        PrintEverySecondCharacter();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 3:
                        Console.Clear();
                        PrintDrinkNameAndPrice();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 4:
                        Console.Clear();
                        CalculateArithmeticAverage();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 5:
                        Console.Clear();
                        CheckLeapYear();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 6:
                        Console.Clear();
                        CalculateSumOfDigits();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 7:
                        Console.Clear();
                        CheckOnlyOddNumbers();
                        Console.WriteLine("Returning to the menu...\n");
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                }
            } while (choice != 8);
        }

        // Function to count integers divisible by 3 in a range
        static void CountIntegersDivisibleBy3()
        {
            Console.Write("Enter the start of the range (integer): ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                
                return;
            }

            Console.Write("Enter the end of the range (integer): ");
            if (!int.TryParse(Console.ReadLine(), out int b) || b < a)
            {
                Console.WriteLine("Invalid input. Please enter an integer greater than the start of the range.");
                
                return;
            }

            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Number of integers divisible by 3 in the range [{a}..{b}]: {count}");
        }

        // Function to print every second character in a string
        static void PrintEverySecondCharacter()
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            for (int i = 1; i < input.Length; i += 2)
            {
                Console.Write(input[i]);
            }
            

            Console.WriteLine();
        }

        // Function to print drink name and price
        static void PrintDrinkNameAndPrice()
        {
            Console.Write("Enter the name of the drink (coffee, tea, juice, water): ");
            string drink = Console.ReadLine().ToLower();

            switch (drink)
            {
                case "coffee":
                    Console.WriteLine("Drink: Coffee | Price: $2.50");
                    break;
                case "tea":
                    Console.WriteLine("Drink: Tea | Price: $1.80");
                    break;
                case "juice":
                    Console.WriteLine("Drink: Juice | Price: $2.00");
                    break;
                case "water":
                    Console.WriteLine("Drink: Water | Price: $1.00");
                    break;
                default:
                    Console.WriteLine("Invalid drink entered.");
                    break;
            }
            
        }

        // Function to calculate arithmetic average of positive integers
        static void CalculateArithmeticAverage()
        {
            int sum = 0;
            int count = 0;

            Console.WriteLine("Enter a sequence of positive integers (to stop, enter a negative number):");
            while (true)
            {
                int num;
                if (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                if (num < 0)
                {
                    break;
                }

                sum += num;
                count++;
            }

            if (count > 0)
            {
                double average = (double)sum / count;
                Console.WriteLine($"Arithmetic average of the entered numbers: {average}");
            }
            else
            {
                Console.WriteLine("No positive integers were entered.");
            }
            
        }

        // Function to check if a year is a leap year
        static void CheckLeapYear()
        {
            Console.Write("Enter a year: ");
            if (!int.TryParse(Console.ReadLine(), out int year) || year <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
                
                return;
            }

            bool isLeapYear = DateTime.IsLeapYear(year);
            if (isLeapYear)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            
        }

        // Function to calculate sum of digits of an integer
        static void CalculateSumOfDigits()
        {
            Console.Write("Enter an integer number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                
                return;
            }

            int sum = 0;
            int tempNumber = Math.Abs(number);

            while (tempNumber > 0)
            {
                sum += tempNumber % 10;
                tempNumber /= 10;
            }

            Console.WriteLine($"Sum of digits of {number}: {sum}");
            
        }

        // Function to check if an integer contains only odd numbers
        static void CheckOnlyOddNumbers()
        {
            Console.Write("Enter an integer number: ");
            if (!int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
                return;
            }

            bool allOdd = true;
            int tempNumber = Math.Abs(number);

            while (tempNumber > 0)
            {
                int digit = tempNumber % 10;
                if (digit % 2 == 0)
                {
                    allOdd = false;
                    break;
                }
                tempNumber /= 10;
            }

            if (allOdd)
            {
                Console.WriteLine($"{number} contains only odd numbers.");
            }
            else
            {
                Console.WriteLine($"{number} does not contain only odd numbers.");
            }
        }
    }
}
