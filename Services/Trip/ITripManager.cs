using Drones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDelivery.Services.TripService
{
    public interface ITripManager
    {
        List<Trip> GenerateTrips(List<Drone> droneList, List<Location> locationList);
       
    }
}
