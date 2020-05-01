using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClassLibrary
{
    public class Car : Automobile
    {
        private bool _trunk;

        public bool Trunk { get; set; }

        public Car()
        {
            Trunk = false;
        }

        public Car(int numWheels, int numDoors, int seatingSpace, bool trunk): base(numWheels, numDoors, seatingSpace) // : base() may not be needed...
        {
            Trunk = trunk;
        }
    }
}
