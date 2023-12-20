using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework9B
{
    class Program
    {
        static void Main(string[] args)
        {
            // File path
            string filePath = "sample.txt";
            // Read all lines from the file into an array
            string[] lines = File.ReadAllLines(filePath);
            
            // Regular expression pattern to match non-alphanumeric and non-whitespace characters
            string pattern = @"[^a-zA-Z0-9\s]";
            
            // 1) Count and write the number of symbols in each line
            Console.WriteLine("Number of non-alphanumeric symbols in each line:\n");
            foreach (string line in lines)
            {
                var symbolsCount = Regex.Matches(line, pattern).Count();
                Console.WriteLine(line);
                Console.WriteLine($"Number of non-alphanumeric symbols in the line {symbolsCount}\n");
            }
            // 2) Find the longest and shortest lines
            var longestLine = lines.OrderByDescending(line => line.Length).FirstOrDefault();
            var shortestLine = lines.OrderBy(line => line.Length).FirstOrDefault();
            Console.WriteLine("\nLongest line:");
            Console.WriteLine(longestLine);
            Console.WriteLine("\nShortest line:");
            Console.WriteLine(shortestLine);

            // 3) Find and write lines consisting of the word 'var'
            var linesConsistingVar = lines.Where(line => Regex.IsMatch(line, @"\bvar\b") && line.Trim() == "var");
            Console.WriteLine("\nLines consisting of the word 'var':");
            bool foundVarLines = false;
            foreach (var line in linesConsistingVar)
            {
                Console.WriteLine(line);
                foundVarLines = true;
            }
            if (!foundVarLines)
            {
                Console.WriteLine("\nNo lines found consisting of the word 'var'.");
            }

            Console.ReadLine();
        }
    }
}
