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
            /* 
             * 2/3/20
             * CSC 153
             * Christian New
             * Presents menu to user,
             * asks user for number of ages to input,
             * displays all the ages input,
             * displays the average age of the list
             */

            /*
             * Code presently verifies user input, but doesn't flow
             * correctly. Needs to start over correctly in order
             * to be user friendly and make sense.
             */

            bool exit = false;
            do
            {
                List<int> ages = new List<int>();
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Add Ages");
                Console.WriteLine("2. Average Age");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Age List");
                        Console.WriteLine("How many ages in this list?: ");
                        string ageCountString = Console.ReadLine();
                        int ageCount;
                        if (int.TryParse(ageCountString, out ageCount))
                        {
                            for (int i = 0; i < ageCount; i++)
                            {
                                Console.WriteLine($"Please enter age {i + 1}: ");
                                string ageInputString = Console.ReadLine();
                                int ageInput;
                                if (int.TryParse(ageInputString, out ageInput))
                                {
                                    ages.Add(ageInput);
                                }
                                else
                                {
                                    Console.WriteLine($"{ageInputString} is not a valid age.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{ageCountString} is not a valid length.");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Averaging ages...");
                        
                        double average = ages.Average();
                        Console.WriteLine($"The average age is {average}");
                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine($"{choice} is not a valid choice.");
                        break;
                }
            } while (exit == false);
        }
    }
}
