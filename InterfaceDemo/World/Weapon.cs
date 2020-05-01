using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public class Weapon : IInventoryItem
    {
        private string _name;
        private string _damageType;
        private int _minDamage;
        private int _maxDamage;

        public Weapon()
        {
            Name = "";
            DamageType = "";
            MinDamage = 0;
            MaxDamage = 0;
        }
        public Weapon(string name, string damageType, int minDamage, int maxDamage)
        {
            Name = name;
            DamageType = damageType;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public string Name { get => _name; set => _name = value; }
        public string DamageType { get => _damageType; set => _damageType = value; }
        public int MinDamage { get => _minDamage; set => _minDamage = value; }
        public int MaxDamage { get => _maxDamage; set => _maxDamage = value; }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayError()
        {
            throw new NotImplementedException();
        }
    }
}
