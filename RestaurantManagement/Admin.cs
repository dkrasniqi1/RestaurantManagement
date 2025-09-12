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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("A jeni i sigurt që dëshironi të dilni?", "Mesazh Konfirmimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("A jeni i sigurt që dëshironi të çkyçeni?", "Mesazh Konfirmimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void addProduct2_Load(object sender, EventArgs e)
        {

        }

      
        private void button1_Click(object sender, EventArgs e)
        {
              dashboard1.Visible = true;
              addUsers1.Visible = false;
              addProduct1.Visible = false;
              customers1.Visible = false;
              stockManagement1.Visible = false;

             Dashboard allForm = dashboard1 as Dashboard;

              if (allForm != null)
              {
                  allForm.refreshData();
              }
          }
        private void button2_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addUsers1.Visible = true;
            addProduct1.Visible = false;
            customers1.Visible = false;
            stockManagement1.Visible = false;

            AddUsers addUsers = addUsers1 as AddUsers;

            if (addUsers != null)
            {
                addUsers.refreshData();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addUsers1.Visible = false;
            addProduct1.Visible = true;
            customers1.Visible = false;
            stockManagement1.Visible = false;

            AddProduct addProduct = addProduct1 as AddProduct;

            if (addProduct != null)
            {
                addProduct.refreshData();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addUsers1.Visible = false;
            addProduct1.Visible = false;
            customers1.Visible = true;
            stockManagement1.Visible = false;

            Customers customers = customers1 as Customers;

            if (customers != null)
            {
                customers.refreshData();
            }
        }

        private void stockBtn_Click_1(object sender, EventArgs e)
        {
            stockManagement1.Visible = true;
            dashboard1.Visible = false;
            addUsers1.Visible = false;
            addProduct1.Visible = false;
            customers1.Visible = false;

            StockManagement stock = stockManagement1 as StockManagement;

            if (stock != null)
            {
                stock.RefreshData();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}