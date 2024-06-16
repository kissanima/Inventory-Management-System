using System.Data;
using System.Data.SqlClient;

namespace Inventory_Management_System
{
    internal class ConnectionManager
    {
        SqlConnection
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename=C:\USERS\JR3\DESKTOP\JR\C#\INVENTORY MANAGEMENT SYSTEM\INVENTORY.MDF;
                    Integrated Security=True;
                        Connect Timeout=30;
                            Encrypt=False");


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

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
