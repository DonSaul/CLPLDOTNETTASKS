using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4try
{
    internal class VarLineFinder
    {
        public static void FindLinesWithVar(string[] lines)
        {
            Console.WriteLine("\nTask 3: Lines containing the word 'var'");
            var linesWithVar = lines.Where(line => line.Contains("var"));
            foreach (var line in linesWithVar)
            {
                Console.WriteLine(line);
            }
        }

    }
}
