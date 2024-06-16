using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class main : Form
    {
        WindowManager windowManager = new WindowManager();
        public main()
        {
            InitializeComponent();

            //close other userControl
            OpenDashboard();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Dashboard_Click(object sender, System.EventArgs e)
        {

            adminAddProducts1.Visible = false;
            adminDashboard1.Visible = true;
        }

        private void btn_Products_Click(object sender, System.EventArgs e)
        {
            OpenAddProducts();
        }

        private void btn_Logout_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();


                this.Hide();
            }
        }

        private void btn_Export_Click(object sender, System.EventArgs e)
        {
            OpenExport();
        }


        public void OpenDashboard()
        {
            adminDashboard1.Visible = true;
            adminAddProducts1.Visible = false;
            adminExport1.Visible = false;

        }

        public void OpenAddProducts()
        {
            adminAddProducts1.Visible = true;
            adminDashboard1.Visible = false;
            adminExport1.Visible = false;

        }

        public void OpenExport()
        {
            adminExport1.Visible = true;
            adminAddProducts1.Visible = false;
            adminDashboard1.Visible = false;
        }

        private void adminExport1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
