using System.Collections.Generic;

namespace Drones.Models
{
    /// <summary>
    /// Drone Trip Class, it helps to keep track of trips by drone
    /// </summary>
    public class Trip
    {
        private Drone _drone;
        private List<Location> _locations;

        public Trip (Drone drone, List<Location> locations)
        {
            _drone = drone;
            _locations = locations;
        }

        public Drone GetDrone()
        {
            return _drone;
        }
        
        public List<Location> GetLocations()
        {
            return _locations;
        }

    }
}
