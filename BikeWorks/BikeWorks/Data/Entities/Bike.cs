using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWorks.Data.Entities
{
    public class Bike
    {
        public int BikeId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public string SerialNumber { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }
        public List<Order> Orders { get; set; }

    }
}
