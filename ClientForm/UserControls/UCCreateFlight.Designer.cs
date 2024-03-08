using Guna.UI2.WinForms;

namespace ClientForm.UserControls
{
    partial class UCCreateFlight
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
            this.lblDepartureAirport = new System.Windows.Forms.Label();
            this.lblArrivalAirport = new System.Windows.Forms.Label();
            this.tboxTicketPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.lblPlane = new System.Windows.Forms.Label();
            this.btnCreateFlight = new Guna.UI2.WinForms.Guna2Button();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.dtDepartureDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtDepartureTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.dtArrivalTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.cboxPlane = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboxDepartureAirport = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboxArrivalAirport = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.dtArrivalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDepartureAirport
            // 
            this.lblDepartureAirport.AutoSize = true;
            this.lblDepartureAirport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartureAirport.Location = new System.Drawing.Point(8, 92);
            this.lblDepartureAirport.Name = "lblDepartureAirport";
            this.lblDepartureAirport.Size = new System.Drawing.Size(136, 20);
            this.lblDepartureAirport.TabIndex = 7;
            this.lblDepartureAirport.Text = "Departure airport";
            // 
            // lblArrivalAirport
            // 
            this.lblArrivalAirport.AutoSize = true;
            this.lblArrivalAirport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrivalAirport.Location = new System.Drawing.Point(18, 178);
            this.lblArrivalAirport.Name = "lblArrivalAirport";
            this.lblArrivalAirport.Size = new System.Drawing.Size(108, 20);
            this.lblArrivalAirport.TabIndex = 8;
            this.lblArrivalAirport.Text = "Arrival airport";
            // 
            // tboxTicketPrice
            // 
            this.tboxTicketPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tboxTicketPrice.DefaultText = "";
            this.tboxTicketPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tboxTicketPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tboxTicketPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxTicketPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tboxTicketPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTicketPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxTicketPrice.ForeColor = System.Drawing.Color.Black;
            this.tboxTicketPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTicketPrice.Location = new System.Drawing.Point(158, 357);
            this.tboxTicketPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTicketPrice.Name = "tboxTicketPrice";
            this.tboxTicketPrice.PasswordChar = '\0';
            this.tboxTicketPrice.PlaceholderText = "";
            this.tboxTicketPrice.SelectedText = "";
            this.tboxTicketPrice.Size = new System.Drawing.Size(301, 48);
            this.tboxTicketPrice.TabIndex = 12;
            //this.tboxTicketPrice.TextChanged += new System.EventHandler(this.tboxTicketPrice_TextChanged);
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTicketPrice.Location = new System.Drawing.Point(34, 370);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(92, 20);
            this.lblTicketPrice.TabIndex = 16;
            this.lblTicketPrice.Text = "Ticket price";
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlane.Location = new System.Drawing.Point(57, 266);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(50, 20);
            this.lblPlane.TabIndex = 17;
            this.lblPlane.Text = "Plane";
            // 
            // btnCreateFlight
            // 
            this.btnCreateFlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnCreateFlight.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCreateFlight.ForeColor = System.Drawing.Color.White;
            this.btnCreateFlight.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateFlight.Location = new System.Drawing.Point(380, 464);
            this.btnCreateFlight.Name = "btnCreateFlight";
            this.btnCreateFlight.Size = new System.Drawing.Size(282, 48);
            this.btnCreateFlight.TabIndex = 18;
            this.btnCreateFlight.Text = "Create flight";
            //this.btnCreateFlight.Click += new System.EventHandler(this.btnCreateFlight_Click);
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartureDate.Location = new System.Drawing.Point(490, 92);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(120, 20);
            this.lblDepartureDate.TabIndex = 24;
            this.lblDepartureDate.Text = "DepartureDate";
            // 
            // dtDepartureDate
            // 
            this.dtDepartureDate.Checked = true;
            this.dtDepartureDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtDepartureDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtDepartureDate.ForeColor = System.Drawing.Color.White;
            this.dtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDepartureDate.Location = new System.Drawing.Point(633, 78);
            this.dtDepartureDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDepartureDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDepartureDate.Name = "dtDepartureDate";
            this.dtDepartureDate.Size = new System.Drawing.Size(301, 48);
            this.dtDepartureDate.TabIndex = 23;
            this.dtDepartureDate.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // dtDepartureTime
            // 
            this.dtDepartureTime.Checked = true;
            this.dtDepartureTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtDepartureTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtDepartureTime.ForeColor = System.Drawing.Color.White;
            this.dtDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDepartureTime.Location = new System.Drawing.Point(633, 260);
            this.dtDepartureTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDepartureTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDepartureTime.Name = "dtDepartureTime";
            this.dtDepartureTime.Size = new System.Drawing.Size(301, 48);
            this.dtDepartureTime.TabIndex = 22;
            this.dtDepartureTime.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartureTime.Location = new System.Drawing.Point(482, 269);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(119, 20);
            this.lblDepartureTime.TabIndex = 21;
            this.lblDepartureTime.Text = "Departure time";
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.Checked = true;
            this.dtArrivalTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtArrivalTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtArrivalTime.ForeColor = System.Drawing.Color.White;
            this.dtArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtArrivalTime.Location = new System.Drawing.Point(633, 357);
            this.dtArrivalTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtArrivalTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.Size = new System.Drawing.Size(301, 48);
            this.dtArrivalTime.TabIndex = 26;
            this.dtArrivalTime.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrivalTime.Location = new System.Drawing.Point(494, 370);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(91, 20);
            this.lblArrivalTime.TabIndex = 25;
            this.lblArrivalTime.Text = "Arrival time";
            // 
            // cboxPlane
            // 
            this.cboxPlane.BackColor = System.Drawing.Color.Transparent;
            this.cboxPlane.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPlane.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxPlane.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxPlane.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxPlane.ForeColor = System.Drawing.Color.Black;
            this.cboxPlane.ItemHeight = 30;
            this.cboxPlane.Location = new System.Drawing.Point(158, 260);
            this.cboxPlane.Name = "cboxPlane";
            this.cboxPlane.Size = new System.Drawing.Size(301, 36);
            this.cboxPlane.TabIndex = 27;
            // 
            // cboxDepartureAirport
            // 
            this.cboxDepartureAirport.BackColor = System.Drawing.Color.Transparent;
            this.cboxDepartureAirport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxDepartureAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartureAirport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxDepartureAirport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxDepartureAirport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxDepartureAirport.ForeColor = System.Drawing.Color.Black;
            this.cboxDepartureAirport.ItemHeight = 30;
            this.cboxDepartureAirport.Location = new System.Drawing.Point(158, 78);
            this.cboxDepartureAirport.Name = "cboxDepartureAirport";
            this.cboxDepartureAirport.Size = new System.Drawing.Size(301, 36);
            this.cboxDepartureAirport.TabIndex = 28;
            // 
            // cboxArrivalAirport
            // 
            this.cboxArrivalAirport.BackColor = System.Drawing.Color.Transparent;
            this.cboxArrivalAirport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxArrivalAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxArrivalAirport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxArrivalAirport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxArrivalAirport.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxArrivalAirport.ForeColor = System.Drawing.Color.Black;
            this.cboxArrivalAirport.ItemHeight = 30;
            this.cboxArrivalAirport.Location = new System.Drawing.Point(158, 166);
            this.cboxArrivalAirport.Name = "cboxArrivalAirport";
            this.cboxArrivalAirport.Size = new System.Drawing.Size(301, 36);
            this.cboxArrivalAirport.TabIndex = 29;
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrivalDate.Location = new System.Drawing.Point(509, 178);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(92, 20);
            this.lblArrivalDate.TabIndex = 31;
            this.lblArrivalDate.Text = "ArrivalDate";
            // 
            // dtArrivalDate
            // 
            this.dtArrivalDate.Checked = true;
            this.dtArrivalDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtArrivalDate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtArrivalDate.ForeColor = System.Drawing.Color.White;
            this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtArrivalDate.Location = new System.Drawing.Point(633, 166);
            this.dtArrivalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtArrivalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtArrivalDate.Name = "dtArrivalDate";
            this.dtArrivalDate.Size = new System.Drawing.Size(301, 48);
            this.dtArrivalDate.TabIndex = 30;
            this.dtArrivalDate.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // UCCreateFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.dtArrivalDate);
            this.Controls.Add(this.cboxArrivalAirport);
            this.Controls.Add(this.cboxDepartureAirport);
            this.Controls.Add(this.cboxPlane);
            this.Controls.Add(this.dtArrivalTime);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.dtDepartureDate);
            this.Controls.Add(this.dtDepartureTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.btnCreateFlight);
            this.Controls.Add(this.lblPlane);
            this.Controls.Add(this.lblTicketPrice);
            this.Controls.Add(this.tboxTicketPrice);
            this.Controls.Add(this.lblArrivalAirport);
            this.Controls.Add(this.lblDepartureAirport);
            this.Name = "UCCreateFlight";
            this.Size = new System.Drawing.Size(981, 538);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDepartureAirport;
        private System.Windows.Forms.Label lblArrivalAirport;
        private Guna.UI2.WinForms.Guna2TextBox tboxTicketPrice;
        private System.Windows.Forms.Label lblTicketPrice;
        private System.Windows.Forms.Label lblPlane;
        private Guna.UI2.WinForms.Guna2Button btnCreateFlight;
        private System.Windows.Forms.Label lblDepartureDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureTime;
        private System.Windows.Forms.Label lblDepartureTime;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtArrivalTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private Guna.UI2.WinForms.Guna2ComboBox cboxPlane;
        private Guna.UI2.WinForms.Guna2ComboBox cboxDepartureAirport;
        private Guna.UI2.WinForms.Guna2ComboBox cboxArrivalAirport;
        private System.Windows.Forms.Label lblArrivalDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtArrivalDate;
        public Guna2Button BtnCreateFlight { get => btnCreateFlight; set => btnCreateFlight = value; }
        public Guna2ComboBox CboxDepartureAirport { get => cboxDepartureAirport; set => cboxDepartureAirport = value; }
        public Guna2ComboBox CboxArrivalAirport { get => cboxArrivalAirport; set => cboxArrivalAirport = value; }
        public Guna2DateTimePicker DtDepartureDate { get => dtDepartureDate; set => dtDepartureDate = value; }
        public Guna2DateTimePicker DtArrivalDate { get => dtArrivalDate; set => dtArrivalDate = value; }
        public Guna2DateTimePicker DtDepartureTime { get => dtDepartureTime; set => dtDepartureTime = value; }
        public Guna2DateTimePicker DtArrivalTime { get => dtArrivalTime; set => dtArrivalTime = value; }
        public Guna2ComboBox CboxPlane { get => cboxPlane; set => cboxPlane = value; }
        public Guna2TextBox TboxTicketPrice { get => tboxTicketPrice; set => tboxTicketPrice = value; }
    }
}
