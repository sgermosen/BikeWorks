using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeWorks.Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public int BikeId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public string Status { get; set; } // e.g., "Pending", "In Progress", "Completed"
        public decimal TotalCost { get; set; }
        public string Notes { get; set; }
        // Navigation properties
        public virtual Client Client { get; set; }
        public virtual Bike Bike { get; set; }
        public virtual Employee Employee { get; set; }
         public List<OrderDetail> OrderDetails { get; set; }
    }
}
