using System;


class Task3a
{
   

    static void Main()
    {
        int desde;
        int hasta;
        int contador = 0;
        try
        {
            Console.WriteLine("Ingrese un rango 2 números ");
            Console.WriteLine("Ingrese desde");
            desde = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese hasta");
            hasta = Convert.ToInt32(Console.ReadLine());
            hasta = hasta < desde ? throw new Exception("El valor de 'hasta' no puede ser menor que 'desde'") : hasta;
           
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 3 == 0 && i != 0)
                {
                    contador++;
                }
                
            }

            Console.WriteLine("La cantiadad de numeros que divididos por 3 no dejan resto es {0} (sin contar el 0)", contador);
            
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());

        }

    }

}

