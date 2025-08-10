using System.ComponentModel.DataAnnotations;

namespace BikeWorks.Data.Entities
{
    public class Client
    {
      
        public int ClientId { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(15)]
        public string PhoneNumber { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        public decimal DebtAmount { get; set; }
        public List<Order> Orders { get; set; }
    }
}
