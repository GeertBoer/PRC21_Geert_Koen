using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    class ChipNrBasedComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x.ChipRegistrationNumber > y.ChipRegistrationNumber)
            {
                return 1;
            }
            else if (x.ChipRegistrationNumber < y.ChipRegistrationNumber)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
