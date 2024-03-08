using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace ClientForm.UserControls
{
    partial class UCSearchFlight
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
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.tboxFrom = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpDateOfDeparture = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDateOfDeparture = new System.Windows.Forms.Label();
            this.btnDetails = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFlights
            // 
            this.dgvFlights.AllowUserToAddRows = false;
            this.dgvFlights.AllowUserToDeleteRows = false;
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(3, 155);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.ReadOnly = true;
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.Size = new System.Drawing.Size(975, 326);
            this.dgvFlights.TabIndex = 0;
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
            this.tboxFrom.Location = new System.Drawing.Point(155, 76);
            this.tboxFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxFrom.Name = "tboxFrom";
            this.tboxFrom.PasswordChar = '\0';
            this.tboxFrom.PlaceholderText = "";
            this.tboxFrom.SelectedText = "";
            this.tboxFrom.Size = new System.Drawing.Size(189, 48);
            this.tboxFrom.TabIndex = 1;
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
            this.tboxTo.Location = new System.Drawing.Point(396, 76);
            this.tboxTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTo.Name = "tboxTo";
            this.tboxTo.PasswordChar = '\0';
            this.tboxTo.PlaceholderText = "";
            this.tboxTo.SelectedText = "";
            this.tboxTo.Size = new System.Drawing.Size(189, 48);
            this.tboxTo.TabIndex = 2;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(220, 40);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 16);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(474, 40);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 16);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To";
            // 
            // dtpDateOfDeparture
            // 
            this.dtpDateOfDeparture.Checked = true;
            this.dtpDateOfDeparture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDateOfDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDateOfDeparture.Location = new System.Drawing.Point(636, 76);
            this.dtpDateOfDeparture.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDateOfDeparture.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDateOfDeparture.Name = "dtpDateOfDeparture";
            this.dtpDateOfDeparture.Size = new System.Drawing.Size(209, 48);
            this.dtpDateOfDeparture.TabIndex = 5;
            this.dtpDateOfDeparture.Value = new System.DateTime(2024, 2, 7, 15, 12, 29, 162);
            // 
            // lblDateOfDeparture
            // 
            this.lblDateOfDeparture.AutoSize = true;
            this.lblDateOfDeparture.Location = new System.Drawing.Point(682, 40);
            this.lblDateOfDeparture.Name = "lblDateOfDeparture";
            this.lblDateOfDeparture.Size = new System.Drawing.Size(111, 16);
            this.lblDateOfDeparture.TabIndex = 6;
            this.lblDateOfDeparture.Text = "Date of departure";
            // 
            // btnDetails
            // 
            this.btnDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(396, 487);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(189, 48);
            this.btnDetails.TabIndex = 7;
            this.btnDetails.Text = "Detalji";
            // 
            // UCSearchFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.lblDateOfDeparture);
            this.Controls.Add(this.dtpDateOfDeparture);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.tboxTo);
            this.Controls.Add(this.tboxFrom);
            this.Controls.Add(this.dgvFlights);
            this.Name = "UCSearchFlight";
            this.Size = new System.Drawing.Size(981, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFlights;
        private Guna.UI2.WinForms.Guna2TextBox tboxFrom;
        private Guna.UI2.WinForms.Guna2TextBox tboxTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDateOfDeparture;
        private System.Windows.Forms.Label lblDateOfDeparture;
        private Guna2Button btnDetails;

        public DataGridView DgvFlights { get { return dgvFlights; } set { value = dgvFlights; } }
        public Guna2TextBox TboxFrom { get { return tboxFrom; } set { value = tboxFrom; } }
        public Guna2TextBox TboxTo { get { return tboxTo; } set { value = tboxTo; } }
        public Guna2DateTimePicker DtpDateOfDeparture { get { return dtpDateOfDeparture; } set { value = dtpDateOfDeparture; } }
        public Guna2Button BtnDetails { get { return btnDetails; } set { value = btnDetails; } }
    }
}
