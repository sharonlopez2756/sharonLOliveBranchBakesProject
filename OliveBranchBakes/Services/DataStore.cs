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

            if (Products.Count == 0)
            {
                SeedProducts();
                SaveProducts();
            }

            if (Customers.Count == 0)
            {
                SeedCustomers();
                SaveCustomers();
            }

            if (Orders.Count == 0)
            {
                SeedOrders();
                SaveOrders();
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
            WriteXml(ProductsFile, Products);
        }

        public static void SaveCustomers()
        {
            WriteXml(CustomersFile, Customers);
        }

        public static void SaveOrders()
        {
            WriteXml(OrdersFile, Orders);
        }

        public static void SaveSettings()
        {
            WriteXml(SettingsFile, Settings);
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
            return ReadXml<AppSettings>(SettingsFile) ?? new AppSettings();
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
                new Product { ProductId = 8, Name = "Gingerbread loaf", Description = "Seasonal gingerbread loaf", Price = 9.25m, Category = "Breads", IsSeasonal = true, IsAvailable = true, SeasonStart = new DateTime(2025, 11, 15), SeasonEnd = new DateTime(2026, 1, 5) },
                new Product { ProductId = 9, Name = "Cinnamon raisin bread", Description = "Sweet raisin loaf", Price = 8.00m, Category = "Breads", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 10, Name = "Sugar cookie", Description = "Decorated sugar cookie", Price = 2.00m, Category = "Cookies", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 11, Name = "Banana muffin", Description = "Ripe banana muffin", Price = 3.00m, Category = "Muffins", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 12, Name = "Croissant", Description = "Buttery croissant", Price = 3.50m, Category = "Pastries", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 13, Name = "Pecan pie (9 inch)", Description = "Southern pecan pie", Price = 24.00m, Category = "Pies", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 14, Name = "Chocolate layer cake", Description = "Three-layer chocolate cake", Price = 38.00m, Category = "Cakes", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 15, Name = "Everything bagel (6)", Description = "Half dozen everything bagels", Price = 12.00m, Category = "Breads", IsSeasonal = false, IsAvailable = true },
                new Product { ProductId = 16, Name = "Pumpkin scone", Description = "Seasonal pumpkin scone", Price = 3.25m, Category = "Pastries", IsSeasonal = false, IsAvailable = true }
            };
        }

        private static void SeedCustomers()
        {
            Customers = new List<Customer>
            {
                new Customer { CustomerId = 1, FirstName = "Sharon", LastName = "Lopez", Email = "sharon.lopez@email.com", Phone = "555-0101", PreferredPickupNotes = "Front porch" },
                new Customer { CustomerId = 2, FirstName = "Lebron", LastName = "James", Email = "lebron.jamesdagoat@email.com", Phone = "555-0102", PreferredPickupNotes = "" },
                new Customer { CustomerId = 3, FirstName = "Chris", LastName = "Pratt", Email = "chris.prattl@email.com", Phone = "555-0103", PreferredPickupNotes = "Leave on bench" }
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
                        new OrderItem { OrderItemId = 1, OrderId = 1, ProductId = 1, ProductName = "Sourdough loaf", Quantity = 2, UnitPrice = 7.50m },
                        new OrderItem { OrderItemId = 2, OrderId = 1, ProductId = 2, ProductName = "Chocolate chip cookie", Quantity = 6, UnitPrice = 2.25m }
                    },
                    SubTotal = 28.50m,
                    Total = 30.92m
                },
                new Order
                {
                    OrderId = 2,
                    CustomerId = 2,
                    OrderDate = today.AddDays(-7),
                    Status = "Picked Up",
                    PickupNotes = "Please bag separately",
                    PickupDate = today.AddDays(-5),
                    ConfirmationNumber = "OBB-" + today.AddDays(-7).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 3, OrderId = 2, ProductId = 5, ProductName = "Apple pie (9 inch)", Quantity = 1, UnitPrice = 22.00m }
                    },
                    SubTotal = 22.00m,
                    Total = 23.87m
                },
                new Order
                {
                    OrderId = 3,
                    CustomerId = 1,
                    OrderDate = today.AddDays(-5),
                    Status = "Ready",
                    PickupNotes = "",
                    PickupDate = today.AddDays(-2),
                    ConfirmationNumber = "OBB-" + today.AddDays(-5).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 4, OrderId = 3, ProductId = 4, ProductName = "Cinnamon roll", Quantity = 4, UnitPrice = 3.75m },
                        new OrderItem { OrderItemId = 5, OrderId = 3, ProductId = 7, ProductName = "Honey butter (jar)", Quantity = 1, UnitPrice = 5.00m }
                    },
                    SubTotal = 20.00m,
                    Total = 21.70m
                },
                new Order
                {
                    OrderId = 4,
                    CustomerId = 3,
                    OrderDate = today.AddDays(-4),
                    Status = "Received",
                    PickupNotes = "",
                    PickupDate = today.AddDays(2),
                    ConfirmationNumber = "OBB-" + today.AddDays(-4).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 6, OrderId = 4, ProductId = 13, ProductName = "Pecan pie (9 inch)", Quantity = 2, UnitPrice = 24.00m }
                    },
                    SubTotal = 48.00m,
                    Total = 52.08m
                },
                new Order
                {
                    OrderId = 5,
                    CustomerId = 2,
                    OrderDate = today.AddDays(-3),
                    Status = "Baking",
                    PickupNotes = "Birthday order",
                    PickupDate = today.AddDays(3),
                    ConfirmationNumber = "OBB-" + today.AddDays(-3).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 7, OrderId = 5, ProductId = 6, ProductName = "Custom decorated cake", Quantity = 1, UnitPrice = 45.00m }
                    },
                    SubTotal = 45.00m,
                    Total = 48.83m
                },
                new Order
                {
                    OrderId = 6,
                    CustomerId = 3,
                    OrderDate = today.AddDays(-2),
                    Status = "Received",
                    PickupNotes = "",
                    PickupDate = today.AddDays(5),
                    ConfirmationNumber = "OBB-" + today.AddDays(-2).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 8, OrderId = 6, ProductId = 3, ProductName = "Blueberry muffin", Quantity = 6, UnitPrice = 3.00m },
                        new OrderItem { OrderItemId = 9, OrderId = 6, ProductId = 1, ProductName = "Sourdough loaf", Quantity = 1, UnitPrice = 7.50m }
                    },
                    SubTotal = 25.50m,
                    Total = 27.67m
                },
                new Order
                {
                    OrderId = 7,
                    CustomerId = 1,
                    OrderDate = today.AddDays(-1),
                    Status = "Received",
                    PickupNotes = "",
                    PickupDate = today.AddDays(4),
                    ConfirmationNumber = "OBB-" + today.AddDays(-1).ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 10, OrderId = 7, ProductId = 5, ProductName = "Apple pie (9 inch)", Quantity = 1, UnitPrice = 22.00m },
                        new OrderItem { OrderItemId = 11, OrderId = 7, ProductId = 2, ProductName = "Chocolate chip cookie", Quantity = 12, UnitPrice = 2.25m }
                    },
                    SubTotal = 49.00m,
                    Total = 53.17m
                },
                new Order
                {
                    OrderId = 8,
                    CustomerId = 2,
                    OrderDate = today,
                    Status = "Received",
                    PickupNotes = "Early pickup please",
                    PickupDate = today.AddDays(6),
                    ConfirmationNumber = "OBB-" + today.ToString("yyMMdd") + "-001",
                    Items = new List<OrderItem>
                    {
                        new OrderItem { OrderItemId = 12, OrderId = 8, ProductId = 15, ProductName = "Everything bagel (6)", Quantity = 1, UnitPrice = 12.00m },
                        new OrderItem { OrderItemId = 13, OrderId = 8, ProductId = 9, ProductName = "Cinnamon raisin bread", Quantity = 2, UnitPrice = 8.00m }
                    },
                    SubTotal = 28.00m,
                    Total = 30.38m
                }
            };
        }
    }
}
