using System.Linq;
using System;
using System.Collections.Generic;

class Homework2b
{
    static void Main()
    {
        List<double> Numeros = new List<double>();
       

        try
        {

            Console.WriteLine("Ingrese 3 numeros (int)");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Número " + (i + 1));
                Numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Numero Máximo");
            Console.WriteLine(Numeros.OrderByDescending(N => N).First().ToString());
          
            Console.WriteLine("Numero Mínimo");
            Console.WriteLine(Numeros.OrderBy(N => N).First().ToString());


        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}
