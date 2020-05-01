using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mob
    {
        // Fields
        private string _name;
        private int _atk;
        private int _def;

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

        public int Atk
        {
            get
            {
                return _atk;
            }
            set
            {
                _atk = value;
            }
        }

        public int Def
        {
            get
            {
                return _def;
            }
            set
            {
                _def = value;
            }
        }

        // Auto Property
        public int Loot { get; set; }
        
        // Constructor
        public Mob()
        {
            Name = "";
            Atk = 0;
            Def = 0;
            Loot = 0;
        }

        public Mob(string name, int atk, int def, int loot)
        {
            Name = name;
            Atk = atk;
            Def = def;
            Loot = loot;
        }

    }
}
