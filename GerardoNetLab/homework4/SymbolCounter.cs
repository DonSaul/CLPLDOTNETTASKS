using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4try
{
    internal class SymbolCounter
    {
        public static void CountAndWriteSymbols(string[] lines)
        {
            Console.WriteLine("Task 1: Number of symbols in each line");
            for (int i = 0; i < lines.Length; i++)
            {
                int symbolCount = lines[i].Length;
                Console.WriteLine($"Line {i + 1}: {symbolCount} symbols");
            }
        }
    }
}
