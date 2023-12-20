using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (Menu()) ;
        }

        static bool Menu()
        {
            int opc;

            Console.WriteLine("Bienvenido! Selecciona una opción");
            Console.WriteLine("1) Leer texto y contar sus vocales, excepto la U");
            Console.WriteLine("2) Ingresar el número del mes y obtener la cantidad de días.");
            Console.WriteLine("3) Ingresar 10 números, calcular.");
            Console.WriteLine("4) Salir");

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
            try
            {
                string texto;
                int a = 0, e = 0, i = 0, o = 0;

                Console.WriteLine("Ingresa el texto");
                texto = Console.ReadLine();
                for (int j = 0; j < texto.Length; j++)
                {
                    if (texto[j] == 'a' || texto[j] == 'A')
                    {
                        a++;
                    }

                    if (texto[j] == 'e' || texto[j] == 'E')
                    {
                        e++;
                    }

                    if (texto[j] == 'i' || texto[j] == 'I')
                    {
                        i++;
                    }

                    if (texto[j] == 'o' || texto[j] == 'O')
                    {
                        o++;
                    }
                }

                Console.WriteLine("Cantidad de 'A': " + a);
                Console.WriteLine("Cantidad de 'E': " + e);
                Console.WriteLine("Cantidad de 'I': " + i);
                Console.WriteLine("Cantidad de 'O': " + o);
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner texto.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion1();
            }
        }

        static void Opcion2()
        {
            int a;
            List<int> mesesCon31Dias = new List<int> { 1, 3, 5, 7, 8, 10, 12 };
            List<int> mesesCon30Dias = new List<int> { 4, 6, 9, 11 };

            try
            {
                Console.WriteLine("Ingresa el número del mes:");
                a = int.Parse(Console.ReadLine());

                if (a < 1 || a > 12)
                {
                    Console.WriteLine("Este no es un número de mes válido");
                    return;
                }
                
                if (a == 2)
                {
                    Console.WriteLine("28 días, 29 los años bisiestos.");
                    return;
                }

                if (mesesCon30Dias.Contains(a))
                {
                    Console.WriteLine("30 días.");
                }

                if (mesesCon31Dias.Contains(a))
                {
                    Console.WriteLine("31 días.");
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

        static void Opcion3()
        {
            int[] nums = new int[10];
            int[] first5 = new int[5];
            int[] last5 = new int[5];
            bool negativoEncontrado = false;
            try
            {
                for (int i = 0; i < 10; i++) 
                {
                    Console.WriteLine("Ingresa un número entero:");
                    nums[i] = int.Parse(Console.ReadLine());
                }

                Array.Copy(nums, first5, 5);
                Array.Copy(nums, 5, last5, 0, 5);

                foreach (int num in first5)
                {
                    if (!(num >= 0))
                    {
                        Console.WriteLine("No podemos sumar los 5 primeros números porque al menos uno de ellos es negativo.");
                        negativoEncontrado = true;
                        break;
                    }
                }

                if (negativoEncontrado)
                {
                    int resultadoProducto = last5.Aggregate((a, x) => a * x);
                    Console.WriteLine("El producto de los últimos 5 números es " + resultadoProducto);
                }
                else
                {
                    int resultadoSumatoria = first5.Sum();
                    Console.WriteLine("La sumatoria de los primeros 5 números es " + resultadoSumatoria);
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
    }
}
