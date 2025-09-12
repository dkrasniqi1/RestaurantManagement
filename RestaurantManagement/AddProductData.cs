using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    internal class AddProductData
    {
        public int ID { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Stock { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }
        
        public List<AddProductData> productsListData()
        {
            List<AddProductData> listData = new List<AddProductData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Available");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AddProductData apd = new AddProductData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();
                            apd.Image = reader["prod_image"].ToString();
                            apd.DateInsert = reader["date_insert"].ToString();
                            apd.DateUpdate = reader["date_update"].ToString();

                            listData.Add(apd);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed connection" + ex);

                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        } 
        public string DateInsert { get; set; }
        public string DateUpdate { get; set; }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");

        public List<AddProductData> availableProductsData()
        {
            List<AddProductData> listData = new List<AddProductData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM products  WHERE status = @status";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Available");

                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()) {

                            AddProductData apd = new AddProductData();


                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.Type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                           
                           
                            listData.Add(apd);
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Failed Connection:" + ex);
                }
                finally { connect.Close(); }
            }
            return listData;
        }
    }
}