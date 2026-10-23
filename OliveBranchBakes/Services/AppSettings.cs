namespace OliveBranchBakes.Models
{
    public class AppSettings
    {
        public decimal TaxRate { get; set; }
        public int MaxPiesPerPickupDate { get; set; }
        public int PlanAheadDays { get; set; }
        public int RushHours { get; set; }
        public decimal PlanAheadDiscountPerPieOrCake { get; set; }
        public decimal RushFee { get; set; }
        public string SeasonalItemName { get; set; }

        public AppSettings()
        {
            TaxRate = 0.085m;
            MaxPiesPerPickupDate = 12;
            PlanAheadDays = 7;
            RushHours = 48;
            PlanAheadDiscountPerPieOrCake = 0.50m;
            RushFee = 5.00m;
            SeasonalItemName = "Gingerbread loaf";
        }
    }
}
