using System;
using System.Collections.Generic;
using System.Linq;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class ProductService : IProductService
    {
        public IList<Product> GetAvailableProducts(DateTime asOfDate)
        {
            EnsureData();
            FixProductFlags();

            return DataStore.Products
                .Where(p => p.IsAvailable && p.IsInSeason(asOfDate))
                .OrderBy(p => p.Category)
                .ThenBy(p => p.Name)
                .ToList();
        }

        public IList<Product> GetAvailableProducts(DateTime asOfDate, string category)
        {
            IList<Product> all = GetAvailableProducts(asOfDate);

            if (string.IsNullOrWhiteSpace(category) ||
                string.Equals(category, "All", StringComparison.OrdinalIgnoreCase))
            {
                return all;
            }

            return all
                .Where(p => string.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase))
                .OrderBy(p => p.Name)
                .ToList();
        }

        public IList<string> GetCategories(DateTime asOfDate)
        {
            List<string> categories = GetAvailableProducts(asOfDate)
                .Select(p => p.Category)
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(c => c)
                .ToList();

            categories.Insert(0, "All");
            return categories;
        }

        public Product GetById(int productId)
        {
            EnsureData();
            FixProductFlags();
            return DataStore.Products.FirstOrDefault(p => p.ProductId == productId);
        }

        private void EnsureData()
        {
            if (DataStore.Products == null || DataStore.Products.Count == 0)
            {
                DataStore.Initialize();
            }
        }

        private void FixProductFlags()
        {
            if (DataStore.Products == null)
            {
                return;
            }

            foreach (Product p in DataStore.Products)
            {
                if (!string.IsNullOrWhiteSpace(p.Name) && p.Price > 0m)
                {
                    p.IsAvailable = true;
                }

                if (p.Name != null &&
                    p.Name.IndexOf("Gingerbread", StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    p.IsSeasonal = true;
                    if (string.IsNullOrWhiteSpace(p.Category))
                    {
                        p.Category = "Breads";
                    }
                    if (!p.SeasonStart.HasValue)
                    {
                        p.SeasonStart = new DateTime(2000, 11, 15);
                    }
                    if (!p.SeasonEnd.HasValue)
                    {
                        p.SeasonEnd = new DateTime(2000, 1, 5);
                    }
                }
            }
        }
    }
}
