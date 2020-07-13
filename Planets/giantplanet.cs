using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Planets
{
    class giantplanet : planet, IHasMoons, IHasRings
    {
        private string _type;

        public giantplanet(string type,double diameter,double mass,string name
            ) : base(diameter, mass, name)
        {
            _type = type;
        }

        public bool Hasmoon(bool _moonCount)
        {

            return _moonCount;
        }

        public bool Hasring(int _ringCount)
        {
            return _ringCount ;
        }



    }

    }
}
