using System;
using System.Collections.Generic;

namespace _1_15.Refueling_Stations
{
    class BatteryStation : IStation<IElectricVehicle>
    {
        public int Capacity { get; set; } // The number of vehicles that they can refuel at any one time.
        public BatteryStation()
        { }
        // A method to print a message to the terminal that the vehicle has been refueled.
        public void Refuel(List<IElectricVehicle> vehicles)
        {
            Console.WriteLine($"\nBattery station:");
            foreach (IElectricVehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle.Name} has been charged to {vehicle.BatterykWh} kWh");
            }
        }
    }
}