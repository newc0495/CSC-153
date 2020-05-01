using System;

namespace ClassLibrary
{
    public class StandardMessages
    {
        public static string Menu()
        {
            return "1. Create Car \n2. Accelerate \n3. Brake \n4. Exit";
        }

        public static string GetInput()
        {
            Console.Write("Enter an option: ");
            string input = Console.ReadLine();
            return input;
        }

        public static int MakeInt(string input)
        {
            if (int.TryParse(input, out int output))
            {
                return output;
            }
            else
            {
                output = -1;
                return output;
            }
        }

        public static string InvalidInput()
        {
            return "Not a valid choice. Please try again.";
        }
    }
}
