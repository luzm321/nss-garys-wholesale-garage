using System;

namespace GarysWholeSaleGarage
{
    public interface IElectricVehicle
    {
        string VehicleName { get; set; }
        double CurrentChargePercentage { get; set; }

        void ChargeBattery();
        void ShowCurrentChargePercentage();
    }
}