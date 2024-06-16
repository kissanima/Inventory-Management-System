using System.Collections.Generic;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    internal class AddProductsData
    {
        public int ID { get; set; }
        public string ProdID { get; set; }
        public string ProdName { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public string Date { get; set; }

        public List<AddProductsData> AllProductsData()
        {
            List<AddProductsData> listdata = new List<AddProductsData>();

            using (SqlConnection connect
                = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=C:\Users\Jr3\Desktop\Jr\C#\Inventory Management System\inventory.mdf;
                    Integrated Security=True;
                        Connect Timeout=30;
                            Encrypt=False"))
            {
                connect.Open();

                string selectData = "select * from products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        AddProductsData data = new AddProductsData();
                        data.ID = (int)reader["id"];
                        data.ProdID = reader["prod_id"].ToString();
                        data.ProdName = reader["prod_name"].ToString();
                        data.Category = reader["category"].ToString();
                        data.Price = reader["price"].ToString();
                        data.Stock = reader["stock"].ToString();
                        data.ImagePath = reader["image_path"].ToString();
                        data.Status = reader["status"].ToString();
                        data.Date = reader["date_insert"].ToString();

                        listdata.Add(data);
                    }
                }
            }
            return listdata;
        }

    }
}
