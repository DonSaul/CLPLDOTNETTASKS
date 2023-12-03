using System;
using System.Security.Cryptography;
using System.Xml.Linq;

class Task3b
{


    static void Main()
    {
        string cadena;
       
        try
        {
            Console.WriteLine("Ingrese un string ");
            cadena = Console.ReadLine()?? "";
            cadena = cadena == "" ? throw new Exception("Tu nombre no puede ser nulo") : cadena;
            for (int i = 0; cadena.Length > 0; i++)
            {
                if( i%2 == 1 )
                {
                    Console.WriteLine(cadena[i]);
                }
                
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());

        }

    }

}