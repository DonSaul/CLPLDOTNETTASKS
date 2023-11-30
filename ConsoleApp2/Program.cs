public class Program2
{
    public static void Main(string[] args)
    {
        DayMonthTest();
    }

    private static void DayMonthTest()
    {
        Console.WriteLine("Enter 2 integers to check if they can be day and month:");
        int a, b;
        Console.Write("a: ");
        string s = Console.ReadLine();
        bool rez = Int32.TryParse(s, out a);
        if (!rez )
        {
            Console.WriteLine("You didn't type a number!!!");
            return;
        }
        Console.Write("b: ");
        s = Console.ReadLine();
        rez = Int32.TryParse(s, out b);
        if (!rez )
        {
            Console.WriteLine("You didn't type a number!!!");
            return;
        }
        bool result = IsDayAndMonthPair(a, b);
        Console.WriteLine("{0} a day and month pair!", result ? "Yes, it is" : "No, it's not");
    }

    private static bool IsDayAndMonthPair(int a, int b)
    {
        if (b < 1 || b > 12) { return false; }
        if (a < 1) { return false; }
        int limit = 30;
        if (b == 2) { limit = 29; }
        if (new int[] {4, 6, 9, 11}.Contains(b)) { limit = 31; }
        return a <= limit;
    }
}
