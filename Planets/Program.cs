using System;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            giantplanet _giantplanet = new giantplanet("gas", 10.4, 20, "pluto");
            _giantplanet.ToString();
            terrestialplanet _terrestialplanet = new terrestialplanet(true, 15, 30, "Earth");
            _terrestialplanet.ToString();
        }

        public void waitforanykey()
        {

            Console.ReadKey();

        }
    }
    }
}
