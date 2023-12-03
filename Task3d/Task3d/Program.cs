using System;
using System.Xml.Linq;

class Task3d
{
    static void Main()
    {
    

        try
        {
            Console.WriteLine("Ingrese la cantidad de numero que desea sacar el promedio");
            int Cantidad = Convert.ToInt32(Console.ReadLine());
            int[] Numeros = new int[Cantidad];
            if (Cantidad <= 0) throw new Exception("La cantidad no puede ser negativa o 0");
            Console.WriteLine("Para calcular el primerio los numeros deben ser positivos a excepción del primero");
            Console.WriteLine("Ingrese el primer numero (Debe ser negativo)");
            Numeros[0]= Convert.ToInt32(Console.ReadLine());
            while (Numeros[0] > 0)
            {
                Console.WriteLine("Pofavor volver a ingresar el primer numero, DEBE SER NEGATIVO.");
                Numeros[0]= Convert.ToInt32(Console.ReadLine());
            }
            
            for (int i = 1; i < Numeros.Length; i++) 
            {
                Console.WriteLine("Ingrese el numero {0}° (Debe ser positivo)",i+1);
                Numeros[i] = Convert.ToInt32(Console.ReadLine());
                while (Numeros[i] < 0)
                {
                    Console.WriteLine("Pofavor volver a ingresar el numero {0}° , DEBE SER POSITIVO", i+1);
                    Numeros[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("El promedio es {0}", Numeros.Average());

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}

