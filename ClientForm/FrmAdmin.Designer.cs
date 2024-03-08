using Guna.UI2.WinForms;

namespace ClientForm
{
    partial class FrmAdmin
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
            this.pnlAdmin = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnChangeUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchFlight = new Guna.UI2.WinForms.Guna2Button();
            this.btnInsertUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteFlight = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangeFlight = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateFlight = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.pnlNavbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdmin
            // 
            this.pnlAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAdmin.Location = new System.Drawing.Point(0, 140);
            this.pnlAdmin.Name = "pnlAdmin";
            this.pnlAdmin.Size = new System.Drawing.Size(981, 538);
            this.pnlAdmin.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 69);
            this.panel2.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(828, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 51);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            //this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(51, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 23);
            this.lblName.TabIndex = 0;
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.Controls.Add(this.btnChangeUser);
            this.pnlNavbar.Controls.Add(this.btnSearchFlight);
            this.pnlNavbar.Controls.Add(this.btnInsertUser);
            this.pnlNavbar.Controls.Add(this.btnDeleteFlight);
            this.pnlNavbar.Controls.Add(this.btnChangeFlight);
            this.pnlNavbar.Controls.Add(this.btnCreateFlight);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 69);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(981, 74);
            this.pnlNavbar.TabIndex = 3;
            // 
            // btnChangeUser
            // 
            this.btnChangeUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChangeUser.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnChangeUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnChangeUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeUser.CustomBorderColor = System.Drawing.Color.White;
            this.btnChangeUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnChangeUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeUser.FillColor = System.Drawing.Color.White;
            this.btnChangeUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeUser.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnChangeUser.Location = new System.Drawing.Point(810, 6);
            this.btnChangeUser.Name = "btnChangeUser";
            this.btnChangeUser.Size = new System.Drawing.Size(159, 58);
            this.btnChangeUser.TabIndex = 5;
            this.btnChangeUser.Text = "Change user";
            //this.btnChangeUser.Click += new System.EventHandler(this.btnChangeUser_Click);
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSearchFlight.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSearchFlight.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnSearchFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchFlight.CustomBorderColor = System.Drawing.Color.White;
            this.btnSearchFlight.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnSearchFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchFlight.FillColor = System.Drawing.Color.White;
            this.btnSearchFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSearchFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchFlight.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSearchFlight.Location = new System.Drawing.Point(507, 6);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(160, 58);
            this.btnSearchFlight.TabIndex = 5;
            this.btnSearchFlight.Text = "Search flight";
            //this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInsertUser.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnInsertUser.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnInsertUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertUser.CustomBorderColor = System.Drawing.Color.White;
            this.btnInsertUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnInsertUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertUser.FillColor = System.Drawing.Color.White;
            this.btnInsertUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnInsertUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInsertUser.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnInsertUser.Location = new System.Drawing.Point(670, 6);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(152, 58);
            this.btnInsertUser.TabIndex = 4;
            this.btnInsertUser.Text = "Insert user";
            //this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeleteFlight.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeleteFlight.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDeleteFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteFlight.CustomBorderColor = System.Drawing.Color.White;
            this.btnDeleteFlight.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDeleteFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteFlight.FillColor = System.Drawing.Color.White;
            this.btnDeleteFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDeleteFlight.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDeleteFlight.Location = new System.Drawing.Point(341, 6);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(160, 58);
            this.btnDeleteFlight.TabIndex = 3;
            this.btnDeleteFlight.Text = "Delete flight";
            //this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            // 
            // btnChangeFlight
            // 
            this.btnChangeFlight.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChangeFlight.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnChangeFlight.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnChangeFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeFlight.CustomBorderColor = System.Drawing.Color.White;
            this.btnChangeFlight.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnChangeFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeFlight.FillColor = System.Drawing.Color.White;
            this.btnChangeFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChangeFlight.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnChangeFlight.Location = new System.Drawing.Point(174, 6);
            this.btnChangeFlight.Name = "btnChangeFlight";
            this.btnChangeFlight.Size = new System.Drawing.Size(160, 58);
            this.btnChangeFlight.TabIndex = 2;
            this.btnChangeFlight.Text = "Change flight";
            //this.btnChangeFlight.Click += new System.EventHandler(this.btnChangeFlight_Click);
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCreateFlight.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCreateFlight.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCreateFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFlight.CustomBorderColor = System.Drawing.Color.White;
            this.btnCreateFlight.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnCreateFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateFlight.FillColor = System.Drawing.Color.White;
            this.btnCreateFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateFlight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateFlight.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCreateFlight.Location = new System.Drawing.Point(13, 6);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(160, 58);
            this.btnCreateFlight.TabIndex = 1;
            this.btnCreateFlight.Text = "Create flight";
            //this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 678);
            this.Controls.Add(this.pnlNavbar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlNavbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNavbar;
        private Guna.UI2.WinForms.Guna2Button btnCreateFlight;
        private Guna.UI2.WinForms.Guna2Button btnChangeUser;
        private Guna.UI2.WinForms.Guna2Button btnSearchFlight;
        private Guna.UI2.WinForms.Guna2Button btnInsertUser;
        private Guna.UI2.WinForms.Guna2Button btnDeleteFlight;
        private Guna.UI2.WinForms.Guna2Button btnChangeFlight;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        public Guna2Button BtnCreateFlight { get { return btnCreateFlight; } set { btnCreateFlight = value; } }
        public Guna2Button BtnChangeUser { get { return btnChangeUser; } set { btnChangeUser = value; } }
        public Guna2Button BtnSearchFlight { get { return btnSearchFlight; } set { btnSearchFlight = value; } }
        public Guna2Button BtnInsertUser { get { return btnInsertUser; } set { btnInsertUser = value; } }
        public Guna2Button BtnDeleteFlight { get { return btnDeleteFlight; } set { btnDeleteFlight = value; } }
        public Guna2Button BtnChangeFlight { get { return btnChangeFlight; } set { btnChangeFlight = value; } }
        public Guna2Button BtnLogout { get { return btnLogout; } set { btnLogout = value; } }

    }
}