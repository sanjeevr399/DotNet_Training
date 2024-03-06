using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_task
{

    // Define a class for individual products
    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store 10 products
            Product[] products = new Product[10];

            // Accept details for 10 products
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for product {i + 1}:");
                Console.Write("Product ID: ");
                int productId = Convert.ToInt32(Console.ReadLine());
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                // Create a new product object and store it in the array
                products[i] = new Product { ProductId = productId, ProductName = productName, Price = price };
            }

            // Perform a simple sorting algorithm to sort products by price (e.g., Bubble Sort)
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - 1 - i; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        // Swap products if they are in the wrong order
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            // Display the sorted products
            Console.WriteLine("\nSorted Products:");
            foreach (Product product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
            }
        }
    }
}