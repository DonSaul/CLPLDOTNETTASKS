using System;
using Task_3.src;

class Program
{
    static void Main(string[] args) // Ensure 'Main' is capitalized
    {
        var userInteraction = new UserInteraction();

        Console.WriteLine("Task #1:");
        userInteraction.HandleDivisibleByThree();

        Console.WriteLine("\nTask #2:");
        userInteraction.HandlePrintEverySecondChar();

        Console.WriteLine("\nTask #3:");
        userInteraction.HandleGetDrinkPrice();

        Console.WriteLine("\nTask #4:");
        userInteraction.HandleCalculateAverage();

        Console.WriteLine("\nTask #5:");
        userInteraction.HandleIsLeapYear();

        Console.WriteLine("\nTask #6:");
        userInteraction.HandleSumOfDigits();

        Console.WriteLine("\nTask #7:");
        userInteraction.HandleHasOnlyOddDigits();

        Console.WriteLine("\nMany thanks for trying this program! Have a good day! Process Terminated.");
    }
}
