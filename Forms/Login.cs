using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Karachi_Showroom_System.Forms
{
    public partial class LoginPage : Form
    {

string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";
    public LoginPage()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username=@username AND Password=@password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());  // ✅ FIXED
                con.Close();

                if (count == 1)
                {
                    MessageBox.Show("Login successful!");
                    DashBoard mainForm = new DashBoard();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }

        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
