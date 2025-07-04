using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Karachi_Showroom_System.Forms
{
    public partial class LoginPage : Form
    {
            string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";

    public LoginPage()
        {
            InitializeComponent();
            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
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

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnLogin.PerformClick();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUsername;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
