using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnimalShelter
{
    class PriceBasedComparer : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x.Price < y.Price)
            {
                return -1;
            }
            else if (x.Price > y.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
