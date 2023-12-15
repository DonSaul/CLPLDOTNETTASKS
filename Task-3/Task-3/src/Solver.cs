using System;


namespace Task_3.src
{
    public class Solver
    {
        public Solver() { }

        // 1. Count integers divisible by 3 in a range
        public int CountDivisibleByThree(int a, int b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        // 2. Print every second character of a string
        public string PrintEverySecondChar(string str)
        {
            string result = "";
            for (int i = 1; i < str.Length; i += 2)
            {
                result += str[i];
            }
            return result;
        }

        // 3. Print the name of the drink and its price
        public string GetDrinkPrice(string drinkName)
        {
            switch (drinkName.ToLower())
            {
                case "coffee": return "$2";
                case "tea": return "$1.5";
                case "juice": return "$3";
                case "water": return "$1";
                default: return "Drink not found";
            }
        }

        // 4. Calculate the arithmetic average of a sequence of positive integers
        public double CalculateIntegersAverage(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0) return 0;

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum / (double)numbers.Count;
        }

        // 5. Check if a year is a leap year
        public bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // 6. Find the sum of digits of an integer
        public int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return Math.Abs(sum);
        }

        // 7. Check if an integer has only odd digits
        public bool HasOnlyOddDigits(int number)
        {
            number = Math.Abs(number); // Handle negative numbers
            while (number > 0)
            {
                if ((number % 10) % 2 == 0) return false;
                number /= 10;
            }
            return true;
        }
    }

}

