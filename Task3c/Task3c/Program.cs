using System;

class Homework1c
{
    static void Main()
    {
        string Bebida;
        Console.WriteLine("Ingrese un Producto");
        Bebida = Console.ReadLine() ?? "";

        switch (Bebida.ToLower())
        {
            case "coffee":
                Console.WriteLine("Producto: {0} Precio: 1000", Bebida);
                break;

            case "tea":
                Console.WriteLine("Producto: {0} Precio: 1300", Bebida);
                break;

            case "juice":
                Console.WriteLine("Producto: {0} Precio: 1400", Bebida);
                break;

            case "water":
                Console.WriteLine("Producto: {0} Precio: 500", Bebida);
                break;

            default: 
                Console.WriteLine("Producto no encontrado");
                break;

        }            
    
    }

}
