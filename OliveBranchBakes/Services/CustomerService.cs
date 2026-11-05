using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class CustomerService : ICustomerService
    {
        public Customer FindByEmail(string email)
        {
            if (DataStore.Customers == null || string.IsNullOrWhiteSpace(email))
            {
                return null;
            }

            string key = email.Trim().ToLowerInvariant();
            return DataStore.Customers.FirstOrDefault(c =>
                c.Email != null && c.Email.Trim().ToLowerInvariant() == key);
        }

        public Customer Register(string firstName, string lastName, string email, string phone, string password)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new InvalidOperationException("Email is required.");
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8 || !password.Any(char.IsDigit))
            {
                throw new InvalidOperationException("Password must be at least 8 characters and include a number.");
            }

            if (FindByEmail(email) != null)
            {
                throw new InvalidOperationException("An account with that email already exists.");
            }

            if (DataStore.Customers == null)
            {
                DataStore.Initialize();
            }

            int newId = DataStore.Customers.Count == 0
                ? 1
                : DataStore.Customers.Max(c => c.CustomerId) + 1;

            string salt = Guid.NewGuid().ToString("N");
            string hash = HashPassword(password, salt);

            Customer customer = new Customer
            {
                CustomerId = newId,
                FirstName = firstName ?? string.Empty,
                LastName = lastName ?? string.Empty,
                Email = email.Trim(),
                Phone = phone ?? string.Empty,
                PasswordSalt = salt,
                PasswordHash = hash
            };

            DataStore.Customers.Add(customer);
            DataStore.SaveCustomers();
            return customer;
        }

        public Customer Login(string email, string password)
        {
            Customer customer = FindByEmail(email);
            if (customer == null)
            {
                throw new InvalidOperationException("No account found for that email.");
            }

            if (string.IsNullOrEmpty(customer.PasswordHash) || string.IsNullOrEmpty(customer.PasswordSalt))
            {
                throw new InvalidOperationException("This seed account has no password set. Please register a new account.");
            }

            string hash = HashPassword(password ?? string.Empty, customer.PasswordSalt);
            if (!string.Equals(hash, customer.PasswordHash, StringComparison.Ordinal))
            {
                throw new InvalidOperationException("Incorrect password.");
            }

            return customer;
        }

        private static string HashPassword(string password, string salt)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(salt + password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
