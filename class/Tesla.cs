using System;

namespace _1_15.Refueling_Stations
{

    public class Tesla : IVehicle, IElectricVehicle
    {
        public string Name { get; }
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }
        public Tesla(string name)
        {
            Name = name;
        }

        public void Drive()
        {
            Console.WriteLine("Vroom!");
        }

        public double BatterykWh { get; set; }

        public void ChargeBattery()
        {
            BatterykWh = 100;
        }

        public void Steer()
        {

        }
    }
}