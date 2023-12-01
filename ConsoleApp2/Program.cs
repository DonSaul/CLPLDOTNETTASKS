

public class Program2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("1) Floats in range");
        CheckForFloatsInRange();
        Console.WriteLine("2) Min/max of 3 ints");
        CheckMaxMinInts();
    }

    private static void CheckForFloatsInRange()
    {
        Console.WriteLine("Type in 3 decimal numbers, please:");
        float[] floats = new float[3];
        for (int i = 0; i < floats.Length; i++)
        {
            Console.Write("{0}>", (i + 1));
            string? s = Console.ReadLine();
            bool rez = float.TryParse(s, out float value);
            if (rez) { floats[i] = value; } else
            {
                Console.WriteLine("Sorry, that's not even a number!");
                return;
            }
        }
        foreach (float fl in floats)
        {
            string result = (fl >= -5 && fl <= 5) ? "INDEED" : "NOT";
            Console.WriteLine("{0:F2} is {1} within the range [-5, 5]", fl, result);
        }
    }

    private static void CheckMaxMinInts()
    {
        Console.WriteLine("Type in 3 entegers, please:");
        int min = int.MaxValue;
        int max = int.MinValue;
        for(int i = 0;i < 3; i++)
        {
            Console.Write("{0}>", (i + 1));
            string? s = Console.ReadLine();
            bool rez = Int32.TryParse(s, out int value);
            if (rez)
            {
                max = int.Max(max, value);
                min = int.Min(min, value);
            }
            else
            {
                Console.WriteLine("Sorry, that's not an integer!");
                return;
            }
        }
        Console.WriteLine("The max of those ints is {0}", max);
        Console.WriteLine("The min of those ints is {0}", min);
    }
}
