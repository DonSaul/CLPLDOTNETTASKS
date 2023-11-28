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
            int opc;

            Console.WriteLine("Bienvenido! Selecciona una opción");
            Console.WriteLine("1) Calcular área y perímetro de cuadrado");
            Console.WriteLine("2) Ingresar nombre y edad");
            Console.WriteLine("3) Calcular largo, área y volumen de un círculo");
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
            int a;
            try
            {
                Console.WriteLine("Ingresa el valor en centímetros:");
                a = int.Parse(Console.ReadLine());

                int perimetro = a * 4;
                int area = a * a;

                Console.WriteLine("El perímetro del cuadrado es de " + perimetro + "cms");
                Console.WriteLine("El área del cuadrado es de " + area + "cms^2");
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
            int edad;
            string nombre;
            try
            {
                Console.WriteLine("¿Cómo te llamas?");
                nombre = Console.ReadLine();

                if (!Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
                {
                    throw new Exception();
                }

                Console.WriteLine("¿Cuál es tu edad, " + nombre + "?");
                edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Tu nombre es " + nombre + " y tienes " + edad + " años.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo letras en tu nombre y números enteros en tu edad.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion2();
            }
        }

        static void Opcion3()
        {
            double r;
            try
            {
                Console.WriteLine("Ingresa el valor:");
                r = double.Parse(Console.ReadLine());

                double largo = 2 * Math.PI * r;
                double area = Math.PI * r * r;
                double volumen = (double)4/3 * Math.PI * r * r * r;

                Console.WriteLine("Largo: {0}, Área: {1}, Volumen: {2} ", largo, area, volumen);
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo números." + e.GetBaseException());
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion3();
            }
        }
    }
}
