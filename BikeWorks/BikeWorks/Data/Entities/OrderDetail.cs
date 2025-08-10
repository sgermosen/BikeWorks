using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWorks.Data.Entities
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ServiceId { get; set; }
        public decimal Cost { get; set; }
        public double TaxPercent { get; set; }
        public string Notes { get; set; }
        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Service Service { get; set; }
    }
}
