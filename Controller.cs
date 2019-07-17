using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP
{
   public class Controller
    {
        public static string DataGeting(string sqlcmdstring)
        {
            string result;
            string connectionString = ConfigurationManager.ConnectionStrings["ERPDB"].ToString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCmd = new SqlCommand(sqlcmdstring, connection);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                    result = sqlReader[0].ToString();
                else
                    result = "Empty";
                sqlReader.Close();
            }
            return result;
        }

    }
}
