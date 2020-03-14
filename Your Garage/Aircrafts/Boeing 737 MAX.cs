using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Boeing_737_MAX : Aircraft
    {
        public bool IsSafe => false;

        public void ProgramSafetyUtility()
        {
            Console.WriteLine("Semicolon expected on line 334202");
        }
    }
}
