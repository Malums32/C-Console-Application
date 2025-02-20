using System;
using System.Collections.Generic;
using System.IO;
using ProductASortingApp.Models;

namespace ProductSortingApp.Utilities
{
    /// <summary>
    /// Utility class for reading product data from a CSV file.
    /// </summary>
    #region Reading Valid cvs Files
    public class CsvReader
    {
        /// <summary>
        /// Reads a CSV file and returns a list of products.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>A list of products.</returns>
        public List<Product> ReadCsvFile(string filePath)
        {
            List<Product> products = new List<Product>();

            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"File '{filePath}' not found.");
                }

                var lines = File.ReadAllLines(filePath);

                // Skip the header row (first line)
                for (int i = 1; i < lines.Length; i++)
                {
                    var columns = lines[i].Split(',');

                    if (columns.Length != 3)
                    {
                        throw new FormatException($"Invalid CSV format in line {i + 1}.");
                    }

                    // Parse the columns into a Product object
                    products.Add(new Product
                    {
                        Product_Name = columns[0].Trim(),
                        Price = decimal.Parse(columns[1].Trim()),
                        Quantity = int.Parse(columns[2].Trim())
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the CSV file: {ex.Message}");
                return null;
            }

            return products;
        }
    }
    #endregion
}