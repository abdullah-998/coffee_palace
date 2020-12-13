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
    public partial class OtherStuff: Form
    {
        public Employeee emp;
        public User u;
        public LogIn l;
        public OtherStuff()
        {
            InitializeComponent();
        }
        public OtherStuff(Employeee emp,User u,LogIn l)
        {
            this.l = l;
            this.emp = emp;
            this.u = u;
            InitializeComponent();
            this.ShowInfo();
            panelMouseC.Height = btnHome.Height;
            panelMouseC.Top = btnHome.Top;
            l.Hide();
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.HideInfo();
            panelMouseC.Height = button2.Height;
            panelMouseC.Top = button2.Top;
            ChangePass cp = new ChangePass(emp , u);
            cp.Show() ;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMouseC.Height = btnHome.Height;
            panelMouseC.Top = btnHome.Top;
            this.ShowInfo();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.HideInfo();
            this.Close();
        }
        private void ShowInfo()
        {
            labelName.Text = "\t\tName: " + emp.Name;
            labelID.Text = "\t\tID: " + emp.E_Id.ToString();
            labelPhone.Text = "\t\tContactct Number: " + emp.Phone.ToString();
            labelWC.Text = "WEL COME,";
            labelEmail.Text = "\t\tEmail Address: " + emp.Email.ToString();
            labelAsdress.Text = "\t\tAddress: " + emp.Address.ToString();
            labelDOB.Text = "\t\t DOB: " + emp.Dob;
            labelDept.Text = "\t\tDepartment: " + emp.Dep.D_Name.ToString();
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

        private void buttonPOS_Click(object sender, EventArgs e)
        {
           // panelMouseC.Height = buttonPOS.Height;
            //panelMouseC.Top = buttonPOS.Top;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            l.Close();
            this.Close();
        }
    }
}
