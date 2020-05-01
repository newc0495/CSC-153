using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Weapon
    {

        // Fields
        private string _name;
        private int _dmg;

        // Properties
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Dmg
        {
            get
            {
                return _dmg;
            }
            set
            {
                _dmg = value;
            }
        }

        // Auto Property
        public int Rarity { get; set; }

        // Constructor
        public Weapon()
        {
            Name = "";
            Dmg = 0;
            Rarity = 0;
        }

        public Weapon(string name, int dmg, int rarity)
        {
            Name = name;
            Dmg = dmg;
            Rarity = rarity;
        }

    }
}
