using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        // Fields
        // Properties
        public string Name { get; set; }
        public string Addr { get; set; }
        public string Phone { get; set; }

        // Constructors
        public Person() { }
        public Person(string name, string addr, string phone)
        {
            Name = name;
            Addr = addr;
            Phone = phone;
        }

        // Methods
        public static string GetName()
        {
            Console.Write("Please enter the customer's name: ");
            string input = Console.ReadLine();
            return input;
        }

        public static string GetAddr()
        {
            Console.Write("Please enter the customer's address: ");
            string input = Console.ReadLine();
            return input;
        }

        public static string GetPhone()
        {
            Console.Write("Please enter the customer's phone #: ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
