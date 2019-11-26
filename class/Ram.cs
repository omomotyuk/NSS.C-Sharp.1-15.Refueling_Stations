using System;

namespace _1_15.Refueling_Stations
{
    public class Ram : IVehicle, IGasVehicle
    {
        public string Name { get; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelLevel { get; set; }

        public Ram(string name)
        {
            Name = name;
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }

        public void Drive() { }

    }
}