using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions; 

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

            Console.WriteLine("Lines consisting of the word 'var':");
            bool found = false; // Flag to track if any line is found

            foreach (string line in lines)
            {
                if (line.Trim() == "var") // Check if the line is exactly 'var'
                {
                    string truncatedLine = line.Length > maxLineLength
                                                ? line.Substring(0, maxLineLength - 3) + "..."
                                                : line;
                    Console.WriteLine($"- {truncatedLine}");
                    found = true; // Set flag to true as a line is found
                }
            }

            if (!found) // Check if no line was found
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
