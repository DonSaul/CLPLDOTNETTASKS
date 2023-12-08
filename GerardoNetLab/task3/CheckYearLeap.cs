using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class CheckYearLeap
    {
        public static void CheckYear(int year)
        {
            if (year % 4 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }
            else
            {
                Console.WriteLine("El año no es bisiesto");
            }
        }
    }
}
