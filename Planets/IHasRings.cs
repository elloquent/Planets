using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    interface IHasRings
    {

        //public method that return a boolean to be overriden by the giantplanet class
        public bool Hasring()
        {
            
            return true ;
        }
    }
}
