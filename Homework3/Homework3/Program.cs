class Homework3
{
    //Drink struck to create a list of all drinks with their price
    struct Drink{
        public string drinkName;
        public string drinkPrice; 
    }

    static void Main(string[] args)
    {
        // Homework 3 
        // Part 1: Enter a and b are two integers
        // Calculate how many integers in the range [a..b] are divided by 3 without remainder

        Console.WriteLine("Homework3 ");
        Console.WriteLine("Part 1: Enter 2 integers: ");  
        Console.WriteLine("-----------------------------------------");
        int numberA;
        int numberB;
        bool isValidInputNumber1;
        bool isValidInputNumber2;
        bool isAgreaterThanB;

        do
        {
            Console.WriteLine("Enter the first number: ");
            string inputNumberA = Console.ReadLine();

            Console.WriteLine("Enter the second number: ");
            string inputNumberB = Console.ReadLine();

            // Check if the input numbers are valid (no white spaces, no letters, etc) and parse to int 
            isValidInputNumber1 = int.TryParse(inputNumberA, out numberA);
            isValidInputNumber2 = int.TryParse(inputNumberB, out numberB);

        } while (!isValidInputNumber1 || !isValidInputNumber2);

        int divisibleByThreeNumbers = 0;
        for (int i = numberA; i <= numberB; i++)
        {
            if (i % 3 == 0)
            {
                divisibleByThreeNumbers++;
            }
        }

        Console.WriteLine($"The number of integers in the range [{numberA} to {numberB}] divisible by 3 is: {divisibleByThreeNumbers}");
        Console.WriteLine("--------------------------");

        //Part 2: Enter a character string. Print each second character
        Console.WriteLine("Part 2: Enter a character string to print each second character from it");
        string characterString;
        bool isValidInputString;

        //Get the string from user and store it in characterString
        //If the string is invalid, we stay in the while loop until the user inputs a valid string.
        do
        {
            Console.WriteLine("Enter a string");
            string inputString = Console.ReadLine();

            //Check if the string is valid:
            // - Ensure it is not null or has white spaces
            isValidInputString = (!string.IsNullOrWhiteSpace(inputString));

            characterString = inputString;

        } while (!isValidInputString);

        Console.WriteLine("Every second character from the string: ");

        for (int i = 1; i < characterString.Length; i += 2)
        {
            Console.Write(characterString[i]);
        }
        Console.WriteLine();
        Console.WriteLine("--------------------------");

        //Part 3: Enter the name of the drink (coffee, tea, juice, water). Print the name of the drink and its price.
        Console.WriteLine("Part 3: The name of a drink and its price ");
        
        //Creating drink objects with each drink and its price 
        Drink myDrink1 = new Drink();
        Drink myDrink2 = new Drink();
        Drink myDrink3 = new Drink();
        Drink myDrink4 = new Drink();

        myDrink1.drinkName = "coffee";
        myDrink1.drinkPrice = "2500CLP";

        myDrink2.drinkName = "tea";
        myDrink2.drinkPrice = "2000CLP";

        myDrink3.drinkName = "juice";
        myDrink3.drinkPrice = "1500CLP";

        myDrink4.drinkName = "water";
        myDrink4.drinkPrice = "1000CLP";

        bool isValidInputDrink = false; 

        //Stay in a while loop until the user enters a valid drink name (coffe,tea,juice,water) then print name and price 
        do
        {
            Console.WriteLine("Enter a valid drink name (coffee,tea,juice,water): ");
            string inputDrinkName = Console.ReadLine();

            if (inputDrinkName == "coffee")
            {
                Console.WriteLine($"Drink name: {myDrink1.drinkName}, Price: {myDrink1.drinkPrice}");
                isValidInputDrink = true;
            }

            if (inputDrinkName == "tea")
            {
                Console.WriteLine($"Drink name: {myDrink2.drinkName}, Price: {myDrink2.drinkPrice}");
                isValidInputDrink = true;
            }

            if (inputDrinkName == "juice")
            {
                Console.WriteLine($"Drink name: {myDrink3.drinkName}, Price: {myDrink3.drinkPrice}");
                isValidInputDrink = true;
            }

            if (inputDrinkName == "water")
            {
                Console.WriteLine($"Drink name: {myDrink4.drinkName}, Price: {myDrink4.drinkPrice}");
                isValidInputDrink = true;
            }

        } while (!isValidInputDrink);
        Console.WriteLine("--------------------------");

        //Part 4 :Enter a sequence of positive integers(to the first negative).
        //Calculate the arithmetic average of the entered numbers.
        Console.WriteLine("Part 4: Enter a sequence of positive integers(to the first negative)");

        int amountOfInputNumbers = 0; 
        int sumOfAllInputNumbers = 0;

        //Enter a sequence of numbers until a negative number is entered
        do
        {
            Console.WriteLine("Enter a valid positive integer number, or a negative number to finish the loop:");
            string inputNumber = Console.ReadLine();

            //If the number is positive we enter it on sumOfAllInputNumbers and increase the amountOFInputNumbers counter; 
            if (int.TryParse(inputNumber, out int sequenceNumber))
            {
                //If the number is negative we get out of the loop
                if (sequenceNumber < 0)
                {
                    break;  
                }
                
                sumOfAllInputNumbers += sequenceNumber;
                amountOfInputNumbers ++;
            }
        } while (true); 
        
        double arithmeticAverageNumbers = (double)sumOfAllInputNumbers / amountOfInputNumbers;
        Console.WriteLine($"The arithmetic average of the entered numbers is: {arithmeticAverageNumbers}");
        Console.WriteLine("--------------------------");

        //Part 5: Check whether the entered year is a leap.
        Console.WriteLine("Part 5 : Check whether the entered year is a leap");

        int year;
        bool isValidInputYear;

        //Get the year from user and store it in Year
        //If the year is invalid, we stay in the while loop until the user inputs a valid year
        do
        {
            Console.WriteLine("Insert a valid year: ");
            string inputYear = Console.ReadLine();

            //Check if the input userAge is valid (no white spaces , no letters , greater than 0 , etc) and parse to int
            isValidInputYear = (int.TryParse(inputYear, out year) && year > 0);

        } while (!isValidInputYear);

        //A leap year must be divisible by 4
        //A leap year must be divisible by 400 but not by 100
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            Console.WriteLine($"The year :{year} is a leap year");
        } else
        {
            Console.WriteLine($"The year :{year} is not a leap year");
        }
        Console.WriteLine("--------------------------");

        //Part 6: Find the sum of digits of the entered integer number
        Console.WriteLine("Part 6: Find the sum digits of the entered integer number");
        
        int integerNumber1;
        bool isValidInputIntegerNumber1;

        //Get the integer number from user and store it in integerNumber1
        //If the integer number is invalid, we stay in the while loop until the user inputs a integer number
        do
        {
            Console.WriteLine("Insert a valid integer number: ");
            string inputIntegerNumber1 = Console.ReadLine();

            //Check if the input is valid (no white spaces , no letters , greater than 0 , etc) and parse to int
            isValidInputIntegerNumber1 = (int.TryParse(inputIntegerNumber1, out integerNumber1));

        } while (!isValidInputIntegerNumber1);

        //Convert negative numbers to positive
        integerNumber1 = Math.Abs(integerNumber1);

        int sumOfDigits = 0;
        //Sums all digits from the number 
        while (integerNumber1 > 0)
        {
            sumOfDigits = sumOfDigits + integerNumber1 % 10;
            integerNumber1 = integerNumber1 / 10;
        }

        Console.WriteLine($"The sum of all digits is : {sumOfDigits}");
        Console.WriteLine("--------------------------");


        //Part 7: Check whether the entered integer number contains only odd numbers
        Console.WriteLine("Part 7: Check whether the entered integer number contains only odd numbers");

        int integerNumber2;
        bool isValidInputIntegerNumber2;

        //Get the integer number from user and store it in integerNumber2
        //If the integer number is invalid, we stay in the while loop until the user inputs a integer number
        do
        {
            Console.WriteLine("Insert a valid integer number: ");
            string inputIntegerNumber2 = Console.ReadLine();

            //Check if the input is valid (no white spaces , no letters , greater than 0 , etc) and parse to int
            isValidInputIntegerNumber2 = (int.TryParse(inputIntegerNumber2, out integerNumber2));

        } while (!isValidInputIntegerNumber2);

        //Convert negative numbers to positive
        integerNumber2 = Math.Abs(integerNumber2);

        bool onlyOddNumbers = true; 

        //Checks if there are only odd numbers 
        while (integerNumber2 > 0)
        {
            int digit = integerNumber2 % 10;
            if (digit % 2 == 0)
            {
                onlyOddNumbers = false;
                break; 
            }
            integerNumber2 /= 10; 
        }

        if(onlyOddNumbers == true)
        {
            Console.WriteLine("The number only contains odd numbers");
        }
        else
        {
            Console.WriteLine("The number doesnt contains only odd numbers");
        }


        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();

    }
}

