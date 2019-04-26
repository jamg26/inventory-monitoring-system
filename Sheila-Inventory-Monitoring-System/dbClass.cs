using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Windows.Forms;

namespace Sheila_Inventory_Monitoring_System
{
    class dbClass
    {
        SqlConnection connect = getConnection();

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source = DESKTOP-F9UVCQF\\SQLEXPRESS; Initial Catalog = Inventory_System; Integrated Security=True");
            return conn;
        }

        public System.Data.DataTable dbSelect(string query)
        {
            try {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                connect.Close();
                return dt;
            }
            catch {
                MessageBox.Show("Error in dbSelect query");
                return null;
            }
        }

        public void dbInsert(string query)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.InsertCommand = new SqlCommand(query, connect);
                connect.Open();
                sda.InsertCommand.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Error in dbInsert query");
            }
        }

        public void dbDelete(string query)
        {
            try {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.UpdateCommand = new SqlCommand(query, connect);
                connect.Open();
                sda.UpdateCommand.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Error in dbDelete query");
            }
        }

        public void dbUpdate(string query)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.UpdateCommand = new SqlCommand(query, connect);
                connect.Open();
                sda.UpdateCommand.ExecuteNonQuery();
                connect.Close();
            }
            catch
            {
                MessageBox.Show("Error in dbUpdate query");
            }
        }
    }
}
