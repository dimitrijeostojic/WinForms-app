using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace Common
{
    partial class FrmUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbChangeFlight = new System.Windows.Forms.PictureBox();
            this.pbReserveFlight = new System.Windows.Forms.PictureBox();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnUser = new Guna.UI2.WinForms.Guna2Button();
            this.btnChangeReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnReserveFlight = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlUser = new System.Windows.Forms.Panel();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReserveFlight)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(208, 582);
            this.sidebar.MinimumSize = new System.Drawing.Size(73, 582);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(73, 582);
            this.sidebar.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 103);
            this.panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Transparent;
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.ErrorImage = ((System.Drawing.Image)(resources.GetObject("menuButton.ErrorImage")));
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.Location = new System.Drawing.Point(9, 27);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(59, 39);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMenu.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnMenu.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnMenu.Location = new System.Drawing.Point(9, 27);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(250, 45);
            this.btnMenu.TabIndex = 9;
            this.btnMenu.Text = "Menu";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbLogout);
            this.panel2.Controls.Add(this.pbUser);
            this.panel2.Controls.Add(this.pbChangeFlight);
            this.panel2.Controls.Add(this.pbReserveFlight);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Controls.Add(this.btnChangeReservation);
            this.panel2.Controls.Add(this.btnReserveFlight);
            this.panel2.Location = new System.Drawing.Point(3, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 567);
            this.panel2.TabIndex = 1;
            // 
            // pbLogout
            // 
            this.pbLogout.BackColor = System.Drawing.Color.Transparent;
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbLogout.ErrorImage")));
            this.pbLogout.Image = ((System.Drawing.Image)(resources.GetObject("pbLogout.Image")));
            this.pbLogout.Location = new System.Drawing.Point(9, 271);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(59, 39);
            this.pbLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogout.TabIndex = 8;
            this.pbLogout.TabStop = false;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUser.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbUser.ErrorImage")));
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(9, 188);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(59, 39);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 7;
            this.pbUser.TabStop = false;
            // 
            // pbChangeFlight
            // 
            this.pbChangeFlight.BackColor = System.Drawing.Color.Transparent;
            this.pbChangeFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbChangeFlight.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbChangeFlight.ErrorImage")));
            this.pbChangeFlight.Image = ((System.Drawing.Image)(resources.GetObject("pbChangeFlight.Image")));
            this.pbChangeFlight.Location = new System.Drawing.Point(9, 109);
            this.pbChangeFlight.Name = "pbChangeFlight";
            this.pbChangeFlight.Size = new System.Drawing.Size(59, 39);
            this.pbChangeFlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChangeFlight.TabIndex = 6;
            this.pbChangeFlight.TabStop = false;
            // 
            // pbReserveFlight
            // 
            this.pbReserveFlight.BackColor = System.Drawing.Color.Transparent;
            this.pbReserveFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReserveFlight.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbReserveFlight.ErrorImage")));
            this.pbReserveFlight.Image = ((System.Drawing.Image)(resources.GetObject("pbReserveFlight.Image")));
            this.pbReserveFlight.Location = new System.Drawing.Point(9, 34);
            this.pbReserveFlight.Name = "pbReserveFlight";
            this.pbReserveFlight.Size = new System.Drawing.Size(59, 39);
            this.pbReserveFlight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbReserveFlight.TabIndex = 2;
            this.pbReserveFlight.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLogout.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogout.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(9, 271);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(250, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            // 
            // btnUser
            // 
            this.btnUser.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUser.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnUser.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUser.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnUser.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnUser.Location = new System.Drawing.Point(9, 188);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(250, 45);
            this.btnUser.TabIndex = 4;
            // 
            // btnChangeReservation
            // 
            this.btnChangeReservation.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChangeReservation.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnChangeReservation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnChangeReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeReservation.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnChangeReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnChangeReservation.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangeReservation.ForeColor = System.Drawing.Color.White;
            this.btnChangeReservation.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnChangeReservation.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnChangeReservation.Location = new System.Drawing.Point(9, 109);
            this.btnChangeReservation.Name = "btnChangeReservation";
            this.btnChangeReservation.Size = new System.Drawing.Size(250, 45);
            this.btnChangeReservation.TabIndex = 3;
            this.btnChangeReservation.Text = "Change flight";
            // 
            // btnReserveFlight
            // 
            this.btnReserveFlight.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnReserveFlight.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnReserveFlight.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnReserveFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserveFlight.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnReserveFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReserveFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReserveFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReserveFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReserveFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnReserveFlight.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReserveFlight.ForeColor = System.Drawing.Color.White;
            this.btnReserveFlight.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnReserveFlight.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnReserveFlight.Location = new System.Drawing.Point(9, 34);
            this.btnReserveFlight.Name = "btnReserveFlight";
            this.btnReserveFlight.Size = new System.Drawing.Size(250, 45);
            this.btnReserveFlight.TabIndex = 2;
            this.btnReserveFlight.Text = "Reserve flight";
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Location = new System.Drawing.Point(75, 4);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(949, 578);
            this.pnlUser.TabIndex = 2;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 582);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnlUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChangeFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReserveFlight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox menuButton;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogout;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.PictureBox pbChangeFlight;
        private System.Windows.Forms.PictureBox pbReserveFlight;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnUser;
        private Guna.UI2.WinForms.Guna2Button btnChangeReservation;
        private Guna.UI2.WinForms.Guna2Button btnReserveFlight;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private System.Windows.Forms.Panel pnlUser;

        public FlowLayoutPanel Sidebar { get { return sidebar; } set { value = sidebar; } }
        public Timer SidebarTimer { get { return sidebarTimer; } set { value = sidebarTimer; } }
        public PictureBox MenuButton { get { return menuButton; } set { value = menuButton; } }
        public PictureBox PbLogout { get { return pbLogout; } set { value = pbLogout; } }
        public PictureBox PbUser { get { return pbUser; } set { value = pbUser; } }
        public PictureBox PbChangeFlight { get { return pbChangeFlight; } set { value = pbChangeFlight; } }
        public PictureBox PbReserveFlight { get { return pbReserveFlight; } set { value = pbReserveFlight; } }
        public Guna2Button BtnLogout { get { return btnLogout; } set { value = btnLogout; } }
        public Guna2Button BtnUser { get { return btnUser; } set { value = btnUser; } }
        public Guna2Button BtnChangeReservation { get { return btnChangeReservation; } set { value = btnChangeReservation; } }
        public Guna2Button BtnReserveFlight { get { return btnReserveFlight; } set { value = btnReserveFlight; } }
        public Guna2Button Guna2Button5 { get { return btnMenu; } set { value = btnMenu; } }
        public Panel PnlUser { get { return pnlUser; } set { value = pnlUser; } }
    }
}