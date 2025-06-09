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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.EditOwnerBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.DisplayDataOwnersBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.displayGrid = new System.Windows.Forms.DataGridView();
            this.DisplayLbl = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.SearchBtn);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.EditOwnerBtn);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 889);
            this.panel1.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Navy;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.SearchBtn.Location = new System.Drawing.Point(12, 443);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(231, 68);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search Owner Specifically";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(12, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(231, 68);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Remove Owner";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // EditOwnerBtn
            // 
            this.EditOwnerBtn.BackColor = System.Drawing.Color.Navy;
            this.EditOwnerBtn.FlatAppearance.BorderSize = 0;
            this.EditOwnerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOwnerBtn.ForeColor = System.Drawing.Color.White;
            this.EditOwnerBtn.Location = new System.Drawing.Point(12, 267);
            this.EditOwnerBtn.Name = "EditOwnerBtn";
            this.EditOwnerBtn.Size = new System.Drawing.Size(231, 68);
            this.EditOwnerBtn.TabIndex = 1;
            this.EditOwnerBtn.Text = "Edit Owner";
            this.EditOwnerBtn.UseVisualStyleBackColor = false;
            this.EditOwnerBtn.Click += new System.EventHandler(this.EditOwnerBtn_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Navy;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 174);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 68);
            this.button4.TabIndex = 1;
            this.button4.Text = "Add Car";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Owner";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayDataOwnersBtn
            // 
            this.DisplayDataOwnersBtn.BackColor = System.Drawing.Color.Navy;
            this.DisplayDataOwnersBtn.FlatAppearance.BorderSize = 0;
            this.DisplayDataOwnersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayDataOwnersBtn.ForeColor = System.Drawing.Color.White;
            this.DisplayDataOwnersBtn.Location = new System.Drawing.Point(1184, 864);
            this.DisplayDataOwnersBtn.Name = "DisplayDataOwnersBtn";
            this.DisplayDataOwnersBtn.Size = new System.Drawing.Size(231, 68);
            this.DisplayDataOwnersBtn.TabIndex = 1;
            this.DisplayDataOwnersBtn.Text = "Load Data Of Owners";
            this.DisplayDataOwnersBtn.UseVisualStyleBackColor = false;
            this.DisplayDataOwnersBtn.Click += new System.EventHandler(this.DisplayDataOwnersBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Exit);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1478, 133);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(529, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // displayGrid
            // 
            this.displayGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displayGrid.Location = new System.Drawing.Point(341, 210);
            this.displayGrid.Name = "displayGrid";
            this.displayGrid.RowHeadersWidth = 82;
            this.displayGrid.RowTemplate.Height = 33;
            this.displayGrid.Size = new System.Drawing.Size(1074, 631);
            this.displayGrid.TabIndex = 1;
            // 
            // DisplayLbl
            // 
            this.DisplayLbl.AutoSize = true;
            this.DisplayLbl.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLbl.Location = new System.Drawing.Point(529, 166);
            this.DisplayLbl.Name = "DisplayLbl";
            this.DisplayLbl.Size = new System.Drawing.Size(0, 84);
            this.DisplayLbl.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 815);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(231, 62);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Logout";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.White;
            this.Exit.Image = global::Karachi_Showroom_System.Properties.Resources.cross_235;
            this.Exit.Location = new System.Drawing.Point(1365, 11);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 77);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 15;
            this.Exit.TabStop = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 1021);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayLbl);
            this.Controls.Add(this.displayGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DisplayDataOwnersBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Karachi Showroom Management System";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DisplayDataOwnersBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EditOwnerBtn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView displayGrid;
        private System.Windows.Forms.Label DisplayLbl;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox Exit;
    }
}