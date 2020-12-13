using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CoffeeShop
{
    public partial class MenuAll : UserControl
    {
        public MenuAll()
        {
            InitializeComponent();
            this.MenuAllLoad();
        }
        public void MenuAllLoad()
        {
            try
            { 
                string query = "select * from Product";
                DataTable dt = DBConnection.AllData(query);
                dgvMenu.AutoGenerateColumns = false;
                dgvMenu.DataSource = dt;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
