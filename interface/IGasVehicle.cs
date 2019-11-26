namespace _1_15.Refueling_Stations
{
    public interface IGasVehicle
    {
        string Name { get; }
        string MainColor { get; set; }
        int MaximumOccupancy { get; set; }
        double FuelCapacity { get; set; }
        double FuelLevel { get; set; }
        void RefuelTank();
    }
}