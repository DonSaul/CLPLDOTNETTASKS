internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Task 1 sub-tasks:\n");

        Console.WriteLine("1. Calculator");
        Console.WriteLine("2. Greeting");
        Console.WriteLine("3. Read 3 characters");
        Console.WriteLine("4. Check if 2 numbers are positive");

        Console.WriteLine("\nChoose an option:");
        bool parseOp = int.TryParse(Console.ReadLine(), out int op); //op se declara aqui para que vscode no moleste

        // while para asegurar que el usuario ingrese una opcion valida
        while(op < 1 || op > 4 || !parseOp)
        {
            Console.WriteLine("Invalid option, try again:");
            parseOp = int.TryParse(Console.ReadLine(), out op);
        }

        switch (op){
            case 1:
                int a, b;

                Console.WriteLine("Enter a number:");
                bool parseA = int.TryParse(Console.ReadLine(), out a);

                Console.WriteLine("Enter a second number:");
                bool parseB = int.TryParse(Console.ReadLine(), out b);

                // si no se pudo parsear alguno de los numeros, se termina el programa
                // tambien es posible usar un ciclo while para no terminar el programa y asegurar input correcto
                if (!parseA)
                {
                    Console.WriteLine("Invalid input a");
                    return;
                }

                if(!parseB)
                {
                    Console.WriteLine("Invalid input b");
                    return;
                }

                // se calculan los resultados en el mismo console.write
                Console.WriteLine($"Sum:\t{a + b}");
                Console.WriteLine($"Sub:\t{a - b}");
                Console.WriteLine($"Mul:\t{a * b}");
                Console.WriteLine($"Div:\t{(decimal)a / b}"); // se castea a decimal para que el resultado muestre decimales
            break;

            case 2:
                Console.WriteLine("How are you?");
                // Console.ReadLine() lanza warning si el string no es nullable
                string? input = Console.ReadLine();

                if (input == null || input.Length == 0)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                Console.WriteLine($"You are {input}");
            break;

            case 3:
                // ReadKey lee un caracter a la vez, solo hay que apretar tres teclas. NO APRETAR ENTER.
                // se puede y deberia validar que el input sea un caracter, pero se complicaria el codigo
                Console.WriteLine("Read a single character 3 times (NO PRESSING ENTER REQUIRED):");
                char char1 = Console.ReadKey().KeyChar;
                char char2 = Console.ReadKey().KeyChar;
                char char3 = Console.ReadKey().KeyChar;
                Console.WriteLine($"\nYou entered {char1}, {char2}, {char3}");

            break;

            case 4:
                int num1, num2;
                
                Console.WriteLine("Enter a number:");
                bool parseNum1 = int.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("Enter a second number:");
                bool parseNum2 = int.TryParse(Console.ReadLine(), out num2);

                if (!parseNum1 || !parseNum2)
                {
                    Console.WriteLine("Invalid input");
                    return;
                }

                if(num1 >= 0 && num2 >= 0)
                {
                    // :D
                    Console.WriteLine("\nBoth numbers are positive!");
                } else {
                    // :(
                    Console.WriteLine("\nAt least one number is negative :(");
                }

            break;
        }
        
        return;
    }
}