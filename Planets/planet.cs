using System;
using System.Collections.Generic;
using System.Text;



// Author:             Richard Elridge
//Author number#:      301107264
//Date last modify:    July 13 2020
//Program description: This assignment is design to test our knownlodge in Polymorphism, inheritance and interfaces.
//                     It also gives you the oppertunity to prctices getting use to publishing on Github,overriding methods and documenting your codes
//

namespace Planets
{
   abstract class planet
    {

        //private fields
        private double _diameter;
        private double _mass;
        private double _orbitalPeriod;
        private int _moonCount;
        private string _name;
        private int _ringCount;
        private double _rotationPeriod;

        // pulic properties read only
        public double Diameter { get; }
        public double Mass { get; }
        public double OritalPeriod { get; }
        public double RotationPeriod { get; }
        public int MoonCount { get; }
        public int RingCount { get; }
        public string Name { get; }



        /// <summary>
        /// public constructor of the base class
        /// </summary>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="name"></param>
        public planet( double diameter,double mass,string name)
        {
            _diameter = diameter;
            _mass = mass;
            _name = name;
        }


        /// <summary>
        /// method that display the results of the class properties
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {Diameter} {Mass}";
        }


    }
}
