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
    public partial class SignUpC : Form
    {
        public Customerr c;
        public User u;
        public LogIn l;
        public SignUpC()
        {
            InitializeComponent();
        }
        public SignUpC(LogIn l)
        {
            this.l = l;
            InitializeComponent();
            l.Hide();
        }

        private void labelCross_Click(object sender, EventArgs e)
        {

        }
        private void PassTyping(object sender,EventArgs e)
        {
            if(textBoxpass.Text!=textBoxRepass.Text)
            {
                labelCross.Visible = true;
                labelOK.Visible = false;
            }
            else
            {
                labelCross.Visible = false;
                labelOK.Visible = true;
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(textBoxfname.Text!=null && textBoxpass.Text!=null && txtEmail.Text!=null && textBoxpass.Text!=null && textBoxRepass.Text!=null && textBoxPhone.Text!=null && textBoxAddress.Text!=null && checkBoxAccept.Checked)
            {
                c = new Customerr();
                c.Name = textBoxfname.Text +" "+ textBoxlname.Text;
                c.Email = txtEmail.Text;
                c.Phone = textBoxPhone.Text;
                c.Address = textBoxAddress.Text;

                u = new User();
                u.Designation = 4;
                u.Password = textBoxpass.Text;
               
                try
                {
                    string query = "insert into Customer(C_Name,C_Email,C_Phone,C_Address) "
                        + " VALUES('" + c.Name + "','" + c.Email + "','" + c.Phone + "','" + c.Address + "')";

                    SqlConnection conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    query = "select SCOPE_IDENTITY() as 'C_id';";
                    cmd.CommandText = query;
                    DataSet ds = new DataSet();
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    c.C_ID = Help.ToInt(dt.Rows[0]["C_id"].ToString());


                    u.User_Id = c.C_ID;
                     query = "insert into Log(User_id,[Password],Designation) "
                            + " VALUES('" + u.User_Id + "','" + u.Password + "','" + u.Designation + "')";
                    DBConnection.Execute(query);
                    MessageBox.Show("Dear customer,Your Successfully signed up\nYour user id = " + c.C_ID + "\nPlease go back to Log in Page","Sign up Successful",MessageBoxButtons.OK);

                    textBoxfname.Text = "";
                    textBoxlname.Text = "";
                    txtEmail.Text = "";
                    textBoxpass.Text = "";
                    textBoxRepass.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";

                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {

                }

            }
            else
            {
                MessageBox.Show("Must enter all values", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l.Show();
            this.Close();
        }
        
    }
}
