using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class StockManagement : UserControl
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30";

        public StockManagement()
        {
            InitializeComponent();
            SetupStockDataGrid();
            LoadStockData();
        }

        public void RefreshData()
        {
            txtSearch.Text = "";
            LoadStockData("");
        }

        public void LoadStockData(string searchName = "")
        {
            dgvStock.Rows.Clear();

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT * FROM Products WHERE prod_name LIKE @searchName";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@searchName", "%" + searchName + "%");
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int quantity = reader["prod_stock"] != DBNull.Value ? Convert.ToInt32(reader["prod_stock"]) : 0;
                                int sold = reader["quantity_sold"] != DBNull.Value ? Convert.ToInt32(reader["quantity_sold"]) : 0;
                                int remaining = quantity - sold;

                                string status = "Në dispozicion";
                                if (remaining <= 0) status = "Out of Stock";
                                else if (remaining <= 10) status = "Low Stock";

                                dgvStock.Rows.Add(
                                    reader["id"],
                                    reader["prod_name"],
                                    reader["prod_price"],
                                    reader["prod_type"],
                                    quantity,
                                    sold,
                                    remaining,
                                    reader["prod_unit"],
                                    reader["date_insert"],
                                    status
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim gjatë ngarkimit të të dhënave: " + ex.Message);
            }

            ColorRowsByStatus();
        }

        private void ColorRowsByStatus()
        {
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString();
                if (status == "Low Stock")
                    row.DefaultCellStyle.BackColor = Color.Khaki;
                else if (status == "Out of Stock")
                    row.DefaultCellStyle.BackColor = Color.IndianRed;
                else
                    row.DefaultCellStyle.BackColor = Color.Honeydew;
            }
        }

        private void SetupStockDataGrid()
        {
            dgvStock.Columns.Clear();
            dgvStock.Columns.Add("ProductID", "ID");
            dgvStock.Columns["ProductID"].Visible = false;

            dgvStock.Columns.Add("ProductName", "Emri");
            dgvStock.Columns.Add("Price", "Çmimi");
            dgvStock.Columns.Add("Type", "Lloji");
            dgvStock.Columns.Add("Quantity", "Sasia");
            dgvStock.Columns.Add("QuantitySold", "Shitur");
            dgvStock.Columns.Add("QuantityRemaining", "Mbetur");
            dgvStock.Columns.Add("Unit", "Njësia");
            dgvStock.Columns.Add("DateAdded", "Data");
            dgvStock.Columns.Add("Status", "Statusi");

            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.RowTemplate.Height = 35;
            dgvStock.AllowUserToAddRows = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockModuleForm moduleForm = new StockModuleForm();
            moduleForm.mode = "Add";
            moduleForm.ShowDialog();
            LoadStockData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                StockModuleForm moduleForm = new StockModuleForm
                {
                    mode = "Edit",
                    productId = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["ProductID"].Value)
                };

                moduleForm.LoadProductData(moduleForm.productId);
                moduleForm.ShowDialog();
                LoadStockData();
            }
            else
            {
                MessageBox.Show("Zgjidh një produkt për editim.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Fshi produktin?", "Konfirmim", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvStock.SelectedRows[0].Cells["ProductID"].Value);
                    try
                    {
                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE id = @id", connect))
                            {
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        MessageBox.Show("Produkti u fshi.");
                        LoadStockData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gabim gjatë fshirjes: " + ex.Message);
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadStockData(txtSearch.Text.Trim());
        }
    }
}




