using RaceSimulator.Entities;
using RaceSimulator.Exceptions;
using RaceSimulator.Services;
using RaceSimulator.Tools;

namespace RaceSimulator;

internal static class Program
{
    private static void Main()
    {
        Actions.OnStartAction();

        var type = Actions.InputRaceTypeAction();

        var distance = Actions.InputRaceDistanceAction();

        var weather = Actions.InputRaceWeatherAction();

        IRaceService raceService = new RaceService(distance, type, weather);

        List<KeyValuePair<Vehicle, double>> result = [];

        while (!raceService.RegisterVehicles(Actions.SelectParticipantsAction(raceService.GetRaceType())))
        {
            try
            {
                result = raceService.StartRace();
            }
            catch (NoRaceParticipantsException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        Actions.OutputRaceResultsAction(result);

        Actions.OnFinishAction();
    }
}