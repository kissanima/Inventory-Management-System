using System;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AdminProducts : UserControl
    {


        public AdminProducts()
        {
            InitializeComponent();
        }

        private void btn_AddProducts_Click(object sender, EventArgs e)
        {
            var adminaddproducts = new AdminProducts();

            this.Controls.Add(adminaddproducts);
        }
    }
}
