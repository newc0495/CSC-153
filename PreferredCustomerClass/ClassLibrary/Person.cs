using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public Person() { }

        public Person(string name, string addr, string phone)
        {
            Name = name;
            Addr = addr;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Addr { get; set; }
        public string Phone { get; set; }

        public static string GetName()
        {
            Console.Write("Customer's name: ");
            string input = Console.ReadLine();
            return input;
        }

        public static string GetAddr()
        {
            Console.Write("Customer's address: ");
            string input = Console.ReadLine();
            return input;
        }

        public static string GetPhone()
        {
            Console.Write("Customer's phone #: ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
