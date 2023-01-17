using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    public class Store
    {
        private List<Vehicle> vehicleList = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            vehicleList.Add(vehicle);
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicleList.Remove(vehicle);
        }
        public List<Vehicle> GetVehicles()
        {
            return vehicleList;
        }

    }

}
