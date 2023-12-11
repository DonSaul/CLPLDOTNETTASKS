// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1) The range of 2 ints");
        TwoIntegerRange();
        Console.WriteLine("2) Every other char in string");
        SecondCharsInString();
    }

    private static void SecondCharsInString()
    {
        Console.WriteLine("Please input any string of characters that you wish:");
        Console.Write("> ");
        string s = Console.ReadLine();

        Console.WriteLine(!string.IsNullOrWhiteSpace(s)
            ? "Well, the second characters for that string are:"
            : "Well, that's just an empty string");
        for (int i = 1; i < s.Length; i+=2)
        {
            Console.WriteLine(s[i]);
        }
    }

    private static void TwoIntegerRange()
    {
        Console.WriteLine("Please input 2 integer numbers:");
        int[] inputInts = new int[2];

        for (int i = 0; i < inputInts.Length; i++)
        {
            Console.Write("{0}> ", (i + 1));
            string? s = Console.ReadLine();
            bool rez = Int32.TryParse(s, out inputInts[i]);
            if (!rez)
            {
                Console.WriteLine("Sorry, that's not an integer!");
            }
        }

        int start = Math.Min(inputInts[0], inputInts[1]);
        int end = Math.Max(inputInts[0], inputInts[1]);
        int count = 0;
        for (int i = start; i <= end; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }

        Console.WriteLine("Between {0} and {1}, there are {2} numbers divisible by 3");
    }
}
