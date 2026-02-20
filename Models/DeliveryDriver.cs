using Microsoft.AspNetCore.Mvc;

namespace Eatsy1.Models
{
    public class DeliveryDriver
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string VehicleDetails { get; set; }

        public ICollection<Order> AssignedOrders { get; set; }
    }
}
