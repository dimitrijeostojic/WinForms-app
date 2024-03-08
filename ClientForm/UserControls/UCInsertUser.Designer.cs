using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace ClientForm.UserControls
{
    partial class UCInsertUser
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblJmbg = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.btnInsertUser = new Guna.UI2.WinForms.Guna2Button();
            this.tboxFirstName = new System.Windows.Forms.TextBox();
            this.tboxLastName = new System.Windows.Forms.TextBox();
            this.tboxJmbg = new System.Windows.Forms.TextBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.tboxConfirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFirstName.Location = new System.Drawing.Point(52, 51);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(73, 17);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "First name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(52, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 17);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "Last name";
            // 
            // lblJmbg
            // 
            this.lblJmbg.AutoSize = true;
            this.lblJmbg.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblJmbg.Location = new System.Drawing.Point(52, 263);
            this.lblJmbg.Name = "lblJmbg";
            this.lblJmbg.Size = new System.Drawing.Size(45, 17);
            this.lblJmbg.TabIndex = 8;
            this.lblJmbg.Text = "Jmbg";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUsername.Location = new System.Drawing.Point(424, 51);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 17);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.Location = new System.Drawing.Point(424, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 10;
            this.lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(424, 263);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(126, 17);
            this.lblConfirmPassword.TabIndex = 11;
            this.lblConfirmPassword.Text = "Confirm password";
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertUser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnInsertUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnInsertUser.ForeColor = System.Drawing.Color.White;
            this.btnInsertUser.Location = new System.Drawing.Point(277, 351);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(175, 54);
            this.btnInsertUser.TabIndex = 12;
            this.btnInsertUser.Text = "Insert user";
            //this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // tboxFirstName
            // 
            this.tboxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxFirstName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxFirstName.Location = new System.Drawing.Point(56, 74);
            this.tboxFirstName.Multiline = true;
            this.tboxFirstName.Name = "tboxFirstName";
            this.tboxFirstName.Size = new System.Drawing.Size(256, 38);
            this.tboxFirstName.TabIndex = 13;
            //this.tboxFirstName.TextChanged += new System.EventHandler(this.tboxFirstName_TextChanged_1);
            // 
            // tboxLastName
            // 
            this.tboxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxLastName.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxLastName.Location = new System.Drawing.Point(55, 175);
            this.tboxLastName.Multiline = true;
            this.tboxLastName.Name = "tboxLastName";
            this.tboxLastName.Size = new System.Drawing.Size(256, 38);
            this.tboxLastName.TabIndex = 14;
            //this.tboxLastName.TextChanged += new System.EventHandler(this.tboxLastName_TextChanged_1);
            // 
            // tboxJmbg
            // 
            this.tboxJmbg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxJmbg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxJmbg.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxJmbg.Location = new System.Drawing.Point(55, 283);
            this.tboxJmbg.Multiline = true;
            this.tboxJmbg.Name = "tboxJmbg";
            this.tboxJmbg.Size = new System.Drawing.Size(256, 38);
            this.tboxJmbg.TabIndex = 15;
            //this.tboxJmbg.TextChanged += new System.EventHandler(this.tboxJmbg_TextChanged_1);
            // 
            // tboxUsername
            // 
            this.tboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxUsername.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxUsername.Location = new System.Drawing.Point(427, 74);
            this.tboxUsername.Multiline = true;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(256, 38);
            this.tboxUsername.TabIndex = 16;
            //this.tboxUsername.TextChanged += new System.EventHandler(this.tboxUsername_TextChanged_1);
            // 
            // tboxPassword
            // 
            this.tboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxPassword.Location = new System.Drawing.Point(427, 175);
            this.tboxPassword.Multiline = true;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(256, 38);
            this.tboxPassword.TabIndex = 17;
            //this.tboxPassword.TextChanged += new System.EventHandler(this.tboxPassword_TextChanged_1);
            // 
            // tboxConfirmPassword
            // 
            this.tboxConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.tboxConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxConfirmPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxConfirmPassword.Location = new System.Drawing.Point(427, 283);
            this.tboxConfirmPassword.Multiline = true;
            this.tboxConfirmPassword.Name = "tboxConfirmPassword";
            this.tboxConfirmPassword.Size = new System.Drawing.Size(256, 38);
            this.tboxConfirmPassword.TabIndex = 18;
            //this.tboxConfirmPassword.TextChanged += new System.EventHandler(this.tboxConfirmPassword_TextChanged_1);
            // 
            // UCInsertUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxConfirmPassword);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.tboxJmbg);
            this.Controls.Add(this.tboxLastName);
            this.Controls.Add(this.tboxFirstName);
            this.Controls.Add(this.btnInsertUser);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblJmbg);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UCInsertUser";
            this.Size = new System.Drawing.Size(760, 408);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblJmbg;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button btnInsertUser;
        private System.Windows.Forms.TextBox tboxFirstName;
        private System.Windows.Forms.TextBox tboxLastName;
        private System.Windows.Forms.TextBox tboxJmbg;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.TextBox tboxConfirmPassword;
        public Guna2Button BtnInsertUser { get { return btnInsertUser; } set { value = btnInsertUser; } }
        public TextBox TboxFirstName { get { return tboxFirstName; } set { value = tboxFirstName; } }
        public TextBox TboxLastName { get { return tboxLastName; } set { value = tboxLastName; } }
        public TextBox TboxJmbg { get { return tboxJmbg; } set { value = tboxJmbg; } }
        public TextBox TboxUsername { get { return tboxUsername; } set { value = tboxUsername; } }
        public TextBox TboxPassword { get { return tboxPassword; } set { value = tboxPassword; } }
        public TextBox TboxConfirmPassword { get { return tboxConfirmPassword; } set { value = tboxConfirmPassword; } }
    }
}
