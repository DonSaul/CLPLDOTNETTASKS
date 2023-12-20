using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Menu()) ;
        }

        static bool Menu()
        {
            int opt;

            Console.WriteLine("Welcome! Choose an option");
            Console.WriteLine("1) Enter a and b are two integers. Calculate how many integers in the range [a..b] are divided by 3 without remainder..");
            Console.WriteLine("2) Enter a character string. Print each second character");
            Console.WriteLine("3) Enter the name of the drink (coffee, tea, juice, water). Print the name of the drink and its price.");
            Console.WriteLine("4) Enter a sequence of positive integers (to the first negative). Calculate the arithmetic average of the entered numbers.");
            Console.WriteLine("5) Check whether the entered year is a leap.");
            Console.WriteLine("6) Find the sum of digits of the entered integer number");
            Console.WriteLine("7) Check whether the entered integer number contains only odd numbers");
            Console.WriteLine("8) Quit");

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
                        Option4();
                        return true;
                    case 5:
                        Console.WriteLine("");
                        Option5();
                        return true;
                    case 6:
                        Console.WriteLine("");
                        Option6();
                        return true;
                    case 7:
                        Console.WriteLine("");
                        Option7();
                        return true;
                    case 8:
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
            int a, b, dividedBy3 = 0;
            try
            {
                Console.WriteLine("Enter the first number:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                b = int.Parse(Console.ReadLine());

                for (int i = a + 1; i < b; i++)
                {
                    if (i % 3 == 0)
                    {
                        dividedBy3++;
                    }
                }

                Console.WriteLine("The amount of numbers between " + a + " and " + b + " divided by 3 without remainder are " + dividedBy3);
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should input numbers only.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option1();
            }
        }

        static void Option2()
        {
            string text;

            try
            {
                Console.WriteLine("Enter text:");
                text = Console.ReadLine();
                var secondChar = string.Empty;
                for (int i = 1; i < text.Length; i += 2)
                {
                    secondChar += text.Substring(i, 1);
                }
                Console.WriteLine("Each second character: " + secondChar);

                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should input text only.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option2();
            }
        }

        static void Option3()
        {
            string[,] drinks = { { "coffee", 4.ToString() }, { "tea", 2.ToString() }, { "juice", 3.ToString() }, { "water", 1.ToString() } };
            string texto;
            try
            {
                Console.WriteLine("Enter the name of the drink you want from the menu!");
                Console.WriteLine("- Coffee");
                Console.WriteLine("- Tea");
                Console.WriteLine("- Juice");
                Console.WriteLine("- Water");
                texto = Console.ReadLine();

                if (texto.ToLower() != "coffee" && texto.ToLower() != "tea" && texto.ToLower() != "juice" && texto.ToLower() != "water")
                {
                    Console.WriteLine("Not a drink we have on the menu!");
                    return;
                }

                for (int i = 0; i < drinks.GetLength(0); i++)
                {
                    if (drinks[i, 0] == texto.ToLower())
                    {
                        Console.WriteLine("The price for " + drinks[i, 0] + " is $" + drinks[i, 1]);
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should try to order only with the names on the menu.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option3();
            }
        }

        static void Option4()
        {
            List<int> numbers = new List<int>();
            int num = 0;
            try
            {
                while (num >= 0)
                {
                    Console.WriteLine("Enter a number:");
                    num = int.Parse(Console.ReadLine());
                    if (num >= 0)
                    {
                        numbers.Add(num);
                    }
                }

                int[] nums = numbers.ToArray();
                double avg = Queryable.Average(nums.AsQueryable());

                Console.WriteLine("The average of these numbers is " + avg);
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should try only integer numbers.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option4();
            }
        }

        static void Option5()
        {
            int year;
            try
            {
                Console.WriteLine("Enter the year you want to check");
                year = int.Parse(Console.ReadLine());
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("It's a leap year");
                }
                else
                {
                    Console.WriteLine("It's not a leap year");
                }

                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should try only integer numbers.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option5();
            }
        }

        static void Option6()
        {
            int num, sum = 0, res;
            try
            {
                Console.WriteLine("Enter a number");
                num = int.Parse(Console.ReadLine());
                while (num > 0)
                {
                    res = num % 10;
                    sum = sum + res;
                    num = num / 10;
                }
                Console.WriteLine("The sum of it's digits is " + sum);
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should try only integer numbers.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option6();
            }
        }

        static void Option7()
        {
            int countOdd = 0;
            string num;
            try
            {
                Console.WriteLine("Enter a number");
                num = Console.ReadLine();

                for (int i = 0; i < num.Length; i++)
                {
                    if ((int.Parse(num[i].ToString()) % 2) != 0)
                    {
                        countOdd++;
                    }
                }

                if (countOdd == num.Length)
                {
                    Console.WriteLine("Contains only odd numbers");
                }
                else
                {
                    Console.WriteLine("Doesn't contains only odd numbers");
                }
                Console.WriteLine("");
                Console.WriteLine("Press a button to go back to the main menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should try only integer numbers.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option6();
            }
        }
    }
}
