using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Glider : Aircraft
    {
        public bool OpenAir { get; set; }

        public void JustGlide()
        {
            Console.WriteLine("I have cut the engine and now we just glidin'");
        }
    }
}
