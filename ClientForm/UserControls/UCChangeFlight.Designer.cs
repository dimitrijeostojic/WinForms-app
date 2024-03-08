using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace ClientForm.UserControls
{
    partial class UCChangeFlight
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
            this.cboxPlane = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtArrivalTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.dtDepartureDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtDepartureTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.lblPlane = new System.Windows.Forms.Label();
            this.lblTicketPrice = new System.Windows.Forms.Label();
            this.tboxTicketPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblArrivalAirport = new System.Windows.Forms.Label();
            this.lblDepartureAirport = new System.Windows.Forms.Label();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.cboxDepartureAirport = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboxArrivalAirport = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSelect = new Guna.UI2.WinForms.Guna2Button();
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.dtArrivalDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.tboxTo = new Guna.UI2.WinForms.Guna2TextBox();
            this.tboxFrom = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxPlane
            // 
            this.cboxPlane.BackColor = System.Drawing.Color.Transparent;
            this.cboxPlane.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPlane.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxPlane.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxPlane.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxPlane.ForeColor = System.Drawing.Color.Black;
            this.cboxPlane.ItemHeight = 30;
            this.cboxPlane.Location = new System.Drawing.Point(388, 278);
            this.cboxPlane.Name = "cboxPlane";
            this.cboxPlane.Size = new System.Drawing.Size(134, 36);
            this.cboxPlane.TabIndex = 43;
            // 
            // dtArrivalTime
            // 
            this.dtArrivalTime.Checked = true;
            this.dtArrivalTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtArrivalTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtArrivalTime.ForeColor = System.Drawing.Color.White;
            this.dtArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtArrivalTime.Location = new System.Drawing.Point(544, 340);
            this.dtArrivalTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtArrivalTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtArrivalTime.Name = "dtArrivalTime";
            this.dtArrivalTime.Size = new System.Drawing.Size(169, 34);
            this.dtArrivalTime.TabIndex = 42;
            this.dtArrivalTime.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrivalTime.Location = new System.Drawing.Point(541, 319);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(81, 17);
            this.lblArrivalTime.TabIndex = 41;
            this.lblArrivalTime.Text = "Arrival time";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartureDate.Location = new System.Drawing.Point(166, 259);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(105, 17);
            this.lblDepartureDate.TabIndex = 40;
            this.lblDepartureDate.Text = "DepartureDate";
            // 
            // dtDepartureDate
            // 
            this.dtDepartureDate.Checked = true;
            this.dtDepartureDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtDepartureDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtDepartureDate.ForeColor = System.Drawing.Color.White;
            this.dtDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDepartureDate.Location = new System.Drawing.Point(169, 279);
            this.dtDepartureDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDepartureDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDepartureDate.Name = "dtDepartureDate";
            this.dtDepartureDate.Size = new System.Drawing.Size(205, 36);
            this.dtDepartureDate.TabIndex = 39;
            this.dtDepartureDate.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // dtDepartureTime
            // 
            this.dtDepartureTime.Checked = true;
            this.dtDepartureTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtDepartureTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtDepartureTime.ForeColor = System.Drawing.Color.White;
            this.dtDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDepartureTime.Location = new System.Drawing.Point(544, 278);
            this.dtDepartureTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtDepartureTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtDepartureTime.Name = "dtDepartureTime";
            this.dtDepartureTime.Size = new System.Drawing.Size(169, 34);
            this.dtDepartureTime.TabIndex = 38;
            this.dtDepartureTime.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartureTime.Location = new System.Drawing.Point(541, 258);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(106, 17);
            this.lblDepartureTime.TabIndex = 37;
            this.lblDepartureTime.Text = "Departure time";
            // 
            // lblPlane
            // 
            this.lblPlane.AutoSize = true;
            this.lblPlane.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPlane.Location = new System.Drawing.Point(385, 258);
            this.lblPlane.Name = "lblPlane";
            this.lblPlane.Size = new System.Drawing.Size(44, 17);
            this.lblPlane.TabIndex = 36;
            this.lblPlane.Text = "Plane";
            // 
            // lblTicketPrice
            // 
            this.lblTicketPrice.AutoSize = true;
            this.lblTicketPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTicketPrice.Location = new System.Drawing.Point(385, 319);
            this.lblTicketPrice.Name = "lblTicketPrice";
            this.lblTicketPrice.Size = new System.Drawing.Size(80, 17);
            this.lblTicketPrice.TabIndex = 35;
            this.lblTicketPrice.Text = "Ticket price";
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
            this.tboxTicketPrice.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tboxTicketPrice.ForeColor = System.Drawing.Color.Black;
            this.tboxTicketPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tboxTicketPrice.Location = new System.Drawing.Point(388, 340);
            this.tboxTicketPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTicketPrice.Name = "tboxTicketPrice";
            this.tboxTicketPrice.PasswordChar = '\0';
            this.tboxTicketPrice.PlaceholderText = "";
            this.tboxTicketPrice.SelectedText = "";
            this.tboxTicketPrice.Size = new System.Drawing.Size(134, 34);
            this.tboxTicketPrice.TabIndex = 33;
            //this.tboxTicketPrice.TextChanged += new System.EventHandler(this.tboxTicketPrice_TextChanged);
            // 
            // lblArrivalAirport
            // 
            this.lblArrivalAirport.AutoSize = true;
            this.lblArrivalAirport.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrivalAirport.Location = new System.Drawing.Point(9, 318);
            this.lblArrivalAirport.Name = "lblArrivalAirport";
            this.lblArrivalAirport.Size = new System.Drawing.Size(95, 17);
            this.lblArrivalAirport.TabIndex = 32;
            this.lblArrivalAirport.Text = "Arrival airport";
            // 
            // lblDepartureAirport
            // 
            this.lblDepartureAirport.AutoSize = true;
            this.lblDepartureAirport.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDepartureAirport.Location = new System.Drawing.Point(9, 259);
            this.lblDepartureAirport.Name = "lblDepartureAirport";
            this.lblDepartureAirport.Size = new System.Drawing.Size(120, 17);
            this.lblDepartureAirport.TabIndex = 31;
            this.lblDepartureAirport.Text = "Departure airport";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(307, 396);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(158, 35);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            //this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(3, 3);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.RowHeadersWidth = 51;
            this.dgvFlights.RowTemplate.Height = 24;
            this.dgvFlights.Size = new System.Drawing.Size(723, 186);
            this.dgvFlights.TabIndex = 45;
            // 
            // cboxDepartureAirport
            // 
            this.cboxDepartureAirport.BackColor = System.Drawing.Color.Transparent;
            this.cboxDepartureAirport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxDepartureAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartureAirport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxDepartureAirport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxDepartureAirport.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxDepartureAirport.ForeColor = System.Drawing.Color.Black;
            this.cboxDepartureAirport.ItemHeight = 30;
            this.cboxDepartureAirport.Location = new System.Drawing.Point(12, 279);
            this.cboxDepartureAirport.Name = "cboxDepartureAirport";
            this.cboxDepartureAirport.Size = new System.Drawing.Size(134, 36);
            this.cboxDepartureAirport.TabIndex = 46;
            // 
            // cboxArrivalAirport
            // 
            this.cboxArrivalAirport.BackColor = System.Drawing.Color.Transparent;
            this.cboxArrivalAirport.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboxArrivalAirport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxArrivalAirport.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxArrivalAirport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboxArrivalAirport.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cboxArrivalAirport.ForeColor = System.Drawing.Color.Black;
            this.cboxArrivalAirport.ItemHeight = 30;
            this.cboxArrivalAirport.Location = new System.Drawing.Point(12, 338);
            this.cboxArrivalAirport.Name = "cboxArrivalAirport";
            this.cboxArrivalAirport.Size = new System.Drawing.Size(134, 36);
            this.cboxArrivalAirport.TabIndex = 47;
            // 
            // btnSelect
            // 
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnSelect.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(564, 208);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(124, 31);
            this.btnSelect.TabIndex = 48;
            this.btnSelect.Text = "Select";
            //this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblArrivalDate.Location = new System.Drawing.Point(166, 318);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(80, 17);
            this.lblArrivalDate.TabIndex = 50;
            this.lblArrivalDate.Text = "ArrivalDate";
            // 
            // dtArrivalDate
            // 
            this.dtArrivalDate.Checked = true;
            this.dtArrivalDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.dtArrivalDate.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtArrivalDate.ForeColor = System.Drawing.Color.White;
            this.dtArrivalDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtArrivalDate.Location = new System.Drawing.Point(168, 338);
            this.dtArrivalDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtArrivalDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtArrivalDate.Name = "dtArrivalDate";
            this.dtArrivalDate.Size = new System.Drawing.Size(206, 36);
            this.dtArrivalDate.TabIndex = 49;
            this.dtArrivalDate.Value = new System.DateTime(2024, 2, 3, 18, 26, 52, 747);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(369, 192);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 17);
            this.lblTo.TabIndex = 54;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(91, 192);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(40, 17);
            this.lblFrom.TabIndex = 53;
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
            this.tboxTo.Location = new System.Drawing.Point(293, 213);
            this.tboxTo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxTo.Name = "tboxTo";
            this.tboxTo.PasswordChar = '\0';
            this.tboxTo.PlaceholderText = "";
            this.tboxTo.SelectedText = "";
            this.tboxTo.Size = new System.Drawing.Size(189, 26);
            this.tboxTo.TabIndex = 52;
            //this.tboxTo.TextChanged += new System.EventHandler(this.tboxTo_TextChanged);
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
            this.tboxFrom.Location = new System.Drawing.Point(22, 213);
            this.tboxFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxFrom.Name = "tboxFrom";
            this.tboxFrom.PasswordChar = '\0';
            this.tboxFrom.PlaceholderText = "";
            this.tboxFrom.SelectedText = "";
            this.tboxFrom.Size = new System.Drawing.Size(189, 26);
            this.tboxFrom.TabIndex = 51;
            //this.tboxFrom.TextChanged += new System.EventHandler(this.tboxFrom_TextChanged);
            // 
            // UCChangeFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.tboxTo);
            this.Controls.Add(this.tboxFrom);
            this.Controls.Add(this.lblArrivalDate);
            this.Controls.Add(this.dtArrivalDate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cboxArrivalAirport);
            this.Controls.Add(this.cboxDepartureAirport);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cboxPlane);
            this.Controls.Add(this.dtArrivalTime);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.dtDepartureDate);
            this.Controls.Add(this.dtDepartureTime);
            this.Controls.Add(this.lblDepartureTime);
            this.Controls.Add(this.lblPlane);
            this.Controls.Add(this.lblTicketPrice);
            this.Controls.Add(this.tboxTicketPrice);
            this.Controls.Add(this.lblArrivalAirport);
            this.Controls.Add(this.lblDepartureAirport);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UCChangeFlight";
            this.Size = new System.Drawing.Size(981, 538);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cboxPlane;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtArrivalTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Label lblDepartureDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtDepartureTime;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblPlane;
        private System.Windows.Forms.Label lblTicketPrice;
        private Guna.UI2.WinForms.Guna2TextBox tboxTicketPrice;
        private System.Windows.Forms.Label lblArrivalAirport;
        private System.Windows.Forms.Label lblDepartureAirport;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvFlights;
        private Guna.UI2.WinForms.Guna2ComboBox cboxDepartureAirport;
        private Guna.UI2.WinForms.Guna2ComboBox cboxArrivalAirport;
        private Guna.UI2.WinForms.Guna2Button btnSelect;
        private System.Windows.Forms.Label lblArrivalDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtArrivalDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private Guna.UI2.WinForms.Guna2TextBox tboxTo;
        private Guna.UI2.WinForms.Guna2TextBox tboxFrom;

        public Guna2Button BtnSelect { get { return btnSelect; } set { value = btnSelect; } }
        public Guna2Button BtnUpdate { get { return btnUpdate; } set { value = btnUpdate; } }
        public Guna2ComboBox CboxPlane { get { return cboxPlane; } set { value = cboxPlane; } }
        public Guna2DateTimePicker DtArrivalTime { get { return dtArrivalTime; } set { value = dtArrivalTime; } }
        public Guna2DateTimePicker DtDepartureTime { get { return dtDepartureTime; } set { value = dtDepartureTime; } }
        public Guna2DateTimePicker DtDepartureDate { get { return dtDepartureDate; } set { value = dtDepartureDate; } }
        public Guna2DateTimePicker DtArrivalDate { get { return dtArrivalDate; } set { value = dtArrivalDate; } }
        public Guna2TextBox TboxTicketPrice { get { return tboxTicketPrice; } set { value = tboxTicketPrice; } }
        public Guna2TextBox TboxTo { get { return tboxTo; } set { value = tboxTo; } }
        public Guna2TextBox TboxFrom { get { return tboxFrom; } set { value = tboxFrom; } }
        public Guna2ComboBox CboxDepartureAirport { get { return cboxDepartureAirport; } set { value = cboxDepartureAirport; } }
        public Guna2ComboBox CboxArrivalAirport { get { return cboxArrivalAirport; } set { value = cboxArrivalAirport; } }
        public DataGridView DgvFlights { get { return dgvFlights; } set { value = dgvFlights; } }
    }
}
