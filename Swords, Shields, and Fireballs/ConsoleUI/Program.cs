using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**

* 2/7/2020

* CSC 153

* Christian New

* Swords, Shields, and Fireballs is a Rock, Paper, Scissors-style Dungeon-Crawler

*/

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Minimal functionality for now. Taking 6 courses,
             * to include Capstone, this semester.
             * Please bear with developers as we continue to patch
             * in future updates ;)
             */

            string[] roomArray = new string[5];
            string[] weapArray = new string[4];
            string[] potArray = new string[2];
            string[] treasArray = new string[3];

            List<string> mobs = new List<string>();
            mobs.Add("Goblin");
            mobs.Add("Slime");
            mobs.Add("Undead");
            mobs.Add("Soldier");
            mobs.Add("Wizard");

            List<string> items = new List<string>();
            items.Add("Cloak of Wizardry");
            items.Add("Helm of Hard Heads");
            items.Add("Shoes of Not Procrastinating");
            items.Add("Shield of Not Today");

            var exit = false;
            do
            {
                //Main Menu
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Weapon");
                Console.WriteLine("3. Display Potions");
                Console.WriteLine("4. Display Treasures");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Mobs");
                Console.WriteLine("7. Exit Game");
                Console.WriteLine();
                Console.WriteLine("Enter option: ");
                string choiceString = Console.ReadLine();
                int choice;

                if (int.TryParse(choiceString, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Displaying Rooms...");
                            break;
                        case 2:
                            Console.WriteLine("Displaying Weapons...");
                            break;
                        case 3:
                            Console.WriteLine("Displaying Potions...");
                            break;
                        case 4:
                            Console.WriteLine("Displaying Treasures...");
                            break;
                        case 5:
                            Console.WriteLine("Displaying Items...");
                            break;
                        case 6:
                            Console.WriteLine("Displaying Mobs...");
                            break;
                        case 7:
                            Console.WriteLine("Exiting...");
                            exit = true;
                            break;
                        default:
                            // Double validation
                            Console.WriteLine("Error. Try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine($"{choiceString} is not a valid option.");
                }
                

            } while (exit == false);
        }
    }
}
