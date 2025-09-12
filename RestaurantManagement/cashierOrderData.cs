using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    internal class cashierOrderData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        public int CID { get; set; }
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public string ProdType { get; set; }
        public int Qty { get; set; }
        public string Price { get; set; }

        public List<cashierOrderData> ordersListData()
        {
            List<cashierOrderData> listData = new List<cashierOrderData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    int custID = 0;

                    string selectCustData = "SELECT MAX(customer_id) FROM orders";

                    using (SqlCommand getCustData = new SqlCommand(selectCustData, connect))
                    {
                        object result = getCustData.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            int temp = Convert.ToInt32(result);

                            if (temp == 0)
                            {
                                custID = 1;
                            }
                            else
                            {
                                custID = temp;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error Id");
                        }
                    }
                    string selectOrders = "SELECT * FROM orders WHERE customer_id = @customerID ";

                   

                      using (SqlCommand cmd = new SqlCommand(selectOrders, connect))
                      {
                          cmd.Parameters.AddWithValue("@customerID", custID);

                          SqlDataReader reader = cmd.ExecuteReader();
                          
                              while (reader.Read())
                              {
                                  cashierOrderData coData = new cashierOrderData();

                                  coData.CID = (int)reader["customer_id"];
                                  coData.ProdID = Convert.ToInt32(reader["prod_id"]);
                                  coData.ProdName = reader["prod_name"].ToString();
                                  coData.ProdType = reader["prod_type"].ToString();
                                  coData.Qty = (int)reader["qty"];
                                  coData.Price = reader["prod_price"].ToString();

                                  listData.Add(coData);
                              }
                          }
                      
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed:" + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        
                
            
        }
    }
}