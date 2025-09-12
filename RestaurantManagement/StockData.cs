using System;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public class StockData
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30";

        public void UpdateStockAfterSale(int prodId, int qtyOrdered)
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    int stock = 0, sold = 0;

                    using (SqlCommand getCmd = new SqlCommand("SELECT prod_stock, quantity_sold FROM Products WHERE id = @id", connect))
                    {
                        getCmd.Parameters.AddWithValue("@id", prodId);
                        using (SqlDataReader reader = getCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                stock = Convert.ToInt32(reader["prod_stock"]);
                                sold = Convert.ToInt32(reader["quantity_sold"]);
                            }
                        }
                    }

                    int newSold = sold + qtyOrdered;
                    string status = "Në dispozicion";
                    if (stock - newSold <= 10) status = "Low Stock";
                    if (stock - newSold <= 0) status = "Out of Stock";

                    using (SqlCommand update = new SqlCommand("UPDATE Products SET quantity_sold = @sold WHERE id = @id", connect))
                    {
                        update.Parameters.AddWithValue("@sold", newSold);
                        update.Parameters.AddWithValue("@id", prodId);
                        update.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Gabim gjatë përditësimit të stokut: " + ex.Message);
            }
        }
    }
}
