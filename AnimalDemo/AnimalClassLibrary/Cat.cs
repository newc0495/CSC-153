using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassLibrary
{
    public class Cat : Animal
    {
        // Fields

        // Properties
        public string Name { get; set; }

        // Constructors
        public Cat(string species, string name)
        {
            Species = species;
            Name = name;
        }

        // Methods
        public override string MakeSound()
        {
            return "Meow";
        }
    }
}
