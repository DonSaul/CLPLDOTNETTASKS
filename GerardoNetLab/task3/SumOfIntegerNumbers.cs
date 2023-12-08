using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class SumOfIntegerNumbers
    {
        //Find the sum of digits of the entered integer number using a list.
        public static void SumOfDigits(int number)
        {
            int sum = 0;
            List<int> digits = new List<int>();
            while (number > 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            foreach (var digit in digits)
            {
                sum += digit;
            }

            Console.WriteLine($"The sum of digits is {sum}");
        }

    }


}
