using Guna.UI2.WinForms;

namespace ClientForm
{
    partial class FrmDetailsReservation
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
            this.tboxFlightID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxJMBG = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxNumOfSeats = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdateReservation = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tboxFlightID
            // 
            this.tboxFlightID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxFlightID.DefaultText = "";
            this.tboxFlightID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxFlightID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxFlightID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxFlightID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxFlightID.Enabled = false;
            this.tboxFlightID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxFlightID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxFlightID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxFlightID.Location = new System.Drawing.Point(223, 69);
            this.tboxFlightID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxFlightID.Name = "tboxFlightID";
            this.tboxFlightID.PasswordChar = '\0';
            this.tboxFlightID.PlaceholderText = "";
            this.tboxFlightID.SelectedText = "";
            this.tboxFlightID.Size = new System.Drawing.Size(229, 48);
            this.tboxFlightID.TabIndex = 0;
            // 
            // tboxJMBG
            // 
            this.tboxJMBG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxJMBG.DefaultText = "";
            this.tboxJMBG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxJMBG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxJMBG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxJMBG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxJMBG.Enabled = false;
            this.tboxJMBG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxJMBG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxJMBG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxJMBG.Location = new System.Drawing.Point(223, 160);
            this.tboxJMBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxJMBG.Name = "tboxJMBG";
            this.tboxJMBG.PasswordChar = '\0';
            this.tboxJMBG.PlaceholderText = "";
            this.tboxJMBG.SelectedText = "";
            this.tboxJMBG.Size = new System.Drawing.Size(229, 48);
            this.tboxJMBG.TabIndex = 1;
            // 
            // tboxNumOfSeats
            // 
            this.tboxNumOfSeats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxNumOfSeats.DefaultText = "";
            this.tboxNumOfSeats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxNumOfSeats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxNumOfSeats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNumOfSeats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNumOfSeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNumOfSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxNumOfSeats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNumOfSeats.Location = new System.Drawing.Point(223, 247);
            this.tboxNumOfSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNumOfSeats.Name = "tboxNumOfSeats";
            this.tboxNumOfSeats.PasswordChar = '\0';
            this.tboxNumOfSeats.PlaceholderText = "";
            this.tboxNumOfSeats.SelectedText = "";
            this.tboxNumOfSeats.Size = new System.Drawing.Size(229, 48);
            this.tboxNumOfSeats.TabIndex = 2;
            // 
            // btnUpdateReservation
            // 
            this.btnUpdateReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdateReservation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateReservation.ForeColor = System.Drawing.Color.White;
            this.btnUpdateReservation.Location = new System.Drawing.Point(248, 337);
            this.btnUpdateReservation.Name = "btnUpdateReservation";
            this.btnUpdateReservation.Size = new System.Drawing.Size(180, 45);
            this.btnUpdateReservation.TabIndex = 3;
            this.btnUpdateReservation.Text = "Update reservation";
            // 
            // FrmDetailsReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.btnUpdateReservation);
            this.Controls.Add(this.tboxNumOfSeats);
            this.Controls.Add(this.tboxJMBG);
            this.Controls.Add(this.tboxFlightID);
            this.Name = "FrmDetailsReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDetailsReservation";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tboxFlightID;
        private Guna.UI2.WinForms.Guna2TextBox tboxJMBG;
        private Guna.UI2.WinForms.Guna2TextBox tboxNumOfSeats;
        private Guna2Button btnUpdateReservation;

        public Guna2TextBox TboxFlightID { get { return tboxFlightID; } set { value = tboxFlightID; } }
        public Guna2TextBox TboxJMBG { get { return tboxJMBG; } set { value = tboxJMBG; } }
        public Guna2TextBox TboxNumOfSeats { get { return tboxNumOfSeats; } set { value = tboxNumOfSeats; } }
        public Guna2Button BtnUpdateReservation { get { return btnUpdateReservation; } set { value = btnUpdateReservation; } }
    }
}