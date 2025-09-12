using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class StockModuleForm : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30";
        public string mode = "Add";
        public int productId;

        public StockModuleForm()
        {
            InitializeComponent();
            InitializeDropdowns();
        }

        private void InitializeDropdowns()
        {
            cmbType.Items.AddRange(new string[] { "Pije", "Ushqim", "Embëlsirë", "Sallatë", "Antipastë" });
            txtUnit.Items.AddRange(new string[] { "Copë", "Kg", "Litra", "Gram", "Paketë" });
            cmbType.SelectedIndex = -1;
            txtUnit.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtPrice.Text) || string.IsNullOrWhiteSpace(cmbType.Text) ||
                 string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Plotëso të dhënat.");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Çmimi jo valid.");
                return;
            }

            string checkQuery = mode == "Add"
                ? "SELECT COUNT(*) FROM Products WHERE prod_name = @name"
                : "SELECT COUNT(*) FROM Products WHERE prod_name = @name AND id != @id";

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connect))
                {
                    checkCmd.Parameters.AddWithValue("@name", txtProductName.Text.Trim());
                    if (mode == "Edit") checkCmd.Parameters.AddWithValue("@id", productId);
                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Produkti ekziston.");
                        return;
                    }
                }

                string query = mode == "Add"
                    ? @"INSERT INTO Products (prod_name, prod_price, prod_type, prod_stock, quantity_sold, prod_unit, prod_image, date_insert) 
                        VALUES (@name, @price, @type, @stock, 0, @unit, @image, @date)"
                    : @"UPDATE Products SET prod_name=@name, prod_price=@price, prod_type=@type, 
                         prod_stock=@stock, prod_unit=@unit, prod_image=@image, date_insert=@date WHERE id=@id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                   
                    cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@type", cmbType.Text);
                    cmd.Parameters.AddWithValue("@stock", (int)numQuantity.Value);
                    cmd.Parameters.AddWithValue("@unit", txtUnit.Text);
                    cmd.Parameters.AddWithValue("@date", dtpDateAdded.Value);

                    if (!string.IsNullOrEmpty(productImage.Tag?.ToString()))
                    {
                        cmd.Parameters.AddWithValue("@image", productImage.Tag.ToString()); // ruaj path-in si string
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@image", DBNull.Value);
                    }
                    if (mode == "Edit") cmd.Parameters.AddWithValue("@id", productId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Produkti u ruajt me sukses!");
            this.Close();
        }

        public void LoadProductData(int id)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Products WHERE id = @id", connect))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtProductName.Text = reader["prod_name"].ToString();
                                txtPrice.Text = reader["prod_price"].ToString();
                                cmbType.Text = reader["prod_type"].ToString();
                                numQuantity.Value = Convert.ToInt32(reader["prod_stock"]);
                                txtUnit.Text = reader["prod_unit"].ToString();
                                dtpDateAdded.Value = Convert.ToDateTime(reader["date_insert"]);

                                if (reader["prod_image"] != DBNull.Value)
                                {
                                    string imgPath = reader["prod_image"].ToString();
                                    if (File.Exists(imgPath))
                                    {
                                        productImage.Image = Image.FromFile(imgPath);
                                        productImage.Tag = imgPath; 
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë ngarkimit: " + ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                productImage.Image = Image.FromFile(open.FileName);
                productImage.Tag = open.FileName; 
            }
        }
    }
}
