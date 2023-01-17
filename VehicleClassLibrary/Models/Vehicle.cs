using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    public class Vehicle
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public Vehicle(string maker,string model)
        {
            this.Maker = maker;
            this.Model = model;
        }

        public Vehicle()
        {
        }
    }
}
