using System;
using System.Collections.Generic;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public interface ISchedulingService
    {
        bool IsPickupDateAllowed(DateTime orderDate, DateTime pickupDate, out string message);
        int CountPiesForDate(DateTime pickupDate);
        int CountPiesInCart(IList<OrderItem> items);
        int PiesRemainingForDate(DateTime pickupDate);
        bool CanAcceptOrder(DateTime orderDate, DateTime pickupDate, IList<OrderItem> items, out string message);
    }
}
