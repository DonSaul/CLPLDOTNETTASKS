using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLabTask3
{
    internal class DrinkName
    {
        //enter a drikn name and print the price, use a bidimensional array
        public static void DrinkPrice(string drinkName)
        {
            string[,] drink = new string[3, 2]
            {
                {"cocacola", "1.50"},
                {"sprite", "2.50"},
                {"fanta", "3.50"}
            };

            for (int i = 0; i < drink.GetLength(0); i++)
            {
                if (drink[i, 0] == drinkName)
                {
                    Console.WriteLine($"El precio de {drinkName} es {drink[i, 1]}");
                }
            }
        }   

    }
}
