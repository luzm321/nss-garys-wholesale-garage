using System;

namespace GarysWholeSaleGarage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        // need to define method as virtual to be able to override the default logic/behavior of method when inherited by the subclasses:
        public virtual void Drive()
        {
            Console.WriteLine("Vrooom!");
        }
    }
}
