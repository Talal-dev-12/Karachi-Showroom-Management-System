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
    public partial class EditOwnerForm : Form
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
        public EditOwnerForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                string query = "SELECT * FROM CustomerDetails WHERE CID = @Cid";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Cid", txtAID.Text);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtOwnerName.Text = reader["CustomerName"].ToString();
                        txtNIC.Text = reader["CustomerNIC"].ToString();
                        txtPhone.Text = reader["PhoneNo"].ToString();
                        txtVehicle.Text = reader["VehicleName"].ToString();
                        txtEngine.Text = reader["EngineNo"].ToString();
                        txtChasis.Text = reader["ChasisNo"].ToString();
                        txtNoPlat.Text = reader["LicensePlate"].ToString();
                        txtrent.Text = reader["RentFees"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Owner not found.", "Search Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                con.Close();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connString))
            {
                con.Open();
                string updateQuery = @"UPDATE CustomerDetails SET 
                    CustomerName = @name,
                    CustomerNIC = @nic,
                    PhoneNo = @phone,
                    VehicleName = @vehicle,
                    EngineNo = @engine,
                    ChasisNo = @Number,
                    LicensePlate = @plate,
                    RentFees = @fees
                    WHERE AID = @aid";

                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@name", txtOwnerName.Text);
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@vehicle", txtVehicle.Text);
                cmd.Parameters.AddWithValue("@engine", txtEngine.Text);
                cmd.Parameters.AddWithValue("@Number", txtChasis.Text);
                cmd.Parameters.AddWithValue("@plate", txtNoPlat.Text);
                cmd.Parameters.AddWithValue("@fees", txtrent.Text);
                cmd.Parameters.AddWithValue("@aid", txtAID.Text);

                int rows = cmd.ExecuteNonQuery();
                con.Close();

                if (rows > 0)
                {
                    MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EditOwnerForm_Load(object sender, EventArgs e)
        {

        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
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
    }
}
