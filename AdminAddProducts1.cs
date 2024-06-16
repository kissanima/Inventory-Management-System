using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace Inventory_Management_System
{
    public partial class AdminAddProducts1 : UserControl
    {
        SqlConnection
            connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=C:\Users\Jr3\Documents\inventory.mdf;
                    Integrated Security=True;
                        Connect Timeout=30;
                            Encrypt=False");

        public AdminAddProducts1()
        {
            InitializeComponent();
        }

        private void button_AddProducts_Click(object sender, EventArgs e)
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "select * from products here prod_id = @prodID";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            MessageBox.Show("Product ID: " + addProducts_prodID.Text.Trim() + " is existing already",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string relativePath = Path.Combine("Product_Directory", addProducts_prodID.Text.Trim() + ".jpg");
                            string path = Path.Combine(baseDirectory, relativePath);

                            string directoryPath = Path.GetDirectoryName(path);

                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }

                            File.Copy(addProducts_imageView.ImageLocation, path, true);


                            string insertData = "insert into products " +
                                "(prod_id, prod_name, category, price, stock, image_path, status, date_insert)" +
                                "values(@prodID, @prodName, @cat, @price, @stock, @path, @status, @date)";

                            using (SqlCommand insertD = new SqlCommand(insertData, connect))
                            {
                                insertD.Parameters.AddWithValue("@prodID", addProducts_prodID.Text.Trim());
                                insertD.Parameters.AddWithValue("@prodName", addProducts_name.Text.Trim());
                                insertD.Parameters.AddWithValue("@cat", addProducts_category.SelectedItem);
                                insertD.Parameters.AddWithValue("@price", addProducts_price.Text.Trim());
                                insertD.Parameters.AddWithValue("@stock", addProducts_stock.Text.Trim());
                                insertD.Parameters.AddWithValue("@path", path);
                                insertD.Parameters.AddWithValue("@status", addProducts_status.SelectedItem);

                                DateTime today = DateTime.Today;
                                insertD.Parameters.AddWithValue("@date", addProducts_prodID.Text.Trim());
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Failed connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        public bool CheckConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            return false;


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.png|*.jpg;*.png";
                string imagePath = "";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    addProducts_imageView.ImageLocation = imagePath;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
