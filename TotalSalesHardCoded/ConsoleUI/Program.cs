using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 1/27/2020
* CSC 153
* Christian New
* Program displays values in an array.
* Sales per day and Total for the week.
*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] salesArray = { 1245.67m, 1189.55m, 1089.72m,
                1456.88m, 2109.34m, 1987.55m, 1872.36m };
            decimal total = 0m;

            for (int day = 0; day < salesArray.Length; day++)
            {
                Console.WriteLine($"Day {day + 1}: ${salesArray[day]}");
                total += salesArray[day];
            }

            Console.WriteLine();
            Console.WriteLine($"Total sales this week: ${total}");

            Console.ReadLine();
        }
    }
}
