using System;

namespace GarysWholeSaleGarage
{
    // Propellor light aircraft
    public class Cessna : Vehicle 
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"Your have refueled your car with {FuelCapacity} gallons!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna with {MaximumOccupancy} passengers flashes by you like a hurricane. Zoooooom!");
        }
    }
}
