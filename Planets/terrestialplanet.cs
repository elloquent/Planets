 using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class terrestialplanet : planet
    {
        private bool _oxygen;

        public terrestialplanet(bool oxygen, double diameter, double mass, string name) : base(diameter, mass, name)
        {
            _oxygen = oxygen;
        }

        public bool Hasmoon(bool _moonCount)
        {

            return _moonCount;
        }

        public bool Habitable(bool _oxygen)
        {
            return _oxygen;
        }
    }
}
