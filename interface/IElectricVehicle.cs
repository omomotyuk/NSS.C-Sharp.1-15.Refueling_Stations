namespace _1_15.Refueling_Stations
{
    public interface IElectricVehicle
    {
        string Name { get; }
        string MainColor { get; set; }
        int MaximumOccupancy { get; set; }
        double BatterykWh { get; set; }
        void ChargeBattery();
    }
}