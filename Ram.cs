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
              Console.WriteLine();
        }

         public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram with {MaximumOccupancy} passengers growls by you. Rrrruuummmble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram makes a heavy turn to the {direction}. Roarrrr!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram noisily bellows to a stop.");
        }
    }
}
