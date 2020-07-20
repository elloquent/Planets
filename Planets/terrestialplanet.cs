 using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class terrestialplanet : planet, IHasMoons, IHaitable
    {
        //private field
        private bool _oxygen;


        /// <summary>
        /// public constructor that inherited  values from base class and initiate them 
        /// </summary>
        /// <param name="oxygen"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="name"></param>
        public terrestialplanet(bool oxygen, double diameter, double mass, string name) : base(diameter, mass, name)
        {
            _oxygen = oxygen;
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


       //public methed this method override the habitable method in Ihabitable interface
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else return false;
        }


        /// <summary>
        /// This method override the abstract class toString method
        /// </summary>
        /// <returns>
        /// This method returned a formatted string that displays class properties
        /// </returns>
        public override string ToString()
        {
            return base.ToString() +"\t"+ _oxygen.ToString();
        }
    }
}
