using DroneDelivery.Services.FileService;
using DroneDelivery.Services.OutputService;
using DroneDelivery.Services.TripService;
using Drones.Models;

namespace Drones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" DELIVERY DRONE SYSTEM ");

            IFileManager<string[]> _fileManager = new FileManager();
            ITripManager _tripManager = new TripManager();
            IOutputManager _outputManager = new OutputManager();

            _outputManager.ShowInputFile(_fileManager);
            var drones =  Drone.GetAllDrones(_fileManager);
            var locations = Location.GetAllLocations(_fileManager);
            var trips = _tripManager.GenerateTrips(drones, locations);
            _outputManager.ShowTrips(trips);

            Console.ReadKey();

        }
    }
}