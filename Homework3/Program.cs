internal class Program
{
  public enum Drinks
  {
    Water = 500,
    Coffee = 1000,
    Tea = 800,
    Juice = 900
  }
  private static void Main(string[] args)
  {
    Console.WriteLine("Sub-tasks:\n");

    Console.WriteLine("1. Integers divisible by 3 without remainder in entered range [a, b]");
    Console.WriteLine("2. Log every second character of entered string");
    Console.WriteLine("3. Tea, Coffee, Water and Juice Shop");
    Console.WriteLine("4. Arithmetic average of integers");
    Console.WriteLine("5. Is the entered year a leap? Find out here!");
    Console.WriteLine("6. Sum of digits of an integer");
    Console.WriteLine("7. Just for today! Find out if your number consists only of odd numbers!");

    Console.Write("\nEnter an option: ");

    bool parseOp = int.TryParse(Console.ReadLine(), out int op);
    if (!parseOp) return;

    switch (op)
    {
      case 1:
        bool parseA = int.TryParse(Console.ReadLine(), out int a);
        bool parseB = int.TryParse(Console.ReadLine(), out int b);

        if (!parseA || !parseB) return;
        if (a > b) return;

        //int[] range = [..Enumerable.Range(a,b)]; // c#12.0?

        // foreach(int num in Enumerable.Range(a,b)){ // dont really need a foreach
        // }
        int count = 0;

        for (int i = a; i <= b; i++)
        {
          if (i % 3 == 0 && i != 0) count++;
          // if(i%3 == 0) Console.WriteLine(i);
        }
        Console.WriteLine($"The amount of numbers divisible by 3 with no remainder in the range [{a}, {b}] is {count}.");

        break;

      case 2:
        string? input = Console.ReadLine();
        if (input?.Length < 0) return;

        for (int i = 1; i < input?.Length; i += 2)   // i am sorry for this but tis necessary
        {
          Console.WriteLine(input[i]);
        }

        break;

      case 3:
        string? drink = Console.ReadLine();

        if (drink?.Length < 0) return;

        bool parsePrice = Enum.TryParse(typeof(Drinks), drink, out object? drinkPrice);
        if (parsePrice && drinkPrice is Drinks validDrink) Console.WriteLine($"{drink} costs {(int)validDrink} Chilean Coconuts.");

        break;

      case 4:
        string? seqString = Console.ReadLine();
        if (seqString?.Length == null) return;
        bool parseSeq = int.TryParse(seqString, out int seq);
        if (seq > 0 || !parseSeq) return;

        int firstDigit = -(seqString[1] - '0');
        for (int i = 2; i < seqString?.Length; i++)
        {
          //Console.WriteLine(i);
          firstDigit += seqString[i] - '0';
        }
        Console.WriteLine((double)firstDigit / (seqString?.Length - 1));

        break;

      case 5:
        bool parseYear = int.TryParse(Console.ReadLine(), out int year);
        if (parseYear && year > 1900 && year < 3000)
          if (DateTime.IsLeapYear(year))
            Console.WriteLine("ye it is");
          else
            Console.WriteLine("no it isnt");
        
        break;

      case 6:
        string? numString = Console.ReadLine();
        if (numString?.Length == null) return;
        bool parseNum = int.TryParse(numString, out int num);
        if (!parseNum || num < 0) return;

        int sum=0;
        for (int i = 0; i < numString?.Length; i++)
        {
          //Console.WriteLine(i);
          sum += numString[i] - '0';
        }
        Console.WriteLine($"The sum of the digits of {num} is {sum}.");
        // test cases 
        /*
        456
        =15

        -150
        =6

        1001
        =2

        86798
        =38
        */

        break;

      case 7:
        string? intString = Console.ReadLine();
        if (intString?.Length == null) return;
        bool parseInt = int.TryParse(intString, out int inp);
        if (!parseInt || inp < 0) return;

        bool isValid = true;

        for(int i=0;i<intString?.Length;i++)
        {
          if((intString[i]-'0') % 2 == 0)
          isValid = false;

          if(!isValid)
          break;
        }

        Console.WriteLine(isValid);
        // test cases 
        /*
        456
        =false

        395
        =true

        9963
        =false

        51797
        =true
        */
        break;

      default:
        Console.WriteLine("bruh");
        return;
    }

  }
}