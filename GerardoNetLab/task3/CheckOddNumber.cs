using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class CheckOddNumber
    {
        //Check whether the entered integer number contains only odd numbers
        public static void CheckOdd(int number)
        {
            bool isOdd = true;
            while (number > 0)
            {
                if (number % 2 == 0)
                {
                    isOdd = false;
                    break;
                }
                number /= 10;
            }

            if (isOdd)
            {
                Console.WriteLine("Solo contiene números impares.");
            }
            else
            {
                Console.WriteLine("No todos los números son impares.");
            }
        }   
    }
}
