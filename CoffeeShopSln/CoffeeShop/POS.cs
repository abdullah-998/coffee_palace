using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class POS : Form
    {
        public double netTk=000;
        public Employeee emp;
        public Employee eui;
        public int tid;
        public POS()
        {
            InitializeComponent();
            this.IntialPos();
            this.DataGridLoad();
        }
        public POS(Employeee emp,Employee eui)
        {
            this.eui = eui;
            this.emp = emp;
            InitializeComponent();
            this.IntialPos();
            this.DataGridLoad();
            eui.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            netTk = netTk - (Help.ToDouble(textBoxDiscount.Text));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            eui.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxC_Id.Text = "";
            textBoxDiscount.Text = "";
            textBoxCash.Text = "";
            netTk = 000;
            this.IntialPos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            netTk = netTk - ((netTk * Help.ToInt(textBoxDiscount.Text)) / 100);
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string query;
            double d;
            if (textBoxC_Id.Text != "" && textBoxCash.Text != "")
            {
                query = "insert into Transaction(C_id,E_id,Net_Tk) "
                        + " VALUES('" + Help.ToInt(textBoxC_Id.Text) + "','" + emp.E_Id + "','" + netTk + "')";

                if (Help.ToDouble(textBoxCash.Text) == netTk)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        query = "select SCOPE_IDENTITY() as 'Tranx_id';";
                        cmd.CommandText = query;
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];
                        tid = Help.ToInt(dt.Rows[0]["Tranx_id"].ToString());

                        richTextBoxPOS.Text += "\n\n\t\tCustomer Id" + textBoxC_Id.Text;
                        richTextBoxPOS.Text += "\n\t\tTransaction ID" + tid;
                        richTextBoxPOS.Text += "\n\t\tThank You for Visiting US";
                        MessageBox.Show("Payment successfully paid");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (Help.ToDouble(textBoxCash.Text) > netTk)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        query = "select SCOPE_IDENTITY() as 'Tranx_id';";
                        cmd.CommandText = query;
                        DataSet ds = new DataSet();
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        adp.Fill(ds);
                        DataTable dt = new DataTable();
                        dt = ds.Tables[0];
                        tid = Help.ToInt(dt.Rows[0]["Tranx_id"].ToString());

                        d = Help.ToDouble(textBoxCash.Text) - netTk;
                        richTextBoxPOS.Text += "\n\n\t\tCustomer Id" + textBoxC_Id.Text;
                        richTextBoxPOS.Text += "\n\t\tTransaction ID" + tid;
                        richTextBoxPOS.Text += "\n\t\tThank You for Visiting US";
                        MessageBox.Show("Payment successfully paid.Return TK " + d);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    d = netTk - (Help.ToDouble(textBoxCash.Text));
                    MessageBox.Show("Payment unsuccessfull.Due to TK " + d);
                }

            }

                ////
                ////
                ////
                ////when customer id is null
            else if (textBoxC_Id.Text == "" && textBoxCash.Text != "")
             {
                    query = "insert into Transaction(E_id,Net_Tk) "
                        + " VALUES('" + emp.E_Id + "','" + netTk + "')";

                    if (Help.ToDouble(textBoxCash.Text) == netTk)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                            query = "select SCOPE_IDENTITY() as 'Tranx_id';";
                            cmd.CommandText = query;
                            DataSet ds = new DataSet();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            adp.Fill(ds);
                            DataTable dt = new DataTable();
                            dt = ds.Tables[0];
                            tid = Help.ToInt(dt.Rows[0]["Tranx_id"].ToString());

                            //richTextBoxPOS.Text += "\n\n\t\tCustomer Id" + textBoxC_Id.Text;
                            richTextBoxPOS.Text += "\n\t\tTransaction ID" + tid;
                            richTextBoxPOS.Text += "\n\t\tThank You for Visiting US";
                            MessageBox.Show("Payment successfully paid");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else if (Help.ToDouble(textBoxCash.Text) > netTk)
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                            conn.Open();
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.ExecuteNonQuery();
                            query = "select SCOPE_IDENTITY() as 'Tranx_id';";
                            cmd.CommandText = query;
                            DataSet ds = new DataSet();
                            SqlDataAdapter adp = new SqlDataAdapter(cmd);
                            adp.Fill(ds);
                            DataTable dt = new DataTable();
                            dt = ds.Tables[0];
                            tid = Help.ToInt(dt.Rows[0]["Tranx_id"].ToString());

                            d = Help.ToDouble(textBoxCash.Text) - netTk;
                            //richTextBoxPOS.Text += "\n\n\t\tCustomer Id" + textBoxC_Id.Text;
                            richTextBoxPOS.Text += "\n\t\tTransaction ID" + tid;
                            richTextBoxPOS.Text += "\n\t\tThank You for Visiting US";
                            MessageBox.Show("Payment successfully paid.Return TK " + d);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

                    }
                 else
                    {
                        d = netTk - (Help.ToDouble(textBoxCash.Text));
                        MessageBox.Show("Payment unsuccessfull.Due to TK " + d);
                    }
                   
                }
                else
                {
                    MessageBox.Show("Customer id or cash amount missing");
                }
            
        }
          

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from PRODUCT WHERE P_Name like '%" + textBoxSearch.Text + "%';";
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-8UF2A7P;Initial Catalog=CoffeeShopDB;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt=ds.Tables[0];
            //we have to work more down
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
            conn.Close(); 
        }

        private void buttonTotal_Click(object sender, EventArgs e)
        {
            if(netTk>0)
            richTextBoxPOS.Text += "\n---------------------------------------------------------------------------------------------------------------------------------------------\n\t\t\t\t\t\t\t\t\tTotal bill = " + netTk;
            else
            {
                MessageBox.Show("No item added to cart");
            }
        }
        private void IntialPos()
        {
            richTextBoxPOS.Text = "\t\t\t\t\tCoffee Palace";
            //richTextBoxPOS.Text += "\n\t\t\t\t\t     Recipt";
            richTextBoxPOS.Text += "\n\t\t\t\tService Provided By";
            richTextBoxPOS.Text += "\n\t\t\t\t\t     Recipt";
            richTextBoxPOS.Text += "\n\n\tProduct Name    \t\t                \t\t\t\tPrice";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.DataGridLoad();
            textBoxSearch.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string name;
            double price;
            if (e.RowIndex>0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                //richTextBoxPOS.Text="\n"+
                //txtID.Text = row.Cells[0].Value.ToString();
                name = row.Cells[0].Value.ToString();
                price = Help.ToInt(row.Cells[1].Value.ToString());
                netTk += price;
                richTextBoxPOS.Text += "\n\t\t" + name;
                richTextBoxPOS.Text += "\t\t\t\t\t\t\t\t" + price;

            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name;
            double price;
            name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            price = Help.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            netTk += price;
            richTextBoxPOS.Text += "\n\t" + name;
            richTextBoxPOS.Text += "\t\t\t\t\t\t\t" + price;

        }
        public void DataGridLoad()
        {
            string query = "select * from Product";
            DataTable dt = DBConnection.AllData(query);
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = dt;
        }
    }
}
