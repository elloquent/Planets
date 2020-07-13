using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    interface IHasMoons 
    {

        //public method that return a boolean to be overriden by the giantplanet  and the terrestialplanet class
        bool Hasmoon()
        {

            return true;
        }
    }
}
