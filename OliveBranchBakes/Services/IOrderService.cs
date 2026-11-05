using System;
using System.Collections.Generic;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public interface IOrderService
    {
        Order PlaceOrder(IList<OrderItem> items, DateTime pickupDate, string pickupNotes, int customerId);
        IList<Order> GetOrdersForCustomer(int customerId);
        string NextConfirmationNumber(DateTime orderDate);
    }
}
