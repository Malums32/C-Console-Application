using System;
using System.Collections.Generic;
using ProductASortingApp.Models;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductASortingApp.Services
{
    /// <summary>
    /// Defines all the product-related operations for extension
    /// </summary>
   
    public interface IProductService
    {
        #region Sorting Lists Products
        List<Product> SortByPrice(List<Product> products);
        List<Product> SortByQuantity(List<Product> products);
        List<Product> SortByProduct_Name(List<Product> products);
        List<Product> GroupByProduct_NameAndSortByPrice(List<Product> products);
        #endregion

        #region Sorting Methods
        public int GetPrefixLength(string productName);
        public string GetPrefix(string productName);
        #endregion
    }

}
