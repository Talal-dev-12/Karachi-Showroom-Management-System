using MySql.Data.MySqlClient;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Karachi_Showroom_System.Forms
{
    public partial class AddOwner : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
                                                        int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        string Connection_String = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";

        public AddOwner()
        {
            InitializeComponent();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void AddOwner_Load(object sender, EventArgs e)
        {
            LoadVehicleNames();
            cmbVehicleName.SelectedIndexChanged += cmbVehicleName_SelectedIndexChanged;

        }
        decimal ratePerDay = 0, ratePerWeek = 0, ratePerMonth = 0;

        private void cmbVehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVehicleName.SelectedIndex <= 0)
            {
                rdoPerDay.Enabled = rdoPerWeek.Enabled = rdoPerMonth.Enabled = false;
                rdoPerDay.Text = "Per Day: Rs 0";
                rdoPerWeek.Text = "Per Week: Rs 0";
                rdoPerMonth.Text = "Per Month: Rs 0";
                return;
            }

            using (MySqlConnection con = new MySqlConnection(Connection_String))
            {
                try
                {
                    con.Open();
                    string query = "SELECT PerDayRate, PerWeekRate, PerMonthRate FROM VehicleRates WHERE VehicleName = @VehicleName";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@VehicleName", cmbVehicleName.Text);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ratePerDay = reader.GetDecimal("PerDayRate");
                            ratePerWeek = reader.GetDecimal("PerWeekRate");
                            ratePerMonth = reader.GetDecimal("PerMonthRate");

                            // 🛠️ Properly display updated text
                            rdoPerDay.Text = $"Per Day: Rs {ratePerDay:N0}";
                            rdoPerWeek.Text = $"Per Week: Rs {ratePerWeek:N0}";
                            rdoPerMonth.Text = $"Per Month: Rs {ratePerMonth:N0}";

                            rdoPerDay.Enabled = rdoPerWeek.Enabled = rdoPerMonth.Enabled = true;

                            // Reset radio buttons
                            rdoPerDay.Checked = false;
                            rdoPerWeek.Checked = false;
                            rdoPerMonth.Checked = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching vehicle rates:\n" + ex.Message);
                }
            }
        }

        private void LoadVehicleNames()
        {
            using (MySqlConnection con = new MySqlConnection(Connection_String))
            {
                try
                {
                    con.Open();
                    string query = "SELECT VehicleName FROM VehicleRates ORDER BY VehicleName ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbVehicleName.Items.Clear();
                    cmbVehicleName.Items.Add("Select Vehicle ▼"); // 👈 Placeholder item

                    while (reader.Read())
                    {
                        cmbVehicleName.Items.Add(reader["VehicleName"].ToString());
                    }

                    cmbVehicleName.SelectedIndex = 0; // 👈 Set default item

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load vehicle list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
        }
        private void Exit_Click(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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

                    
        private void guna2Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOwnerName.Text) ||
                            string.IsNullOrWhiteSpace(txtNIC.Text) ||
                          string.IsNullOrWhiteSpace(txtPhone.Text) ||
                       string.IsNullOrWhiteSpace(txtEngineNo.Text) ||
                       string.IsNullOrWhiteSpace(txtChasisNo.Text) ||
                    string.IsNullOrWhiteSpace(txtNoPlate.Text))
            {
                MessageBox.Show("Please fill out all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbVehicleName.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a valid vehicle.");
                return;
            }

            using (MySqlConnection con = new MySqlConnection(Connection_String))
            {
                try
                {
                    decimal selectedRent = 0;
                    string selectedPlan = "";

                    if (rdoPerDay.Checked)
                    {
                        selectedRent = ratePerDay;
                        selectedPlan = "1 Day";
                    }
                    else if (rdoPerWeek.Checked)
                    {
                        selectedRent = ratePerWeek;
                        selectedPlan = "1 Week";
                    }
                    else if (rdoPerMonth.Checked)
                    {
                        selectedRent = ratePerMonth;
                        selectedPlan = "1 Month";
                    }
                    else
                    {
                        MessageBox.Show("Please select a rent plan.");
                        return;
                    }

                    // Combine rent + plan in a string like "1 Week : 4500 Rs"
                    string rentFeesFormatted = $"{selectedPlan} : {selectedRent} Rs";

                    string query = @"INSERT INTO CustomerDetails 
(CustomerName, CustomerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, LicensePlate, RentFees)
VALUES 
(@OwnerName, @OwnerNIC, @PhoneNo, @VehicleName, @EngineNo, @ChasisNo, @NoPlat, @RentFees)";

                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@OwnerNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@VehicleName", cmbVehicleName.Text);
                    cmd.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text);
                    cmd.Parameters.AddWithValue("@ChasisNo", txtChasisNo.Text);
                    cmd.Parameters.AddWithValue("@NoPlat", txtNoPlate.Text);
                    cmd.Parameters.AddWithValue("@RentFees", rentFeesFormatted); // <- Save full string
                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Customer added successfully!");
                        txtOwnerName.Clear();
                        txtNIC.Clear();
                        txtPhone.Clear();
                        cmbVehicleName.SelectedIndex = 0;
                        txtEngineNo.Clear();
                        txtChasisNo.Clear();
                        txtNoPlate.Clear();
                        rdoPerDay.Checked = false;
                        rdoPerWeek.Checked = false;
                        rdoPerMonth.Checked = false;

                        rdoPerDay.Text = "Per Day: Rs 0";
                        rdoPerWeek.Text = "Per Week: Rs 0";
                        rdoPerMonth.Text = "Per Month: Rs 0";

                        rdoPerDay.Enabled = rdoPerWeek.Enabled = rdoPerMonth.Enabled = false;

                    }
                    else
                    {
                        MessageBox.Show("Failed to add Customer.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void BtnTest_Click(object sender, EventArgs e)
        {
            if (rdoPerDay.Checked) MessageBox.Show("Per Day selected");
            if (rdoPerWeek.Checked) MessageBox.Show("Per Week selected");
            if (rdoPerMonth.Checked) MessageBox.Show("Per Month selected");
        }
    }
}
