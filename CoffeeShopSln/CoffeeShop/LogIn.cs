using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class LogIn : Form
    {
        public User user;
        public Employeee emp;
        public Customerr cr;
        public Department dep;
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && (txtPass.Text != ""))
            {
                try
                {
                    user = new User();
                    user.User_Id = Help.ToInt(txtID.Text);
                    user.Password = txtPass.Text;
                    string query = "select * from Log where [User_id]='" + txtID.Text + "' and [Password]='" + txtPass.Text + "';";
                    DataTable dt = DBConnection.AllData(query);
                    if (dt.Rows.Count == 1)
                    {
                        txtID.Text = "";
                        txtPass.Text = "";
                        user.Designation = Help.ToInt(dt.Rows[0]["Designation"].ToString());


                        if (user.Designation == 1)
                        {
                            try
                            {
                                query = "select * from Employee where E_id='" + user.User_Id + "';";
                                dt = DBConnection.AllData(query);
                                emp = new Employeee();
                                emp.E_Id = Help.ToInt(dt.Rows[0]["E_id"].ToString());
                                emp.Name = dt.Rows[0]["E_Name"].ToString();
                                emp.Dob = Convert.ToDateTime(dt.Rows[0]["DOB"].ToString());
                                dep = new Department();
                                dep.D_Id = Help.ToInt(dt.Rows[0]["D_id"].ToString());
                                emp.Dep = dep;
                                emp.Salary = Help.ToDouble(dt.Rows[0]["Salary"].ToString());
                                emp.Joindate = Convert.ToDateTime(dt.Rows[0]["JoinDate"].ToString());
                                emp.Email = dt.Rows[0]["E_email"].ToString();
                                emp.Phone = dt.Rows[0]["E_phone"].ToString();
                                emp.Address = dt.Rows[0]["E_address"].ToString();

                                Manager mg = new Manager(emp, user, this);
                                mg.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }



                        }
                        else if (user.Designation == 2)
                        {
                            try
                            {
                                query = "select * from Employee where E_id='" + user.User_Id + "';";
                                dt = DBConnection.AllData(query);
                                emp = new Employeee();
                                emp.E_Id = Help.ToInt(dt.Rows[0]["E_id"].ToString());
                                emp.Name = dt.Rows[0]["E_Name"].ToString();
                                emp.Dob = Convert.ToDateTime(dt.Rows[0]["DOB"].ToString());
                                dep = new Department();
                                dep.D_Id = Help.ToInt(dt.Rows[0]["D_id"].ToString());
                                emp.Dep = dep;
                                emp.Salary = Help.ToDouble(dt.Rows[0]["Salary"].ToString());
                                emp.Joindate = Convert.ToDateTime(dt.Rows[0]["JoinDate"].ToString());
                                emp.Email = dt.Rows[0]["E_email"].ToString();
                                emp.Phone = dt.Rows[0]["E_phone"].ToString();
                                emp.Address = dt.Rows[0]["E_address"].ToString();

                                Employee em = new Employee(emp, user, this);
                                em.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (user.Designation == 3)
                        {
                            try
                            {
                                query = "select * from Employee where E_id='" + user.User_Id + "';";
                                dt = DBConnection.AllData(query);
                                emp = new Employeee();
                                emp.E_Id = Help.ToInt(dt.Rows[0]["E_id"].ToString());
                                emp.Name = dt.Rows[0]["E_Name"].ToString();
                                //emp.Dob = Convert.ToDateTime(dt.Rows[0]["DOB"].ToString());
                                dep = new Department();
                                dep.D_Id = Help.ToInt(dt.Rows[0]["D_id"].ToString());
                                emp.Dep = dep;
                                emp.Salary = Help.ToDouble(dt.Rows[0]["Salary"].ToString());
                                //emp.Joindate = Convert.ToDateTime(dt.Rows[0]["JoinDate"].ToString());
                                emp.Email = dt.Rows[0]["E_email"].ToString();
                                emp.Phone = dt.Rows[0]["E_phone"].ToString();
                                emp.Address = dt.Rows[0]["E_address"].ToString();

                                OtherStuff os = new OtherStuff(emp, user, this);
                                os.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else if (user.Designation == 4)
                        {
                            try
                            {
                                query = "select * from Customer where C_id='" + user.User_Id + "';";
                                dt = DBConnection.AllData(query);
                                cr = new Customerr();
                                cr.C_ID = user.User_Id;
                                cr.Name = dt.Rows[0]["C_Name"].ToString();
                                cr.Email = dt.Rows[0]["C_Email"].ToString();
                                cr.Phone = dt.Rows[0]["C_Phone"].ToString();
                                cr.Address = dt.Rows[0]["C_Address"].ToString();

                                Customer cm = new Customer(cr, user, this);
                                cm.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Your userid or password is not correct", "Error!!", MessageBoxButtons.OK);
                    }
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
                if (txtPass.Text == "")
                    MessageBox.Show("Please enter password", "Login failed", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Please enter userid", "Login failed", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpC sc = new SignUpC(this);
            sc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
