class Homework1
{
    static void Main(string[] args)
    {
        //Homework1 
        //Part A
        
        Console.WriteLine("Homework1 ");
        int squareLength;
        bool isValidInputNumber;

        //Get a number from user and store it in squareLength 
        //If the number is invalid, we stay in the while loop until the user inputs a valid number
        do
        {
            Console.WriteLine("Enter a valid number (square length) to calculate square perimeter and area: ");
            string inputNumber = Console.ReadLine();

            //Check if the input number is valid (no white spaces , no letters , etc) and parse to int 
            isValidInputNumber = int.TryParse(inputNumber, out squareLength);

        } while (!isValidInputNumber);

        //Calculate the perimeter and area of the square
        int squarePerimeter = (squareLength * 4);
        int squareArea = (squareLength * squareLength);

        Console.WriteLine("The square perimeter is: " + squarePerimeter);
        Console.WriteLine("The square area is: " + squareArea);

        //Part B

        Console.WriteLine("--------------------------");
        string userName;
        bool isValidInputName;

        //Get the name from user and store it in userName
        //If the name is invalid, we stay in the while loop until the user inputs a valid name.
        do
        {
            Console.WriteLine("Hello, what is your name?");
            string inputName = Console.ReadLine();

            //Check if the input userName is valid:
            // - Ensure it is not null or has white spaces
            // - Verify that all characters are letters
            isValidInputName = (!string.IsNullOrWhiteSpace(inputName) && inputName.All(char.IsLetter));

            userName = inputName;

        } while (!isValidInputName);

        int userAge;
        bool isValidInputAge;

        //Get the age from user and store it in userAge
        //If the age is invalid, we stay in the while loop until the user inputs a valid age
        do
        {
            Console.WriteLine("How old are you, " + userName + "?");
            string inputAge = Console.ReadLine();

            //Check if the input userAge is valid (no white spaces , no letters , greater than 0 , etc) and parse to int
            isValidInputAge = (int.TryParse(inputAge, out userAge) && userAge > 0);

        } while (!isValidInputAge);

        //Show the user information (name and age)
        Console.WriteLine("User information:");
        Console.WriteLine("Name: " + userName);
        Console.WriteLine("Age: " + userAge);

        //Part C 

        Console.WriteLine("--------------------------");
        double circleRadius;
        bool isValidInputNumberR;

        //Get the number from user and store it in circleRadius
        //If the number is invalid, we stay in the while loop until the user inputs a valid number
        do
        {
            Console.WriteLine("Enter a valid number (circle radius) to calculate circle length, area and volume: ");
            string inputNumberR = Console.ReadLine();

            //Check if the input circleRadius is valid (no white spaces , no letters , etc) and parse to double
            isValidInputNumberR = double.TryParse(inputNumberR, out circleRadius);

        } while (!isValidInputNumberR);

        //Calculate the length, area and volume of the circle
        double circleLength = (2 * Math.PI * circleRadius);
        double circleArea = (Math.PI * circleRadius * circleRadius);
        double circleVolume = ((4.0 / 3.0) * Math.PI * circleRadius * circleRadius * circleRadius);

        Console.WriteLine("The circle length is: " + circleLength);
        Console.WriteLine("The circle area is: " + circleArea);
        Console.WriteLine("The circle volume is: " + circleVolume);

        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();
    }
}