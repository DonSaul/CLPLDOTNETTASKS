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
            int opc;

            Console.WriteLine("Bienvenido! Selecciona una opción");
            Console.WriteLine("1) Leer 3 números float, verificar si entran en rango [-5, 5]");
            Console.WriteLine("2) Leer 3 números enteros, escribir el más grande y el más pequeño.");
            Console.WriteLine("3) Leer número de HTTP Error y mostrar el mensaje de error");
            Console.WriteLine("4) Crear un struct de un Perro con sus atributos correspondientes.");
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
            float num1;
            float num2;
            float num3;

            try
            {
                Console.WriteLine("Ingresa el primer número:");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número:");
                num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer número:");
                num3 = float.Parse(Console.ReadLine());

                Console.WriteLine("");

                if (num1 <= 5 && num1 >= -5)
                    if (num2 <= 5 && num2 >= -5)
                        if (num3 <= 5 && num3 >= -5)
                            Console.WriteLine("Todos los números están dentro del rango.");
                        else
                            Console.WriteLine("No todos los números están dentro del rango.");
                    else
                        Console.WriteLine("No todos los números están dentro del rango.");
                else
                    Console.WriteLine("No todos los números están dentro del rango.");

                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner números.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion1();
            }
        }

        static void Opcion2()
        {
            int[] numeros = new int[3];
            try
            {
                Console.WriteLine("Ingresa el primer número:");
                numeros[0] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo número:");
                numeros[1] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el tercer número:");
                numeros[2] = int.Parse(Console.ReadLine());

                Array.Sort(numeros);

                Console.WriteLine("El número más pequeño es: " + numeros[0].ToString());
                Console.WriteLine("El número más grande es: " + numeros[2].ToString());


                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo números.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion2();
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

        static void Opcion3()
        {
            int errorNum;

            try
            {
                Console.WriteLine("Ingresa el número de error:");
                errorNum = int.Parse(Console.ReadLine());
                if(errorNum < 400 || errorNum > 499)
                {
                    Console.WriteLine("Este no es un código de error 400.");
                    Console.WriteLine("");
                    return;
                }
                HTTPError status = (HTTPError)errorNum;
                if(int.TryParse(status.ToString(), out int i))
                {
                    Console.WriteLine("No existe este número de error 400");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("El error es " + status.ToString());
                    Console.WriteLine("");
                }
                
                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo números desde el 400 al 499.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion3();
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
                Console.WriteLine("El perro se llama " + Name + " de Raza " + Breed + " y de edad " + Age + ".");
            }
        }
        static void Opcion4()
        {
            Dog perro;

            try
            {
                Console.WriteLine("Ingresa el nombre del perro:");
                perro.Name = Console.ReadLine();
                Console.WriteLine("Ingresa la raza del perro:");
                perro.Breed = Console.ReadLine();
                Console.WriteLine("Ingresa la edad del perro:");
                perro.Age = int.Parse(Console.ReadLine());

                perro.myDog();

                Console.WriteLine("Pulsa una tecla para volver al menú");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Ocurrió un error fatal, probablemente debes poner solo números en la edad.");
                Console.WriteLine("");
                Console.WriteLine("Pulsa una tecla para volver a intentarlo");
                Console.ReadKey();
                Console.Clear();
                Opcion4();
            }
        }
    }
}
