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
    public partial class Manager : Form
    {
        public Employeee emp;
        public User u;
        public LogIn l;
        public EmployeeUpdate eupdate;
        public Additem ai;
        public UpdateItem up;
        public Manager()
        {
            InitializeComponent();
        }
        public Manager(Employeee emp,User u,LogIn l)
        {
            this.l = l;
            this.emp = emp;
            this.u = u;
            InitializeComponent();
            l.Hide();
            this.ShowInfo();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonChangePass.Height;
            panelMouseC.Top = buttonChangePass.Top;

            ChangePass cp = new ChangePass(emp, u);
            cp.Show();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            HideInfo();
            panelMouseC.Height = buttonAddEmployee.Height;
            panelMouseC.Top = buttonAddEmployee.Top;
            SignUpE se = new SignUpE();
            se.Show();
        }
        private void ShowInfo()
        {
            labelName.Text = "\t\tName: " + emp.Name;
            labelID.Text = "\t\tID: " + emp.E_Id.ToString();
            labelPhone.Text = "\t\tContactct Number: " + emp.Phone.ToString();
            labelWC.Text = "WEL COME,";
            labelEmail.Text = "\t\tEmail Address: " + emp.Email.ToString();
            labelAsdress.Text = "\t\tAddress: " + emp.Address.ToString();
            labelDOB.Text = "\t\tDOB: " + emp.Dob;
            labelDept.Text = "\t\tDepartment: " + emp.Dep.D_Id.ToString();
            labelSalary.Text = "\t\tSalary: " + emp.Salary.ToString();
            labelJoinDate.Text = "\t\tJoin Date: " + emp.Joindate.ToString();



            labelJoinDate.Visible = true;
            labelSalary.Visible = true;
            labelDept.Visible = true;
            labelDOB.Visible = true;
            labelName.Visible = true;
            labelID.Visible = true;
            labelPhone.Visible = true;
            labelWC.Visible = true;
            labelEmail.Visible = true;
            labelAsdress.Visible = true;
        }
        private void HideInfo()
        {
            labelJoinDate.Visible = false;
            labelSalary.Visible = false;
            labelDept.Visible = false;
            labelDOB.Visible = false;
            labelName.Visible = false;
            labelID.Visible = false;
            labelPhone.Visible = false;
            labelWC.Visible = false;
            labelEmail.Visible = false;
            labelAsdress.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelMouseC.Height = btnHome.Height;
            panelMouseC.Top = btnHome.Top;

            Infoem ie = new Infoem(emp);
            panel1.Controls.Add(ie);
            ie.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelMouseC.Height = buttonLogOut.Height;
            panelMouseC.Top = buttonLogOut.Top;
            l.Show();
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            panelMouseC.Height = buttonUpdate.Height;
            panelMouseC.Top = buttonUpdate.Top;

            eupdate = new EmployeeUpdate(emp, u);
            eupdate.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(eupdate);
            eupdate.Show();
        }

        private void buttonItemAdd_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelMouseC.Height = buttonItemAdd.Height;
            panelMouseC.Top = buttonItemAdd.Top;

            ai = new Additem();
            panel1.Controls.Add(ai);
            ai.Show();
        }

        private void buttonUpItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonUpItem.Height;
            panelMouseC.Top = buttonUpItem.Top;

            up = new UpdateItem();
            panel1.Controls.Add(up);
            up.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            this.HideInfo();
            panel1.Controls.Clear();
            panelMouseC.Height = buttonDelete.Height;
            panelMouseC.Top = buttonDelete.Top;

            // DeleteAcC dac = new DeleteAcC(this,emp, u);
            DeleteAcC dac = new DeleteAcC(this, emp, u);
            dac.Show();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonTransaction.Height;
            panelMouseC.Top = buttonTransaction.Top;

            AllTransaction AS= new AllTransaction();
            panel1.Controls.Add(AS);
            AS.Show();

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = btnEmployees.Height;
            panelMouseC.Top = btnEmployees.Top;

            AllEmployee ae = new AllEmployee();
            panel1.Controls.Add(ae);
            ae.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            l.Close();
            this.Close();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelMouseC.Height = btnCustomers.Height;
            panelMouseC.Top = btnCustomers.Top;

            AllCustomers acc = new AllCustomers();
            panel1.Controls.Add(acc);
        }
    }
}
