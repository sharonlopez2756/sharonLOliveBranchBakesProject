using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OliveBranchBakes.Models;
using System.Security.Cryptography;

namespace OliveBranchBakes.Services
{
    public class AdminService : IAdminService
    {
        private static readonly string[] Statuses =
        {
            "Received", "In Progress", "Ready", "Picked Up", "Cancelled"
        };

        public AdminUser Login(string username, string password)
        {
            EnsureDefaultAdmin();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new InvalidOperationException("Username and password are required.");

            string key = username.Trim().ToLowerInvariant();
            AdminUser admin = null;
            if (DataStore.Admins != null)
            {
                admin = DataStore.Admins.FirstOrDefault(a =>
                    a.Username != null &&
                    a.Username.Trim().ToLowerInvariant() == key);
            }

            if (admin == null)
                throw new InvalidOperationException("Admin account not found.");

            string hash = HashPassword(password, admin.PasswordSalt);
            if (!string.Equals(hash, admin.PasswordHash, StringComparison.Ordinal))
                throw new InvalidOperationException("Incorrect password.");

            return admin;
        }

        public IList<Order> GetAllOrders()
        {
            if (DataStore.Orders == null)
                DataStore.Initialize();

            return DataStore.Orders.OrderByDescending(o => o.OrderDate).ToList();
        }

        public IList<string> AllowedStatuses()
        {
            return Statuses.ToList();
        }

        public bool UpdateOrderStatus(int orderId, string newStatus, out string message)
        {
            message = string.Empty;
            if (DataStore.Orders == null)
            {
                message = "No orders loaded.";
                return false;
            }

            Order order = DataStore.Orders.FirstOrDefault(o => o.OrderId == orderId);
            if (order == null)
            {
                message = "Order not found.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(newStatus) ||
                !Statuses.Any(s => string.Equals(s, newStatus.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                message = "Invalid status. Use: " + string.Join(", ", Statuses);
                return false;
            }

            order.Status = Statuses.First(s =>
                string.Equals(s, newStatus.Trim(), StringComparison.OrdinalIgnoreCase));
            DataStore.SaveOrders();
            message = "Status updated to " + order.Status + ".";
            return true;
        }

        private void EnsureDefaultAdmin()
        {
            if (DataStore.Admins == null)
                DataStore.Admins = new List<AdminUser>();

            if (DataStore.Admins.Count > 0)
                return;

            string salt = Guid.NewGuid().ToString("N");
            DataStore.Admins.Add(new AdminUser
            {
                AdminId = 1,
                Username = "admin",
                DisplayName = "Bakery Owner",
                PasswordSalt = salt,
                PasswordHash = HashPassword("admin123", salt)
            });
            DataStore.SaveAdmins();
        }

        private static string HashPassword(string password, string salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(salt + password);
                return Convert.ToBase64String(sha.ComputeHash(bytes));
            }
        }
    }
}
