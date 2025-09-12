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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace RestaurantManagement
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
        }

        private void loginShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = loginShowPassword.Checked ? '\0' : '*';
        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {

        }
        public bool emptyFields()
        {
            if (loginName.Text == "" || loginPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Të gjitha fushat duhet të plotësohen", "Mesazh Informues", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectAccount = "SELECT COUNT(*)  FROM users WHERE username =@user AND password = @pass AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@user", loginName.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", loginPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            int rowCount = (int)cmd.ExecuteScalar();

                            if (rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM users WHERE username = @usern AND password = @pass";

                                using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                                {
                                    getRole.Parameters.AddWithValue("@usern", loginName.Text.Trim());
                                    getRole.Parameters.AddWithValue("@pass", loginPassword.Text.Trim());

                                    string userRole = getRole.ExecuteScalar() as string;
                                    MessageBox.Show("Kyçja u realizua me sukses!", "Mesazh Informues", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                    if (!string.IsNullOrEmpty(userRole) && userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))

                                    {
                                        try
                                        {
                                            Admin adminForm = new Admin();
                                            adminForm.Show();
                                            this.Hide();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Dështoi hapja e formës për Administratorin: " + ex.Message);
                                        }


                                    }

                                    else if (!string.IsNullOrEmpty(userRole) && userRole.Equals("Cashier", StringComparison.OrdinalIgnoreCase))

                                    {

                                        CashierForm cashierForm = new CashierForm();
                                            cashierForm.Show();
                                            this.Hide();
                                      
                                    }
                                    else
                                    {
                                        MessageBox.Show("Roli i panjohur: " + userRole, "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                
                                MessageBox.Show("Emri i përdoruesit/fjalëkalimi është i pasaktë ose nuk ka aprovimin e administratorit", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lidhja me databazën dështoi: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}