using System.Runtime.InteropServices;
using System;
class Homework2
{
    //Counter to check if all float numbers are in the [-5, 5] range 
    public static int counterFloat = 0;
    
    //HTTPError enum to list some HTTPs errores 
    enum HTTPError
    {
        OK = 200,
        PermanentRedirect = 301,
        TemporaryRedirect = 302,
        NotModified = 304,
        BadRequest = 400,
        Unauthorized = 401,
        PaymentRequired = 402,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500,
        NotImplemented = 501, 
        GatewayTimeout = 504, 
    };

    //Struck Dog with toString method 
    struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        //Method to print the data of myDog on the terminal 
        public override string ToString()
        {
            return $" myDog: \n Dog's name: {Name} \n Dog's Mark: {Mark} \n Dog's Age: {Age}";
        }

    }

    //Method that returns a float number from user 
    static public float inputFloatNumber()
    {
        float numberFloat;
        bool isValidInputNumber;

        //Get the float number from user and store it in numberFloat
        //If the float number is invalid, we stay in the while loop until the user inputs a valid number
        do
        {
            Console.WriteLine("Enter a valid float number: ");
            string inputNumberF = Console.ReadLine();

            //Check if the input circleRadius is valid (no white spaces , no letters , etc) and parse to double
            isValidInputNumber = float.TryParse(inputNumberF, out numberFloat);

        } while (!isValidInputNumber);

        return numberFloat;
    }

    //Method that returns a integer number from user 
    static public int inputIntegerNumber()
    {
        int numberInteger;
        bool isValidInputNumber;

        //Get a integer number from user and store it in numberInteger
        //If the integer number is invalid, we stay in the while loop until the user inputs a valid number
        do
        {
            Console.WriteLine("Enter a valid integer number: ");
            string inputNumberI = Console.ReadLine();

            //Check if the input number is valid (no white spaces , no letters , etc) and parse to int 
            isValidInputNumber = int.TryParse(inputNumberI, out numberInteger);

        } while (!isValidInputNumber);

        return numberInteger;
    }

    //Method that checks if the float number is inside the [-5, 5] range or not 
    static public void showFloatNumberRange(float numberFloat)
    {
        string answer = (numberFloat >= -5 && numberFloat <= 5) ?
            $"Number: {numberFloat} belongs to range[-5, 5]" : $"Number: {numberFloat} doesn't belong to range [-5, 5]";

        //checks if the float number is inside the [-5, 5] range or not
        if (numberFloat >= -5 && numberFloat <= 5) {
            counterFloat++;
        }

        Console.WriteLine(answer);
    }

    //Method thats gets input from user and shows HTTPError number with its name
    static public void inputShowHttpError()
    {
        int numberError;
        string errorName = null;
        bool isValidInputNumber;
        bool isValidHttpNumber = false;

        do
        {
            Console.WriteLine("Enter a valid HTTPError number: ");
            string inputNumberE = Console.ReadLine();

            //Check if the input number is valid (no white spaces , no letters , etc) and parse to int 
            isValidInputNumber = int.TryParse(inputNumberE, out numberError);

            //Check if the HTTPError exist on our enum HTTPError
            if (Enum.IsDefined(typeof(HTTPError), numberError))
            {
                errorName = Enum.GetName(typeof(HTTPError), numberError);
                isValidHttpNumber = true;
            }

        } while (!isValidInputNumber || !isValidHttpNumber);

        Console.WriteLine($"HTTP Error {numberError}: {errorName}");
    }

    static void Main(string[] args)
    {
        //Homework2 
        //Part A: read 3 float numbers and check: are they all belong to the range [-5,5].
        Console.WriteLine("Homework2 ");
        Console.WriteLine("Part A: Enter 3 float numbers:");
        Console.WriteLine("-----------------------------------------");
        
        float numberFloat1;
        float numberFloat2;
        float numberFloat3;

        numberFloat1 = inputFloatNumber();
        showFloatNumberRange(numberFloat1);
        Console.WriteLine("-----------------------------------------");

        numberFloat2 = inputFloatNumber();
        showFloatNumberRange(numberFloat2);
        Console.WriteLine("-----------------------------------------");

        numberFloat3 = inputFloatNumber();
        showFloatNumberRange(numberFloat3);
        Console.WriteLine("-----------------------------------------");

        string answerA = (counterFloat == 3) ?
             "All of the numbers belongs to range[-5, 5]" : "Not all of the numbers belongs to range [-5, 5]";
        Console.WriteLine(answerA);
        Console.WriteLine("-----------------------------------------");

        //Part B: read 3 integers and write max and min of them.
        Console.WriteLine("Part B: Enter 3 numbers:");
        Console.WriteLine("-----------------------------------------");

        int numberInteger1;
        int numberInteger2;
        int numberInteger3;

        numberInteger1 = inputIntegerNumber();
        Console.WriteLine("-----------------------------------------");

        numberInteger2 = inputIntegerNumber();
        Console.WriteLine("-----------------------------------------");

        numberInteger3 = inputIntegerNumber();
        Console.WriteLine("-----------------------------------------");

        int minIntegerNumber = Math.Max(numberInteger1, Math.Max(numberInteger2, numberInteger3));
        int maxIntegerNumber = Math.Min(numberInteger1, Math.Min(numberInteger2, numberInteger3));

        Console.WriteLine($"The max value from all 3 integer numbers is {maxIntegerNumber}");
        Console.WriteLine($"The min value from all 3 integer numbers is {minIntegerNumber}");
        Console.WriteLine("-----------------------------------------");

        //Part C: read number of HTTP Error (400, 401,402, ...) and write the name of this error (Declare enum HTTPError)

        Console.WriteLine("Part C: HTTPError ");
        inputShowHttpError();
        Console.WriteLine("-----------------------------------------");

        //Part D: declare struct Dog with fields Name, Mark, Age. Declare variable myDog of Dog type
        //and read values for it. Output myDos into console. (Declare method ToString in struct)
       
        Console.WriteLine("Part D: Dog Struct");
        Console.WriteLine("-----------------------------------------");
        Dog myDog;
        myDog = new Dog();

        bool isValidInputDogName;

        //Get the user's dog's name 
        //If the input is invalid, we stay in the while loop until the user inputs a valid name.
        do
        {
            Console.WriteLine("Hello, what is your dog's name?");
            string inputDogName = Console.ReadLine();

            //Check if the inputDogName is valid:
            // - Ensure it is not null or has white spaces
            isValidInputDogName = (!string.IsNullOrWhiteSpace(inputDogName));

            myDog.Name = inputDogName;

        } while (!isValidInputDogName);
        Console.WriteLine("-----------------------------------------");

        bool isValidInputDogMark;

        //Get the user's dog's mark
        //If the input is invalid, we stay in the while loop until the user inputs a valid name.
        do
        {
            Console.WriteLine("Hello, what is your dog's mark?");
            string inputDogMark = Console.ReadLine();

            //Check if the inputDogMark is valid:
            // - Ensure it is not null or has white spaces
            isValidInputDogMark = (!string.IsNullOrWhiteSpace(inputDogMark) && inputDogMark.All(char.IsLetter));

            myDog.Mark = inputDogMark;

        } while (!isValidInputDogMark);
        Console.WriteLine("-----------------------------------------");

        bool isValidInputDogAge;
        int auxDogAge; 

        //Get the user's dog's age
        //If the input is invalid, we stay in the while loop until the user inputs a valid age
        do
        {
            Console.WriteLine("Hello, how old is your dog?");
            string inputDogAge = Console.ReadLine();

            //Check if the input is valid (no white spaces , no letters , greater than 0 , etc) and parse to int
            isValidInputDogAge = (int.TryParse(inputDogAge, out auxDogAge) && auxDogAge > 0);
            myDog.Age = auxDogAge;

        } while (!isValidInputDogAge);
        
        Console.WriteLine("-----------------------------------------");
        Console.WriteLine(myDog.ToString());
        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();
    }
}