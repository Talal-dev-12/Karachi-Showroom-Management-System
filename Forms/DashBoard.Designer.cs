namespace Karachi_Showroom_System.Forms
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.DisplayLbl = new System.Windows.Forms.Label();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DisplayDataOwnersBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EditOwnerBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.displayGrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnExit = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelLeftMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayLbl
            // 
            this.DisplayLbl.AutoSize = true;
            this.DisplayLbl.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLbl.Location = new System.Drawing.Point(758, 90);
            this.DisplayLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DisplayLbl.Name = "DisplayLbl";
            this.DisplayLbl.Size = new System.Drawing.Size(0, 42);
            this.DisplayLbl.TabIndex = 3;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelLeftMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeftMenu.Controls.Add(this.btnBack);
            this.panelLeftMenu.Controls.Add(this.button4);
            this.panelLeftMenu.Controls.Add(this.btnDelete);
            this.panelLeftMenu.Controls.Add(this.EditOwnerBtn);
            this.panelLeftMenu.Controls.Add(this.SearchBtn);
            this.panelLeftMenu.Controls.Add(this.PnlNav);
            this.panelLeftMenu.Controls.Add(this.DisplayDataOwnersBtn);
            this.panelLeftMenu.Controls.Add(this.button1);
            this.panelLeftMenu.Controls.Add(this.panel2);
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(194, 568);
            this.panelLeftMenu.TabIndex = 17;
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 130);
            this.PnlNav.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnBack.Image = global::Karachi_Showroom_System.Properties.Resources.Logout_Icon;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(0, 503);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(35, 0, 20, 0);
            this.btnBack.Size = new System.Drawing.Size(192, 55);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Logout";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoSize = true;
            this.SearchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.SearchBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.SearchBtn.Image = global::Karachi_Showroom_System.Properties.Resources.Search_Icon_46_px;
            this.SearchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchBtn.Location = new System.Drawing.Point(0, 275);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Padding = new System.Windows.Forms.Padding(13, 0, 20, 0);
            this.SearchBtn.Size = new System.Drawing.Size(192, 54);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search Data";
            this.SearchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // DisplayDataOwnersBtn
            // 
            this.DisplayDataOwnersBtn.AutoSize = true;
            this.DisplayDataOwnersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.DisplayDataOwnersBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DisplayDataOwnersBtn.FlatAppearance.BorderSize = 0;
            this.DisplayDataOwnersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayDataOwnersBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayDataOwnersBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.DisplayDataOwnersBtn.Image = global::Karachi_Showroom_System.Properties.Resources.Load_Icon;
            this.DisplayDataOwnersBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DisplayDataOwnersBtn.Location = new System.Drawing.Point(0, 219);
            this.DisplayDataOwnersBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DisplayDataOwnersBtn.Name = "DisplayDataOwnersBtn";
            this.DisplayDataOwnersBtn.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.DisplayDataOwnersBtn.Size = new System.Drawing.Size(192, 56);
            this.DisplayDataOwnersBtn.TabIndex = 1;
            this.DisplayDataOwnersBtn.Text = "Load Data";
            this.DisplayDataOwnersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisplayDataOwnersBtn.UseVisualStyleBackColor = false;
            this.DisplayDataOwnersBtn.Click += new System.EventHandler(this.DisplayDataOwnersBtn_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::Karachi_Showroom_System.Properties.Resources.Add_Icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.button1.Size = new System.Drawing.Size(192, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Customer";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDelete.Image = global::Karachi_Showroom_System.Properties.Resources.Remove_Icon;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.Location = new System.Drawing.Point(0, 393);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.btnDelete.Size = new System.Drawing.Size(192, 56);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Remove ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.Location = new System.Drawing.Point(0, 449);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.button4.Size = new System.Drawing.Size(192, 54);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add Car";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // EditOwnerBtn
            // 
            this.EditOwnerBtn.AutoSize = true;
            this.EditOwnerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.EditOwnerBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditOwnerBtn.FlatAppearance.BorderSize = 0;
            this.EditOwnerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOwnerBtn.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditOwnerBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.EditOwnerBtn.Image = global::Karachi_Showroom_System.Properties.Resources.Edit;
            this.EditOwnerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EditOwnerBtn.Location = new System.Drawing.Point(0, 329);
            this.EditOwnerBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditOwnerBtn.Name = "EditOwnerBtn";
            this.EditOwnerBtn.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.EditOwnerBtn.Size = new System.Drawing.Size(192, 64);
            this.EditOwnerBtn.TabIndex = 1;
            this.EditOwnerBtn.Text = "Edit Record";
            this.EditOwnerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditOwnerBtn.UseVisualStyleBackColor = false;
            this.EditOwnerBtn.Click += new System.EventHandler(this.EditOwnerBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2DateTimePicker1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 163);
            this.panel2.TabIndex = 0;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(3, 0);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(188, 36);
            this.guna2DateTimePicker1.TabIndex = 1;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 6, 29, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(43, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Karachi_Showroom_System.Properties.Resources.Usernme_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(54, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // displayGrid
            // 
            this.displayGrid.AllowUserToAddRows = false;
            this.displayGrid.AllowUserToDeleteRows = false;
            this.displayGrid.AllowUserToOrderColumns = true;
            this.displayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGrid.Location = new System.Drawing.Point(203, 118);
            this.displayGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.displayGrid.Name = "displayGrid";
            this.displayGrid.ReadOnly = true;
            this.displayGrid.RowHeadersWidth = 82;
            this.displayGrid.RowTemplate.Height = 33;
            this.displayGrid.Size = new System.Drawing.Size(1063, 386);
            this.displayGrid.TabIndex = 1;
            this.displayGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displayGrid_CellContentClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(194, 513);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 2, 3);
            this.label9.Size = new System.Drawing.Size(1083, 55);
            this.label9.TabIndex = 23;
            this.label9.Text = "DBMS LAB PROJECT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Poppins", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1083, 111);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BtnExit.FillColor = System.Drawing.Color.Transparent;
            this.BtnExit.Image = global::Karachi_Showroom_System.Properties.Resources.Exit;
            this.BtnExit.ImageRotate = 0F;
            this.BtnExit.Location = new System.Drawing.Point(1027, 0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnExit.Size = new System.Drawing.Size(53, 56);
            this.BtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnExit.TabIndex = 1;
            this.BtnExit.TabStop = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.BtnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(194, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1083, 110);
            this.panel1.TabIndex = 18;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1277, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.DisplayLbl);
            this.Controls.Add(this.displayGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karachi Showroom Management System";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLeftMenu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisplayDataOwnersBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EditOwnerBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label DisplayLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.DataGridView displayGrid;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox BtnExit;
        private System.Windows.Forms.Panel panel1;
    }
}