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
                   + "\n3. Submit Cart"
                   + "\n4. Exit Program";
        }

        public static string InvalidInput()
        {
            return "Invalid input. Please try again.";
        }

        public static void EnterInfo(List<Person> people)
        {
            PreferredCustomer fNG = new PreferredCustomer(Person.GetName(),
                                                          Person.GetAddr(),
                                                          Person.GetPhone(),
                                                          Customer.GetNum(),
                                                          Customer.GetMail(),
                                                          PreferredCustomer.GetPurchases(),
                                                          0);
            people.Add(fNG);
        }

        public static void DisplayInfo(List<Person> people)
        {
            if (people.Count == 0)
            {
                Console.WriteLine("There are no customers entered.");
            }
            foreach (PreferredCustomer person in people)
            {
                Console.WriteLine($"\nCustomer Name: {person.Name}"
                                  + $"\nAddress: {person.Addr}"
                                  + $"\nPhone: {person.Phone}"
                                  + $"\nCustomer ID#: {person.CustNum}"
                                  + $"\nSubscribed: {person.Subscr}"
                                  + $"\nPurchase History: ${person.Purchases}"
                                  + $"\nDiscount Level: {person.DiscountLevel}%");
            }
        }

        public static void SubmitCart(List<Person> people)
        {
            if (people.Count == 0)
            {
                Console.WriteLine("There are no customers.");
            }
            else
            {
                Console.Write("Enter Customer ID#: ");
                string inputID = Console.ReadLine();
                foreach (PreferredCustomer person in people)
                {
                    if (person.CustNum == inputID)
                    {
                        Console.Write("Enter purchase amount: $");
                        if (!decimal.TryParse(Console.ReadLine(), out decimal amount))
                        {
                            InvalidInput();
                        }
                        person.Purchases += amount;
                        PreferredCustomer.GetDiscount(person);
                    }
                    else
                    {
                        Console.WriteLine($"Customer with ID# '{inputID}' could not be found.");
                    }
                } 
            }
        }
    }
}
