using DroneDelivery.Services.FileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Models
{
   
    public class Drone
    {
        public string Name { get; set; }
        public double MaxWeight { get; set; }

        public Drone() { }

        public Drone(string name, double maxWeight)
        {
            Name = name;
            MaxWeight = maxWeight;
        }


        public static List<Drone> GetAllDrones(IFileManager<string[]> fileManager)
        {
            var content = fileManager.GetFile();
            if (content == null)
                throw new NullReferenceException();
            if (content.Length < 2)
                throw new Exception("The configuration file is with errors.");


            var line = content[0];
            var data = line.Split(',');

            var drones = new List<Drone>();
            for (int i = 0; i < data.Length; i += 2)
            {
                drones.Add(new Drone() { Name = data[i].Trim(), MaxWeight = Double.Parse(data[i + 1].Trim()) });
            }
            return drones;
        }

    }
}
