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
    public partial class AllEmployee : UserControl
    {
        public AllEmployee()
        {
            InitializeComponent();
            this.AllEmployeeLoad();
        }
        public void AllEmployeeLoad()
        {
            string query = "select * from Employee";
            DataTable dt = DBConnection.AllData(query);
            dgvAE.AutoGenerateColumns = true;
            dgvAE.DataSource = dt;
        }
    }
}
