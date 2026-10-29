using System;

namespace OliveBranchBakes.Models
{
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
        public DateTime? SeasonStart { get; set; }
        public DateTime? SeasonEnd { get; set; }

        public Product()
        {
            Name = string.Empty;
            Description = string.Empty;
            Category = string.Empty;
            IsAvailable = true;
            ImagePath = string.Empty;
        }

        public bool IsInSeason(DateTime onDate)
        {
            if (!IsSeasonal)
            {
                return true;
            }

            if (!SeasonStart.HasValue || !SeasonEnd.HasValue)
            {
                return false;
            }

            DateTime day = onDate.Date;
            int startMonth = SeasonStart.Value.Month;
            int startDay = Math.Min(SeasonStart.Value.Day, DateTime.DaysInMonth(day.Year, startMonth));
            int endMonth = SeasonEnd.Value.Month;
            int endDay = Math.Min(SeasonEnd.Value.Day, DateTime.DaysInMonth(day.Year, endMonth));

            DateTime startThisYear = new DateTime(day.Year, startMonth, startDay);
            DateTime endThisYear = new DateTime(day.Year, endMonth, endDay);

            if (endThisYear < startThisYear)
            {
                return day >= startThisYear || day <= endThisYear;
            }

            return day >= startThisYear && day <= endThisYear;
        }

        public override string ToString()
        {
            return string.Format("{0}  ${1:0.00}", Name, Price);
        }
    }
}
