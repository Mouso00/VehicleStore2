using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassLibrary.Models
{
    public class Vehicle
    {

        public string maker { get; set; }
        public string model { get; set; }

        public Vehicle(string maker,string model)
        {
            this.maker = maker;
            this.model = model;

        }
    }
}
