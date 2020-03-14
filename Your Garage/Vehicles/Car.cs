using System;
using System.Collections.Generic;
using System.Text;

namespace Your_Garage
{
    class Car : Vehicle
    {
        public int BatteryCapacity { get; set; }

        public void Refuel()
        {
            Console.WriteLine($"Refueled the {Color} car");
        }

        public void Drive()
        {
            Console.WriteLine("Vroom vroom");
        }

        public void Brake()
        {
            Console.WriteLine("Skkkkkrrrrrtt");
        }
    }
}
