using System;
using System.Collections.Generic;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public interface IPricingService
    {
        decimal CalculateSubtotal(IList<OrderItem> items);
        decimal CalculateDiscount(IList<OrderItem> items, DateTime orderDate, DateTime pickupDate);
        decimal CalculateFees(DateTime orderDate, DateTime pickupDate);
        decimal CalculateTax(decimal discountedSubtotal, decimal fees);
        decimal CalculateTotal(IList<OrderItem> items, DateTime orderDate, DateTime pickupDate);
        PriceBreakdown GetBreakdown(IList<OrderItem> items, DateTime orderDate, DateTime pickupDate);
    }

    public class PriceBreakdown
    {
        public decimal SubTotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Fees { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }
}
