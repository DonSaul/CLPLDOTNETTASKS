using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
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
            Console.WriteLine("1) Calcular suma, resta, multiplicación y división de A y B enteros");
            Console.WriteLine("2) Mostrar como estás!");
            Console.WriteLine("3) Ingresar 3 caracteres");
            Console.WriteLine("4) Ingresar 2 enteros y ver si son positivos");
            Console.WriteLine("5) Salir");

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
                        Console.WriteLine("Gracias por usar nuestro programa!");
                        Console.ReadKey();
                        return false;
                    default:
                        Console.Clear();
                        Console.WriteLine("Debes elegir una opción válida!");
                        Console.WriteLine("");
                        return true;
                }
            } catch (Exception e) {
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
            try
            {
                Console.WriteLine("Ingresa el valor de A:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de B:");
                b = int.Parse(Console.ReadLine());

                int sum = a + b;
                int res = a - b;
                int mul = a * b;
                int div = a / b;

                Console.WriteLine("La suma de ambos números es: " + sum);
                Console.WriteLine("La resta de ambos números es: " + res);
                Console.WriteLine("La multiplicación de ambos números es: " + mul);
                Console.WriteLine("La división de ambos números es: " + div);
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner números enteros y no dividir por 0.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion1();
            }
        }

        static void Opcion2()
        {
            string respuesta;
            try
            {
                Console.WriteLine("¿Cómo estás?");
                respuesta = Console.ReadLine();

                if(!Regex.IsMatch(respuesta, @"^[a-zA-Z]+$"))
                {
                    throw new Exception();
                }

                Console.WriteLine("Estás " + respuesta);
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo letras.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion2();
            }
        }

        static void Opcion3()
        {
            char firstChar;
            char secondChar;
            char thirdChar;
            try
            {
                Console.WriteLine("Ingresa el primer char:");
                firstChar = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo char:");
                secondChar = char.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer char:");
                thirdChar = char.Parse(Console.ReadLine());

                Console.WriteLine("Escribiste {0}, {1}, {2} ", firstChar, secondChar, thirdChar);
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo 1 carácter.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion3();
            }
        }

        static void Opcion4()
        {
            int a;
            int b;
            bool aIsPositive;
            bool bIsPositive;
            try
            {
                Console.WriteLine("Ingresa el valor de A:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de B:");
                b = int.Parse(Console.ReadLine());

                aIsPositive = a >= 0 ? true : false;
                bIsPositive = b >= 0 ? true : false;

                Console.WriteLine("");

                if (aIsPositive) {
                    Console.WriteLine("A es positivo");
                } else {
                    Console.WriteLine("A es negativo");
                }

                if (bIsPositive) {
                    Console.WriteLine("B es positivo");
                } else {
                    Console.WriteLine("B es negativo");
                }
                
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo números enteros.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion4();
            }
        }
    }
}
