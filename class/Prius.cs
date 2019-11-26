using System;

namespace _1_15.Refueling_Stations
{
    public class Prius : IVehicle, IGasVehicle, IElectricVehicle
    {
        public string Name { get; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public double FuelCapacity { get; set; }
        public double FuelLevel { get; set; }
        public double BatterykWh { get; set; }
        public Prius(string name)
        {
            Name = name;
        }

        public void Drive() { }
        public void RefuelTank() { }
        public void ChargeBattery() { }
    }
}