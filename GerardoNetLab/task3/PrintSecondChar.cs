using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class PrintSecondChar
    {
       
        public static void PrintSecond(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine();
        }
       
    }
}
