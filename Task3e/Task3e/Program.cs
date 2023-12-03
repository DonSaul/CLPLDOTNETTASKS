using System;

class Task3e
{
    static void Main()
    {
        int año;

        try
        {
            Console.WriteLine("Ingrese un año ");
            año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( año%4==0 ? "El año es Bisiesto" : "El año no es Bisiesto");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

    }

}
