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
    public partial class Additem: UserControl
    {
        public Product p;
       
        public Additem()
        {
            InitializeComponent();
        }
        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(txtItname.Text!="" && textItPrice.Text!="")
            {
                p = new Product();
                p.P_Name = txtItname.Text;
                p.P_Price = Help.ToDouble(textItPrice.Text);
                try
                {
                    string query = "insert into Product(P_Name,P_Price) "
                        + " VALUES('" + p.P_Name +"','" + p.P_Price + "')";
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    query = "select SCOPE_IDENTITY() as 'P_id';";
                    cmd.CommandText = query;
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    p.P_ID=Help.ToInt(dt.Rows[0]["P_id"].ToString());


                    MessageBox.Show("Product Inserted successfully.\nProduct id " + p.P_ID);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               

            }
            else
            {
                MessageBox.Show("Please insert all values");
            }
        }
    }
}
