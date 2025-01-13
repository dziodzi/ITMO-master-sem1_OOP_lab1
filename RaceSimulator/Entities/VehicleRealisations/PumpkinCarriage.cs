namespace RaceSimulator.Entities.VehicleRealisations;

internal class PumpkinCarriage() : GroundVehicle("Pumpkin Carriage", 10.0, 30.0)
{
    protected override double GetRestDuration(int restCount)
    {
        return Math.Min(restCount * 2.0, 15.0);
    }
}