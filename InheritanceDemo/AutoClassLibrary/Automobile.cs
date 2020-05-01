using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoClassLibrary
{
    /* sealed */ public class Automobile
    {
        private int _numberWheels;
        private int _numberDoors;
        private int _seatingSpace;

        public int NumberWheels { get; set; }
        public int NumberDoors { get; set; }
        public int SeatingSpace { get; set; }

        public Automobile()
        {
            NumberWheels = 0;
            NumberDoors = 0;
            SeatingSpace = 0;
        }

        public Automobile(int numWheels, int numDoors, int seatingSpace)
        {
            NumberWheels = numWheels;
            NumberDoors = numDoors;
            SeatingSpace = seatingSpace;
        }
    }
}
