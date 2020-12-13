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
    public partial class DeleteAcC : Form
    {
        public Customer c;
        public Customerr cr;
        public Manager em;
        public Employeee emp;
        public User u;
        public DeleteAcC()
        {
            InitializeComponent();
        }
        public DeleteAcC(Customer c,Customerr cr,User u)
        {
            this.c = c;
            this.cr = cr;
            this.u = u;
            InitializeComponent();
            labelID.Visible = false;
            textBoxId.Visible = false;
        }
        public DeleteAcC(Manager em, Employeee emp, User u)
        {
            this.em = em;
            this.emp = emp;
            this.u = u;
            InitializeComponent();
            labelID.Visible = true;
            textBoxPassword.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string query;
            if (u.Designation==4)
            {
                query = "delete from Log where id='" + u.User_Id + "';";
                DBConnection.Execute(query);
                c.Close();
                this.Close();
            }
            else
            {
                query = "delete from Log where id='" + u.User_Id + "';";
                DBConnection.Execute(query);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
