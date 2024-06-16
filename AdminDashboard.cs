using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Inventory_Management_System
{
    public partial class AdminDashboard : UserControl
    {
        int productsCount;
        int productsOutStock;
        int productsLowStock;

        SqlConnection
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=C:\USERS\JR3\DESKTOP\JR\C#\INVENTORY MANAGEMENT SYSTEM\INVENTORY.MDF;
                    Integrated Security=True;
                        Connect Timeout=30;
                            Encrypt=False");
        public AdminDashboard()
        {
            InitializeComponent();

            DisplayProductsCount();
            PopulatePieChart();
            PopulateProductsByStockStatus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void DisplayProductsCount()
        {
            GetProductsCount();


            totalProductsAmountLabel.Text = productsCount.ToString();
            productsOutofStock.Text = productsOutStock.ToString();
            productsLowOfStocks.Text = productsLowStock.ToString();
        }

        public void GetProductsCount()
        {
            if (CheckConnection())
            {
                try
                {
                    conn.Open();

                    string selectData = @"
                    select count(*) from products;
                    select count(*) from products where stock = 0;
                    select count(*) from products where stock < 5;
                ";

                    using (SqlCommand cmd = new SqlCommand(selectData, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                productsCount = reader.GetInt32(0);
                            }
                            if (reader.NextResult() && reader.Read())
                            {
                                productsOutStock = reader.GetInt32(0);
                            }
                            if (reader.NextResult() && reader.Read())
                            {
                                productsLowStock = reader.GetInt32(0);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }





        public void GetLowOfStocks()
        {

            string selectData = "select count(*) from products where stock < @stock";

            using (SqlCommand cmd2 = new SqlCommand(selectData, conn))
            {
                cmd2.Parameters.AddWithValue("@stock", 5);
                SqlDataReader reader2 = cmd2.ExecuteReader();

                if (reader2.Read())
                {
                    Console.WriteLine("low of stock: " + reader2[0]);
                    productsLowStock = Convert.ToInt32(reader2[0]);

                }
            }
        }


        public bool CheckConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart_categories_Click(object sender, EventArgs e)
        {

        }



        //chart
        private void PopulatePieChart()
        {
            if (CheckConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT category, COUNT(prod_id) as ProductCount
                    FROM products
                    GROUP BY category";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        chart_categories.Series.Clear();
                        Series series = chart_categories.Series.Add("Products by Category");
                        series.ChartType = SeriesChartType.Doughnut;

                        foreach (DataRow row in dataTable.Rows)
                        {
                            series.Points.AddXY(row["category"], row["ProductCount"]);
                        }

                        // Enable labels and customize them
                        series.IsValueShownAsLabel = true;
                        series.Label = "#VALX: #VALY"; // This will show category name and count
                        chart_categories.Legends[0].Enabled = true;

                        //chart_categories.Legends[0].Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void PopulateProductsByStockStatus()
        {
            try
            {
                conn.Open();
                string query = @"
            SELECT
                CASE
                    WHEN Stock = 0 THEN 'Out of Stock'
                    WHEN Stock < 5 THEN 'Low Stock'
                    ELSE 'In Stock'
                END AS StockStatus,
                COUNT(*) AS ProductCount
            FROM products
            GROUP BY
                CASE
                    WHEN Stock = 0 THEN 'Out of Stock'
                    WHEN Stock < 5 THEN 'Low Stock'
                    ELSE 'In Stock'
                END";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    chart_stocks.Series.Clear();
                    Series series = chart_stocks.Series.Add("Products by Stock Status");
                    series.ChartType = SeriesChartType.Doughnut;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        series.Points.AddXY(row["StockStatus"], row["ProductCount"]);
                    }

                    // Enable labels and customize them
                    series.IsValueShownAsLabel = true;
                    series.Label = "#VALX: #VALY"; // This will show stock status and count
                    chart_stocks.Legends[0].Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }


        private void chart_stocks_Click(object sender, EventArgs e)
        {

        }

        private void totalProductsAmountLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
