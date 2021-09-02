using System;

namespace GarysWholeSaleGarage
{
    // Electric motorcycle
    public class Zero : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your car is now charged to {BatteryKWh} KWh!");
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero with {MaximumOccupancy} passengers zips by you. Yeeeooowww!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Zero carefully turns {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero gently rolls to a stop. Swoosh!");
        }
    }
}
