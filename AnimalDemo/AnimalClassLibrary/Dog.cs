using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassLibrary
{
    public class Dog : Animal
    {
        // Fields

        // Properties
        public string Name { get; set; }

        // Constructors
        public Dog(string species, string name) : base(species)
        {
            Name = name;
        }

        // Methods
        public override string MakeSound()
        {
            return "Woof";
        }
    }
}
