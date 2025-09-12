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
    public partial class CashierForm : Form
    {
        public CashierForm()
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
        
        private void dashboardCashier_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addProduct1.Visible = false;
            customers1.Visible = false;
            orderForm1.Visible = false;

            Dashboard dashboard = dashboard1 as Dashboard;

            if (dashboard != null)
            {
                dashboard.refreshData();
            }
        }

        private void addProductsCashier_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addProduct1.Visible = true;
            customers1.Visible = false;
            orderForm1.Visible = false;

            AddProduct addProduct = addProduct1 as AddProduct;

            if (addProduct != null)
            {
                addProduct.refreshData();
            }
        }

        private void orderCashier_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addProduct1.Visible = false;
            customers1.Visible = false;
            orderForm1.Visible = true;

            OrderForm order = orderForm1 as OrderForm;

            if (order != null)
            {
                order.refreshData();
            }
        }

        private void customerCashier_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            addProduct1.Visible = false;
            customers1.Visible = true;
            orderForm1.Visible = false;

            Customers customers = customers1 as Customers;

            if (customers != null)
            {
                customers.refreshData();
            }
        }

        private void logoutCashier_Click_1(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("A jeni i sigurt që dëshironi të çkyçeni?", "Mesazh Konfirmimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();

                this.Hide();
            }
        }
    }
}
