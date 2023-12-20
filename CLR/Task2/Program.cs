using System;
using System.Drawing;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Menu());
        }

        static bool Menu()
        {
            int opc;

            Console.WriteLine("Bienvenido! Selecciona una opción");
            Console.WriteLine("1) Revisar si dos enteros representan día y mes");
            Console.WriteLine("2) Ingresar un número decimal, sumar sus 2 dígitos después del punto.");
            Console.WriteLine("3) Ingresar la hora del día");
            Console.WriteLine("4) Usando ENUM");
            Console.WriteLine("5) Usando Struct");
            Console.WriteLine("6) Salir");

            try
            {
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("");
                        Opcion1();
                        return true;
                    case 2:
                        Console.WriteLine("");
                        Opcion2();
                        return true;
                    case 3:
                        Console.WriteLine("");
                        Opcion3();
                        return true;
                    case 4:
                        Console.WriteLine("");
                        Opcion4();
                        return true;
                    case 5:
                        Console.WriteLine("");
                        Opcion5();
                        return true;
                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine("Gracias por usar nuestro programa!");
                        Console.ReadKey();
                        return false;
                    default:
                        Console.Clear();
                        Console.WriteLine("Debes elegir una opción válida!");
                        Console.WriteLine("");
                        return true;
                }
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes elegir una opción válida.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
        }

        static void Opcion1()
        {
            int a;
            int b;
            int day = 31;
            int month = 12;
            bool aDay = false;
            bool bDay = false;
            bool aMonth = false;
            bool bMonth = false;
            List<int> mesesCon31Dias = new List<int> { 1, 3, 5, 7, 8, 10, 12 };
            List<int> mesesCon30Dias = new List<int> { 4, 6, 9, 11 };

            try
            {
                Console.WriteLine("Ingresa el valor de A:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de B:");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (a <= day && a > 0)
                {
                    aDay = true;
                }

                if(b <= day && b > 0)
                {
                    bDay = true;
                }

                if (!aDay && !bDay)
                {
                    Console.WriteLine("Ni A ni B pueden representar al día.");
                }

                if (a <= month && a > 0)
                {
                    aMonth = true;
                }

                if (b <= month && b > 0)
                {
                    bMonth = true;
                }

                if (!aMonth && !bMonth)
                {
                    Console.WriteLine("Ni A ni B pueden representar al mes.");
                }

                Console.WriteLine("");

                if (aDay && bMonth || aMonth && bDay)
                {
                    Console.WriteLine("Podemos representar un día y mes de las siguientes formas con estos dos números");
                    Console.WriteLine("");
                    if (aDay && a <= 31 && bMonth && mesesCon31Dias.Contains(b))
                    {
                        Console.WriteLine("" + a + "/" + b);
                        Console.WriteLine("");
                    }
                    else if (aDay && a <= 30 && bMonth && mesesCon30Dias.Contains(b))
                    {
                        Console.WriteLine("" + a + "/" + b);
                        Console.WriteLine("");
                    }
                    else if (aDay && a > 29 && bMonth && b == 2)
                    {
                        Console.WriteLine("A no puede ser día porque B en mes indica a febrero, el cual no puede tener más de 29 días");
                        Console.WriteLine("");
                    } 
                    else if (aDay && a <= 29 && bMonth && b == 2)
                    {
                        Console.WriteLine("" + a + "/" + b);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("A no puede ser día por correlación a B en mes");
                        Console.WriteLine("");
                    }

                    if (bDay && b <= 31 && aMonth && mesesCon31Dias.Contains(a))
                    {
                        Console.WriteLine("" + b + "/" + a);
                        Console.WriteLine("");
                    }
                    else if (bDay && b <= 30 && aMonth && mesesCon30Dias.Contains(a))
                    {
                        Console.WriteLine("" + b + "/" + a);
                        Console.WriteLine("");
                    }
                    else if (bDay && b > 29 && aMonth && a == 2)
                    {
                        Console.WriteLine("B no puede ser día porque A en mes indica a febrero, el cual no puede tener más de 29 días");
                        Console.WriteLine("");
                    }
                    else if (bDay && b <= 29 && aMonth && a == 2)
                    {
                        Console.WriteLine("" + b + "/" + a);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("B no puede ser día por correlación a A en mes");
                        Console.WriteLine("");
                    }
                } 
                else
                {
                    Console.WriteLine("Solamente uno de los valores puede representar a un día o mes, el otro no.");
                }

                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner números enteros.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion1();
            }
        }

        static void Opcion2()
        {
            string numero;
            int resultado;
            string[] subs;
            char[] nums;
            int num1;
            int num2;
            try
            {
                Console.WriteLine("Ingresa el número decimal");
                numero = Console.ReadLine();

                if (Decimal.TryParse(numero, out decimal num))
                {
                    numero = String.Format("{0:0.00}", numero);
                    subs = numero.Split('.');
                    if (subs.Count() > 1)
                    {
                        nums = subs[1].ToCharArray();
                        if (nums.Count() > 1)
                        {
                            num1 = int.Parse(nums[0].ToString());
                            num2 = int.Parse(nums[1].ToString());
                            resultado = num1 + num2;
                            Console.WriteLine("La suma de los dos primeros dígitos es: " + resultado);
                        } 
                        else
                        {
                            Console.WriteLine("Este decimal no contiene más de 1 dígito luego del punto.");
                        }
                    } 
                    else
                    {
                        Console.WriteLine("No ingresaste un número decimal.");
                    }
                } 
                else
                {
                    Console.WriteLine("No ingresaste un número decimal.");
                }
                
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo números decimales.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion2();
            }
        }

        static void Opcion3()
        {
            int num;

            try
            {
                Console.WriteLine("Ingresa el número que equivaldrá a la hora del día:");
                num = int.Parse(Console.ReadLine());

                if (num < 0 || num > 24)
                {
                    Console.WriteLine("No es una hora válida");
                }
                else if(num >= 4 && num < 12) 
                {
                    Console.WriteLine("Buenos días!");
                }
                else if (num >= 12 && num < 20)
                {
                    Console.WriteLine("Buenas tardes!");
                }
                else if ((num >= 20 && num <= 24) || num < 3)
                {
                    Console.WriteLine("Buenas noches!");
                }
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner una hora correcta.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion3();
            }
        }

        enum TestCaseStatus { Pass, Fail, Blocked, WP, Unexecuted };

        static void Opcion4() 
        {
            TestCaseStatus test1Status = TestCaseStatus.Pass;
            Console.WriteLine("La variable test1Status contiene {0}.", test1Status);
            Console.WriteLine("");
            Console.WriteLine("Pulsa una tecla para volver al menú");
            Console.ReadKey();
            Console.Clear();
        }
        
        [Serializable]
        public struct RGB
        {
            public byte Red;
            public byte Green;
            public byte Blue;

            public void info(string color)
            {
                Console.WriteLine("Los valores para el color " + color + " son: R = " + Red + "; G = " + Green + "; B = " + Blue + ";");
            }
        }
        static void Opcion5()
        {
            RGB blanco;
            blanco.Red = 255;
            blanco.Green = 255;
            blanco.Blue = 255;

            RGB negro;
            negro.Red = 0;
            negro.Green = 0;
            negro.Blue = 0;

            blanco.info("Blanco");
            negro.info("Negro");
            Console.WriteLine("");
            Console.WriteLine("Pulsa una tecla para volver al menú");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
