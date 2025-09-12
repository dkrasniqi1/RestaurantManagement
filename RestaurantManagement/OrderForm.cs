using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;



namespace RestaurantManagement
{
    public partial class OrderForm : UserControl
    {
        public static int getCustID;
       

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        private int idGen = 0;
        private float totalPrice;
        private int getOrderID = 0;
        private int rowIndex = 0;
        public OrderForm()
        {
            InitializeComponent();

            orderProductName.ReadOnly = true;
            orderProductPrice.ReadOnly = true;
            orderPayPrice.ReadOnly = true;
            orderChange.ReadOnly = true;

            IDGenerator();

            displayAvailableProds();

            displayAllOrders();

            displayTotalPrice();
            
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAvailableProds();

            displayAllOrders();

            displayTotalPrice();

           
        }
        void UpdateProductStock(string prodId, int qtyOrdered)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                // Merr sasinë aktuale të shitjeve dhe stokun
                SqlCommand getCmd = new SqlCommand("SELECT prod_stock, quantity_sold FROM products WHERE prod_id = @id", connect);
                getCmd.Parameters.AddWithValue("@id", prodId);
                SqlDataReader reader = getCmd.ExecuteReader();

                int currentSold = 0 ;
                int stock = 0;
                if (reader.Read())
                {
                    stock = Convert.ToInt32(reader["prod_stock"]);
                    currentSold = Convert.ToInt32(reader["quantity_sold"]);
                }
                reader.Close();

                int newSold = currentSold + qtyOrdered;
                int remaining = stock - qtyOrdered;

                string status = "Available";
                if (remaining <= 10) status = "Low Stock";
                if (remaining <= 0) status = "Out of Stock";

                // Përditëso të dhënat në products
                SqlCommand updateCmd = new SqlCommand(
                  "UPDATE products SET quantity_sold = @sold, prod_stock = @remaining, prod_status = @status WHERE prod_id = @id", connect);
                updateCmd.Parameters.AddWithValue("@sold", newSold);
                updateCmd.Parameters.AddWithValue("@remaining", remaining);
                updateCmd.Parameters.AddWithValue("@status", status);
                updateCmd.Parameters.AddWithValue("@id", prodId);


