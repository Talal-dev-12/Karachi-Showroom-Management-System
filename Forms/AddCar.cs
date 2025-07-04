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
        string Connection_String = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";

        private void LoadVehicleRatesGrid()
        {
            using (MySqlConnection con = new MySqlConnection(Connection_String))
            {
                try
                {
                    con.Open();
                    string query = "SELECT VehicleName, PerDayRate, PerWeekRate, PerMonthRate FROM VehicleRates";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvVehicleRates.DataSource = dt;

                    dgvVehicleRates.ClearSelection(); // Unselect first row

                    // Optional: Rename column headers
                    dgvVehicleRates.Columns[0].HeaderText = "Vehicle";
                    dgvVehicleRates.Columns[1].HeaderText = "Per Day";
                    dgvVehicleRates.Columns[2].HeaderText = "Per Week";
                    dgvVehicleRates.Columns[3].HeaderText = "Per Month";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load vehicle data: " + ex.Message);
                }
            }
        }


        private void AddCar_Load(object sender, EventArgs e)
        {
            LoadVehicleRatesGrid();
            StyleDataGridView();
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
            using (MySqlConnection con = new MySqlConnection(Connection_String))
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
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    if (rows > 0)
                    {
                        MessageBox.Show("Vehicle added successfully!", "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear fields...
                        txtVehicalName.Clear();
                        txtVehicalPerdayrate.Clear();
                        txtVehicalPerWeekrate.Clear();
                        txtVehicalPerMonthrate.Clear();

                        // Refresh grid
                        LoadVehicleRatesGrid();
                    }
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
        private void StyleDataGridView()
        {
            
            dgvVehicleRates.BorderStyle = BorderStyle.None;
            dgvVehicleRates.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvVehicleRates.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVehicleRates.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 51, 73);
            dgvVehicleRates.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvVehicleRates.BackgroundColor = Color.White;
            dgvVehicleRates.DefaultCellStyle.ForeColor = Color.Black;
            dgvVehicleRates.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            // check check
            // Column Header Styles
            dgvVehicleRates.EnableHeadersVisualStyles = false;
            dgvVehicleRates.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvVehicleRates.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            dgvVehicleRates.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVehicleRates.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            dgvVehicleRates.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row Height
            dgvVehicleRates.RowTemplate.Height = 30;

            // Grid lines off (optional)
            dgvVehicleRates.GridColor = Color.LightGray;

            // Auto size columns
            dgvVehicleRates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVehicleRates.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}