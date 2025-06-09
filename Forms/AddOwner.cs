using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Karachi_Showroom_System.Forms
{
    public partial class AddOwner : Form
    {
        public AddOwner()
        {
            InitializeComponent();
        }
            string Connection_String = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            using (MySqlConnection con = new MySqlConnection(Connection_String))
            {
                try
                {
                    string query = @"INSERT INTO OwnerDetails 
        (OwnerName, OwnerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, NoPlat, RegFees)
        VALUES 
        (@OwnerName, @OwnerNIC, @PhoneNo, @VehicleName, @EngineNo, @ChasisNo, @NoPlat, @RegFees)";

                    MySqlCommand cmd = new MySqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@OwnerName", txtOwnerName.Text);
                    cmd.Parameters.AddWithValue("@OwnerNIC", txtNIC.Text);
                    cmd.Parameters.AddWithValue("@PhoneNo", txtPhone.Text);
                    cmd.Parameters.AddWithValue("@VehicleName", txtVehicleName.Text);
                    cmd.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text);
                    cmd.Parameters.AddWithValue("@ChasisNo", txtChasisNo.Text);
                    cmd.Parameters.AddWithValue("@NoPlat", txtNoPlate.Text);
                    cmd.Parameters.AddWithValue("@RegFees", Convert.ToInt32(txtRegFees.Text));

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Owner added successfully!");
                        txtOwnerName.Clear();
                        txtNIC.Clear();
                        txtPhone.Clear();
                        txtVehicleName.Clear();
                        txtEngineNo.Clear();
                        txtChasisNo.Clear();
                        txtNoPlate.Clear();
                        txtRegFees.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add owner.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void AddOwner_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Close();
        }
    }
}
