using System;
using Task_3.src;

class Program
{
    static void Main(string[] args)
    {
        var userInteraction = new UserInteraction();

        Console.WriteLine("Task 1: Count Integers Divisible by 3 in a Range");
        userInteraction.HandleDivisibleByThree();

        Console.WriteLine("\nTask 2: Print Every Second Character in a String");
        userInteraction.HandlePrintEverySecondChar();

        Console.WriteLine("\nTask 3: Get Drink Price");
        userInteraction.HandleGetDrinkPrice();

        Console.WriteLine("\nTask 4: Calculate Arithmetic Average of Positive Integers");
        userInteraction.HandleCalculateAverage();

        Console.WriteLine("\nTask 5: Check if a Year is a Leap Year");
        userInteraction.HandleIsLeapYear();

        Console.WriteLine("\nTask 6: Find Sum of Digits of an Integer");
        userInteraction.HandleSumOfDigits();

        Console.WriteLine("\nTask 7: Check if Integer Contains Only Odd Numbers");
        userInteraction.HandleHasOnlyOddDigits();

        Console.WriteLine("\nMany thanks for trying this program! Have a good day! Process Terminated.");
    }
}
