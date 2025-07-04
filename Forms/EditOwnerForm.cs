using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Engines;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Karachi_Showroom_System.Forms
{
    public partial class EditOwnerForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect,
                                                        int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";
        decimal ratePerDay = 0, ratePerWeek = 0, ratePerMonth = 0;

        public EditOwnerForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
           
        }
        private void LoadVehicleNames()
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT VehicleName FROM VehicleRates ORDER BY VehicleName ASC";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbVehicleName.Items.Clear();
                    cmbVehicleName.Items.Add("Select Vehicle ▼"); // Placeholder item

                    while (reader.Read())
                    {
                        cmbVehicleName.Items.Add(reader["VehicleName"].ToString());
                    }

                    cmbVehicleName.SelectedIndex = 0; // Default selection
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load vehicle list: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


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

            using (MySqlConnection con = new MySqlConnection(connString))
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

                            rdoPerDay.Text = $"Per Day: Rs {ratePerDay:N0}";
                            rdoPerWeek.Text = $"Per Week: Rs {ratePerWeek:N0}";
                            rdoPerMonth.Text = $"Per Month: Rs {ratePerMonth:N0}";

                            rdoPerDay.Enabled = rdoPerWeek.Enabled = rdoPerMonth.Enabled = true;

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





        private void SearchBtn_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                string query = "SELECT * FROM CustomerDetails WHERE IsArchive = 0 AND  CID = @Cid";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Cid", txtAID.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtOwnerName.Text = reader["CustomerName"].ToString();
                        txtNIC.Text = reader["CustomerNIC"].ToString();
                        txtPhone.Text = reader["PhoneNo"].ToString();
                        txtEngineNo.Text = reader["EngineNo"].ToString();
                        txtChasisNo.Text = reader["ChasisNo"].ToString();
                        txtNoPlate.Text = reader["LicensePlate"].ToString();
                        string rentFees = reader["RentFees"].ToString();

                        string vehicleFromDB = reader["VehicleName"].ToString().Trim();

                        int index = cmbVehicleName.FindStringExact(vehicleFromDB);
                        if (index != -1)
                        {
                            cmbVehicleName.SelectedIndex = index;
                        }
                        else
                        {
                            MessageBox.Show("Vehicle from record not found in dropdown.");
                            cmbVehicleName.SelectedIndex = 0;
                        }

                        // Extract selected plan from the RentFees column (e.g., "1 Week : 12500 Rs" => "1 Week")
                        if (rentFees.StartsWith("1 Day")) rdoPerDay.Checked = true;
                        else if (rentFees.StartsWith("1 Week")) rdoPerWeek.Checked = true;
                        else if (rentFees.StartsWith("1 Month")) rdoPerMonth.Checked = true;
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOwnerName.Text) ||
               string.IsNullOrWhiteSpace(txtNIC.Text) ||
               string.IsNullOrWhiteSpace(txtPhone.Text) ||
               string.IsNullOrWhiteSpace(txtEngineNo.Text) ||
               string.IsNullOrWhiteSpace(txtChasisNo.Text) ||
               string.IsNullOrWhiteSpace(txtNoPlate.Text) ||
               cmbVehicleName.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill out all fields and select a vehicle.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal selectedRent = 0;
            string selectedPlan = "";

            if (rdoPerDay.Checked) { selectedRent = ratePerDay; selectedPlan = "1 Day"; }
            else if (rdoPerWeek.Checked) { selectedRent = ratePerWeek; selectedPlan = "1 Week"; }
            else if (rdoPerMonth.Checked) { selectedRent = ratePerMonth; selectedPlan = "1 Month"; }
            else
            {
                MessageBox.Show("Please select a rent plan.");
                return;
            }

            string rentFeesFormatted = $"{selectedPlan} : {selectedRent} Rs";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                string updateQuery = @"UPDATE CustomerDetails SET 
                    CustomerName = @name,
                    CustomerNIC = @nic,
                    PhoneNo = @phone,
                    VehicleName = @vehicle,
                    EngineNo = @engine,
                    ChasisNo = @chasis,
                    LicensePlate = @plate,
                    RentFees = @fees
                    WHERE CID = @cid";

                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@name", txtOwnerName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@vehicle", cmbVehicleName.Text);
                cmd.Parameters.AddWithValue("@engine", txtEngineNo.Text);
                cmd.Parameters.AddWithValue("@chasis", txtChasisNo.Text);
                cmd.Parameters.AddWithValue("@plate", txtNoPlate.Text);
                cmd.Parameters.AddWithValue("@fees", rentFeesFormatted);
                cmd.Parameters.AddWithValue("@cid", txtAID.Text);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                { 
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAID.Clear();
                txtOwnerName.Clear();
                txtNIC.Clear();
                txtPhone.Clear();
                cmbVehicleName.SelectedIndex = 0;
                txtEngineNo.Text = "";
                txtChasisNo.Text = "";
                txtNoPlate.Text = "";

                rdoPerDay.Checked = false;
                rdoPerWeek.Checked = false;
                rdoPerMonth.Checked = false;

                rdoPerDay.Text = "Per Day: ₨ 0";
                rdoPerWeek.Text = "Per Week: ₨ 0";
                rdoPerMonth.Text = "Per Month: ₨ 0";
                rdoPerDay.Enabled = rdoPerWeek.Enabled = rdoPerMonth.Enabled = false; }
                else
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditOwnerForm_Load(object sender, EventArgs e)
        {
            LoadVehicleNames();
            cmbVehicleName.SelectedIndexChanged += cmbVehicleName_SelectedIndexChanged;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new DashBoard().Show();
            this.Close();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
