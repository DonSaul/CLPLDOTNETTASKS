using System;

/*
 
SoftServe | Homework 1

Author: Claudio Rain

Date: 27 nov 2023
 
*/


class Program
{
    public static void Main()
    {
        try
        {
            PerformSquareCalculations();
            GetUserInformation();
            PerformCircleCalculations();

            Console.WriteLine("\nMany thanks for trying this program! Have a good day! Process Terminated.");

        }
        catch (Exception ex) // Captures any unextepected exepction
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }


    /*
    This method prompts the user to enter the side length of a square and
    calculates and displays its area and perimeter.
 
    Accepted inputs:
        - Length side: Positive number (including decimals)
    */
    public static void PerformSquareCalculations()
    {
        while (true)
        {
            Console.WriteLine("Enter the side length of the square in cm (Ex: 15.6):");

            if (TryReadPositiveDouble(out double sideLength))
            {
                double areaSquare = sideLength * sideLength; // Calculate area
                areaSquare = Math.Round(areaSquare, 2); // Round the results to two decimal places
                
                double perimeterSquare = 4 * sideLength; // Calculate perimeter
                Console.WriteLine($"Area of Square: {areaSquare} cm²");
                Console.WriteLine($"Perimeter of Square: {perimeterSquare} cm\n");
                break;
            }
            else
            {
                Console.WriteLine("Oops, it looks like something went wrong. Please enter a positive number. For example, you could write 15.75");
            }
        }
    }


    /*
    This method asks for the user's name and age and then displays them.

    Accepted inputs:
        - Name: Accepts any string as a valid name.
        - Age: Positive whole numbers. 
    */
    public static void GetUserInformation()
    {
        Console.WriteLine("What is your name?");

        string name = Console.ReadLine();

        while (true)
        {
            Console.WriteLine($"How old are you, {name}?");

            if (TryReadPositiveInt(out int age))
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}\n");
                break;
            }
            else
            {
                Console.WriteLine("Oops! That doesn't seem right. Please enter a positive number for your age (for example, 30).");
            }
        }
    }



    /*
    This method prompts the user to enter the radius of a circle and
    calculates and displays the length, area and volume of a circle.
    
    Accepted Inputs:
       - Radius: Positive numbers (including decimals).
    */
    public static void PerformCircleCalculations()
    {
        while (true)
        {

            Console.WriteLine("Enter the radius of the circle in cm (Ex: 3.14):");

            if (TryReadPositiveDouble(out double r))
            {
                double lengthCircle = 2 * Math.PI * r; // Calculate circumference
                double areaCircle = Math.PI * r * r; // Calculate area
                double volumeSphere = (4.0 / 3) * Math.PI * Math.Pow(r, 3); // Calculate volume of sphere

                // Round the results to two decimal places
                lengthCircle = Math.Round(lengthCircle, 2);
                areaCircle = Math.Round(areaCircle, 2);
                volumeSphere = Math.Round(volumeSphere, 2);

                Console.WriteLine($"Length of Circle: {lengthCircle} cm");
                Console.WriteLine($"Area of Circle: {areaCircle} cm²");
                Console.WriteLine($"Volume of Sphere: {volumeSphere} cm³");
                break;
            }
            else
            {
                Console.WriteLine("Oops, it looks like something went wrong. Please enter a positive number. For example, you could write 15.75.");
            }
        }
    }

    public static bool TryReadPositiveDouble(out double number)
    {
        number = 0;
        if (double.TryParse(Console.ReadLine(), out double input) && input > 0)
        {
            number = input;
            return true;
        }
        return false;
    }

    public static bool TryReadPositiveInt(out int number)
    {
        number = 0;
        if (int.TryParse(Console.ReadLine(), out int input) && input > 0)
        {
            number = input;
            return true;
        }
        return false;
    }
}
