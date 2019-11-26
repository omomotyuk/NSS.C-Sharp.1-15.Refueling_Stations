using System;

namespace _1_15.Refueling_Stations
{

    public class Zero : IVehicle, IElectricVehicle
    {
        public string Name { get; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public Zero(string name)
        {
            Name = name;
        }

        public void Drive()
        {
            Console.WriteLine("Wooooosh!");
        }

        public double BatterykWh { get; set; }

        public void ChargeBattery()
        {
            BatterykWh = 150;
        }

    }
}