using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string filePath = "textfile.txt"; // Replace with your file path
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            string longestLine = "";
            string shortestLine = lines.Length > 0 ? lines[0] : "";
            int maxLineLength = 50; // Maximum length for displayed lines

            Console.WriteLine("Line Analysis:");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{"Line",-50} | {"Symbols",7}");
            Console.WriteLine(new string('-', 60));

            foreach (string line in lines)
            {
                string truncatedLine = line.Length > maxLineLength
                                        ? line.Substring(0, maxLineLength - 3) + "..."
                                        : line;

                Console.WriteLine($"{truncatedLine,-50} | {line.Length,7}");

                if (line.Length > longestLine.Length) longestLine = line;
                if (line.Length < shortestLine.Length) shortestLine = line;
            }

            Console.WriteLine();
            Console.WriteLine("Longest Line:");
            Console.WriteLine(longestLine.Length > maxLineLength ? longestLine.Substring(0, maxLineLength) + "..." : longestLine);
            Console.WriteLine();

            Console.WriteLine("Shortest Line:");
            Console.WriteLine(shortestLine);
            Console.WriteLine();

           Console.WriteLine("Lines Containing 'var':");
            foreach (string line in lines)
            {
                if (Regex.IsMatch(line, @"\bvar\b")) // This checks for the whole word 'var'
                {
                    string truncatedLine = line.Length > maxLineLength
                                                ? line.Substring(0, maxLineLength - 3) + "..."
                                                : line;
                    Console.WriteLine($"- {truncatedLine}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
