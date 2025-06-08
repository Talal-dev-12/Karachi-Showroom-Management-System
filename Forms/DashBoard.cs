using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karachi_Showroom_System.Forms
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }
        string connString = "server=localhost;user=root;database=karachi_motor_Showroom;port=3307;password=1234;";
        

        private void button1_Click(object sender, EventArgs e)
        {
            AddOwner mainForm = new AddOwner();
            mainForm.Show();
            this.Hide();
        }
        private void LoadOwnerDetails()
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(connString))
                {
                    con.Open();
                    string query = "SELECT AID, OwnerName, OwnerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, NoPlat, RegFees, CreatedAt FROM OwnerDetails ORDER BY AID DESC";
                    using (MySqlDataAdapter da = new MySqlDataAdapter(query, con))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        displayGrid.DataSource = dt;
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayDataOwnersBtn_Click(object sender, EventArgs e)
        {
            LoadOwnerDetails();
        }

        private void EditOwnerBtn_Click(object sender, EventArgs e)
        {
          EditOwnerForm mainForm = new EditOwnerForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteOwner mainForm = new DeleteOwner();
            mainForm.Show();
            this.Hide();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            FindData mainForm = new FindData();
            mainForm.Show();
            this.Hide();
        }
    }
}
