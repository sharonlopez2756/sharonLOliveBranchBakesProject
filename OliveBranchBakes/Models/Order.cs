using System;
using System.Collections.Generic;

namespace OliveBranchBakes.Models
{
   
    // Represents a customer order.
    
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }            // Pending, Ready, Completed
        public string PickupNotes { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            OrderDate = DateTime.Now;
            Status = "Pending";
            PickupNotes = string.Empty;
            Items = new List<OrderItem>();
        }

        // Placeholder properties for future phases
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
    }
}
