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
    public partial class AllCustomers : UserControl
    {
        public AllCustomers()
        {
            InitializeComponent();
            this.AllCustomerLoad();
        }
        public void AllCustomerLoad()
        {
            string query = "select * from Customer";
            DataTable dt = DBConnection.AllData(query);
            dgvAC.AutoGenerateColumns = true;
            dgvAC.DataSource = dt;
        }
    }
}
