using System;
using System.Collections.Generic;

namespace _1_15.Refueling_Stations
{
    public interface IStation<T>
    {
        int Capacity { get; set; } // The number of vehicles that they can refuel at any one time.
        void Refuel(List<T> vehicles) { } // A method to print a message to the terminal that the vehicle has been refueled. (e.g. "The Cessna has been refueled with 200 gallons of gas") Each refueling station's Refuel() method should accept a list of vehicles that only it can process. GasStation.Refuel() should only accept a list of gas-powered vehicles. BatteryStation.Refuel() should only accept a list of electric-powered vehicles.

    }
}