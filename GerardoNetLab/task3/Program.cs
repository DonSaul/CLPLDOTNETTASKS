using NetLabTask3;
using System.Threading.Channels;

bool inputValid = false;

//1) Enter a and b are two integers. Calculate how many integers in the range [a..b] are divided by 3 without remainder.

//do
//{
//    try
//    {
//        Console.WriteLine("Ingresa el primer número: ");
//        int numberA = int.Parse(Console.ReadLine());

//        Console.WriteLine("Ingresa el segundo número: ");
//        int numberB = int.Parse(Console.ReadLine());

//        int total = IntegersInRange.CalculateInteger(numberA, numberB);
//        Console.WriteLine($"La cantidad es: {total}");

//        inputValid = true;
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Número inválido. Por favor, ingresa un valor válido.");
//    }
//} while (!inputValid);

////2) Enter a character string. Print each second character
//Console.WriteLine("Ingresa una frase: ");
//PrintSecondChar.PrintSecond(Console.ReadLine());

////3)Enter the name of the drink
//Console.WriteLine("Ingresa el nombre de la bebida: ");
//DrinkName.DrinkPrice(Console.ReadLine().ToLower());

//4)Sequence of positive integers, average and stop with negative number.
//SequenceOfPositiveIntegers.ProcessNumbers();

//5)Check whether the enered year is a leap.
//Console.WriteLine("Ingresa el año para comprobar si es bisiesto: ");
//CheckYearLeap.CheckYear(int.Parse(Console.ReadLine()));

//6)Find the sum of digits of the entered integer number.
//Console.WriteLine("Ingresa una serie de números:");
//SumOfIntegerNumbers.SumOfDigits(int.Parse(Console.ReadLine()));

//7)Check whether the entered integer number contains only odd numbers.
//CheckOddNumber.CheckOdd(345);