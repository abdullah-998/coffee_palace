using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    public class DBConnection
    {
     
        public static DataTable AllData(string query)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds.Tables[0];
        }

        public static void Execute(string query)//update,delete
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
