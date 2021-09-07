namespace GarysWholeSaleGarage
{
    public interface IGasVehicle
    {
        string VehicleName { get; set; }
        double CurrentTankPercentage { get; set; }

        void RefuelTank();
        void ShowCurrentTankPercentage();
    }
}