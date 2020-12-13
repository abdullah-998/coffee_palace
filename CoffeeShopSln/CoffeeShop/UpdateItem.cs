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
    public partial class UpdateItem: UserControl
    {
        public Product p;
       
        public UpdateItem()
        {
            InitializeComponent();
        }
        

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if((txtItname.Text!="" || textItPrice.Text!="") && (textITID.Text!=""))
            {
                p = new Product();
                if(txtItname.Text!="")
                     p.P_Name = txtItname.Text;
                else
                {

                }
                if(textItPrice.Text!="")
                    p.P_Price = Help.ToDouble(textItPrice.Text);
                else
                {

                }
                p.P_ID = Help.ToInt(textITID.Text);
                try
                {
                    string query = "Update Product set P_Name='" + p.P_Name + "', P_Price='" + p.P_Price + "' WHERE P_id='" + p.P_ID + "';";
                    DBConnection.Execute(query);
                    MessageBox.Show("Succsefully updated item for id =" + p.P_ID);
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
                MessageBox.Show("Please insert all values");
            }
        }
    }
}
