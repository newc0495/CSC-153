using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleUI
{
    public class BuildCar
    {
        public static void CreateCar(Car thisCar)
        {
            Console.WriteLine("Let's build a car!");
            Console.WriteLine("What is the car's year?: ");
            thisCar.Year = StandardMessages.MakeInt(Console.ReadLine());
            if (thisCar.Year < 1900)
            {
                Console.WriteLine($"{thisCar.Year} is not a valid year. Please try again.");
            }
            else
            {
                Console.WriteLine("What is the car's make?: ");
                thisCar.Make = Console.ReadLine();

                Console.WriteLine("Your car has been created!");
                Console.WriteLine($"Year: {thisCar.Year} \nMake: {thisCar.Make}");
            }
        }
    }
}
