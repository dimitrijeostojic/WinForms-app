using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace ClientForm.UserControls
{
    partial class UCReserveFlight
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
            this.btnAddReservation = new Guna.UI2.WinForms.Guna2Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tboxTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSaveAllReservations = new Guna.UI2.WinForms.Guna2Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.tboxNumberOfSeats = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNumOfSeats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddReservation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnAddReservation.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddReservation.ForeColor = System.Drawing.Color.White;
            this.btnAddReservation.Location = new System.Drawing.Point(714, 237);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(230, 48);
            this.btnAddReservation.TabIndex = 16;
            this.btnAddReservation.Text = "Add reservation";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(426, 226);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 16);
            this.lblTo.TabIndex = 15;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(131, 226);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 16);
            this.lblFrom.TabIndex = 14;
            this.lblFrom.Text = "From";
            // 
            // tboxTo
            // 
            this.tboxTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxTo.DefaultText = "";
            this.tboxTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxTo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTo.Location = new System.Drawing.Point(310, 250);
            this.tboxTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTo.Name = "tboxTo";
            this.tboxTo.PasswordChar = '\0';
            this.tboxTo.PlaceholderText = "";
            this.tboxTo.SelectedText = "";
            this.tboxTo.Size = new System.Drawing.Size(256, 35);
            this.tboxTo.TabIndex = 13;
            // 
            // tboxFrom
            // 
            this.tboxFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxFrom.DefaultText = "";
            this.tboxFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxFrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxFrom.Location = new System.Drawing.Point(24, 250);
            this.tboxFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxFrom.Name = "tboxFrom";
            this.tboxFrom.PasswordChar = '\0';
            this.tboxFrom.PlaceholderText = "";
            this.tboxFrom.SelectedText = "";
            this.tboxFrom.Size = new System.Drawing.Size(256, 35);
            this.tboxFrom.TabIndex = 12;
            // 
            // btnSaveAllReservations
            // 
            this.btnSaveAllReservations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAllReservations.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAllReservations.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveAllReservations.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveAllReservations.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveAllReservations.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSaveAllReservations.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveAllReservations.ForeColor = System.Drawing.Color.White;
            this.btnSaveAllReservations.Location = new System.Drawing.Point(620, 530);
            this.btnSaveAllReservations.Name = "btnSaveAllReservations";
            this.btnSaveAllReservations.Size = new System.Drawing.Size(325, 45);
            this.btnSaveAllReservations.TabIndex = 11;
            this.btnSaveAllReservations.Text = "Save all reservations";
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(3, 3);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.Size = new System.Drawing.Size(942, 220);
            this.dgvFlights.TabIndex = 10;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(4, 299);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 51;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(942, 225);
            this.dgvReservations.TabIndex = 17;
            // 
            // tboxNumberOfSeats
            // 
            this.tboxNumberOfSeats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxNumberOfSeats.DefaultText = "";
            this.tboxNumberOfSeats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxNumberOfSeats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxNumberOfSeats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNumberOfSeats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxNumberOfSeats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNumberOfSeats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tboxNumberOfSeats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxNumberOfSeats.Location = new System.Drawing.Point(620, 250);
            this.tboxNumberOfSeats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNumberOfSeats.MaxLength = 1;
            this.tboxNumberOfSeats.Name = "tboxNumberOfSeats";
            this.tboxNumberOfSeats.PasswordChar = '\0';
            this.tboxNumberOfSeats.PlaceholderText = "";
            this.tboxNumberOfSeats.SelectedText = "";
            this.tboxNumberOfSeats.Size = new System.Drawing.Size(71, 35);
            this.tboxNumberOfSeats.TabIndex = 18;
            // 
            // lblNumOfSeats
            // 
            this.lblNumOfSeats.AutoSize = true;
            this.lblNumOfSeats.Location = new System.Drawing.Point(603, 226);
            this.lblNumOfSeats.Name = "lblNumOfSeats";
            this.lblNumOfSeats.Size = new System.Drawing.Size(105, 16);
            this.lblNumOfSeats.TabIndex = 19;
            this.lblNumOfSeats.Text = "Number of seats";
            // 
            // UCReserveFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumOfSeats);
            this.Controls.Add(this.tboxNumberOfSeats);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.tboxTo);
            this.Controls.Add(this.tboxFrom);
            this.Controls.Add(this.btnSaveAllReservations);
            this.Controls.Add(this.dgvFlights);
            this.Name = "UCReserveFlight";
            this.Size = new System.Drawing.Size(949, 578);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAddReservation;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2TextBox tboxTo;
        private Guna.UI2.WinForms.Guna2TextBox tboxFrom;
        private Guna.UI2.WinForms.Guna2Button btnSaveAllReservations;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.DataGridView dgvReservations;
        private Guna2TextBox tboxNumberOfSeats;
        private Label lblNumOfSeats;

        public Guna2Button BtnSaveAllReservations { get { return btnSaveAllReservations; } set { value = btnSaveAllReservations; } }
        public Guna2Button BtnAddReservation { get { return btnAddReservation; } set { value = btnAddReservation; } }
        public Guna2TextBox TboxTo { get { return tboxTo; } set { value = tboxTo; } }
        public Guna2TextBox TboxFrom { get { return tboxFrom; } set { value = tboxFrom; } }
        public Guna2TextBox TboxNumberOfSeats { get { return tboxNumberOfSeats; } set { value = tboxNumberOfSeats; } }
        public DataGridView DgvFlights { get { return dgvFlights; } set { value = dgvFlights; } }
        public DataGridView DgvReservations { get { return dgvReservations; } set { value = dgvReservations; } }
    }
}
