using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Util
    {
        public static string DisplayMenu()
        {
            return "\n--- Main Menu ---"
                   + "\n1. Enter Customer Info"
                   + "\n2. Display Customer Info"
                   + "\n3. Exit Program";
        }

        public static void EnterInfo(List<Person> customers)
        {
            Customer fNG = new Customer(Person.GetName(),
                                        Person.GetAddr(),
                                        Person.GetPhone(),
                                        Customer.GetNum(),
                                        Customer.GetMail());
            customers.Add(fNG);
        }

        public static void DisplayInfo(List<Person> customers)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("There are no customers entered.");
            }
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"\nCustomer Name: {customer.Name}"
                                  + $"\nAddress: {customer.Addr}"
                                  + $"\nPhone: {customer.Phone}"
                                  + $"\nCustomer #: {customer.CustNum}"
                                  + $"\nMailing List: {customer.MailList}");
            }
        }
    }
}
