namespace OliveBranchBakes.Models
{
    
    // Represents a bakery product available for ordering.
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }         
        public bool IsSeasonal { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }         

        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
            Category = string.Empty;
            IsAvailable = true;
            ImagePath = string.Empty;
        }
    }
}
