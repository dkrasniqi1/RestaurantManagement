using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Customers : UserControl
    {
        public Customers()
        {
            InitializeComponent();

            displayCustomersData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayCustomersData();

        }

        public void displayCustomersData()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.allCustomerDataData();

            dataGridView1.DataSource = listData;
        }
        private void Customers_Load(object sender, EventArgs e)
        {

        }
    }
}
