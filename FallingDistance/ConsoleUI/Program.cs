using System;

/* 2/25/20
 * CSC 153
 * Christian New
 * App allows the user to enter the amount of
 * time a object has fallen and displays the
 * distance the object fell.
 */

namespace ConsoleUI
{
    class Program
    {
        const double GRAV = 9.8;

        static void Main(string[] args)
        {
            var exit = false;

            do
            {
                Console.WriteLine("--- Main Menu ---");
                Console.WriteLine("1. Enter");
                Console.WriteLine("2. Exit");
                Console.WriteLine();
                Console.WriteLine("Please enter an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        double timeToCalculate = FallingTime();
                        Calculate(timeToCalculate);
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

            } while (exit == false);
        }

        static double FallingTime()
        {
            Console.WriteLine("Please enter the the amount of time the object has fallen: ");
            double time = double.Parse(Console.ReadLine());
            Console.WriteLine($"You said the object has been falling {time} second(s).");
            return time;
        }

        static void Calculate(double time)
        {
            double distanceFallen = 0.5 * (GRAV * (time * time));
            Console.WriteLine($"The object has fallen {distanceFallen} meters.");
        }
    }
}
