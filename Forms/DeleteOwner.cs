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
    public partial class DeleteOwner : Form
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
        public DeleteOwner()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }
        string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvOwner_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
                if (string.IsNullOrWhiteSpace(txtAID.Text))
                {
                    MessageBox.Show("Please enter Owner ID to delete.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connString = "server=localhost;user=root;database=Karachi_motor_showroom;port=3307;password=1234;";

                    using (MySqlConnection con = new MySqlConnection(connString))
                    {
                        try
                        {
                            con.Open();
                            string query = "DELETE FROM OwnerDetails WHERE AID = @aid";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            cmd.Parameters.AddWithValue("@aid", txtAID.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvOwner.DataSource = null;
                            txtAID.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Owner not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                
            }

        }

        private void DeleteOwner_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
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
        private void LoadOwnerDetails()
        {

            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = "SELECT AID, OwnerName, OwnerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, NoPlat, RegFees, CreatedAt FROM OwnerDetails  WHERE AID = @aid";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOwner.DataSource = dt;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAID.Text))
            {
                MessageBox.Show("Please enter an Owner ID", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT * FROM OwnerDetails WHERE AID = @aid";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@aid", txtAID.Text);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        LoadOwnerDetails();
                    }
                    else
                    {
                        dgvOwner.DataSource = null;
                        MessageBox.Show("Owner not found.", "No Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
