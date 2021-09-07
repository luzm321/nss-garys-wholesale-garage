using System;

namespace GarysWholeSaleGarage
{
    // Electric car
    public class Tesla : Vehicle, IElectricVehicle // use a colon between the subclass/child class name and the base/parent class name when inheriting.
    // now any instance of Tesla will have the properties/methods from base class on it automatically.
    {
        public double BatteryKWh { get; set; } = 100.00;
        public double CurrentChargePercentage { get; set; }

        public void ChargeBattery()
        {
            // Console.WriteLine($"Your car is now charged to {BatteryKWh} KWh!");
            Console.WriteLine($"Your {VehicleName} is now charged from {CurrentChargePercentage}% to {BatteryKWh}% KWh!");
            CurrentChargePercentage = BatteryKWh;
            Console.WriteLine();
        }

        public void ShowCurrentChargePercentage()
        {
            Console.WriteLine(CurrentChargePercentage.ToString());
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla with {MaximumOccupancy} passengers blazes by you. MMMmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }

        // public override string ToString()
        // {
        //     return $"{VehicleName}";
        // }
    }
}
