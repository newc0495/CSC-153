using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClassLibrary
{
    public class Animal
    {
        // Fields

        // Properties
        public string Species { get; set; }

        // Constructors
        public Animal()
        {
            Species = "";
        }
        public Animal(string species)
        {
            Species = species;
        }

        // Methods
        public virtual string MakeSound()
        {
            return "Grrrr";
        }
    }
}
