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
    public partial class Customer : Form
    {
        public Customerr c;
        public User u;
        public DeleteAcC dc;
        public ChangePass cp;
        public LogIn l;
        public UpdateCustomer up;
        public Customer()
        {
            InitializeComponent();
        }
        public Customer(Customerr c,User u,LogIn l)
        {
            this.l = l;
            this.c = c;
            this.u = u;

            InitializeComponent();
            panelMouseC.Height = btnHome.Height;
            l.Hide();
            this.Showinfo();
        }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonLogout.Height;
            panelMouseC.Top = buttonLogout.Top;
            l.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                try
                {
                    string query = "select * from Product where P_Name like'%" + textBoxSearch.Text + "%';";
                    DataTable dt = DBConnection.AllData(query);
                    if (dt.Rows.Count > 1)
                    {
                        //txtID.Text = dt.Rows[0]["ID"].ToString();
                        MessageBox.Show("Your searched item name is "+dt.Rows[0]["P_Name"].ToString()+" and its price " + dt.Rows[0]["P_Price"].ToString(),"Item Found!!",MessageBoxButtons.OK);

                    }
                    else
                    {
                        MessageBox.Show("Your searched item is not found please suggest us", "Not found", MessageBoxButtons.OK);
                    }
                }
                catch(Exception ex)
                {

                }
            }

             else
                MessageBox.Show("Please enter a food menu","Search",MessageBoxButtons.OK);
       }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panelMouseC.Height = btnHome.Height;
            panelMouseC.Top = btnHome.Top;
            this.Showinfo();
        }
        private void PssChange(object sender,EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonChangePass.Height;
            panelMouseC.Top = buttonChangePass.Top;
            ChangePass cp = new ChangePass(c,u);
            //cp = new ChangePass();
            cp.Show();
        }
        private void Showinfo()
        {
            labelName.Text ="\t\tName: "+ c.Name;
            labelID.Text ="\t\tID: "+ c.C_ID.ToString();
            labelPhone.Text ="\t\tContactct Number: "+ c.Phone.ToString();
            labelWC.Text = "WEL COME,";
            labelEmail.Text ="\t\tEmail Address: "+ c.Email.ToString();
            labelAsdress.Text = "\t\tAddress: "+c.Address.ToString();


            labelName.Visible = true;
            labelID.Visible = true;
            labelPhone.Visible = true;
            labelWC.Visible = true;
            labelEmail.Visible = true;
            labelAsdress.Visible = true;
        }
        private void HideInfo()
        {
            labelName.Visible = false;
            labelID.Visible = false;
            labelPhone.Visible = false;
            labelWC.Visible = false;
            labelEmail.Visible = false;
            labelAsdress.Visible = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.HideInfo();
            panelMouseC.Height = buttonUpdate.Height;
            panelMouseC.Top = buttonUpdate.Top;

            //UserInfo d = new UserInfo();
            //d.Dock = DockStyle.Fill;
            //this.panel1.Controls.Clear();
            //this.panel1.Controls.Add(d);
            //d.Show();
            up = new UpdateCustomer(c, u);
            up.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(up);
            up.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonDelete.Height;
            panelMouseC.Top = buttonDelete.Top;
            dc = new DeleteAcC(this,c, u);
            dc.Show();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            this.HideInfo();
            panelMouseC.Height = buttonMenu.Height;
            panelMouseC.Top = buttonMenu.Top;

            MenuAll ma = new MenuAll();
            panel1.Controls.Add(ma);
            ma.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            l.Close();
            this.Close();
        }
    }
}
