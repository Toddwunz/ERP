using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
   public class Controller
    {
        public static string DataGeting(string sqlcmdstring, int Column)
        {
            string result;
            string connectionString = ConfigurationManager.ConnectionStrings["ERPDB"].ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                }
                catch (SqlException e)
                {
                    MessageBox.Show("Exception Occre while connect database:" + e.Message + "\t" + e.GetType());
                }
                SqlCommand sqlCmd = new SqlCommand(sqlcmdstring, connection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                    result = sqlReader[Column].ToString();
                else
                    result = "Empty";
                sqlReader.Close();
            }
            return result;
        }

        public static void DataInsert(string sqlcmdstring)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["ERPDB"].ToString();
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlcmdstring, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Exception Occre while insert data:" + e.Message + "\t" + e.GetType());
            }
           
        }
    }
}
