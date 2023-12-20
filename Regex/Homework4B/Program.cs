using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("homework8.txt");

            Console.WriteLine("Task 1: Number of symbols in each line");
            foreach (var line in lines)
            {
                int symbolCount = Regex.Matches(line, @"[^\w\d\s]").Count;
                Console.WriteLine($"Line: {line} ///Number of symbols: {symbolCount}");
            }

            string shortestLine = lines.OrderBy(s => s.Length).First();
            string longestLine = lines.OrderByDescending(s => s.Length).First();

            Console.WriteLine("");
            Console.WriteLine("Task 2: Shortest and Longest lines");
            Console.WriteLine($"Shortest line: {shortestLine} ///Length: {shortestLine.Length}");
            Console.WriteLine("");
            Console.WriteLine($"Longest line: {longestLine} ///Length: {longestLine.Length}");

            Console.WriteLine("");
            Console.WriteLine("Task 3: Lines containing ONLY the word 'var'");
            var linesWithVar = lines.Where(line => line.Trim().Equals("var", StringComparison.OrdinalIgnoreCase));
            int count = 0;
            foreach (var line in linesWithVar)
            {
                Console.WriteLine(line);
                count++;
            }
            if (count == 0)
                Console.WriteLine("There are no lines containing ONLY the word 'var'");
            Console.WriteLine("");
            Console.WriteLine("Press a key to exit.");
            Console.ReadKey();
        }
    }
}
