using DroneDelivery.Services.FileService;
using Drones.Models;

namespace DroneDelivery.Services.OutputService
{
    public class OutputManager : IOutputManager
    {
        public void ShowTrips(List<Trip> trips)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("----------- EXPECTED OUTPUT ----------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            if (trips.Count > 0)
            {
                var drones = trips.Select(trip => trip.GetDrone()).Distinct();
                foreach (Drone drone in drones)
                {
                    Console.WriteLine($"Drone: {drone.Name}, Weight limit:{drone.MaxWeight}");
                    foreach (Trip trip in trips.Where(x => x.GetDrone() == drone))
                    {
                        Console.WriteLine($" Trips ");
                        foreach (Location location in trip.GetLocations())
                        {
                            Console.WriteLine($"   {location.Name} Weight: ({location.Weight})");
                        }
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("No generated trips ");
                Console.WriteLine("");
            }

        }
        public void ShowInputFile(IFileManager<string[]> fileManager)
        {
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("----------- INPUT FILE DATA ----------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            string[] content = fileManager.GetFile();

            if (content == null)
                throw new NullReferenceException();
            if (content.Length < 2)
                throw new Exception("The configuration file has errors.");
           
            foreach (string line in content)
            {
                Console.WriteLine(line);
            }
            
        }
    }
}
