namespace OliveBranchBakes.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public OrderItem()
        {
            ProductName = string.Empty;
            Category = string.Empty;
            Quantity = 1;
        }

        public decimal LineTotal
        {
            get { return UnitPrice * Quantity; }
        }

        public bool IsPieOrCake
        {
            get
            {
                if (string.IsNullOrEmpty(Category))
                {
                    return false;
                }

                string c = Category.Trim().ToLowerInvariant();
                return c == "pies" || c == "cakes" || c == "pie" || c == "cake";
            }
        }
    }
}