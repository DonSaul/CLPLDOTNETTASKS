using System;

class Homework1a
{
    static void Main()
    {
        int a;

        try
        {
            Console.WriteLine("Ingrese la longitud del cuadrado. !Debe ser un valor entero!");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Para un Cuadrado de lado: " + a);
            Console.WriteLine("Perímetro: " + CalculoPerimetro(a));
            Console.WriteLine("Area: " + CalculoArea(a));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        int CalculoPerimetro(int Longitud)
        {
            return Longitud * 4;
        }

        int CalculoArea(int Longitud)
        {
            return Longitud * Longitud;
        }

    }

}
