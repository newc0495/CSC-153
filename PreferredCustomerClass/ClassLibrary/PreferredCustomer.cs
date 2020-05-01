using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PreferredCustomer : Customer
    {
        public PreferredCustomer() { }
        public PreferredCustomer(string name, string addr, string phone, string custNum, bool subscr, decimal purchases,
                                 int discountLevel) :base(name, addr, phone, custNum, subscr)
        {
            Name = name;
            Addr = addr;
            Phone = phone;
            CustNum = custNum;
            Subscr = subscr;
            Purchases = purchases;
            DiscountLevel = discountLevel;
        }

        public decimal Purchases { get; set; }
        public int DiscountLevel { get; set; }

        public static decimal GetPurchases()
        {
            Console.WriteLine($"Purchase history: ");
            string historyString = Console.ReadLine();
            if (!decimal.TryParse(historyString, out decimal history))
            {
                Util.InvalidInput();
            }
            return history;
        }

        public static void GetDiscount(PreferredCustomer person) // TODO discount level isn't being updated
        {
            if (person.Purchases >= 2000m)
            {
                person.DiscountLevel = 10;
            }
            else if (person.Purchases >= 1500m)
            {
                person.DiscountLevel = 7;
            }
            else if (person.Purchases >= 1000m)
            {
                person.DiscountLevel = 6;
            }
            else if (person.Purchases >= 500m)
            {
                person.DiscountLevel = 5;
            }
        }
    }
}
