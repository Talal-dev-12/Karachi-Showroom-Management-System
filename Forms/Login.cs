using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Karachi_Showroom_System.Forms
{
    public partial class LoginPage : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
               (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse

               );
                        string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";
    public LoginPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
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

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
