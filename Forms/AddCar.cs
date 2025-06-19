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
    public partial class AddCar : Form
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
        public AddCar()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";

        private void AddCar_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            string name = txtVehicalName.Text.Trim();
            decimal perDay, perWeek, perMonth;

            // Input validation
            if (string.IsNullOrWhiteSpace(name) ||
                !decimal.TryParse(txtVehicalPerdayrate.Text, out perDay) ||
                !decimal.TryParse(txtVehicalPerWeekrate.Text, out perWeek) ||
                !decimal.TryParse(txtVehicalPerMonthrate.Text, out perMonth))
            {
                MessageBox.Show("Please enter valid data in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Database insert
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                string query = "INSERT INTO VehicleRates (VehicleName, PerDayRate, PerWeekRate, PerMonthRate) VALUES (@name, @perDay, @perWeek, @perMonth)";
                MySqlCommand cmd = new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@perDay", perDay);
                cmd.Parameters.AddWithValue("@perWeek", perWeek);
                cmd.Parameters.AddWithValue("@perMonth", perMonth);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Vehicle Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear input fields
                    txtVehicalName.Clear();
                    txtVehicalPerdayrate.Clear();
                    txtVehicalPerWeekrate.Clear();
                    txtVehicalPerMonthrate.Clear();
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1062)
                        MessageBox.Show("Vehicle already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                        MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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
    }
}