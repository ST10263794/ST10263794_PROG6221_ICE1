using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    // Enum to represent different product categories
    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

    // Internal class representing a product
    internal class Product
    {
        // Private fields for product details
        private string name;
        private double price;
        private ProductCategory category;

        // Public properties to access product details
        public string Name { get { return name; } }
        public double Price { get { return price; } }
        public ProductCategory Category { get { return category; } }

        // Constructor to initialize product details
        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        // Virtual method to get information about the product
        // This method can be overridden by derived classes
        public virtual void GetInfo()
        {
            // Displaying product information
            Console.WriteLine($"Name: {name}, Price: R{price}, Category: {category}");
        }
    }
}


