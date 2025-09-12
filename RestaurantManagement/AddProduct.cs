using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class AddProduct : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        public AddProduct()
        {
            InitializeComponent();

            displayData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker) refreshData);
                return;
            }
            displayData();
         } 
        public bool emptyFields()
        {
            if (string.IsNullOrWhiteSpace(adminAddProduct.Text) ||
                string.IsNullOrWhiteSpace(adminAddProduct_username.Text) ||
                string.IsNullOrWhiteSpace(adminAddProduct_type.Text) ||
                string.IsNullOrWhiteSpace(adminAddProduct_stock.Text) ||
                string.IsNullOrWhiteSpace(adminAddProduct_price.Text) ||
                string.IsNullOrWhiteSpace(adminAddProduct_status.Text))
            {
                return true;
            }
            return false;
        }

        private void displayData()
        {
            AddProductData prodData = new AddProductData();
            List<AddProductData> listData = prodData.productsListData();

            dataGridView1.DataSource = listData;
        }

        private void adminAddProduct_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Të gjitha fushat duhet të plotësohen.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(adminAddProduct_stock.Text.Trim(), out int stock))
                {
                    MessageBox.Show("Sasia nuk është numër i vlefshëm.");
                    return;
                }

                if (!float.TryParse(adminAddProduct_price.Text.Trim().Replace("€", "").Replace("$", ""), out float price))
                {
                    MessageBox.Show("Çmimi nuk është numër i vlefshëm.");
                    return;
                }

                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        
                        string selectProdID = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand selectPID = new SqlCommand(selectProdID, connect))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", adminAddProduct_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                              
                                MessageBox.Show("ID e produktit" + adminAddProduct_username + "është tashmë në përdorim.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO products (prod_id, prod_name, prod_type, prod_stock, prod_price, prod_status, prod_image,date_insert) " +
                                "VALUES(@prodID, @prodName, @prodType, @prodStock, @prodPrice, @prodStatus, @prodImage, @prodInsert)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\Users\KujtimWeddings\OneDrive\Desktop\RestaurantManagement\RestaurantManagement\RestaurantManagement\Product_Directory\"
                                + adminAddProduct_username.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(adminAddProduct_image.ImageLocation, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", adminAddProduct_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", adminAddProduct.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", adminAddProduct_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", stock);
                                    cmd.Parameters.AddWithValue("@prodPrice", price);
                                    cmd.Parameters.AddWithValue("@prodStatus", adminAddProduct_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage",path);
                                    cmd.Parameters.AddWithValue("@prodInsert",today );

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Produkti u shtua me sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayData();

                             
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lidhja me bazën e të dhënave dështoi: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void adminAddProduct_importbtn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                string ImagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = dialog.FileName;
                    adminAddProduct_image.ImageLocation = ImagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void clearFields()
        {
            adminAddProduct_username.Text = "";
            adminAddProduct.Text = "";
            adminAddProduct_price.Text = "";
            adminAddProduct_stock.Text = "";
            adminAddProduct_status.SelectedIndex = -1;
            adminAddProduct_type.SelectedIndex = -1;
            adminAddProduct_image.Image = null;
        }

        private void adminAddProduct_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                adminAddProduct_username.Text = row.Cells[1].Value.ToString();
                adminAddProduct.Text = row.Cells[2].Value.ToString();
                adminAddProduct_type.Text = row.Cells[3].Value.ToString();
                adminAddProduct_stock.Text = row.Cells[4].Value.ToString();
                adminAddProduct_price.Text = row.Cells[5].Value.ToString();
                adminAddProduct_status.Text = row.Cells[6].Value.ToString();
              
                string imagepath = row.Cells[7].Value.ToString();

                try
                {

                    if (imagepath != null)
                    {
                        adminAddProduct_image.Image = Image.FromFile(imagepath);
                    }
                    else
                    {
                        adminAddProduct_image.Image = null;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gabim gjatë ngarkimit të imazhit: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void adminAddProduct_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!int.TryParse(adminAddProduct_stock.Text.Trim(), out int stock))
                {
                    MessageBox.Show("Sasia nuk është numër i vlefshëm.");
                    return;
                }

                if (!float.TryParse(adminAddProduct_price.Text.Trim().Replace("€", "").Replace("$", ""), out float price))
                {
                    MessageBox.Show("Çmimi nuk është numër i vlefshëm.");
                    return;
                }

                DialogResult check = MessageBox.Show("A jeni i sigurt që dëshironi të përditësoni produktin: " + adminAddProduct.Text.Trim()
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                          connect.Open();

                            string updateData = "UPDATE products SET prod_name = @prodName , prod_type = @prodType, prod_stock = @prodStock," +
                                " prod_price = @prodPrice , prod_status = @prodStatus, date_update = @dateUpdate WHERE prod_id = @prodID";

                            DateTime today = DateTime.Today;

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodName", adminAddProduct.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodType", adminAddProduct_type.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodStock", stock);
                                updateD.Parameters.AddWithValue("@prodPrice", price);
                                updateD.Parameters.AddWithValue("@prodStatus", adminAddProduct_status.Text.Trim());
                                updateD.Parameters.AddWithValue("@dateUpdate", today);
                                updateD.Parameters.AddWithValue("@prodID", adminAddProduct_username.Text.Trim());
                               
                                updateD.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Produkti u përditësua me sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayData();

                            }

                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Lidhja dështoi: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally { connect.Close(); }
                    }
                }

            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void adminAddProduct_deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adminAddProduct_username.Text))
            {
                MessageBox.Show("Ju lutem zgjidhni një produkt për ta fshirë.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmDelete = MessageBox.Show(
                $"A jeni i sigurt që dëshironi të fshini produktin: {adminAddProduct.Text.Trim()}?",
                "Konfirmim Fshirjeje",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmDelete == DialogResult.Yes)
            {
                try
                {
                    if (connect.State == ConnectionState.Closed)
                        connect.Open();

                    string deleteQuery = "UPDATE products SET date_delete = @dateDelete WHERE prod_id = @prodID";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@dateDelete", DateTime.Now);
                        cmd.Parameters.AddWithValue("@prodID", adminAddProduct_username.Text.Trim());

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Produkti u fshi me sukses!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clearFields();
                            displayData();
                        }
                        else
                        {
                            MessageBox.Show("Produkti nuk u gjet për fshirje.", "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ndodhi një gabim gjatë fshirjes së produktit:\n" + ex.Message, "Gabim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
        }
    }
    
}