namespace OliveBranchBakes.Models
{
   
    // A single line item within an order.
    
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public OrderItem()
        {
            ProductName = string.Empty;
            Quantity = 1;
        }

        // Placeholder for future calculation – not implemented
        public decimal LineTotal => UnitPrice * Quantity;
    }
}
