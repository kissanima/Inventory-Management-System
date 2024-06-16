using OfficeOpenXml;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Inventory_Management_System
{
    public partial class AdminExport : UserControl
    {
        ConnectionManager connectionManager = new ConnectionManager();


        public AdminExport()
        {
            InitializeComponent();

            PopulateCategoryComboBox();
        }

        private void PopulateCategoryComboBox()
        {
            if (connectionManager.CheckConnection())
            {
                try
                {
                    connectionManager.GetConnection().Open();
                    string query = "SELECT DISTINCT Category FROM products";

                    using (SqlCommand cmd = new SqlCommand(query, connectionManager.GetConnection()))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string category = reader["Category"].ToString();
                            comboBox_Categories.Items.Add(category);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connectionManager.GetConnection().Close();
                }
            }
            else
            {

            }

        }


        private void comboBox_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_FileType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            string selectedCategory = comboBox_Categories.SelectedItem.ToString();
            string selectedFileType = comboBox_FileType.SelectedItem.ToString();

            if (selectedCategory == "Select All")
            {
                if (selectedFileType == "Excel")
                {
                    ExportAllToExcel();
                }
                else if (selectedFileType == "PDF")
                {
                    ExportAllToPDF();
                }
            }
            else
            {
                if (selectedFileType == "Excel")
                {
                    ExportToExcel(selectedCategory);
                }
                else if (selectedFileType == "PDF")
                {
                    ExportToPDF(selectedCategory);
                }
            }
        }

        private void ExportAllToExcel()
        {
            try
            {
                string query = "SELECT * FROM products";
                SqlCommand cmd = new SqlCommand(query, connectionManager.GetConnection());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");
                    worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Products_All.xlsx");
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Export to Excel completed successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ExportAllToPDF()
        {
            try
            {
                string query = "SELECT * FROM products";
                SqlCommand cmd = new SqlCommand(query, connectionManager.GetConnection());

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "All Products";

                // Create an empty page
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12, XFontStyleEx.Regular);

                // Define starting points for text
                double yPoint = 0;

                // Write the column names
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    gfx.DrawString(dataTable.Columns[i].ColumnName, font, XBrushes.Black,
                        new XRect(40 + (i * 100), yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                }

                yPoint += 25;

                // Write the data
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        gfx.DrawString(row[i].ToString(), font, XBrushes.Black,
                            new XRect(40 + (i * 100), yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    }
                    yPoint += 20;

                    // Add new page if the content exceeds the page height
                    if (yPoint > page.Height.Point - 40)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        yPoint = 0;
                    }
                }

                // Save the document
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Products_All.pdf");
                document.Save(filePath);

                MessageBox.Show("Export to PDF completed successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(string category)
        {
            try
            {
                string query = "SELECT * FROM products WHERE Category = @category";
                SqlCommand cmd = new SqlCommand(query, connectionManager.GetConnection());
                cmd.Parameters.AddWithValue("@category", category);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Products");
                    worksheet.Cells["A1"].LoadFromDataTable(dataTable, true);

                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Products.xlsx");
                    File.WriteAllBytes(filePath, package.GetAsByteArray());

                    MessageBox.Show("Export to Excel completed successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToPDF(string category)
        {
            try
            {
                string query = "SELECT * FROM products WHERE Category = @category";
                SqlCommand cmd = new SqlCommand(query, connectionManager.GetConnection());
                cmd.Parameters.AddWithValue("@category", category);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Create a new PDF document
                PdfDocument document = new PdfDocument();
                document.Info.Title = "Products - " + category;

                // Create an empty page
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Verdana", 12, XFontStyleEx.Regular);

                // Define starting points for text
                double yPoint = 0;

                // Write the column names
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    gfx.DrawString(dataTable.Columns[i].ColumnName, font, XBrushes.Black,
                        new XRect(40 + (i * 100), yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                }

                yPoint += 25;

                // Write the data
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        gfx.DrawString(row[i].ToString(), font, XBrushes.Black,
                            new XRect(40 + (i * 100), yPoint, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    }
                    yPoint += 20;

                    // Add new page if the content exceeds the page height
                    if (yPoint > page.Height.Point - 40)
                    {
                        page = document.AddPage();
                        gfx = XGraphics.FromPdfPage(page);
                        yPoint = 0;
                    }
                }

                // Save the document
                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Products_{category}.pdf");
                document.Save(filePath);

                MessageBox.Show("Export to PDF completed successfully!", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
