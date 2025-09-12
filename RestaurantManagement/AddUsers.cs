using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.IO;

namespace RestaurantManagement
{
    public partial class AddUsers : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KujtimWeddings\OneDrive\Documents\restaurant.mdf;Integrated Security=True;Connect Timeout=30");
        public AddUsers()
        {
            InitializeComponent();

            displayAddUsersData();
        }
        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayAddUsersData();

        }
        public void displayAddUsersData()
        {
            List<UserData> listData = new UserData().usersListData();
            dataGridView1.DataSource = listData;

        }
        public void clearFields()
        {
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;
            adminAddusers_image.Image = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void AddUsers_Load(object sender, EventArgs e)
        {

        }
        public bool emptyFields()
        {
            if (adminAddUsers_username.Text == "" || adminAddUsers_password.Text == ""
                || adminAddUsers_role.Text == "" || adminAddUsers_status.Text == ""
                || adminAddusers_image.Image == null)
            {
                return true;
            }
            else { return false; }
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Të gjitha fushat duhet të plotësohen.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("A jeni i sigurt që dëshironi të fshini përdoruesin: " + adminAddUsers_username.Text.Trim()
                    + "?", "Mesazh Konfirmimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM users WHERE id=@id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                 cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Përdoruesi u fshi me sukses!", "Mesazh Informues", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                displayAddUsersData();
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

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Të gjitha fushat duhet të plotësohen.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        //check if username existing already
                        string selectUsern = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                        {
                            checkUsern.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                string usern = adminAddUsers_username.Text.Substring(0, 1).ToUpper() + adminAddUsers_username.Text.Substring(1);
                                MessageBox.Show(usern + " është tashmë në përdorim.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users(username, password, profile_image, role, status, date_reg) " +
                                "VALUES(@usern, @pass, @image, @role, @status, @date)";

                                DateTime today = DateTime.Today;

                                string path = Path.Combine(@"C:\Users\KujtimWeddings\OneDrive\Desktop\RestaurantManagement\RestaurantManagement\RestaurantManagement\User_Directory\"
                                + adminAddUsers_username.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }
                                File.Copy(adminAddusers_image.ImageLocation, path, true);

                               

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                    cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();

                                    MessageBox.Show("Përdoruesi u shtua me sukses!", "Mesazh Informues", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    displayAddUsersData();


                                }
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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddUsers_importbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";
                string ImagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath = dialog.FileName;
                    adminAddusers_image.ImageLocation = ImagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gabim: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int id = 0;

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            id = (int)row.Cells[0].Value;
            adminAddUsers_username.Text = row.Cells[1].Value.ToString();
            adminAddUsers_password.Text = row.Cells[2].Value.ToString();
            adminAddUsers_role.Text = row.Cells[3].Value.ToString();
            adminAddUsers_status.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();
            try
            {
                if (imagePath != null)
                {
                    adminAddusers_image.Image = Image.FromFile(imagePath);
                }
                else
                {
                    adminAddusers_image.Image = null;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nuk ka imazh për këtë përdorues.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            
        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Të gjitha fushat duhet të plotësohen.", "Mesazh Gabimi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("A jeni i sigurt që dëshironi të përditësoni përdoruesin: " + adminAddUsers_username.Text.Trim()
                    + "?", "Mesazh Konfirmimi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE users SET username = @usern, password = @pass, role = @role, status = @status WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());

                                cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Përdoruesi u përditësua me sukses!", "Mesazh Informues", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}