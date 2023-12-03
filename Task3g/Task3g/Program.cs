using System;
using System.Xml.Linq;

class Task3g
{
    static void Main()
    {
        string NumeroCh;
        int Contador = 0;

        try
        {
            Console.WriteLine("Ingrese un número ");
            NumeroCh = Console.ReadLine();
            if (0 > Convert.ToInt32(NumeroCh)) NumeroCh = ((-1) * Convert.ToInt32(NumeroCh)).ToString();
            foreach (char ch in NumeroCh)
            {
                if( Convert.ToInt32(ch.ToString()) % 2 == 1 ) Contador++;
            }
            Console.WriteLine( Contador == NumeroCh.Length ? "El numero solo contiene numeros impares" : " No todos los numero o ninguno son impares");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}
