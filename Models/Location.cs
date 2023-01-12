using DroneDelivery.Services.FileService;
using System.Collections.Generic;
using System;

namespace Drones.Models
{
    /// <summary>
    /// Location Class
    /// </summary>
    public class Location
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Location() { }

        public Location(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Name}";
        }

        public static List<Location> GetAllLocations(IFileManager<string[]> fileManager)
        {
            string[] content = fileManager.GetFile();
            
            if (content == null)
                throw new NullReferenceException();
            if (content.Length < 2)
                throw new Exception("The configuration file has errors.");

            List<string> list = new List<string>(content);
            list.RemoveAt(0);

            var locations = new List<Location>();
            foreach(string line in list)
            {
                
                var data = line.Split(',');
                var location = new Location() { Name = data[0].Trim(), Weight = Int32.Parse(data[1]) };

                locations.Add(location);
            }

            return locations;
        }

    }
}
