using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    interface IHaitable
    {


        //public method to be overriden by the terrestialplanet class
        bool Habitable(bool _oxygen)
        {
            return _oxygen;
        }
    }
}
