using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World
{
    public interface IInventoryItem
    {
        string Name { get; set; }
        string Description { get; set; }

        void DisplayError();
    }
}
