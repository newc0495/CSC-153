using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Customer : Person
    {
        // Fields
        // Properties
        public string CustNum { get; set; }
        public bool MailList { get; set; }

        // Constructors
        public Customer(string name, string addr, string phone, string custNum, bool mailList)
        {
            Name = name;
            Addr = addr;
            Phone = phone;
            CustNum = custNum;
            MailList = mailList;
        }
        // Methods
        public static string GetNum()
        {
            Console.Write("Please enter the customer's unique number: ");
            string input = Console.ReadLine();
            return input;
        }

        public static bool GetMail()
        {
            bool subscribed = false;
            Console.Write("Does the customer subscribe to the mailing list? ('y' / 'n'): ");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                    subscribed = true;
                    return subscribed;
                case "n":
                    subscribed = false;
                    return subscribed;
                default:
                    Console.WriteLine("Defaulted. Customer not subscribed.");
                    subscribed = false;
                    return subscribed;
            }
        }
    }
}
