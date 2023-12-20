using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Menu());
        }

        static bool Menu()
        {
            int opt;

            Console.WriteLine("Welcome! Choose an option");
            Console.WriteLine("1) Define integer variable a. Read the value of a from console and calculate area and perimeter of square with length a. Output obtained results.");
            Console.WriteLine("2) define string variable name and integer value age. Output question 'What is your name?';Read the value name and output next question: 'How old are you,(name)?'. Read age and write whole information ");
            Console.WriteLine("3) Read double number r and calculate the length (l=2*pi*r), area (S=pi*r*r) and volume (4/3*pi*r*r*r) of a circle of given r");
            Console.WriteLine("4) Quit");

            try
            {
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("");
                        Option1();
                        return true;
                    case 2:
                        Console.WriteLine("");
                        Option2();
                        return true;
                    case 3:
                        Console.WriteLine("");
                        Option3();
                        return true;
                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine("Thanks for using our program!");
                        Console.ReadKey();
                        return false;
                    default:
                        Console.Clear();
                        Console.WriteLine("You must pick a valid option!");
                        Console.WriteLine("");
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should pick a valid option.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
        }

        static void Option1()
        {
            int a;
            try
            {
                Console.WriteLine("Enter cms value of A:");
                a = int.Parse(Console.ReadLine());

                int perimeter = a * 4;
                int area = a * a;

                Console.WriteLine("The perimeter of the square is of " + perimeter + "cms");
                Console.WriteLine("The area of the square is of " + area + "cms^2");
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should input integer numbers only.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option1();
            }
        }

        static void Option2()
        {
            int age;
            string name;
            try
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                if (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
                {
                    throw new Exception();
                }

                Console.WriteLine("How old are you,{0}?", name);
                age = int.Parse(Console.ReadLine());

                Console.WriteLine("Your name is " + name + " and you are " + age + " years old.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should input numbers on your age, and letters on your name.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option2();
            }
        }

        static void Option3()
        {
            double r;
            try
            {
                Console.WriteLine("Enter value of r:");
                r = double.Parse(Console.ReadLine());

                double length = 2 * Math.PI * r;
                double area = Math.PI * r * r;
                double volume = (double)4/3 * Math.PI * r * r * r;

                Console.WriteLine("Length: {0}, Area: {1}, Volume: {2} ", length, area, volume);
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should input numbers.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option3();
            }
        }
    }
}
