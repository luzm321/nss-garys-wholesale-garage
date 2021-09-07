using System;

namespace GarysWholeSaleGarage
{
    // Propellor light aircraft
    public class Cessna : Vehicle, IGasVehicle 
    {
        public double FuelCapacity { get; set; } = 100.00;
        public double CurrentTankPercentage { get; set; }

        public void RefuelTank()
        {
            // Console.WriteLine($"Your have refueled your car with {FuelCapacity} gallons!");
            Console.WriteLine($"Your {VehicleName} is now refueled from {CurrentTankPercentage}% to {FuelCapacity}%!");
            CurrentTankPercentage = FuelCapacity;
            Console.WriteLine();
        }

        public void ShowCurrentTankPercentage()
        {
            Console.WriteLine(CurrentTankPercentage.ToString());
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna with {MaximumOccupancy} passengers flashes by you like a hurricane. Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna rapidly makes a sharp turn to the {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}
