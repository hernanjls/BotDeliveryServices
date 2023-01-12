using DroneDelivery.Services.FileService;
using Drones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDelivery.Services.OutputService
{
    public interface IOutputManager
    {
        void ShowTrips(List<Trip> trips);
        void ShowInputFile(IFileManager<string[]> fileManager);
    }
}
