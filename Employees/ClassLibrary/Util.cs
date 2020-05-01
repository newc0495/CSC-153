using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Util
    {
        public static string DisplayMenu()
        {
            return "1. Enter Employee's Info" +
                "\n2. Display Employee Info" +
                "\n3. Display Average Age" +
                "\n4. Exit Program";
        }

        public static string UserPrompt()
        {
            Console.Write("Enter: ");
            string input = Console.ReadLine();
            return input;
        }

        public static int MakeInt(string input)
        {
            int output = 0;
            if (int.TryParse(input, out output))
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
            return "Invalid input. Please try again.";
        }

        public static double GetAvgAge(List<Employee> employeeList)
        {
            int count = 0;
            int ageTotal = 0;
            double average = 0.0;
            if (employeeList.Count > 0)
            {
                foreach (Employee employee in employeeList)
                {
                    count++;
                    ageTotal += employee.Age;
                }
                average = ageTotal / count;
                return average;
            }
            else
            {
                average = 0;
                Console.WriteLine("There are no employees to average!");
                return average;
            }
        }
    }
}
