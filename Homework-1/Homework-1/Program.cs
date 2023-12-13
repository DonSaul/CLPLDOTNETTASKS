using System;

class Program
{
    public static void Main()
    {
        try
        {
            
            // Step 1: Perform calculations related to a square
            PerformSquareCalculations();

            // Step 2: Gather user information
            GetUserInformation();

            // Step 3: Perform calculations related to a circle
            PerformCircleCalculations();

            Console.WriteLine("\nAll calculations complete!");
            Console.WriteLine("Many thanks for trying this program! Have a good day! Process Terminated.");
        }
        catch (Exception ex) // Captures any unexpected exception
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
        Console.WriteLine("Task 1: Square Calculations");
        Console.WriteLine("----------------------------");

        while (true)
        {
            Console.WriteLine("Enter the side length of the square(e.g., 15.6):");

            if (TryReadPositiveDouble(out double sideLength))
            {
                double areaSquare = Math.Round(sideLength * sideLength, 2); // Calculate and round area
                double perimeterSquare = 4 * sideLength; // Calculate perimeter

                // Format numbers with thousand separators and two decimal places
                string formattedAreaSquare = areaSquare.ToString("N2");
                string formattedPerimeterSquare = perimeterSquare.ToString("N2");
                


                Console.WriteLine($"Area of Square: {formattedAreaSquare}");
                Console.WriteLine($"Perimeter of Square: {formattedPerimeterSquare}\n");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("Please enter a positive number. For example, 15.75");
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
        Console.WriteLine("Task 2: User Information");
        Console.WriteLine("----------------------------");

        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        while (true)
        {
            Console.WriteLine($"How old are you, {name}?");
            if (TryReadPositiveInt(out int age))
            {
                Console.WriteLine($"Confirmed! Name: {name}, Age: {age}\n");
                Console.WriteLine();

                break;
            }
            else
            {
                Console.WriteLine("Please enter a positive number for your age (e.g., 30).");
            }
        }
    }

    /*
    This method prompts the user to enter the radius of a circle and
    calculates and displays the circumference, area, and volume of a sphere.

    Accepted Inputs:
       - Radius: Positive numbers (including decimals).
    */
    public static void PerformCircleCalculations()
    {
        Console.WriteLine("Task 3: Circle Calculations");
        Console.WriteLine("----------------------------");

        while (true)
        {
            Console.WriteLine("Enter the radius of the circle (e.g., 3.14):");
            if (TryReadPositiveDouble(out double r))
            {
                double lengthCircle = Math.Round(2 * Math.PI * r, 2); // Calculate and round circumference
                double areaCircle = Math.Round(Math.PI * r * r, 2); // Calculate and round area
                double volumeSphere = Math.Round((4.0 / 3) * Math.PI * Math.Pow(r, 3), 2); // Calculate and round volume of sphere


                // Format numbers with thousand separators and two decimal places
                string formattedLengthCircle = lengthCircle.ToString("N2");
                string formattedAreaCircle = areaCircle.ToString("N2");
                string formattedVolumeSphere = volumeSphere.ToString("N2");

                Console.WriteLine($"Length of Circle: {formattedLengthCircle}");
                Console.WriteLine($"Area of Circle: {formattedAreaCircle}");
                Console.WriteLine($"Volume of Sphere: {formattedVolumeSphere}");
                Console.WriteLine();

                break;
            }
            else
            {
                Console.WriteLine("Please enter a positive number. For example, 15.75.");
            }
        }
    }

    // Method to read and validate a positive double value
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

    // Method to read and validate a positive integer value
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
