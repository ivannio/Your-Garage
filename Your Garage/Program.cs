using System;
using System.Collections.Generic;

namespace Your_Garage
{
    class Program
    {
        public static void Main()
        {
            // A I R C R A F T S

            var safePlane = new Boeing_737_MAX()
            {
                FuelCapacity = 100,
                Color = Color.White,
                MaxOccupancy = 172
            };

            var glider = new Glider()
            {
                FuelCapacity = 45,
                Color = Color.Yellow,
                MaxOccupancy = 2,
                OpenAir = true
            };

            var flyingVehicles = new List<Aircraft> { safePlane, glider };

            foreach (var vehicle in flyingVehicles)
            {
                vehicle.Fly();
            }

            // C A R S

            var myCar = new Ford_Focus()
            {
                FuelCapacity = 13,
                Color = Color.Black,
                MaxOccupancy = 5
            };

            var rollsRoyce = new Reliant_Robin()
            {
                FuelCapacity = 7,
                Color = Color.Red,
                MaxOccupancy = 5
            };

            var roadVehicles = new List<Car> { myCar, rollsRoyce };

            foreach (var vehicle in roadVehicles)
            {
                vehicle.Drive();
            }

            // W A T E R C R A F T S

            var titanic = new Titanic()
            {
                FuelCapacity = 500,
                Color = Color.Black,
                MaxOccupancy = 3547
            };

            var redDragon = new King_Of_Red_Lions()
            {
                FuelCapacity = 0,
                Color = Color.Red,
                MaxOccupancy = 2
            };

            var waterVehicles = new List<Watercraft> { titanic, redDragon };

            foreach (var vehicle in waterVehicles)
            {
                vehicle.Drive();
            }
        }
    }
}
