using System;
using System.Collections.Generic;

namespace GarysWholeSaleGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero() { VehicleName = "fxs", CurrentChargePercentage = 50 };
            Zero fx = new Zero() { VehicleName = "fx", CurrentChargePercentage = 75 };
            Tesla modelS = new Tesla() { VehicleName = "modelS", CurrentChargePercentage = 21 };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {
                fx, fxs, modelS
            };

            Console.WriteLine("Electric Vehicles:");
            Console.WriteLine();
            foreach(IElectricVehicle ev in electricVehicles)
            {
                // Console.WriteLine($"{ev.CurrentChargePercentage}");
                Console.Write($"Vehicle {ev.VehicleName} Current Charge Percentage: "); ev.ShowCurrentChargePercentage();
            }

            Console.WriteLine("-------------------------------------------");

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            Console.WriteLine("-------------------------------------------");

            foreach(IElectricVehicle ev in electricVehicles)
            {
                // Console.WriteLine($"{ev.CurrentChargePercentage}");
                Console.Write($"Vehicle {ev.VehicleName} Current Charge Percentage: "); ev.ShowCurrentChargePercentage();
                Console.WriteLine();
            }

            /***********************************************/

            Ram ram = new Ram () { VehicleName = "ram", CurrentTankPercentage = 21};
            Cessna cessna150 = new Cessna () { VehicleName = "cessna150", CurrentTankPercentage = 40};

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>() {
                ram, cessna150
            };

            Console.WriteLine("Gas Vehicles: ");
            Console.WriteLine();
            foreach(IGasVehicle gv in gasVehicles)
            {
                // Console.WriteLine($"{gv.CurrentTankPercentage}");
                Console.Write($"Vehicle {gv.VehicleName} Current Fuel Percentage: "); gv.ShowCurrentTankPercentage();
            }

            Console.WriteLine("-------------------------------------------");

            foreach(IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            Console.WriteLine("-------------------------------------------");

            foreach(IGasVehicle gv in gasVehicles)
            {
                // Console.WriteLine($"{gv.CurrentTankPercentage}");
                Console.Write($"Vehicle {gv.VehicleName} Current Fuel Percentage: "); gv.ShowCurrentTankPercentage();
            }



            // Using object initializer to instantiate new class objects of each type:
            // Zero fxs = new Zero() { MainColor = "Seafoam Green", MaximumOccupancy = 4, BatteryKWh = 200.50 };
            // Tesla modelS = new Tesla() { MainColor = "Lilac", MaximumOccupancy = 2, BatteryKWh = 250.25 };
            // Cessna mx410 = new Cessna() { MainColor = "Turquoise", MaximumOccupancy = 4, FuelCapacity = 12.50 };
            // Ram trx1500 = new Ram() { MainColor = "Jet Black", MaximumOccupancy = 2, FuelCapacity = 21.21 };

            // // Invoking methods available for each class instance:
            // fxs.Drive();
            // fxs.Turn("left");
            // fxs.Stop();
            // fxs.ChargeBattery();

            // modelS.Drive();
            // modelS.Turn("right");
            // modelS.Stop();
            // modelS.ChargeBattery();

            // mx410.Drive();
            // mx410.Turn("right");
            // mx410.Stop();
            // mx410.RefuelTank();

            // trx1500.Drive();
            // trx1500.Turn("left");
            // trx1500.Stop();
            // trx1500.RefuelTank();

            // List<Zero> electricVehicles = new List<Zero>() { fx, fxs };
        }
    }
}
