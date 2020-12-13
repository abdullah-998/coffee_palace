using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class AllTransaction : UserControl
    {
        public AllTransaction()
        {
            InitializeComponent();
        }
        public void AllTransactionList()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01\SQLEXPRESS;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                conn.Open();
                string query = "select * from Transaction";
                SqlCommand cmd = new SqlCommand(query, conn);
                DataSet ds = new DataSet();
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                adp.Fill(ds);
                DataTable dt = ds.Tables[0];
                dgvTrans.AutoGenerateColumns = false;
                dgvTrans.DataSource = dt;
                dgvTrans.Refresh();


                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
