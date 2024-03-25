using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ClothingProduct : Product // Internal class ClothingProduct inheriting from Product
    {
        // Private fields for clothing size and color
        private readonly string size;
        private readonly string color;

        // Public properties to access size and color
        public string Size { get { return size; } }
        public string Color { get { return color; } }

        // Constructor to initialize clothing product details along with base class details
        public ClothingProduct(string name, double price, ProductCategory category, string size, string color)
            : base(name, price, category) // Calling the base class constructor to initialize name, price, and category
        {
            this.size = size; // Initializing size
            this.color = color; // Initializing color
        }

        // Overridden method to get information about the clothing product
        public override void GetInfo()
        {
            base.GetInfo(); // Calling the base class method to display base product information
            Console.WriteLine($"Size: {size}, Color: {color}"); // Displaying additional information about size and color
        }
    }
}
