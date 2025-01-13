using RaceSimulator.Entities;
using RaceSimulator.Tools;

namespace RaceSimulator.Services;

public interface IRaceService
{
    public bool RegisterVehicles(List<Vehicle> transports);

    public List<KeyValuePair<Vehicle, double>> StartRace();

    public RaceEnums GetRaceType();
}