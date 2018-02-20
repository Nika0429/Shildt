using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    class Building
    {
        public int Floors;
        public int Arrea;
        public int Occupants;

        public int ArreaPerPerson()
        {
            return Arrea / Occupants;
        }
    }
}
