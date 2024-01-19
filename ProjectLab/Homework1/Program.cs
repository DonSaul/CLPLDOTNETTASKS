using System;
namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Calculate area and perimeter of square
            int a;
            bool isValidA = false;
            Console.WriteLine("Task 1: Calculate area and perimeter of square\n");

            do
            {
                Console.Write("Enter the value of a: ");
                string inputA = Console.ReadLine();

                if (int.TryParse(inputA, out a) && a > 0)
                {
                    isValidA = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive integer for 'a'.");
                }
            } while (!isValidA);

            int areaSquare = a * a;
            int perimeterSquare = 4 * a;

            Console.WriteLine("Area of square: {0}", areaSquare);
            Console.WriteLine("Perimeter of square: {0}", perimeterSquare);


            // Task 2: Read user's name and age
            string name = string.Empty;
            int age;
            Console.WriteLine("\nTask 2: Read user's name and age\n");

            do
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Please enter a valid name.");
                }
            } while (string.IsNullOrWhiteSpace(name));

            bool isValidAge = false;
            do
            {
                Console.WriteLine("How old are you, {0}?", name);
                string inputAge = Console.ReadLine();

                if (int.TryParse(inputAge, out age) && age > 0)
                {
                    isValidAge = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive integer for age.");
                }
            } while (!isValidAge);

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);

            // Task 3: Calculate perimeter, area, and volume of circle
            double r;
            bool isValidR = false;
            Console.WriteLine("\nTask 3: Calculate perimeter, area, and volume of circle\n");
            do
            {
                Console.Write("Enter the value of r: ");
                string inputR = Console.ReadLine();

                if (double.TryParse(inputR, out r) && r > 0)
                {
                    isValidR = true;
                }
                else
                {
                    Console.WriteLine("Please enter a valid positive number for 'r'.");
                }
            } while (!isValidR);

            double perimeterCircle = 2 * Math.PI * r;
            double areaCircle = Math.PI * r * r;
            double volumeCircle = (4.0 / 3.0) * Math.PI * r * r * r;

            Console.WriteLine("Perimeter of circle: {0:F4}", perimeterCircle);
            Console.WriteLine("Area of circle: {0:F4}", areaCircle);
            Console.WriteLine("Volume of circle: {0:F4}", volumeCircle);
        }
    }
}
