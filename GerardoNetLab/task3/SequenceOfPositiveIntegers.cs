using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class SequenceOfPositiveIntegers
    {
        private static List<int> numbers = new List<int>();

        public static void ProcessNumbers()
        {
            Console.WriteLine("Ingresa la secuencia de números positivos, ingresa uno negativo para finalizar.");

            while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out int number))
                {
                    if (number < 0)
                        break;

                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Número invalido, ingresar un entero.");
                }
            }

            if (numbers.Any())
            {
                double average = numbers.Average();
                Console.WriteLine($"El promedio de los números es: {average}");
            }
            else
            {
                Console.WriteLine("No se ingresaron enteros.");
            }
        }
    }
}
