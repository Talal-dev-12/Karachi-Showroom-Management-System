using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Karachi_Showroom_System.Forms
{
    public partial class DashBoard : Form
    {
        private Timer delayTimer;
        private Form nextFormToShow;
        Guna.UI2.WinForms.Guna2Elipse elipsee;


        public DashBoard()
        {
           
            InitializeComponent();
            AlignNavLine(DisplayDataOwnersBtn);
            elipsee = new Guna.UI2.WinForms.Guna2Elipse();
            elipsee.TargetControl = this; // Makes the form rounded
            elipsee.BorderRadius = 30;
        }
        private void OpenFormWithDelay(Form form)
        {
            nextFormToShow = form;

            delayTimer = new Timer();
            delayTimer.Interval = 300; // Time Delay 1 Sec
            delayTimer.Tick += DelayTimer_Tick;
            delayTimer.Start();
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            delayTimer.Stop();
            nextFormToShow.Show();
            this.Hide();
        }

        public void AlignNavLine(Button button)
        {
            foreach (var element in panelLeftMenu.Controls)
            {
                if (element is Button)
                {
                    ((Button)element).BackColor = Color.FromArgb(24, 30, 54);
                }
            }
            PnlNav.Height = button.Height;
            PnlNav.Height = button.Height;
            PnlNav.Top = button.Top;
            PnlNav.Left = button.Left;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }

        string connString = "server=localhost;user=root;database=Karachi_motor_Showroom;port=3307;password=1234;";
        

        private void button1_Click(object sender, EventArgs e)
        {
            AlignNavLine((Button)sender);
            AlignNavLine((Button)sender);
            OpenFormWithDelay(new AddOwner());

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
                        DesignCustomerGrid(); // Apply design after loading
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
            AlignNavLine((Button)sender);
            LoadOwnerDetails();
        }

        private void EditOwnerBtn_Click(object sender, EventArgs e)
        {
            AlignNavLine((Button)sender);
            OpenFormWithDelay(new EditOwnerForm());

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AlignNavLine((Button)sender);
            OpenFormWithDelay(new DeleteOwner());
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            AlignNavLine((Button)sender);
            OpenFormWithDelay(new FindData());
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AlignNavLine((Button)sender);
            AddCar addCar = new AddCar();
            addCar.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AlignNavLine((Button)sender);
            OpenFormWithDelay(new LoginPage());
        }
        private void DesignCustomerGrid()
        {
            // Set font and row height
            displayGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            displayGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            displayGrid.RowTemplate.Height = 30;

            // Header style
            displayGrid.EnableHeadersVisualStyles = false;
            displayGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            displayGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            displayGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Row style
            displayGrid.DefaultCellStyle.BackColor = Color.White;
            displayGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            displayGrid .DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue;
            displayGrid .DefaultCellStyle.SelectionForeColor = Color.White;

            // Border style
            displayGrid.BorderStyle = BorderStyle.None;
            displayGrid .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            displayGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Auto size
            displayGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displayGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            displayGrid.MultiSelect = false;

            // ReadOnly
            displayGrid.ReadOnly = true;
        }

        private void displayGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = DateTime.Today;

        }
    }
}
