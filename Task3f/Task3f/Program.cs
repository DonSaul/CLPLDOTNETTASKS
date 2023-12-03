using System;
using System.Xml.Linq;

class Task3f
{
    static void Main()
    {
        string NumeroCh;
        int Sumatoria = 0;

        try
        {
            Console.WriteLine("Ingrese un número ");
            NumeroCh = Console.ReadLine();
            if (0 > Convert.ToInt32(NumeroCh)) NumeroCh = ((-1) * Convert.ToInt32(NumeroCh)).ToString();
            foreach (char ch in NumeroCh)
            {
                Sumatoria = Sumatoria + Convert.ToInt32(ch.ToString());
            }
            Console.WriteLine("La sumatoria de sus digitos es {0}", Sumatoria);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}

