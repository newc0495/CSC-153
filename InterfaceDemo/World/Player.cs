using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class Player
    {
        private string _firstName;
        private string _lastName;

        public Player()
        {
            FirstName = "";
            LastName = "";
            Health = 0;
            List<IInventoryItem> inventory = new List<IInventoryItem>();
        }
        public Player(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Health { get; private set; }
    }
}
