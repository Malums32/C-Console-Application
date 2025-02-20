using System;
using System.Collections.Generic;
using System.IO;
using ProductASortingApp.Models;
using ProductASortingApp.Services; 
using ProductASortingApp.UI;
using ProductSortingApp.Utilities; 

namespace ProductSortingApp
{
    class Program
    {
        /// <summary>
        /// Handles the whole program specification and functionalities
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Sorting Application!");

            // Initialize dependencies
            var csvReader = new CsvReader();
            IProductService productService = new ProductService();
            var consoleUI = new ConsoleUI(productService);

            // Get the path to the CSV file
            string csvFilePath = Path.Combine(Directory.GetCurrentDirectory(), "ProductList.csv");

            // Read the CSV file
            List<Product> products = csvReader.ReadCsvFile(csvFilePath);

            if (products == null || !products.Any())
            {
                Console.WriteLine("No products found. Exiting application.");
                return;
            }

            // Start the application
            consoleUI.Run(products);
        }
    }
}