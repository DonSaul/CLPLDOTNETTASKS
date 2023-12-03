using System.Linq;
using System;
using System.Collections.Generic;

class Homework2a
{
    static void Main()
    {
        List<double> Numeros = new List<double>();
        int Rango = 5;

        try
        {
            
            Console.WriteLine("Ingrese 3 numeros (float)");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Número " + (i+1));
                Numeros.Add(Convert.ToDouble(Console.ReadLine()));
            }

            Console.WriteLine( ( Numeros.Where(N => (N<-Rango | N > Rango )).Count() == 0 ) ? "Dentro del rango" : "Fuera del rango");
            

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}
