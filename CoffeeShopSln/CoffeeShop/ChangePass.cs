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
    public partial class ChangePass : Form
    {
        public Customerr c;
        public Employeee emp;
        public User u;
        public ChangePass()
        {
            InitializeComponent();
        }
        public ChangePass(Customerr c,User u)
        {
            this.c = c;
            this.u = u;
            InitializeComponent();
        }
        public ChangePass(Employeee emp, User u)
        {
            this.emp = emp;
            this.u = u;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               if(u.Password==textBoxPass.Text)
                {
                    string query = "update Log set [Password]='" + textBoxNp.Text + "' where User_id='" + u.User_Id+"';";
                    DBConnection.Execute(query);
                    MessageBox.Show("Successfully Password Changed", "Password changed", MessageBoxButtons.OK);
                }
               else
                {
                    MessageBox.Show("Please enter correct password otherwise,Cancel", "Pssaword not matching", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
