class Homework1c
{
    static void Main()
    {
        double r;

        try
        {
            Console.WriteLine("Ingrese la longitud del Radio. !Debe ser un valor Real!");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Para un radio de lado: " + r);
            Console.WriteLine("Perímetro: " + CalculoPerimetro(r));
            Console.WriteLine("Area: " + CalculoArea(r));
            Console.WriteLine("Volumen: " + CalculoVolumen(r));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }

        double CalculoPerimetro(double radio)
        {
            return 2*radio*Math.PI;
        }

        double CalculoArea(double radio)
        {
            return radio*radio*Math.PI;
        }

        double CalculoVolumen(double radio)
        {
            return 0.75*radio*radio*radio*Math.PI;
        }

    }

}
