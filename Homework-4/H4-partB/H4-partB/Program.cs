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
            int maxLineLength = 50; // Maximum length for displayed lines

            // Using LINQ to find the longest and shortest lines
            var longestLine = lines.OrderByDescending(line => line.Length).FirstOrDefault() ?? "";
            var shortestLine = lines.OrderBy(line => line.Length).FirstOrDefault() ?? "";

            // Display Header
            Console.WriteLine("Line Analysis:");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine($"{"Line",-50} | {"Symbols",7}");
            Console.WriteLine(new string('-', 60));

            // Display each line and its length
            foreach (string line in lines)
            {
                string truncatedLine = line.Length > maxLineLength
                                        ? line.Substring(0, maxLineLength - 3) + "..."
                                        : line;

                Console.WriteLine($"{truncatedLine,-50} | {line.Length,7}");
            }

            // Display Longest and Shortest Lines
            Console.WriteLine("\nLongest Line:");
            Console.WriteLine(longestLine.Length > maxLineLength ? longestLine.Substring(0, maxLineLength) + "..." : longestLine);

            Console.WriteLine("\nShortest Line:");
            Console.WriteLine(shortestLine);

            // Using LINQ to find lines consisting of 'var'
            var varLines = lines.Where(line => line.Trim() == "var").ToList();

            Console.WriteLine("\nLines consisting of the word 'var':");
            if (varLines.Any())
            {
                foreach (var line in varLines)
                {
                    string truncatedLine = line.Length > maxLineLength
                                            ? line.Substring(0, maxLineLength - 3) + "..."
                                            : line;
                    Console.WriteLine($"- {truncatedLine}");
                }
            }
            else
            {
                Console.WriteLine("No lines consist only of the word 'var'.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
