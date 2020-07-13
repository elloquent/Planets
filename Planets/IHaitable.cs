using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    interface IHaitable
    {

        bool Habitable(bool _oxygen)
        {
            return _oxygen;
        }
    }
}
