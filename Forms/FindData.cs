using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karachi_Showroom_System.Forms
{
    public partial class FindData : Form
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
        public FindData()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

            string connString = "server=localhost;user=root;database=Karachi_motor_Showroom;port=3307;password=1234;";
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void FindData_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            string name = txtOwnerName.Text.Trim();
            string phone = txtPhoneNo.Text.Trim();

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();

                    // Select only specific columns
                    string query = @"SELECT CID, CustomerName, CustomerNIC, PhoneNo, 
                           VehicleName, EngineNo, ChasisNo, LicensePlate, RentFees, CreatedAt
                           FROM CustomerDetails WHERE IsArchive = 0";

                    if (!string.IsNullOrEmpty(name))
                        query += " AND CustomerName LIKE @name";
                    if (!string.IsNullOrEmpty(phone))
                        query += " AND PhoneNo LIKE @phone";

                    query += " ORDER BY CID DESC";  // Added sorting

                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(name))
                            cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                        if (!string.IsNullOrEmpty(phone))
                            cmd.Parameters.AddWithValue("@phone", "%" + phone + "%");

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvOwnerDetails.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
