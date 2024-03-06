using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category { Id = 1, Name = "Bilgisayar" },
                new Category { Id = 2, Name = "Telefon" }
            };

            List<Product> products = new List<Product>
            {
                new Product { Id = 1, CategoryId = 1, Name = "Acer Laptop", QuantityPerUnit = "8 GB RAM", UnitPrice = 20000, UnitsInStock = 10 },
                new Product { Id = 2, CategoryId = 2, Name = "A34", QuantityPerUnit = "64 GB", UnitPrice = 1000, UnitsInStock = 12000 },
                new Product { Id = 3, CategoryId = 1, Name = "Asus Laptop", QuantityPerUnit = "16 GB", UnitPrice = 25000, UnitsInStock = 15 },
                new Product { Id = 4, CategoryId = 2, Name = "B46", QuantityPerUnit = "256 GB", UnitPrice = 13000, UnitsInStock = 50 },
                new Product { Id = 5, CategoryId = 2, Name = "C57", QuantityPerUnit = "512 GB", UnitPrice = 14000, UnitsInStock = 3 }
            };

            GetProducts(products);

            GetProductsLing(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if (product.UnitPrice < 20000 && product.UnitsInStock > 10)
                {
                   filteredProducts.Add(product);
                }
            }

            return filteredProducts;
        }

        static List<Product> GetProductsLing(List<Product> products)
        {
            return products.Where(p => p.UnitPrice < 20000 && p.UnitPrice >3).ToList();
        }

    }

    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
