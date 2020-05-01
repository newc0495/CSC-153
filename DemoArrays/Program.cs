using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];

            int[] numArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(numArray[0]);
            Console.WriteLine(numArray[4]);

            const int SIZE = 3;

            string[] sizeArray = new string[SIZE];

            sizeArray[0] = "One";
            sizeArray[1] = "Two";
            sizeArray[2] = "Three";
            //sizeArray[3] = "Four";
            // This is out of bounds error

            Console.WriteLine($"The length of the array is: {sizeArray.Length}");

            for (int index = 0; index < sizeArray.Length; index++)
            {
                Console.WriteLine(sizeArray[index]);
            }

            const int ROW = 3;
            const int COL = 3;

            int[,] numb = new int[ROW, COL];

            numb[0, 0] = 5;
            numb[0, 1] = 10;

            Console.WriteLine($"The first number is {numb[0, 0]}");
            Console.WriteLine($"The second number is {numb[0, 1]}");

            int[,] numb2 = { { 1, 2, 3 },
                             { 4, 5, 6 },
                             { 7, 8, 9 } };

            const int ROWS = 3;
            const int COLS = 3;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Console.WriteLine($"The number is: {numb2[row, col]}");
                }
            }

            Console.ReadLine();
        }
    }
}
