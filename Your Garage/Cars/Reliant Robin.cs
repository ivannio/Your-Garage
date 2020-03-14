using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Reliant_Robin : Car
    {
        public int NumberOfWheels => 3;

        public void Roll()
        {
            Console.WriteLine("Hilariously, the Reliant Robin rolled over again");
        }
    }
}
