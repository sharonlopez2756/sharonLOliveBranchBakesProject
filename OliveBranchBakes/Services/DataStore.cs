using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using OliveBranchBakes.Models;

namespace OliveBranchBakes.Services
{
    public class DataStore
    {
        private static readonly string DataFolder = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory, "Data");

        private static readonly string ProductsFile = Path.Combine(DataFolder, "products.xml");
        private static readonly string CustomersFile = Path.Combine(DataFolder, "customers.xml");
        private static readonly string OrdersFile = Path.Combine(DataFolder, "orders.xml");
        private static readonly string SettingsFile = Path.Combine(DataFolder, "settings.xml");

        public static List<Product> Products { get; private set; }
        public static List<Customer> Customers { get; private set; }
        public static List<Order> Orders { get; private set; }
        public static AppSettings Settings { get; private set; }

        public static void Initialize()
        {
            if (!Directory.Exists(DataFolder))
            {
                Directory.CreateDirectory(DataFolder);
            }

            Settings = LoadSettings();
            Products = LoadProducts();
            Customers = LoadCustomers();
            Orders = LoadOrders();

            if (Products == null || Products.Count == 0)
            {
                SeedProducts();
                SaveProducts();
            }

            if (Customers == null || Customers.Count == 0)
            {
                SeedCustomers();
                SaveCustomers();
            }

            if (Orders == null || Orders.Count == 0)
            {
                SeedOrders();
                SaveOrders();
            }

            if (Settings == null)
            {
                Settings = CreateDefaultSettings();
            }

            SaveSettings();
        }

        public static void SaveAll()
        {
            SaveProducts();
            SaveCustomers();
            SaveOrders();
            SaveSettings();
        }

        public static void SaveProducts()
        {
            WriteXml(ProductsFile, Products ?? new List<Product>());
        }

        public static void SaveCustomers()
        {
            WriteXml(CustomersFile, Customers ?? new List<Customer>());
        }

        public static void SaveOrders()
        {
            WriteXml(OrdersFile, Orders ?? new List<Order>());
        }

        public static void SaveSettings()
        {
            WriteXml(SettingsFile, Settings ?? CreateDefaultSettings());
        }

        private static List<Product> LoadProducts()
        {
            return ReadXml<List<Product>>(ProductsFile) ?? new List<Product>();
        }

        private static List<Customer> LoadCustomers()
        {
            return ReadXml<List<Customer>>(CustomersFile) ?? new List<Customer>();
        }

        private static List<Order> LoadOrders()
        {
            return ReadXml<List<Order>>(OrdersFile) ?? new List<Order>();
        }

        private static AppSettings LoadSettings()
        {
            return ReadXml<AppSettings>(SettingsFile) ?? CreateDefaultSettings();
        }

        private static AppSettings CreateDefaultSettings()
        {
            return new AppSettings
            {
                TaxRate = 0.085m,
                MaxPiesPerPickupDate = 12,
                PlanAheadDays = 7,
                RushHours = 48,
                PlanAheadDiscountPerPieOrCake = 0.50m,
                RushFee = 5.00m,
                SeasonalItemName = "Gingerbread loaf"
            };
        }

        private static void WriteXml<T>(string path, T data)
        {
            var serializer = new XmlSerializer(typeof(T));
            using (var writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, data);
            }
        }

        private static T ReadXml<T>(string path) where T : class
        {
            if (!File.Exists(path))
            {
                return null;
            }

            var serializer = new XmlSerializer(typeof(T));
            using (var reader = new StreamReader(path))
            {
                return serializer.Deserialize(reader) as T;
            }
        }

        private static void SeedProducts()
        {
            Products = new List<Product>
            {
                new Product { ProductId = 1, Name = "Sourdough loaf", Description = "Classic artisan sourdough", Price = 7.50m, Category = "Breads", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 2, Name = "Chocolate chip cookie", Description = "Soft baked cookie", Price = 2.25m, Category = "Cookies", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 3, Name = "Blueberry muffin", Description = "Fresh blueberry muffin", Price = 3.00m, Category = "Muffins", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 4, Name = "Cinnamon roll", Description = "Glazed cinnamon roll", Price = 3.75m, Category = "Pastries", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 5, Name = "Apple pie (9 inch)", Description = "Classic apple pie", Price = 22.00m, Category = "Pies", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 6, Name = "Custom decorated cake", Description = "Custom message cake", Price = 45.00m, Category = "Cakes", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 7, Name = "Honey butter (jar)", Description = "Whipped honey butter", Price = 5.00m, Category = "Extras", IsSeasonal = false, IsAvailable = true },
                new Product
                {
                    ProductId = 8,
                    Name = "Gingerbread loaf",
                    Description = "Seasonal gingerbread loaf",
                    Price = 9.25m,
                    Category = "Breads",
                    IsSeasonal = true,
                    IsAvailable = true,
                    SeasonStart = new DateTime(DateTime.Today.Year, 11, 15),
                    SeasonEnd = new DateTime(DateTime.Today.Year + 1, 1, 5)
                },
                new Product { ProductId = 9, Name = "Cinnamon raisin bread", Description = "Sweet raisin loaf", Price = 8.00m, Category = "Breads", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 10, Name = "Sugar cookie", Description = "Decorated sugar cookie", Price = 2.00m, Category = "Cookies", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 11, Name = "Banana muffin", Description = "Ripe banana muffin", Price = 3.00m, Category = "Muffins", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 12, Name = "Croissant", Description = "Buttery croissant", Price = 3.50m, Category = "Pastries", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 13, Name = "Pecan pie (9 inch)", Description = "Southern pecan pie", Price = 24.00m, Category = "Pies", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 14, Name = "Chocolate layer cake", Description = "Three-layer chocolate cake", Price = 38.00m, Category = "Cakes", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 15, Name = "Everything bagel (6)", Description = "Half dozen everything bagels", Price = 12.00m, Category = "Breads", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 16, Name = "Pumpkin scone", Description = "Pumpkin scone", Price = 3.25m, Category = "Pastries", IsSeasonal = false, IsAvailable = true }
            };
        }

        private static void SeedCustomers()
        {
            Customers = new List<Customer>
            {
                new Customer { CustomerId = 1, FirstName = "Sharon", LastName = "Lopez", Email = "sharon.lopez@email.com", Phone = "555-0101", PreferredPickupNotes = "Front porch" },
                new Customer { CustomerId = 2, FirstName = "Lebron", LastName = "James", Email = "lebron.jamesdagoat@email.com", Phone = "555-0102", PreferredPickupNotes = "" },
                new Customer { CustomerId = 3, FirstName = "Chris", LastName = "Pratt", Email = "chris.pratt@email.com", Phone = "555-0103", PreferredPickupNotes = "Leave on bench" }
            };
        }

        private static void SeedOrders()
        {
            DateTime today = DateTime.Today;

            Orders = new List<Order>
            {
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1,
                    OrderDate = today.AddDays(-10),
                    Status = "Picked Up",
                    PickupNotes = "",
                    PickupDate = today.AddDays(-8),
                    ConfirmationNumber = "OBB-" + today.AddDays(-10).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 1, OrderId = 1, ProductId = 1, ProductName = "Sourdough loaf", Quantity = 2 }

                    }
                }
            };
        }
    }
}

          
    

