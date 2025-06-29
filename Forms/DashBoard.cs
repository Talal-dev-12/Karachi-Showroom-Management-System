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
                    string query = "SELECT CID, CustomerName, CustomerNIC, PhoneNo, VehicleName, EngineNo, ChasisNo, LicensePlate, RentFees, CreatedAt " +
                        "FROM CustomerDetails " +
                        "WHERE IsArchive = 0" +
                        "ORDER BY CID DESC;";
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
            displayGrid.BorderStyle = BorderStyle.None;
            displayGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            displayGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            displayGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 51, 73);
            displayGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            displayGrid.BackgroundColor = Color.White;
            displayGrid.DefaultCellStyle.ForeColor = Color.Black;
            displayGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            // Column Header Styles
            displayGrid.EnableHeadersVisualStyles = false;
            displayGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            displayGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 30, 54);
            displayGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            displayGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);

            // Row Height
            displayGrid.RowTemplate.Height = 30;

            // Grid lines off (optional)
            displayGrid.GridColor = Color.LightGray;

            // Auto size columns
            displayGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            displayGrid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
