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
    public partial class UpdateCustomer : UserControl
    {
        public Customerr cr;
        public User u;
        public UpdateCustomer()
        {
            InitializeComponent();
        }
        public UpdateCustomer(Customerr cr,User u)
        {
            this.cr = cr;
            this.u = u;
            InitializeComponent();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(textBoxAddress.Text!="" || textBoxPhone.Text!="" || txtEmail.Text!="")
            {
                if (textBoxAddress.Text != "")
                    cr.Address = textBoxAddress.Text;
                else { }
                if (textBoxPhone.Text != "")
                    cr.Phone = textBoxPhone.Text;
                else { }
                if (txtEmail.Text != "")
                    cr.Email = txtEmail.Text;
                else { }
                try
                {
                    string query = "Update Customer set C_Email='" + cr.Email + "', C_Phone='" + cr.Phone + "', C_Address='" + cr.Address + "' WHERE C_id='" + cr.C_ID + "';";
                    DBConnection.Execute(query);
                    MessageBox.Show("Updated Customer info for id = " + cr.C_ID);
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
                MessageBox.Show("Must need fill up a info");
            }
        }
    }
}
