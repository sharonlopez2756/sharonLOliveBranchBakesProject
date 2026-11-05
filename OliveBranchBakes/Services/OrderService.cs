using System;
using System.Collections.Generic;
using System.Linq;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class OrderService : IOrderService
    {
        private readonly IPricingService _pricing = new PricingService();
        private readonly ISchedulingService _scheduling = new SchedulingService();

        public string NextConfirmationNumber(DateTime orderDate)
        {
            string prefix = "OBB-" + orderDate.ToString("yyMMdd") + "-";
            int next = 1;

            if (DataStore.Orders != null)
            {
                foreach (Order o in DataStore.Orders)
                {
                    if (o.ConfirmationNumber != null && o.ConfirmationNumber.StartsWith(prefix))
                    {
                        string tail = o.ConfirmationNumber.Substring(prefix.Length);
                        int n;
                        if (int.TryParse(tail, out n) && n >= next)
                        {
                            next = n + 1;
                        }
                    }
                }
            }

            return prefix + next.ToString("000");
        }

        public Order PlaceOrder(IList<OrderItem> items, DateTime pickupDate, string pickupNotes, int customerId)
        {
            if (items == null || items.Count == 0)
            {
                throw new InvalidOperationException("Cannot place an order with an empty cart.");
            }

            DateTime orderDate = DateTime.Now;
            string scheduleMessage;
            if (!_scheduling.CanAcceptOrder(orderDate, pickupDate, items, out scheduleMessage))
            {
                throw new InvalidOperationException(scheduleMessage);
            }

            PriceBreakdown price = _pricing.GetBreakdown(items, orderDate, pickupDate);

            if (DataStore.Orders == null)
            {
                DataStore.Initialize();
            }

            int newId = DataStore.Orders.Count == 0
                ? 1
                : DataStore.Orders.Max(o => o.OrderId) + 1;

            List<OrderItem> copied = new List<OrderItem>();
            int lineId = 1;
            foreach (OrderItem src in items)
            {
                copied.Add(new OrderItem
                {
                    OrderItemId = lineId++,
                    OrderId = newId,
                    ProductId = src.ProductId,
                    ProductName = src.ProductName,
                    Category = src.Category,
                    Quantity = src.Quantity,
                    UnitPrice = src.UnitPrice
                });
            }

            Order order = new Order
            {
                OrderId = newId,
                CustomerId = customerId,
                OrderDate = orderDate,
                Status = "Received",
                PickupNotes = pickupNotes ?? string.Empty,
                PickupDate = pickupDate,
                Items = copied,
                SubTotal = price.SubTotal,
                Discount = price.Discount,
                Fees = price.Fees,
                Tax = price.Tax,
                Total = price.Total,
                ConfirmationNumber = NextConfirmationNumber(orderDate)
            };

            DataStore.Orders.Add(order);
            DataStore.SaveOrders();
            return order;
        }

        public IList<Order> GetOrdersForCustomer(int customerId)
        {
            if (DataStore.Orders == null)
            {
                return new List<Order>();
            }

            return DataStore.Orders
                .Where(o => o.CustomerId == customerId)
                .OrderByDescending(o => o.OrderDate)
                .ToList();
        }
    }
}
