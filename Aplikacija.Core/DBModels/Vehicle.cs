using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string TypeVehicle { get; set; }
        public string Regnumber { get; set; }
        public string Chassis { get; set; }
        public string MotorNum { get; set; }
        public decimal Power { get; set; }
        public decimal Capacity { get; set; }
        public string Color { get; set; }
        public int SeetsNum { get; set; }


        public Policy Policy { get; set; }
    }
}
