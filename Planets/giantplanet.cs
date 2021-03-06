﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Planets
{
    class giantplanet : planet, IHasMoons, IHasRings
    {

        //private field
        private string _type;


        /// <summary>
        /// public constructor that inherited  values from base class and initiate them 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="name"></param>
        public giantplanet(string type,double diameter,double mass,string name
            ) : base(diameter, mass, name)
        {
            _type = type;
        }


        //public methed this method override the hasmoon method in IHasmoon interface
        public bool Hasmoon()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            return false;
        }



        //public methed this method override the hasring method in IHasring interface
        public bool Hasring()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// This method override the abstract class toString method
        /// </summary>
        /// <returns>
        /// This method returned a formatted string that displays class properties
        /// </returns>
        public override string ToString()
        {
            //return base.ToString()
           return base.ToString() +"\t"+ _type.ToString();
        }


    }

    
}
