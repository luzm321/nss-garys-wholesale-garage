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
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero with {MaximumOccupancy} passengers zips by you. Yeeeooowww!");
        }
    }
}
