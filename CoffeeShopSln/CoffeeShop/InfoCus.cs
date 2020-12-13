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
    public partial class InfoCus : UserControl
    {
        public Customerr cr;
        public InfoCus()
        {
            InitializeComponent();
        }
        public InfoCus(Customerr cr)
        {
            this.cr = cr;
            InitializeComponent();
            this.Info();
        }
        public void Info()
        {
            labelName.Text = "\t\tName: " + cr.Name;
            labelID.Text = "\t\tID: " + cr.C_ID.ToString();
            labelPhone.Text = "\t\tContact Number: " + cr.Phone.ToString();
            labelWC.Text = "WEL COME,";
            labelEmail.Text = "\t\tEmail Address: " + cr.Email.ToString();
            labelAsdress.Text = "\t\tAddress: " + cr.Address.ToString();


            labelName.Visible = true;
            labelID.Visible = true;
            labelPhone.Visible = true;
            labelWC.Visible = true;
            labelEmail.Visible = true;
            labelAsdress.Visible = true;
        }
    }
}
