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
    public partial class SignUpE : Form
    {
        User u;
        Employeee ems;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adp;
        DataSet ds;
        DataTable dt;
        public SignUpE()
        {
            InitializeComponent();
            string query = "select * from Department";
            dt = DBConnection.AllData(query);
            comboBoxdepartment.DataSource = dt;
            comboBoxdepartment.DisplayMember = "D_Name";
            comboBoxdepartment.ValueMember = "D_id";
            comboBoxdepartment.SelectedItem = null;
        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {
            if (textBoxfname.Text != null && textBoxpass.Text != null && txtEmail.Text != null && textBoxpass.Text != null && textBoxRepass.Text != null && textBoxPhone.Text != null && textBoxAddress.Text != null && !checkBoxAccept.Checked)
            {
                ems = new Employeee();
                ems.Name = textBoxfname.Text + textBoxlname.Text;
                ems.Email = txtEmail.Text;
                ems.Phone = textBoxPhone.Text;
                ems.Address = textBoxAddress.Text;
                ems.Dob = Convert.ToDateTime(dateTimePickerDOB);
                Department dp = new Department();
                dp.D_Id = Help.ToInt(comboBoxdepartment.SelectedItem.ToString());
                ems.Dep = dp;
                ems.Salary = Help.ToDouble(textBoxSalary.Text);
                ems.Joindate = Convert.ToDateTime(dateTimePickerJoin);


                u = new User();
                if (dp.D_Id == 1000)
                {
                    u.Designation = 1;
                }
                else if(dp.D_Id==1001)
                {
                    u.Designation = 2;
                }
                else
                {
                    u.Designation = 3;
                }
                u.Password = textBoxpass.Text;

                try
                {
                    string query = "insert into Employee(E_Name,DOB,D_id,Salary,JoinDate,E_Email,E_Phone,E_Address) "
                        + " VALUES('" + ems.Name + "','" + ems.Dob + "','" + ems.Dep.D_Id + "','" + ems.Salary + "','" + ems.Joindate + "','" + ems.Email + "','" + ems.Phone + "','" + ems.Address + "')";

                    conn = new SqlConnection(@"Data Source=ABBAS\MSSQLSERVER01;Initial Catalog=CoffeeShopDB;Integrated Security=True");
                    conn.Open();
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    query = "select SCOPE_IDENTITY() as 'E_id';";
                    cmd.CommandText = query;
                    ds = new DataSet();
                    adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                    dt = ds.Tables[0];
                    ems.E_Id = Help.ToInt(dt.Rows[0]["E_id"].ToString());

                    u.User_Id = ems.E_Id;
                    query = "insert into Log(User_id,[Password],Designation) "
                           + " VALUES('" + u.User_Id + "','" + u.Password + "','" + u.Designation + "')";
                    


                    DBConnection.Execute(query);
                    MessageBox.Show("Dear Employee,Your Succesfully signed up\nYour user id = " + ems.E_Id + "\nPlease go back to Log in Page");
                    textBoxfname.Text = "";
                    textBoxlname.Text = "";
                    txtEmail.Text = "";
                    textBoxpass.Text = "";
                    textBoxRepass.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    textBoxSalary.Text = "";
                    conn.Close();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {

            }
        }

        private void textBoxRepass_TextChanged(object sender, EventArgs e)
        {
            if(textBoxpass.Text==textBoxRepass.Text)
            {
                labelOk.Visible = true;
                labelCross.Visible = false;
            }
            else
            {
                labelOk.Visible = false;
                labelCross.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

      
