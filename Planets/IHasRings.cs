using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    interface IHasRings
    {
        public bool Hasring(int _ringCount)
        {
            return _ringCount;
        }
    }
}
