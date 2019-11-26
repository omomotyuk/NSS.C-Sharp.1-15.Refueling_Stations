namespace _1_15.Refueling_Stations
{
    public interface IVehicle
    {
        string Name {get;}
        string MainColor {get; set;}
        int MaximumOccupancy {get; set;}
        void Drive();
    }
}


