using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2/25/20
 * CSC 153
 * Christian New
 * App lets the user enter an item's cost and
 * its markup to display the item's price.
 */

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var exit = false;

            do
            {
                Console.WriteLine("--- Main Menu ---");
                Console.WriteLine("1. Enter");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                Console.WriteLine("Enter an option: ");
                string choiceString = Console.ReadLine();
                int choice;
                if (int.TryParse(choiceString, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Calculator();
                            break;
                        case 2:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine();
                            Console.WriteLine($"'{choice}' is not a valid option. Please try again.");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"'{choiceString}' is not a valid option. Please try again.");
                    Console.WriteLine();
                }
            } while (exit == false);
        }

        static void Calculator()
        {
            Console.WriteLine("Please enter the wholesale cost of the item: ");
            string costString = Console.ReadLine();
            decimal cost;
            if (decimal.TryParse(costString, out cost))
            {
                Console.WriteLine();
                Console.WriteLine($"You entered ${cost} as the cost.");
                Console.WriteLine();
            }

            Console.WriteLine("Please enter the percentage markup of the item: ");
            string markupString = Console.ReadLine();
            decimal markup;
            if (decimal.TryParse(markupString, out markup))
            {
                Console.WriteLine();
                Console.WriteLine($"You entered {markup}% for the markup.");
                Console.WriteLine();
            }

            decimal price = cost + (cost * (markup / 100));

            Console.WriteLine("Calculating...");
            Console.WriteLine();
            Console.WriteLine($"The price for this item is: ${price:N2}");
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
