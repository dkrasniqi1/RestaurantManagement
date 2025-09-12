using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace RestaurantManagement
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");

        public RegisterForm() 
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void registerShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
            registerConfirmPassword.PasswordChar = registerShowPassword.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (registerName.Text == "" || registerPassword.Text == "" || registerConfirmPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Të gjitha fushat duhet të plotësohen.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(connect.State == ConnectionState.Closed) {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT * FROM users WHERE username =@usern";

                        using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", registerName.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = registerName.Text.Substring(0, 1).ToUpper() + registerName.Text.Substring(1);
                                MessageBox.Show(usern + " është tashmë i/e përdorur.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (registerPassword.Text != registerConfirmPassword.Text)
                            {
                                MessageBox.Show("Fjalëkalimi nuk përputhet.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (registerPassword.Text.Length < 8)
                            {
                                MessageBox.Show("Fjalëkalimi është i pavlefshëm – kërkohen të paktën 8 karaktere.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username, password, profile_image, role, status, date_reg) " +
                    "VALUES(@user, @pass, @profile_image, @role, @status, @date)";


                                DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@user", registerName.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", registerPassword.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", "Cashier");
                                cmd.Parameters.AddWithValue("@status", "Approval");
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Regjistrimi u realizua me sukses!", "Mesazh Informues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();



                                }
                        }
                    }
                }
                 catch(Exception ex) 
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

        private void registerName_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
