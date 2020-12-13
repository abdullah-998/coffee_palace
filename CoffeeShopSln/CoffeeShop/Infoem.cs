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
    public partial class Infoem : UserControl
    {
        public Employeee em;
        public Infoem()
        {
            InitializeComponent();
        }
        public Infoem(Employeee em)
        {
            this.em = em;
            InitializeComponent();
            this.info();
        }
        public void info()
        {
            labelName.Text = "\t\tName: " + em.Name;
            labelID.Text = "\t\tID: " + em.E_Id.ToString();
            labelPhone.Text = "\t\tContact Number: " + em.Phone.ToString();
            labelWC.Text = "WEL COME,";
            labelEmail.Text = "\t\tEmail Address: " + em.Email.ToString();
            labelAsdress.Text = "\t\tAddress: " + em.Address.ToString();
            //labelDOB.Text = "\t\tDOB: " + em.Dob;
            labelDept.Text = "\t\tDepartment: " + em.Dep.D_Id.ToString();
            labelSalary.Text = "\t\tSalary: " + em.Salary.ToString();
            //labelJoinDate.Text = "\t\tJoin Date: " + em.Joindate.ToString();



            //labelJoinDate.Visible = true;
            labelSalary.Visible = true;
            labelDept.Visible = true;
            //labelDOB.Visible = true;
            labelName.Visible = true;
            labelID.Visible = true;
            labelPhone.Visible = true;
            labelWC.Visible = true;
            labelEmail.Visible = true;
            labelAsdress.Visible = true;
        }
    }
}
