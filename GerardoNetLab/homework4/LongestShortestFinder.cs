using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4try
{
    internal class LongestShortestFinder
    {
        public static void FindLongestShortestLines(string[] lines)
        {
            string longestLine = lines.OrderByDescending(s => s.Length).First();
            string shortestLine = lines.OrderBy(s => s.Length).First();

            Console.WriteLine("\nTask 2: Longest and shortest lines");
            Console.WriteLine($"Longest Line: {longestLine} (Length: {longestLine.Length} symbols)");
            Console.WriteLine($"Shortest Line: {shortestLine} (Length: {shortestLine.Length} symbols)");
        }
    }
}
