# Inventory Management System

This project is an Inventory Management System built using C# and Windows Forms. It allows users to manage products, view product statistics, and export product data to Excel and PDF.

## Features

- **Product Management**: Add, edit, and delete products.
- **Dashboard**: View total products, products out of stock, and products with low stock.
- **Export Data**: Export product data to Excel or PDF.
- **Charts**: Visualize product data with charts.

## Getting Started

### Prerequisites

- Visual Studio 2019 or later
- .NET Framework 4.7
- SQL Server or SQL Server Express

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/yourusername/inventory-management-system.git
    ```

2. Open the solution file `InventoryManagementSystem.sln` in Visual Studio.

3. Restore the NuGet packages:
    ```sh
    dotnet restore
    ```

4. Update the connection string in `ConnectionManager.cs` to point to your database.

5. Build and run the project.

### Database Setup

1. Create a SQL Server database.
2. Execute the SQL scripts in the `Scripts` folder to create the necessary tables.

### Using the Application

1. **Login**: Start the application and log in using the admin credentials (username: `admin`, password: `admin`).
2. **Dashboard**: View product statistics on the dashboard.
3. **Manage Products**: Add, edit, or delete products from the `Products` section.
4. **Export Data**: Export product data to Excel or PDF from the `Export` section.
5. **Charts**: View charts for product data by category and stock status.

## Export to Excel and PDF

### Export to Excel

1. Select the category to export.
2. Choose `Excel` as the file type.
3. Click the `Export` button.

### Export to PDF

1. Select the category to export.
2. Choose `PDF` as the file type.
3. Click the `Export` button.

## Charts

- **Products by Category**: Visualize the number of products in each category using a pie chart.
- **Products by Stock Status**: Visualize the stock status of products using a pie chart.
- **Products by Price Range**: Visualize the distribution of products by price range using a pie chart.

## Work in Progress

This project is currently under active development. Here are some of the upcoming features and improvements:

- **User Authentication and Authorization**: Implement user roles and permissions.
- **Advanced Reporting**: Add more detailed and customizable reports.
- **Improved UI/UX**: Enhance the user interface for better user experience.
- **Notifications**: Implement notifications for low stock and other alerts.
- **Unit Tests**: Add unit tests to improve code quality and reliability.
- **Category Management**: Manage product categories.

## Contributing

1. Fork the repository.
2. Create a new branch:
    ```sh
    git checkout -b feature/your-feature-name
    ```
3. Make your changes.
4. Commit your changes:
    ```sh
    git commit -m "Add some feature"
    ```
5. Push to the branch:
    ```sh
    git push origin feature/your-feature-name
    ```
6. Open a pull request.

## License

This project is licensed under the GNU General Public License v3.0. See the [LICENSE](LICENSE) file for details.

## Acknowledgements

- [PdfSharp](https://github.com/empira/PDFsharp) for PDF generation.
- [EPPlus](https://github.com/EPPlusSoftware/EPPlus) for Excel generation.

---

Feel free to customize this README file according to your project's specifics. Make sure to replace placeholder URLs and names with actual information related to your project.
