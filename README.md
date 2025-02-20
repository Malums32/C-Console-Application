Product Sorting Console Application
==================================

Overview
--------
This is a C# console application that reads a CSV file containing product data, sorts the data based on various criteria,
and displays the sorted results in the console. The application adheres to SOLID principles and follows best practices for
object-oriented programming.

Features
--------
1. Reads a CSV file containing product data (Product Name, Price, Quantity).
2. Provides a menu for sorting options:
   - Sort by Price (ascending)
   - Sort by Quantity (ascending)
   - Sort alphabetically by Product Name (ascending)
   - Group by Product Name and sort each group by Price (ascending)
3. Demonstrates the Liskov Substitution Principle (LSP).
4. Handles errors gracefully (e.g., missing file, invalid CSV format).
5. Allows the user to hide and show the menu by pressing 'M'.

Project Structure
-----------------
ProductSortingApp/
│
├── Program.cs               // Entry point of the application
├── Models/
│   └── Product.cs           // Product class definition
├── Services/
│   ├── IProductService.cs   // Interface for ProductService
│   └── ProductService.cs    // Implementation of IProductService
├── UI/
│   |── ConsoleUI.cs         // Handles user input
|   └── ConsoleDiplay.cs     // Handles the display
|    
├── Utilities/
│   └── CsvReader.cs         // Handles CSV file reading
├── ProductList.csv             // Sample CSV file for testing
└── README.txt               // This file

Requirements
------------
1. .NET SDK (version 6.0 or later).
2. Visual Studio Explorer  (or any code editor with C# support).


Setup Instructions
------------------
1. Clone or download the project to your local machine.
2. Open the project folder in Visual Studio Code (or your preferred editor).
3. Ensure the `ProductList.csv` file is present in the project root directory.
4. Ensure that the "Copy to Ouput Repository" property of the 'ProductList.csv' is 'Copy Always' or 'Copy if newer'

Running the Application
-----------------------
1. Open a terminal in the project directory.
2. Run the following command to build and start the application: dotnet run
3. Follow the on-screen prompts to interact with the application.

Sample CSV File (products.csv)
------------------------------
The CSV file should have the following format:
Product Name,Price (ZAR),Quantity
Widget A,10.99,100
Gadget B,24.95,50
Thingamajig C,15.49,75
Doohickey D,8.99,120
Whatchamacallit E,19.99,60
Doodad F,5.75,200
Gizmo G,29.99,45
Widget H,12.49,90
Widget I,11.99,110
Gadget J,27.50,55
Thingamajig K,16.99,70...


Application Workflow
--------------------
1. The application reads the `ProductList.csv` file and loads the product data.
2. A menu is displayed with sorting options.
3. The user selects an option to sort the products.
4. The sorted products are displayed, and the menu is hidden.
5. The user can press 'M' to show the menu again.
6. The application exits when the user selects the "Exit" option.

Error Handling
--------------
- If the CSV file is missing or has an invalid format, the application displays an error message and exits gracefully after pressing any key.
- Invalid user input (e.g., non-numeric input for sorting options) is handled with appropriate error messages
  and prompts the user to insert 'M' for menu to make the correct selection.

SOLID Principles
---------------
1. Single Responsibility Principle (SRP):
   - Each class has a single responsibility (e.g., `ConsoleUI` handles user inputs, 'ConsoleDisplay' handles displays
   , `ProductService` handles sorting).

2. Open/Closed Principle (OCP):
   - The application is open for extension (e.g., adding new sorting options) but closed for modification.

3. Liskov Substitution Principle (LSP):
   - The `ProductService` class can be substituted for its base interface (`IProductService`).

4. Interface Segregation Principle (ISP):
   - The `IProductService` interface is specific to product-related operations.

5. Dependency Inversion Principle (DIP):
   - High-level modules (e.g., `ConsoleUI`) depend on abstractions (e.g., `IProductService`), not on low-level details.

Testing
-------
1. Ensure the `ProductList.csv` file is correctly formatted and located in the project root.
2. Run the application and test all sorting options.
3. Verify that the menu is hidden after a selection and revealed when 'M' is pressed.
4. Test error handling by providing invalid input or removing the CSV file.

Contact
-------
For questions or issues, please contact Mfundo Mthembu at
mfundo1.mthembu@gmail.com
www.linkedin.com/in/mfundomthembu/ 
                                           

