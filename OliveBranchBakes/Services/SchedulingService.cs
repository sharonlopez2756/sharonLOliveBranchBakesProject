using System;
using System.Collections.Generic;
using System.Linq;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class SchedulingService : BakeryRuleService, ISchedulingService
    {
        public override string RuleCode
        {
            get { return "O1"; }
        }

        public override string DescribeRule()
        {
            return "O1 Pie capacity: no more than 12 pies total across all orders for one pickup date.";
        }

        public bool IsPickupDateAllowed(DateTime orderDate, DateTime pickupDate, out string message)
        {
            message = string.Empty;
            DateTime day = pickupDate.Date;
            DateTime ordered = orderDate.Date;

            if (day.Month == 12 && day.Day == 25)
            {
                message = "The bakery is closed on December 25.";
                return false;
            }

            if (day.Month == 11 && day.Day == 28)
            {
                message = "The bakery is closed on Thanksgiving Day.";
                return false;
            }

            if (day < ordered.AddDays(1))
            {
                message = "Pickup must be at least 24 hours after the order is placed.";
                return false;
            }

            if (day > ordered.AddDays(30))
            {
                message = "Pickup cannot be more than 30 days ahead.";
                return false;
            }

            return true;
        }

        public int CountPiesInCart(IList<OrderItem> items)
        {
            if (items == null)
            {
                return 0;
            }

            return items
                .Where(i => IsPieItem(i))
                .Sum(i => i.Quantity);
        }

        public int CountPiesForDate(DateTime pickupDate)
        {
            if (DataStore.Orders == null)
            {
                return 0;
            }

            int total = 0;
            DateTime day = pickupDate.Date;

            foreach (Order order in DataStore.Orders)
            {
                if (!order.PickupDate.HasValue)
                {
                    continue;
                }

                if (order.PickupDate.Value.Date != day)
                {
                    continue;
                }

                string status = order.Status ?? string.Empty;
                if (string.Equals(status, "Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (order.Items == null)
                {
                    continue;
                }

                total += order.Items.Where(i => IsPieItem(i)).Sum(i => i.Quantity);
            }

            return total;
        }

        public int PiesRemainingForDate(DateTime pickupDate)
        {
            int max = Settings.MaxPiesPerPickupDate > 0 ? Settings.MaxPiesPerPickupDate : 12;
            int used = CountPiesForDate(pickupDate);
            int left = max - used;
            return left < 0 ? 0 : left;
        }

        public bool CanAcceptOrder(DateTime orderDate, DateTime pickupDate, IList<OrderItem> items, out string message)
        {
            if (!IsPickupDateAllowed(orderDate, pickupDate, out message))
            {
                return false;
            }

            int additionalPies = CountPiesInCart(items);
            if (additionalPies <= 0)
            {
                message = string.Empty;
                return true;
            }

            int remaining = PiesRemainingForDate(pickupDate);
            if (additionalPies > remaining)
            {
                message = string.Format(
                    "Only {0} pie(s) still available for {1:d}. Maximum is {2} pies per pickup date (O1).",
                    remaining,
                    pickupDate.Date,
                    Settings.MaxPiesPerPickupDate > 0 ? Settings.MaxPiesPerPickupDate : 12);
                return false;
            }

            message = string.Empty;
            return true;
        }

        private static bool IsPieItem(OrderItem item)
        {
            if (item == null)
            {
                return false;
            }

            if (!string.IsNullOrEmpty(item.Category))
            {
                string c = item.Category.Trim().ToLowerInvariant();
                if (c == "pies" || c == "pie")
                {
                    return true;
                }
            }

            if (!string.IsNullOrEmpty(item.ProductName))
            {
                return item.ProductName.IndexOf("pie", StringComparison.OrdinalIgnoreCase) >= 0;
            }

            return false;
        }
    }
}
