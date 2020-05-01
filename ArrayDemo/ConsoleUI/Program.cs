using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 6, 3, 8, 5, 7 };
            int[] numbers2 = new int[6];

            Array.Sort(numbers);

            //for (int x = 0; x < numbers.Length; x++)
            //{
            //    Console.WriteLine(numbers[x]);
            //}

            int index = 0;

            foreach (var element in numbers)
            {
                Console.WriteLine(element);
                numbers2[index] = element;
                index++;
            }

            foreach (var element in numbers2)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();
        }
    }
}
