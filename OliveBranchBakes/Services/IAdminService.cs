using OliveBranchBakes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes.Services
{
    public interface IAdminService
    {
        AdminUser Login(string username, string password);
        IList<Order> GetAllOrders();
        bool UpdateOrderStatus(int orderId, string newStatus, out string message);
        IList<string> AllowedStatuses();
    }
}
