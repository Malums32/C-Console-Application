using ProductASortingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductASortingApp.Services
{
    /// <summary>
    /// This class provides functionality for sorting and grouping products
    /// </summary>
    public class ProductService : IProductService
    {
        #region Sorting Lists Products
        /// <summary>
        /// Sorts products by price in ascending order
        /// </summary>
        /// <param name="products">The list of products to sort by price</param>
        /// <returns>A sorted list of products sorted by price in an ascending order </returns>

        public List<Product> SortByPrice(List<Product> products)
        {
            return [.. products.OrderBy(p => p.Price)];
        }

        /// <summary>
        /// Sorting products by quantity in ascending order
        /// </summary>
        /// <param name="products">The list of products to sort by quantity</param>
        /// <returns>A sorted list of products sorted by quantity in an ascending order</returns>

        public List<Product> SortByQuantity(List<Product> products)
        {
           return [.. products.OrderBy(p =>p.Quantity)];
        }

        /// <summary>
        /// Sorts products by product Name in ascending order
        /// </summary>
        /// <param name="products">The list of products to sort by product_name</param>
        /// <returns>A sorted list of products sorted by product_name in an ascending order</returns>
        public List<Product> SortByProduct_Name(List<Product> products)
        {
            return products.OrderBy(p => GetPrefixLength(p.Product_Name))
                       .ThenBy(p => GetPrefix(p.Product_Name))
                       .ThenBy(p => p.Product_Name)
                       .ToList();
        }

        /// <summary>
        /// Group products by product_name and sorts each group by price in ascending order
        /// </summary>
        /// <param name="products">The list of products to group and sort </param>
        /// <returns>A grouped and sorted list of products</returns>
        public List<Product> GroupByProduct_NameAndSortByPrice(List<Product> products)
        {
            return products
                      .GroupBy(p => GetPrefixLength(p.Product_Name)) // Sort by prefix length
                      .SelectMany(group => group.OrderBy(p => p.Price)) // Sort each group by price
                      .ToList();
        }
        #endregion

        #region Sorting Methods
        /// <summary>
        /// Sorts product_Name by single-letter prefix and double-letter prefix of product_Name
        /// </summary>
        /// <param name="productName">The list of products to sort  prefixes</param>
        /// <returns>A list of sorted products by single-letter prefix and double-letter prefix </returns>
        public int GetPrefixLength(string productName)
        {
            string prefix = GetPrefix(productName);
            return prefix.Length; // 1 for single-letter, 2 for double-letter
        }

        public string GetPrefix(string productName)
        {
            string[] words = productName.Split(' ');
            return words.Length > 1 ? words[1] : string.Empty;
        }
        #endregion

    }


}
