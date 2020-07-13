using System;
using System.Collections.Generic;
using System.Text;

namespace Planets
{
    class planet
    {
        private double _diameter;
        private double _mass;
        private double _orbitalPeriod;
        private int _moonCount;
        private string _name;
        private int _ringCount;
        private double _rotationPeriod;


        public double Diameter { get; }
        public double Mass { get; }
        public double OritalPeriod { get; }
        public double RotationPeriod { get; }
        public int MoonCount { get; }
        public int RingCount { get; }
        public string Name { get; }

        public planet( double diameter,double mass,string name)
        {
            _diameter = diameter;
            _mass = mass;
            _name = name;
        }

        public override string ToString()
        {
            return $"{Name} {Diameter} {Mass}";
        }


    }
}
