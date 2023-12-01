
public class Program2
{
    public static void Main(string[] args)
    {
        CheckForFloatsInRange();
    }

    private static void CheckForFloatsInRange()
    {
        Console.WriteLine("Type in 3 decimal numbers, please:");
        float[] floats = new float[3];
        for (int i = 0; i < floats.Length; i++)
        {
            Console.Write("{0}>", i);
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
}
