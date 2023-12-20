using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
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
            Console.WriteLine("1) Read 3 float numbers and check: are they all belong to the range [-5,5].");
            Console.WriteLine("2) Read 3 integers and write max and min of them..");
            Console.WriteLine("3) Read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)");
            Console.WriteLine("4) Declare struct Dog with fields Name, Mark, Age. Declare variable myDog of Dog type and read values for it.\n Output myDog into console. (Declare method ToString in struct)");
            Console.WriteLine("5) Quit");

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
            float num1;
            float num2;
            float num3;

            try
            {
                Console.WriteLine("Enter the first number:");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third number:");
                num3 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (num1 <= 5 && num1 >= -5)
                    if (num2 <= 5 && num2 >= -5)
                        if (num3 <= 5 && num3 >= -5)
                            Console.WriteLine("All numbers are in the [-5,5] range.");
                        else
                            Console.WriteLine("Not all numbers are in the range.");
                    else
                        Console.WriteLine("Not all numbers are in the range.");
                else
                    Console.WriteLine("Not all numbers are in the range.");

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
            int[] nums = new int[3];
            try
            {
                Console.WriteLine("Ingresa el primer número:");
                nums[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número:");
                nums[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer número:");
                nums[2] = int.Parse(Console.ReadLine());

                Array.Sort(nums);

                Console.WriteLine("Min number is: " + nums[0].ToString());
                Console.WriteLine("Max number is: " + nums[2].ToString());


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
                Option2();
            }
        }
        enum HTTPError
        {
            Bad_Request = 400,
            Unauthorized,
            Payment_Required,
            Forbidden,
            Not_Found,
            Method_Not_Allowed,
            Not_Acceptable,
            Proxy_Authentication_Required,
            Request_Timeout,
            Conflict,
            Gone,
            Length_Required,
            Precondition_Failed,
            Payload_Too_Large,
            URI_Too_Long,
            Unsupported_Media_Type,
            Range_Not_Satisfiable,
            Expectation_Failed,
            Im_a_Teapot,
            Misdirected_Request = 421,
            Unprocessable_Entity,
            Locked,
            Failed_Dependency,
            Too_Early,
            Upgrade_Required,
            Precondition_Required = 428,
            Too_Many_Requests,
            Request_Header_Fields_Too_Large = 431,
            Unavailable_For_Legal_Reasons = 451
        };

        static void Option3()
        {
            int errorNum;

            try
            {
                Console.WriteLine("Enter HTTP Error:");
                errorNum = int.Parse(Console.ReadLine());
                if(errorNum < 400 || errorNum > 499)
                {
                    Console.WriteLine("this isn't a 400 error code.");
                    Console.WriteLine("");
                    return;
                }
                HTTPError status = (HTTPError)errorNum;
                if(int.TryParse(status.ToString(), out int i))
                {
                    Console.WriteLine("this 400 error code doesn't exists");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("The error is " + status.ToString());
                    Console.WriteLine("");
                }

                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered, maybe you should input numbers from 400 to 499 only.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option3();
            }
        }

        [Serializable]
        public struct Dog
        {
            public string Name;
            public string Breed;
            public int Age;

            public void myDog()
            {
                Console.WriteLine("The dog is named " + Name + ", it's a  " + Breed + " breed, and it's " + Age + " years old.");
            }
        }
        static void Option4()
        {
            Dog dog;

            try
            {
                Console.WriteLine("Enter the name of the dog:");
                dog.Name = Console.ReadLine();
                Console.WriteLine("Enter the breed of the dog:");
                dog.Breed = Console.ReadLine();
                Console.WriteLine("Enter the age of the dog:");
                dog.Age = int.Parse(Console.ReadLine());

                dog.myDog();

                Console.WriteLine("Press a button to go back to the menu");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("A fatal error was encountered.");
                Console.WriteLine("");
                Console.WriteLine("Press a button to try again");
                Console.ReadKey();
                Console.Clear();
                Option4();
            }
        }
    }
}
