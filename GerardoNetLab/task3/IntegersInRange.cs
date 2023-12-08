using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class IntegersInRange
    {
        public static int CalculateInteger(int numberA, int numberB){

            int count = 0;
            for (int i = numberA; i<= numberB; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
