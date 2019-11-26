using System;
using System.Collections.Generic;

namespace _1_15.Refueling_Stations
{
    class GasStation : IStation<IGasVehicle>
    {
        public int Capacity { get; set; } // The number of vehicles that they can refuel at any one time.
        public GasStation() { }

        // A method to print a message to the terminal that the vehicle has been refueled.
        public void Refuel(List<IGasVehicle> vehicles)
        {
            Console.WriteLine($"\nGas station:");
            foreach (IGasVehicle vehicle in vehicles)
            {
                Console.WriteLine($"The {vehicle.Name} has been refueled with {vehicle.FuelCapacity} gallons of gas.");
            }
        }
    }
}