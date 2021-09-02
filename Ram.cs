using System;

namespace GarysWholeSaleGarage
{
    // Gas powered truck
    public class Ram : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
              Console.WriteLine($"Your have refueled your car with {FuelCapacity} gallons!");
        }

         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram with {MaximumOccupancy} passengers growls by you. Rrrruuummmble!");
        }
    }
}
