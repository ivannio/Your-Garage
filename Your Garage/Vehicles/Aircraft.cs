using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Aircraft : Vehicle
    {
        public void Refuel()
        {
            Console.WriteLine($"Refueled the {Color} aircraft");
        }

        public void Fly()
        {
            Console.WriteLine("I'm literally flying right now");
        }

        public void Land()
        {
            Console.WriteLine("The aircraft has landed");
        }
    }
}
