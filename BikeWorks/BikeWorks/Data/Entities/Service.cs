using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWorks.Data.Entities
{
    public class Service
    {
        public int ServiceId { get; set; }   
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public double TaxPercent { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }

    }
}
