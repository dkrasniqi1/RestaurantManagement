using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    internal class UserData
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }

        public string Image {  get; set; }
        public string DateRegistered { get; set; }

        public List<UserData> usersListData()
        {
            List<UserData> listData = new List<UserData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string selectData = "Select * FROM users";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read()) {
                            UserData userData = new UserData();
                            userData.Id = (int)reader["Id"];
                            userData.UserName = reader["username"].ToString();
                            userData.Password = reader["password"].ToString();
                            userData.Role = reader["role"].ToString();
                            userData.Status = reader["status"].ToString();
                            userData.Image = reader["profile_image"].ToString();
                            userData.DateRegistered = reader["date_reg"].ToString();

                            listData.Add(userData);
                        } 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed" + ex);
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