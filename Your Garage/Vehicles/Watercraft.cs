using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Watercraft : Vehicle
    {
        public void Refuel()
        {
            Console.WriteLine($"Refueled the {Color} watercraft");
        }

        public void Drive()
        {
            Console.WriteLine("I am driving my watercraft");
        }

    }
}
