using ProductASortingApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductASortingApp.Models;

namespace ProductASortingApp.UI
{
    /// <summary>
    /// This class handles display and user input for the application
    /// Uses constructor dependency injection 'productService' to ensure all necessary
    /// Displays inheritance from the ConsoleDisplay to inherit DisplayMenu and SortedProducts Method for UI
    /// dependencies are present and initialized when an object is created .
    /// </summary>
    #region User Input Handler
    public class ConsoleUI : ConsoleDisplay                 
    {
        private readonly IProductService _productService;

        public ConsoleUI(IProductService productService)
        {
            _productService = productService;                                                   
        }

        /// <summary>
        /// Displays the main menu and handles user input.
        /// </summary>
        /// <param name="products">The list of products to sort.</param>
        public void Run(List<Product> products)
        {
            bool showMenu = true;

            while (true)
            {
                if(showMenu)
                {
                    DisplayMenu();
                }

                // Read user input
                string input = Console.ReadLine()?.Trim().ToUpper();
                if(input == "5")
                {
                    Console.WriteLine("THANK YOU FOR USING THE PRODUCT SORTING APPLICATION. GOODBYE!");
                    break;
                }

                switch (input)
                {
                    case "1":
                        ShowSortedProducts(_productService.SortByPrice(products));
                        showMenu = false;
                        break;
                    case "2":
                      ShowSortedProducts( _productService.SortByQuantity(products));
                        showMenu = false;
                        break;
                    case "3":
                       ShowSortedProducts(_productService.SortByProduct_Name(products));
                        showMenu = false;
                        break;
                    case "4":
                        ShowSortedProducts(_productService.GroupByProduct_NameAndSortByPrice(products));
                        showMenu = false;
                        break;
                    case "M":
                        showMenu = true; //show menu when 'M' is pressed
                        break;

                    default:
                        Console.WriteLine("Invalid option. Press 'M' to show the menu.");
                        showMenu = false;
                        break;
                }
            }
        }
    }
    #endregion
}
