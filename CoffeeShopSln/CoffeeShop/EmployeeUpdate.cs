using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class EmployeeUpdate : UserControl
    {
        public DataTable dt;
        public Employeee emp;
        public User u;
        public EmployeeUpdate()
        {
            InitializeComponent();
            string query = "select * from Department";
            dt = DBConnection.AllData(query);
            comboBoxdepartment.DataSource = dt;
            comboBoxdepartment.DisplayMember = "D_Name";
            comboBoxdepartment.ValueMember = "D_id";
            comboBoxdepartment.SelectedItem = null;
        }
        public EmployeeUpdate(Employeee emp,User u)
        {
            this.emp = emp;
            this.u = u;
            InitializeComponent();
            string query = "select * from Department";
            dt = DBConnection.AllData(query);
            comboBoxdepartment.DataSource = dt;
            comboBoxdepartment.DisplayMember = "D_Name";
            comboBoxdepartment.ValueMember = "D_id";
            comboBoxdepartment.SelectedItem = null;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string query;
            Employeee em = new Employeee();
            Department dep;
            if(textBoxEMpId.Text!="" || textBoxPhone.Text!="" || textBoxSalary.Text!="" || textBoxAddress.Text!="" || txtEmail.Text!="" || comboBoxdepartment.SelectedItem.ToString()!="")
            {
                try
                {
                    query = "select * from Employee where E_id='" + Help.ToInt(textBoxEMpId.Text) + "';";
                    dt = DBConnection.AllData(query);
                    em = new Employeee();
                    em.E_Id = Help.ToInt(dt.Rows[0]["E_id"].ToString());
                    em.Name = dt.Rows[0]["E_Name"].ToString();
                    em.Dob = Convert.ToDateTime(dt.Rows[0]["DOB"].ToString());
                    dep= new Department();
                    dep.D_Id = Help.ToInt(dt.Rows[0]["D_id"].ToString());
                    em.Dep = dep;
                    em.Salary = Help.ToDouble(dt.Rows[0]["Salary"].ToString());
                    em.Joindate = Convert.ToDateTime(dt.Rows[0]["JoinDate"].ToString());
                    em.Email = dt.Rows[0]["E_email"].ToString();
                    em.Phone = dt.Rows[0]["E_phone"].ToString();
                    em.Address = dt.Rows[0]["E_address"].ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (textBoxPhone.Text != "")
                    em.Phone = textBoxPhone.Text;
                if (textBoxSalary.Text != "")
                    em.Salary = Help.ToInt(textBoxSalary.Text);
                if (textBoxAddress.Text != "")
                    em.Address = textBoxAddress.Text;
                if (txtEmail.Text != "")
                    em.Email = txtEmail.Text;
                if (comboBoxdepartment.SelectedItem.ToString() != "")
                    em.Dep.D_Id = Help.ToInt(comboBoxdepartment.SelectedItem.ToString());
                try
                {
                    query = "Update Employee set Salary='" + em.Salary + "', D_id='" + em.Dep.D_Id + "', E_phone='" + em.Phone + "', E_email='" + em.Email + "',E_address='" + em.Address + "' WHERE E_id='" + textBoxEMpId.Text + "';";
                    DBConnection.Execute(query);
                    MessageBox.Show("Updated employee info for id = " + em.E_Id);
                }
               catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                }


            }
            else
            {
                MessageBox.Show("Must update one info");
            }
        }
    }
}
