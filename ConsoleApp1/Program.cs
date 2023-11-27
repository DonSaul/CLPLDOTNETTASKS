// See https://aka.ms/new-console-template for more information
class Program
{
    public static int Main(string[] args)
    {
        string s = Console.ReadLine();
        int a;
        bool rez = int.TryParse(s, out a);
        Console.WriteLine("Square's Perimeter: {0}", a * 4);
        Console.WriteLine("Square's Area: {0}", a * a);
        return 0;
    }
}
