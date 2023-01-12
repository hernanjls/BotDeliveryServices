using DroneDelivery.Extensions;
using Drones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneDelivery.Services.TripService
{
    public class TripManager : ITripManager
    {
        public List<Trip> GenerateTrips(List<Drone> droneList, List<Location> locationList)
        {
            var drones = droneList.OrderBy(d => d.MaxWeight).ToList();
            var locations = locationList;
            double maxWeight = drones.Max(d => d.MaxWeight);

            List<Location> undeliverables = locations.Where(x => x.Weight > maxWeight).ToList();
            locations.RemoveAll(p => p.Weight > maxWeight);

            List<Trip> trips = new List<Trip>();

            while (locations.Count() > 0)
            {
                foreach (Drone drone in drones)
                {
                    var locationsForDrone = ClosestWeightList(locations, drone.MaxWeight);
                    foreach (Location location in locationsForDrone)
                    {
                        locations.Remove(location);
                    }
                    if (locationsForDrone.Count() > 0)
                    {
                        var trip = new Trip(drone, locationsForDrone);
                        trips.Add(trip);
                    }
                    if (locations.Count() == 0)
                    {
                        break;
                    }
                }
            }

            return trips;

        }

        private  List<Location> ClosestWeightList(List<Location> locations, double maxWeight)
        {
            var target = Enumerable.Range(1, locations.Count)
                .SelectMany(p => locations.Combinations(p))
                .Where(p => p.Sum(x => x.Weight) <= maxWeight)
                .OrderByDescending(p => p.Count()).FirstOrDefault();

            return target != null ? target.ToList() : new List<Location>();
        }

    }
}
