using System;
using System.Collections.Generic;

namespace GarysWholeSaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using object initializer to instantiate new class objects of each type:
            Zero fxs = new Zero() { MainColor = "Seafoam Green", MaximumOccupancy = 4, BatteryKWh = 200.50 };
            Tesla modelS = new Tesla() { MainColor = "Lilac", MaximumOccupancy = 2, BatteryKWh = 250.25 };
            Cessna mx410 = new Cessna() { MainColor = "Turquoise", MaximumOccupancy = 4, FuelCapacity = 12.50 };
            Ram trx1500 = new Ram() { MainColor = "Jet Black", MaximumOccupancy = 2, FuelCapacity = 21.21 };

            // Invoking methods available for each class instance:
            fxs.Drive();
            fxs.Turn("left");
            fxs.Stop();
            fxs.ChargeBattery();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            modelS.ChargeBattery();

            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();
            mx410.RefuelTank();

            trx1500.Drive();
            trx1500.Turn("left");
            trx1500.Stop();
            trx1500.RefuelTank();

            // List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
        }
    }
}
