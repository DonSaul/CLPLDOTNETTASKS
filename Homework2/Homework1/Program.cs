internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Homework 1 sub-tasks:\n");
        Console.WriteLine("a. Area and perimeter of a square");
        Console.WriteLine("b. What is your name?");
        Console.WriteLine("c. Area, perimeter of a circle and volume of a sphere");

        Console.Write("\nChoose an option: ");

        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        while(op != 'a' && op != 'b' && op != 'c')
        {
            Console.Write("\nInvalid option, try again: ");
            op = Console.ReadKey().KeyChar;
        }

        Console.WriteLine();

        switch(op)
        {
            case 'a':
                int a;
                
                Console.WriteLine("Enter square side length: ");
                bool parseA = int.TryParse(Console.ReadLine(), out a);
                
                while(!parseA)
                {
                    Console.WriteLine("Invalid input, try again");
                    parseA = int.TryParse(Console.ReadLine(), out a);
                }

                int area = a * a;
                int perimeter = 4 * a;

                Console.WriteLine($"Area = {area}");
                Console.WriteLine($"Perimeter = {perimeter}");
            break;

            case 'b':
                string? name;
                int age;

                Console.WriteLine("What is your name?: ");
                name = Console.ReadLine();

                Console.WriteLine($"How old are you, {name}?");
                bool parseAge = int.TryParse(Console.ReadLine(), out age);
                while(!parseAge)
                {
                    Console.WriteLine("Invalid input, try again");
                    parseAge = int.TryParse(Console.ReadLine(), out age);
                }

                Console.WriteLine($"Hello, {name}! You are {age} years old.");
            break;

            case 'c':
                double radius;

                Console.WriteLine("Enter radius:");
                bool parseR = double.TryParse(Console.ReadLine(), out radius);
                while(!parseR)
                {
                    Console.WriteLine("Invalid input, try again");
                    parseR = double.TryParse(Console.ReadLine(), out radius);
                }

                double areaCircle = Math.PI * radius * radius;
                double perimeterCircle = 2 * Math.PI * radius;
                double volumeSphere = 4 / 3 * Math.PI * radius * radius * radius;

                Console.WriteLine($"Area = {areaCircle}");
                Console.WriteLine($"Perimeter = {perimeterCircle}");
                Console.WriteLine($"Volume = {volumeSphere}");
            break;
        }
    }
}