using System;
using System.Collections.Generic;

namespace _1_15.Refueling_Stations
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a GasStation type for gas-powered vehicles.
                Create a BatteryStation type for electric-powered vehicles.
                Create an inteface that both types of stations must implement that ensures that they both have the following properties and methods.
                    int Capacity: The number of vehicles that they can refuel at any one time.
                    void Refuel(List<T> vehicles): A method to print a message to the terminal that the vehicle has been refueled. (e.g. "The Cessna has been refueled with 200 gallons of gas") Each refueling station's Refuel() method should accept a list of vehicles that only it can process. GasStation.Refuel() should only accept a list of gas-powered vehicles. BatteryStation.Refuel() should only accept a list of electric-powered vehicles.
                In your main method, make sure you have a list of electric vehicles, and a list of gas vehicles.
                Create an instance of BatteryStation and GasStation.
                Refuel all the vehicles by sending them to the correct refueling station.
            */

            var ram = new Ram("Ram");
            var zero = new Zero("Zero");
            var tesla = new Tesla("Tesla");
            var prius = new Prius("Prius");

            List<IVehicle> vehicles = new List<IVehicle> { ram, zero, tesla, prius };
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle> { zero, tesla, prius };
            List<IGasVehicle> gasVehicles = new List<IGasVehicle> { ram, prius };

            // 3. Define a different value for each vehicle's properties

            // ram
            ram.MainColor = "Red";
            ram.MaximumOccupancy = 6;
            ram.FuelCapacity = 20.0;

            // zero
            zero.MainColor = "Green";
            zero.MaximumOccupancy = 2;
            zero.BatterykWh = 25.0;

            // tesla
            tesla.MainColor = "Blue";
            tesla.MaximumOccupancy = 4;
            tesla.BatterykWh = 54.0;

            // prius
            prius.MainColor = "White";
            prius.MaximumOccupancy = 2;
            prius.FuelCapacity = 30.0;
            prius.BatterykWh = 25.0;


            GasStation gasStation = new GasStation();
            BatteryStation batteryStation = new BatteryStation();

            gasStation.Refuel( gasVehicles );
            batteryStation.Refuel( electricVehicles );
        }
    }
}