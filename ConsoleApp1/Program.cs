// See https://aka.ms/new-console-template for more information
class Program
{
    public static int Main(string[] args)
    {
        Console.WriteLine("Insert a number for the square's side:");
        string s = Console.ReadLine();
        int a;
        bool rez = int.TryParse(s, out a);
        if (rez )
        {
            Console.WriteLine("Square's Perimeter: {0}", a * 4);
            Console.WriteLine("Square's Area: {0}", a * a);
        }
        else
        {
            Console.WriteLine("Whatever you just typed was not a number, sorry");
        }


        string name;
        int age;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("How old are you, {0}?", name);
        s = Console.ReadLine();
        rez = int.TryParse(s, out age);
        if (rez)
        {
            Console.WriteLine("So you are {0}, aged {1} years. Nice to meet you!", name, age);
        }
        else
        {
            Console.WriteLine("Whatever you just typed was not a number, sorry");
        }
        Console.WriteLine("Input a valid circle raduis:");
        double r;
        s = Console.ReadLine();
        rez = double.TryParse(s, out r);
        if (rez)
        {
            Console.WriteLine("Circunference length: {0:F3}", 2 * Math.PI * r);
            Console.WriteLine("Circle area: {0:F3}", Math.PI * r * r);
            Console.WriteLine("Sphere volume: {0:F3}", Math.PI * r * r * r * 4/3);
        }
        else
        {
            Console.WriteLine("Whatever you just typed was not a number, sorry");
        }
        return 0;
    }
}
