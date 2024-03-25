using ShoppingCartApp; // Importing the ShoppingCartApp namespace where our classes are defined

internal class Program // Internal class representing the program
{
    static void Main(string[] args) // Main method, the entry point of the program
    {
        // Example usage

        // Creating a new instance of the ShoppingCart class with a capacity of 5
        ShoppingCart cart = new ShoppingCart(5);

        // Creating a new instance of ClothingProduct and ElectronicsProduct
        ClothingProduct shirt = new ClothingProduct("T-shirt", 499.99, ProductCategory.Clothing, "L", "Red");
        ElectronicsProduct laptop = new ElectronicsProduct("Laptop", 25999.99, ProductCategory.Electronics, "Apple", "MacBook Air");

        // Adding products to the shopping cart
        cart.AddProduct(shirt);
        cart.AddProduct(laptop);

        // Looping through the products in the shopping cart
        foreach (var product in cart.Products)
        {
            // Checking if the product is not null
            if (product != null)
            {
                // Displaying information about each product
                product.GetInfo();
            }
        }
    }
}
