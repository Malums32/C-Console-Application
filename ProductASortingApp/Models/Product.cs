using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductASortingApp.Models
{
    /// <summary>
    /// Represents a product with a name, price, and quantity.
    /// </summary>
    public class Product
    {
        #region Property Members
        public required string Product_Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        #endregion

        #region String Override Method
        /// <summary>
        /// Overrides the default ToString method to display product details.
        /// </summary>
        /// <returns>A string representation of the product.</returns>
        public override string ToString()
        {
            return $"{Product_Name} - Price: ZAR {Price}, Quantity: {Quantity})";
        }
        #endregion 

    }

}
