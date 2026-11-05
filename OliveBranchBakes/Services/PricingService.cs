using System;
using System.Collections.Generic;
using System.Linq;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class PricingService : BakeryRuleService, IPricingService
    {
        public override string RuleCode
        {
            get { return "P5"; }
        }

        public override string DescribeRule()
        {
            return "P5 Plan ahead: $0.50 off each pie/cake if 7+ days before pickup; $5 rush fee if under 48 hours.";
        }

        public decimal CalculateSubtotal(IList<OrderItem> items)
        {
            if (items == null || items.Count == 0)
            {
                return 0m;
            }

            return items.Sum(i => i.LineTotal);
        }

        public decimal CalculateDiscount(IList<OrderItem> items, DateTime orderDate, DateTime pickupDate)
        {
            if (items == null || items.Count == 0)
            {
                return 0m;
            }

            double days = (pickupDate.Date - orderDate.Date).TotalDays;
            int planAheadDays = Settings.PlanAheadDays > 0 ? Settings.PlanAheadDays : 7;
            decimal perItem = Settings.PlanAheadDiscountPerPieOrCake > 0
                ? Settings.PlanAheadDiscountPerPieOrCake
                : 0.50m;

            if (days < planAheadDays)
            {
                return 0m;
            }

            int pieCakeUnits = items
                .Where(i => i.IsPieOrCake)
                .Sum(i => i.Quantity);

            return perItem * pieCakeUnits;
        }

        public decimal CalculateFees(DateTime orderDate, DateTime pickupDate)
        {
            double hours = (pickupDate - orderDate).TotalHours;
            int rushHours = Settings.RushHours > 0 ? Settings.RushHours : 48;
            decimal rushFee = Settings.RushFee > 0 ? Settings.RushFee : 5.00m;

            if (hours < rushHours)
            {
                return rushFee;
            }

            return 0m;
        }

        public decimal CalculateTax(decimal discountedSubtotal, decimal fees)
        {
            decimal rate = Settings.TaxRate > 0 ? Settings.TaxRate : 0.085m;
            return (discountedSubtotal + fees) * rate;
        }

        public decimal CalculateTotal(IList<OrderItem> items, DateTime orderDate, DateTime pickupDate)
        {
            return GetBreakdown(items, orderDate, pickupDate).Total;
        }

        public PriceBreakdown GetBreakdown(IList<OrderItem> items, DateTime orderDate, DateTime pickupDate)
        {
            decimal subtotal = CalculateSubtotal(items);
            decimal discount = CalculateDiscount(items, orderDate, pickupDate);
            decimal discounted = subtotal - discount;
            if (discounted < 0m)
            {
                discounted = 0m;
            }

            decimal fees = CalculateFees(orderDate, pickupDate);
            decimal tax = CalculateTax(discounted, fees);
            decimal total = Math.Round(discounted + fees + tax, 2, MidpointRounding.AwayFromZero);

            return new PriceBreakdown
            {
                SubTotal = subtotal,
                Discount = discount,
                Fees = fees,
                Tax = Math.Round(tax, 4, MidpointRounding.AwayFromZero),
                Total = total
            };
        }
    }
}
