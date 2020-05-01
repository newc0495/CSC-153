using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer : Person
    {
        public Customer() { }
        public Customer(string name, string addr, string phone, string custNum, bool subscr):base(name, addr, phone)
        {
            Name = name;
            Addr = addr;
            Phone = phone;
            CustNum = custNum;
            Subscr = subscr;
        }

        public string CustNum { get; set; }
        public bool Subscr { get; set; }

        public static string GetNum()
        {
            Console.Write("Customer's ID#: ");
            string input = Console.ReadLine();
            return input;
        }

        public static bool GetMail()
        {
            bool subscribed = false;
            Console.Write("Subscribed? (y / n): ");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    subscribed = true;
                    return subscribed;
                case "n":
                    subscribed = false;
                    return subscribed;
                default:
                    Console.WriteLine("Defaulted: Customer not subscribed.");
                    subscribed = false;
                    return subscribed;
            }
        }
    }
}
