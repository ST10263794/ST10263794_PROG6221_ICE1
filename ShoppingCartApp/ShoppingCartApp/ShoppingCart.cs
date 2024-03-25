using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ShoppingCart // Internal class ShoppingCart representing a shopping cart
    {
        private Product[] products; // Array to store products in the shopping cart
        private int itemCount; // Variable to track the number of items in the shopping cart

        // Public properties to access products and item count
        public Product[] Products { get { return products; } }
        public int ItemCount { get { return itemCount; } }

        // Constructor to initialize the shopping cart with a specified capacity
        public ShoppingCart(int capacity)
        {
            products = new Product[capacity]; // Initializing the products array with the specified capacity
            itemCount = 0; // Initializing the item count to 0
        }

        // Method to add a product to the shopping cart
        public void AddProduct(Product product)
        {
            if (itemCount < products.Length) // Checking if there is space in the shopping cart
            {
                products[itemCount] = product; // Adding the product to the next available slot in the array
                itemCount++; // Incrementing the item count
            }
            else
            {
                Console.WriteLine("The shopping cart is full."); // Displaying a message if the shopping cart is full
            }
        }

        // Method to remove a product from the shopping cart
        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++) // Looping through the products in the shopping cart
            {
                if (products[i] == product) // Checking if the current product matches the specified product
                {
                    for (int j = i; j < itemCount - 1; j++) // Shifting the remaining products in the array
                    {
                        products[j] = products[j + 1];
                    }
                    products[itemCount - 1] = null; // Setting the last element to null
                    itemCount--; // Decrementing the item count
                    Console.WriteLine("Product removed from the shopping cart."); // Displaying a message
                    return; // Exiting the method after removing the product
                }
            }
            Console.WriteLine("Product not found in the shopping cart."); // Displaying a message if the product is not found
        }
    }
}
