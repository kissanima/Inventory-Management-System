namespace Inventory_Management_System
{
    internal class WindowManager
    {
        AdminDashboard adminDashboardWindow = new AdminDashboard();
        AdminProducts ProductsWindow = new AdminProducts();
        AdminAddProducts addProductsWindow = new AdminAddProducts();
        AdminExport adminExport = new AdminExport();


        public void OpenDashboard()
        {

        }

        public void OpenProducts()
        {
            //adminDashboardWindow.Hide();
            //ProductsWindow.Show();
            //addProductsWindow.Hide();
        }

        public void OpenAddProducts()
        {
            //adminDashboardWindow.Hide();
            //ProductsWindow.Hide();
            //addProductsWindow.Show();
        }
    }
}
