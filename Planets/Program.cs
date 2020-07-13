using System;

namespace Planets
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an instance of the giantplanet class
            giantplanet _giantplanet = new giantplanet("gas", 10.4, 20, "pluto");

            //useing the instance to call the tostring method in the giantplanet class
            _giantplanet.ToString();

            //creating an instance of the terrestialplanet class
            terrestialplanet _terrestialplanet = new terrestialplanet(true, 15, 30, "Earth");

            //useing the instance to call the tostring method in the terrestialplanet class
            _terrestialplanet.ToString();
        }

        //this method read the console for any keys
        public void waitforanykey()
        {

            Console.ReadKey();

        }
    }
    }
}
