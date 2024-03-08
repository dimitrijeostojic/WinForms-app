using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace ClientForm.UserControls
{
    partial class UCChangeUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.tboxJmbg = new System.Windows.Forms.TextBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateUser = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(41, 87);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.Size = new System.Drawing.Size(907, 271);
            this.dgvUsers.TabIndex = 0;
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxFirstName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxFirstName.Location = new System.Drawing.Point(38, 383);
            this.tboxFirstName.Multiline = true;
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(256, 38);
            this.tboxFirstName.TabIndex = 14;
            //this.tboxFirstName.TextChanged += new System.EventHandler(this.tboxFirstName_TextChanged);
            // 
            // tboxLastName
            // 
            this.tboxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxLastName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxLastName.Location = new System.Drawing.Point(38, 454);
            this.tboxLastName.Multiline = true;
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(256, 38);
            this.tboxLastName.TabIndex = 15;
            //this.tboxLastName.TextChanged += new System.EventHandler(this.tboxLastName_TextChanged);
            // 
            // tboxJmbg
            // 
            this.tboxJmbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxJmbg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxJmbg.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxJmbg.Location = new System.Drawing.Point(319, 27);
            this.tboxJmbg.Multiline = true;
            this.tboxJmbg.Name = "tboxJmbg";
            this.tboxJmbg.Size = new System.Drawing.Size(256, 38);
            this.tboxJmbg.TabIndex = 16;
            //this.tboxJmbg.TextChanged += new System.EventHandler(this.tboxJmbg_TextChanged);
            // 
            // tboxUsername
            // 
            this.tboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxUsername.Location = new System.Drawing.Point(673, 385);
            this.tboxUsername.Multiline = true;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(256, 38);
            this.tboxUsername.TabIndex = 17;
            //this.tboxUsername.TextChanged += new System.EventHandler(this.tboxUsername_TextChanged);
            // 
            // tboxPassword
            // 
            this.tboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxPassword.Location = new System.Drawing.Point(362, 385);
            this.tboxPassword.Multiline = true;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(256, 38);
            this.tboxPassword.TabIndex = 18;
            //this.tboxPassword.TextChanged += new System.EventHandler(this.tboxPassword_TextChanged);
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxConfirmPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxConfirmPassword.Location = new System.Drawing.Point(362, 454);
            this.tboxConfirmPassword.Multiline = true;
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(256, 38);
            this.tboxConfirmPassword.TabIndex = 19;
            //this.tboxConfirmPassword.TextChanged += new System.EventHandler(this.tboxConfirmPassword_TextChanged);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 361);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(69, 16);
            this.lblFirstName.TabIndex = 20;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(38, 435);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(69, 16);
            this.lblLastName.TabIndex = 21;
            this.lblLastName.Text = "Last name";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Location = new System.Drawing.Point(256, 37);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(41, 16);
            this.lblJmbg.TabIndex = 22;
            this.lblJmbg.Text = "Jmbg";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(670, 363);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(70, 16);
            this.lblUsername.TabIndex = 23;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(359, 366);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 24;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(359, 435);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(114, 16);
            this.lblConfirmPassword.TabIndex = 25;
            this.lblConfirmPassword.Text = "Confirm password";
            // 
            // btnSelect
            // 
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(673, 27);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(180, 45);
            this.btnSelect.TabIndex = 26;
            this.btnSelect.Text = "Select user";
            //this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(709, 447);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateUser.TabIndex = 27;
            this.btnUpdateUser.Text = "Update user";
            //this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // UCChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tboxConfirmPassword);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.tboxJmbg);
            this.Controls.Add(this.tboxLastName);
            this.Controls.Add(this.tboxFirstName);
            this.Controls.Add(this.dgvUsers);
            this.Name = "UCChangeUser";
            this.Size = new System.Drawing.Size(981, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.TextBox tboxJmbg;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxConfirmPassword;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private Guna.UI2.WinForms.Guna2Button btnUpdateUser;

        public DataGridView DgvUsers { get { return dgvUsers; } set {value= dgvUsers; } }
        public Guna2Button BtnUpdateUser { get { return btnUpdateUser; } set {value=btnUpdateUser;} }
        public Guna2Button BtnSelect { get { return btnSelect; } set {value= btnSelect; } }
        public TextBox TboxFirstName { get { return tboxFirstName; } set {value= tboxFirstName; } }
        public TextBox TboxLastName { get { return tboxLastName; } set {value= tboxLastName; } }
        public TextBox TboxJmbg { get { return tboxJmbg; } set {value= tboxJmbg; } }
        public TextBox TboxUsername { get { return tboxUsername; } set {value= tboxUsername; } }
        public TextBox TboxPassword { get { return tboxPassword; } set {value= tboxPassword; } }
        public TextBox TboxConfirmPassword { get { return tboxConfirmPassword; } set {value= tboxConfirmPassword; } }
    }
}
