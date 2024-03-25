using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ElectronicsProduct : Product // Internal class ElectronicsProduct inheriting from Product
    {
        // Private fields for brand and model of the electronics product
        private readonly string brand;
        private readonly string model;

        // Public properties to access brand and model
        public string Brand { get { return brand; } }
        public string Model { get { return model; } }

        // Constructor to initialize electronics product details along with base class details
        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model)
            : base(name, price, category) // Calling the base class constructor to initialize name, price, and category
        {
            this.brand = brand; // Initializing brand
            this.model = model; // Initializing model
        }

        // Overridden method to get information about the electronics product
        public override void GetInfo()
        {
            base.GetInfo(); // Calling the base class method to display base product information
            Console.WriteLine($"Brand: {brand}, Model: {model}"); // Displaying additional information about brand and model
        }
    }
}
