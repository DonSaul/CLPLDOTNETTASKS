// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1) The range of 2 ints");
        TwoIntegerRange();
        Console.WriteLine("2) Every other char in string");
        SecondCharsInString();
        Console.WriteLine("3) Get the price of a drink");
        GetDrinkPrice();
        Console.WriteLine("4) The average of integers");
        IntAverage();
        Console.WriteLine("5) Check for leap year");
        LeapYearCheck();
    }

    private static void LeapYearCheck()
    {
        Console.WriteLine("Please input a possible year number:");
        Console.Write("> ");
        string? s = Console.ReadLine();
        bool rez = Int32.TryParse(s, out int year);

        if (!rez)
        {
            Console.WriteLine("Well, can't be a year number!");
            return;
        }

        string result = (year % 4 == 0) ? "INDEED" : "NOT";
        Console.WriteLine("{0} is {1} a leap year", year, result);
    }

    private static void IntAverage()
    {
        ulong qty;
        int val = 0, total = 0;

        Console.WriteLine("Enter, separately, any number of integers you desire:");
        Console.WriteLine("(Enter a negative value to end)");

        for (qty = 0; val >= 0; qty++)
        {
            Console.Write("> ");
            string? s = Console.ReadLine();
            bool rez = Int32.TryParse(s, out val);
            if (rez)
            {
                total += val;
            }
            else
            {
                Console.WriteLine("That's not an integer! (Or it's WAY out of range");
                qty--;
            }
        }
        Console.WriteLine("There, integer sequence ended!");
        float mean = (float) total / (float) qty;
        Console.WriteLine("The average of all the integers entered is {0:F3}", mean);
    }

    private static void GetDrinkPrice()
    {
        Dictionary<string, ushort> priceDict = new()
        {
            { "cofee", 2500 },
            { "tea", 1500 },
            { "juice", 2700 },
            { "water", 800 },
        };

        Console.WriteLine("Please input the name of the drink you wish to consult:");
        Console.Write("(cofee, tea, juice, water) > ");
        string s = Console.ReadLine() ?? "";
        s = s.Trim().ToLower();

        if (priceDict.TryGetValue(s, out ushort value))
        {
            Console.WriteLine("So, the price for {0} is: {1:C}", s, value);
        }
        else
        {
            Console.WriteLine("Uh... we don't have that drink (Did you type it right?)");
        }
    }

    private static void SecondCharsInString()
    {
        Console.WriteLine("Please input any string of characters that you wish:");
        Console.Write("> ");
        string s = Console.ReadLine() ?? "";

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
