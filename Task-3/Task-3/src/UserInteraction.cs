using System;
using System.Collections.Generic;
using System.Globalization;
using Task_3.src.Util;

namespace Task_3.src
{
    public class UserInteraction
    {
        private Solver solver = new Solver();

        // Task 1
        public void HandleDivisibleByThree()
        {
            Console.Write("Enter the first integer (a): ");
            int a = UserInputValidation.GetValidInteger();
            Console.Write("Enter the second integer (b): ");
            int b = UserInputValidation.GetValidInteger();

            if (b < a)
            {
                Console.WriteLine("(Note: b should be greater than or equal to a. Please re-enter both integers.)");
                HandleDivisibleByThree(); // Recursive call without return
                return; // Exit the current invocation after the recursive call
            }

            int count = solver.CountDivisibleByThree(a, b);
            string countText = count == 1 ? "integer" : "integers";
            Console.WriteLine($"Result: There {((count == 1) ? "is" : "are")} {count} {countText} divisible by 3 in the range [{a}..{b}].");

        }

        // Task 2
        public void HandlePrintEverySecondChar()
        {
            Console.Write("Enter a string: ");
            string str = UserInputValidation.GetValidString();

            string result = solver.PrintEverySecondChar(str);
            Console.WriteLine($"Result: The second characters in the string are \"{result}\".");
        }

        // Task 3
        public void HandleGetDrinkPrice()
        {
            string[] validDrinks = new string[] { "coffee", "tea", "juice", "water" };
            Console.WriteLine("Enter the name of the drink (Options: coffee, tea, juice, water):");
            string drink = UserInputValidation.GetValidStringFromOptions(validDrinks);

            string priceInfo = solver.GetDrinkPrice(drink);
            Console.WriteLine($"Result: The price of {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(drink)} is {priceInfo}.");
        }

        // Task 4
        public void HandleCalculateAverage()
        {
            var numbers = UserInputValidation.GetPositiveIntegersSequence();
            double average = solver.CalculateAverage(numbers);
            Console.WriteLine($"Result: The arithmetic average of the entered numbers is {average}.");
        }

        // Task 5
        public void HandleIsLeapYear()
        {
            Console.WriteLine("Enter a year:");
            int year = UserInputValidation.GetValidInteger();

            bool isLeap = solver.IsLeapYear(year);
            Console.WriteLine($"Result: The year {year} is {(isLeap ? "" : "not ")}a leap year.");
        }

        // Task 6
        public void HandleSumOfDigits()
        {
            Console.WriteLine("Enter an integer number:");
            int number = UserInputValidation.GetValidInteger();

            int sum = solver.SumOfDigits(number);
            Console.WriteLine($"Result: The sum of the digits in the number {number} is {sum}.");
        }

        // Task 7
        public void HandleHasOnlyOddDigits()
        {
            Console.WriteLine("Enter an integer number:");
            int number = UserInputValidation.GetValidInteger();

            bool hasOnlyOdd = solver.HasOnlyOddDigits(number);
            Console.WriteLine($"Result: The number {number} {(hasOnlyOdd ? "contains" : "does not contain")} only odd digits.");
        }
    }
}
