using System;
using System.Collections.Generic;
using Task_3.src.Util;

namespace Task_3.src
{
    public class UserInteraction
    {
        private Solver solver = new Solver();

        // Task 1
        public void HandleDivisibleByThree()
        {
            Console.WriteLine("Enter two integers (a and b):");
            int a = UserInputValidation.GetValidInteger();
            int b = UserInputValidation.GetValidInteger();

            int count = solver.CountDivisibleByThree(a, b);
            Console.WriteLine($"Count of integers divisible by 3 in range [{a}..{b}]: {count}");
        }

        // Task 2
        public void HandlePrintEverySecondChar()
        {
            Console.WriteLine("Enter a string:");
            string str = UserInputValidation.GetValidString();

            string result = solver.PrintEverySecondChar(str);
            Console.WriteLine($"Every second character: {result}");
        }

        // Task 3
        public void HandleGetDrinkPrice()
        {
            Console.WriteLine("Enter the name of the drink (coffee, tea, juice, water):");
            string[] validDrinks = new string[] { "coffee", "tea", "juice", "water" };
            string drink = UserInputValidation.GetValidStringFromOptions(validDrinks);

            string priceInfo = solver.GetDrinkPrice(drink);
            Console.WriteLine(priceInfo);
        }

        // Task 4
        public void HandleCalculateAverage()
        {
            var numbers = UserInputValidation.GetPositiveIntegersSequence();

            double average = solver.CalculateAverage(numbers);
            Console.WriteLine($"Arithmetic average: {average}");
        }

        // Task 5
        public void HandleIsLeapYear()
        {
            Console.WriteLine("Enter a year:");
            int year = UserInputValidation.GetValidInteger();

            bool isLeap = solver.IsLeapYear(year);
            Console.WriteLine(isLeap ? $"{year} is a leap year." : $"{year} is not a leap year.");
        }

        // Task 6
        public void HandleSumOfDigits()
        {
            Console.WriteLine("Enter an integer number:");
            int number = UserInputValidation.GetValidInteger();

            int sum = solver.SumOfDigits(number);
            Console.WriteLine($"Sum of digits: {sum}");
        }

        // Task 7
        public void HandleHasOnlyOddDigits()
        {
            Console.WriteLine("Enter an integer number:");
            int number = UserInputValidation.GetValidInteger();

            bool hasOnlyOdd = solver.HasOnlyOddDigits(number);
            Console.WriteLine(hasOnlyOdd ? "The number contains only odd digits." : "The number does not contain only odd digits.");
        }
    }
}