                updateCmd.ExecuteNonQuery();
            }
            finally
            {
                connect.Close();
            }
        }
        public void displayAvailableProds()
        {
            OrderData allProds = new OrderData();
            List<OrderData> listData = allProds.availableProductsData();
            Order_menu.DataSource = listData;
        }

        public void displayAllOrders()
        {
            cashierOrderData allOrders = new cashierOrderData();
            List<cashierOrderData> listData = allOrders.ordersListData();
            cashierOrder_Table.DataSource = listData;
        }
        private void label12_Click(object sender, EventArgs e)
        {

        }
        public void displayTotalPrice()
        {
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custId";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@custId", idGen);
                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            orderPayPrice.Text = totalPrice.ToString("0.00");
                        }
                        else
                        {
                            orderPayPrice.Text = "0.00";
                            totalPrice = 0;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lidhja dështoi: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        private void orderRemoveBtn_Click(object sender, EventArgs e)
        {
            if (getOrderID == 0)
            {
                MessageBox.Show("Ju lutem zgjidhni produktin fillimisht!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("A jeni i sigurt që dëshironi të fshini ID e porosis?: " + getOrderID + "?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", getOrderID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("U fshi me sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lidhja dështoi: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }

            displayAllOrders();
            displayTotalPrice();
        }
        

        private void orderAddBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (string.IsNullOrWhiteSpace(orderType.Text) || string.IsNullOrWhiteSpace(orderProdId.Text) ||
                string.IsNullOrWhiteSpace(orderProductName.Text) || orderQuality.Value == 0 ||
                string.IsNullOrWhiteSpace(orderProductPrice.Text))
            {
                MessageBox.Show("Ju lutem zgjidhni produktin fillimisht!");
                return;
            }

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    float getPrice = 0;

                    string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";
                    using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                    {
                        getOrder.Parameters.AddWithValue("@prodID", orderProdId.Text.Trim());

                        using (SqlDataReader reader = getOrder.ExecuteReader())
                        {
                            if (reader.Read() && reader["prod_price"] != DBNull.Value)
                            {
                                getPrice = Convert.ToSingle(reader["prod_price"]);
                            }
                        }
                    }

                    float totalItemPrice = getPrice * (int)orderQuality.Value;

                    string insertOrders = "INSERT INTO orders (customer_id, prod_id, prod_name, prod_type, qty, prod_price, order_date) " +
                                          "VALUES (@customerID, @prodID, @prodName, @prodType, @qty, @prodPrice, @orderDate)";

                    DateTime today = DateTime.Today;

                    using (SqlCommand cmd = new SqlCommand(insertOrders, connect))
                    {
                        cmd.Parameters.AddWithValue("@customerID", idGen);
                        cmd.Parameters.AddWithValue("@prodID", orderProdId.Text.Trim());
                        cmd.Parameters.AddWithValue("@prodName", orderProductName.Text);
                        cmd.Parameters.AddWithValue("@prodType", orderType.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", orderQuality.Value);
                        cmd.Parameters.AddWithValue("@prodPrice", totalItemPrice);
                        cmd.Parameters.AddWithValue("@orderDate", today);

                        cmd.ExecuteNonQuery();
                        StockData stock = new StockData();
                        UpdateProductStock(orderProdId.Text.Trim(), (int)orderQuality.Value);
                    }

                    displayAllOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lidhja dështoi: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
                displayTotalPrice();
        } 
       
        
         
        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                connect.Open();
                string selectID = "SELECT MAX(customer_id) FROM customers";
                using (SqlCommand cmd = new SqlCommand(selectID, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if(result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
                getCustID = idGen;
            }
            
            }

        private void orderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderProdId.SelectedIndex = -1;
            orderProdId.Items.Clear();
            orderProductName.Text = "";
            orderProductPrice.Text = "";




            string selectedValue = orderType.SelectedItem as string;


            if (selectedValue != null)
            {

                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_type = '{selectedValue}' AND prod_status =@status AND date_delete IS NULL";


                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    orderProdId.Items.Add(value);
                                }
                            }
                        }
                    }

                }

                catch (Exception exx)
                {
                    MessageBox.Show("Gabim:" + exx, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void orderProdId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = orderProdId.SelectedItem as string;
            if (selectedValue != null)
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();

                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND prod_status =@status AND date_delete IS NULL";


                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    orderProductName.Text = prodName;
                                    orderProductPrice.Text = prodPrice;
                                }
                            }
                        }
                    }

                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
            }
        
        private void Order_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderQuality_ValueChanged(object sender, EventArgs e)
        {

        }

        private void orderAmountText_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void orderAmountText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(orderAmountText.Text);
                    float getChange = getAmount - totalPrice;

                    if (getChange < 0)
                    {
                        orderChange.Text = "";
                        MessageBox.Show("Shuma nuk është e mjaftueshme!");
                    }
                    else
                    {
                        orderChange.Text = getChange.ToString("0.00");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Shumë e pavlefshme");
                    orderAmountText.Text = "";
                    orderChange.Text = "";
                }
            }
        }

        private void orderPayBtn_Click(object sender, EventArgs e)
        {
            if (orderAmountText.Text == "" || cashierOrder_Table.Rows.Count == 0)
            {
                MessageBox.Show("Diçka shkoi keq.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (MessageBox.Show("A jeni i sigurt që dëshironi të kryeni pagesën?", "Confirmation Message"
                      , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            IDGenerator();                           
                            string insertData = "INSERT INTO customers (customer_id, total_price , amount , change , date) " +
                                "VALUES (@custID, @totalprice , @amount , @change , @date) ";

                            DateTime today = DateTime.Today;
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", orderAmountText.Text);
                                cmd.Parameters.AddWithValue("@change", orderChange.Text);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Pagesa u krye me sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            } 
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Lidhja dështoi.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { connect.Close(); }
                    }
                }
            }
            displayTotalPrice();
        }
      

        private void orderReceiptBtn_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printDocument1.BeginPrint += new PrintEventHandler(printDocument1_BeginPrint);

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            displayTotalPrice();

            float y = 0;
            int count = 0;
            int colWidth = 120;
            int headerMargin = 10;      
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            string headerText = "Restaurant";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left + (cashierOrder_Table.Columns.Count / 2) * colWidth, y, alignCenter); ;

            count++;
            y += tableMargin;

            string[] header = { "CID" ,"ProdID","ProdName", "ProdType", "Qty", "Price"};

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            while (rowIndex < cashierOrder_Table.Rows.Count)
            {
                DataGridViewRow row = cashierOrder_Table.Rows[rowIndex];

                for (int i = 0; i < cashierOrder_Table.Rows.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font , Brushes.Black , e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                if(y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);
             DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("- - - - - - - - - - - - - - - - - - - - - - - - - - -", labelFont).Width;

            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Totali:\t$" + totalPrice + "\nShuma e dhënë: \t$" + orderAmountText.Text + "\n\t\t- - - - - - -- - -\nChange:\t$" + Change.Text, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("- - - - - - - - - - - - - - - - - - - - - - - - - - -", labelFont).Width, y);


        }
        public void clearFields()
        {
            orderType.SelectedIndex = -1;
            orderProdId.SelectedIndex = -1;
            orderProductName.Text = "";
            orderProductPrice.Text = "";
            orderQuality.Value = 0;
            orderAmountText.Text = "";
            orderChange.Text = "";
        }

        
        private void orderClearBtn_Click(object sender, EventArgs e)
        {
           
            clearFields();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cashierOrder_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        
        private void cashierOrder_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = cashierOrder_Table.Rows[e.RowIndex];
                getOrderID = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void Order_menu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Order_menu.Rows[e.RowIndex];

                
                orderProdId.Text = row.Cells["ProductID"].Value.ToString();
                orderProductName.Text = row.Cells["ProductName"].Value.ToString();
                orderProductPrice.Text = row.Cells["Price"].Value.ToString();
                orderType.Text = row.Cells["Type"].Value.ToString();
            }
        }

        private void Order_menu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}