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
            List<int> numbers = new List<int>();

            List<string> words = new List<string>() { "One", "Two", "Three", "Four", "Five" };

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            Console.WriteLine($"There are {numbers.Count} values in the list.");

            //for (int index = 0; index < numbers.Count; index++)
            //{
            //    Console.WriteLine($"Number {numbers[index]}");
            //}

            numbers.Insert(3, 100);

            Console.WriteLine("After instering");

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine($"Number {numbers[index]}");
            }

            numbers.Remove(100);

            Console.WriteLine("After Remove");

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine($"Number {numbers[index]}");
            }

            numbers.RemoveAt(3);

            Console.WriteLine("After RemoveAt");

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine($"Number {numbers[index]}");
            }

            int numberToSearch = 5;
            int position = numbers.IndexOf(numberToSearch);

            if (position != -1)
            {
                Console.WriteLine($"{numberToSearch} was found in the list");
            }
            else
            {
                Console.WriteLine($"{numberToSearch} was not found in the list");
            }

            Console.WriteLine("Using the foreach loop");

            foreach (int value in numbers)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}
