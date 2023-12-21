class Homework4PartB
{
    static void Main(string[] args)
    {
        // Homework 4 Part B 
        // Prepare txt file with a lot of text inside (for example take you .cs file from previos homework)
        // Read all lines of text from file into array of strings.
        // Each array item contains one line from file.

        // 1) Count and write the number of symbols in every line
        Console.WriteLine("Homework 4 Part B:");
        Console.WriteLine("-----------------------------------------");

        try
        {
            // Combine the current directory with the file name
            string filePath = Path.Combine(Environment.CurrentDirectory, "TextHomework4PartB.txt");

            // Read all lines from the file into an array
            string[] lines = File.ReadAllLines(filePath);

            Console.WriteLine("Text content:");

            // Display each line on the console
            foreach (string line in lines)
            {
                Console.WriteLine("{0} with length: {1}", line, line.Length);
            }
            Console.WriteLine("-----------------------------------------");

            //2) Find the longest and the shortest line
            string longestLine = lines[0];
            string shortestLine = lines[0];

            foreach (string line in lines)
            {
                if (line.Length > longestLine.Length)
                {
                    longestLine = line;
                }

                if (line.Length < shortestLine.Length)
                {
                    shortestLine = line;
                }
            }

            Console.WriteLine("Longest Line: {0}, Length: {1}", longestLine, longestLine.Length);
            Console.WriteLine("Shortest Line: {0}, Length: {1}", shortestLine, shortestLine.Length);
            Console.WriteLine("-----------------------------------------");

            // 3) Find and write lines that consist of the word "var"
            Console.WriteLine("Lines containing the word 'var':");
            foreach (string line in lines)
            {
                // Split the line into words
                string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                // Check if the line has only one word and that word is "var"
                if (words.Length == 1 && words[0] == "var")
                {
                    Console.WriteLine(line);
                }
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
       
        Console.WriteLine("--------------------------");
        Console.WriteLine("Program finished , press enter to close the terminal...");
        Console.ReadLine();
    }
}
