using System;

namespace GarysWholeSaleGarage
{
    // Electric car
    public class Tesla : Vehicle // use a colon between the subclass/child class name and the base/parent class name when inheriting.
    // now any instance of Tesla will have the properties/methods from base class on it automatically.
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Your car is now charged to {BatteryKWh} KWh!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla with {MaximumOccupancy} passengers blazes by you. MMMmmmmmm!");
        }
    }
}
