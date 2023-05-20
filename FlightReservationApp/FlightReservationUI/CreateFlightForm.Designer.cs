namespace FlightReservationUI
{
    partial class CreateFlightForm
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
            this.destinationTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.originTextBox = new System.Windows.Forms.TextBox();
            this.originLabel = new System.Windows.Forms.Label();
            this.flightNumberTextBox = new System.Windows.Forms.TextBox();
            this.headerLabel = new System.Windows.Forms.Label();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            this.tripDurationLabel = new System.Windows.Forms.Label();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.departureTimeLabel = new System.Windows.Forms.Label();
            this.departureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.arrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tripDurationTextBox = new System.Windows.Forms.TextBox();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.aircraftLabel = new System.Windows.Forms.Label();
            this.businessClassSeatsTextBox = new System.Windows.Forms.TextBox();
            this.businessClassSeatsLabel = new System.Windows.Forms.Label();
            this.aircraftComboBox = new System.Windows.Forms.ComboBox();
            this.economyClassSeatsTextBox = new System.Windows.Forms.TextBox();
            this.economyClassSeatsLabel = new System.Windows.Forms.Label();
            this.addFlightButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // destinationTextBox
            // 
            this.destinationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.destinationTextBox.Location = new System.Drawing.Point(564, 174);
            this.destinationTextBox.Name = "destinationTextBox";
            this.destinationTextBox.Size = new System.Drawing.Size(186, 42);
            this.destinationTextBox.TabIndex = 24;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(420, 176);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(153, 37);
            this.destinationLabel.TabIndex = 23;
            this.destinationLabel.Text = "Destination";
            // 
            // originTextBox
            // 
            this.originTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originTextBox.Location = new System.Drawing.Point(564, 122);
            this.originTextBox.Name = "originTextBox";
            this.originTextBox.Size = new System.Drawing.Size(186, 42);
            this.originTextBox.TabIndex = 22;
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(420, 124);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(91, 37);
            this.originLabel.TabIndex = 21;
            this.originLabel.Text = "Origin";
            // 
            // flightNumberTextBox
            // 
            this.flightNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flightNumberTextBox.Location = new System.Drawing.Point(219, 125);
            this.flightNumberTextBox.Name = "flightNumberTextBox";
            this.flightNumberTextBox.Size = new System.Drawing.Size(185, 42);
            this.flightNumberTextBox.TabIndex = 20;
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.headerLabel.Location = new System.Drawing.Point(288, 19);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(236, 62);
            this.headerLabel.TabIndex = 19;
            this.headerLabel.Text = "New Flight";
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.AutoSize = true;
            this.flightNumberLabel.Location = new System.Drawing.Point(12, 127);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(188, 37);
            this.flightNumberLabel.TabIndex = 18;
            this.flightNumberLabel.Text = "Flight Number";
            // 
            // tripDurationLabel
            // 
            this.tripDurationLabel.AutoSize = true;
            this.tripDurationLabel.Location = new System.Drawing.Point(12, 328);
            this.tripDurationLabel.Name = "tripDurationLabel";
            this.tripDurationLabel.Size = new System.Drawing.Size(172, 37);
            this.tripDurationLabel.TabIndex = 28;
            this.tripDurationLabel.Text = "Trip Duration";
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Location = new System.Drawing.Point(12, 278);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(158, 37);
            this.arrivalTimeLabel.TabIndex = 27;
            this.arrivalTimeLabel.Text = "Arrival Time";
            // 
            // departureTimeLabel
            // 
            this.departureTimeLabel.AutoSize = true;
            this.departureTimeLabel.Location = new System.Drawing.Point(12, 230);
            this.departureTimeLabel.Name = "departureTimeLabel";
            this.departureTimeLabel.Size = new System.Drawing.Size(201, 37);
            this.departureTimeLabel.TabIndex = 26;
            this.departureTimeLabel.Text = "Departure Time";
            // 
            // departureTimePicker
            // 
            this.departureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.departureTimePicker.Location = new System.Drawing.Point(219, 225);
            this.departureTimePicker.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.departureTimePicker.MinDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.departureTimePicker.Name = "departureTimePicker";
            this.departureTimePicker.Size = new System.Drawing.Size(185, 42);
            this.departureTimePicker.TabIndex = 31;
            // 
            // arrivalTimePicker
            // 
            this.arrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.arrivalTimePicker.Location = new System.Drawing.Point(219, 274);
            this.arrivalTimePicker.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.arrivalTimePicker.MinDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.arrivalTimePicker.Name = "arrivalTimePicker";
            this.arrivalTimePicker.Size = new System.Drawing.Size(185, 42);
            this.arrivalTimePicker.TabIndex = 32;
            // 
            // tripDurationTextBox
            // 
            this.tripDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tripDurationTextBox.Location = new System.Drawing.Point(219, 326);
            this.tripDurationTextBox.Name = "tripDurationTextBox";
            this.tripDurationTextBox.Size = new System.Drawing.Size(185, 42);
            this.tripDurationTextBox.TabIndex = 33;
            // 
            // costTextBox
            // 
            this.costTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costTextBox.Location = new System.Drawing.Point(564, 228);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(185, 42);
            this.costTextBox.TabIndex = 35;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(420, 229);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(70, 37);
            this.costLabel.TabIndex = 34;
            this.costLabel.Text = "Cost";
            // 
            // aircraftLabel
            // 
            this.aircraftLabel.AutoSize = true;
            this.aircraftLabel.Location = new System.Drawing.Point(420, 279);
            this.aircraftLabel.Name = "aircraftLabel";
            this.aircraftLabel.Size = new System.Drawing.Size(102, 37);
            this.aircraftLabel.TabIndex = 36;
            this.aircraftLabel.Text = "Aircraft";
            // 
            // businessClassSeatsTextBox
            // 
            this.businessClassSeatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.businessClassSeatsTextBox.Location = new System.Drawing.Point(30, 416);
            this.businessClassSeatsTextBox.Name = "businessClassSeatsTextBox";
            this.businessClassSeatsTextBox.Size = new System.Drawing.Size(195, 42);
            this.businessClassSeatsTextBox.TabIndex = 39;
            // 
            // businessClassSeatsLabel
            // 
            this.businessClassSeatsLabel.AutoSize = true;
            this.businessClassSeatsLabel.Location = new System.Drawing.Point(-4, 383);
            this.businessClassSeatsLabel.Name = "businessClassSeatsLabel";
            this.businessClassSeatsLabel.Size = new System.Drawing.Size(252, 37);
            this.businessClassSeatsLabel.TabIndex = 38;
            this.businessClassSeatsLabel.Text = "Business Class Seats";
            // 
            // aircraftComboBox
            // 
            this.aircraftComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.aircraftComboBox.FormattingEnabled = true;
            this.aircraftComboBox.Location = new System.Drawing.Point(564, 276);
            this.aircraftComboBox.Name = "aircraftComboBox";
            this.aircraftComboBox.Size = new System.Drawing.Size(185, 44);
            this.aircraftComboBox.TabIndex = 40;
            // 
            // economyClassSeatsTextBox
            // 
            this.economyClassSeatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.economyClassSeatsTextBox.Location = new System.Drawing.Point(260, 423);
            this.economyClassSeatsTextBox.Name = "economyClassSeatsTextBox";
            this.economyClassSeatsTextBox.Size = new System.Drawing.Size(201, 42);
            this.economyClassSeatsTextBox.TabIndex = 42;
            // 
            // economyClassSeatsLabel
            // 
            this.economyClassSeatsLabel.AutoSize = true;
            this.economyClassSeatsLabel.Location = new System.Drawing.Point(249, 383);
            this.economyClassSeatsLabel.Name = "economyClassSeatsLabel";
            this.economyClassSeatsLabel.Size = new System.Drawing.Size(262, 37);
            this.economyClassSeatsLabel.TabIndex = 41;
            this.economyClassSeatsLabel.Text = "Economy Class Seats";
            // 
            // addFlightButton
            // 
            this.addFlightButton.BackColor = System.Drawing.Color.Silver;
            this.addFlightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFlightButton.Location = new System.Drawing.Point(554, 376);
            this.addFlightButton.Name = "addFlightButton";
            this.addFlightButton.Size = new System.Drawing.Size(178, 82);
            this.addFlightButton.TabIndex = 43;
            this.addFlightButton.Text = "Add Flight";
            this.addFlightButton.UseVisualStyleBackColor = false;
            this.addFlightButton.Click += new System.EventHandler(this.addFlightButton_Click);
            // 
            // CreateFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 493);
            this.Controls.Add(this.addFlightButton);
            this.Controls.Add(this.economyClassSeatsTextBox);
            this.Controls.Add(this.economyClassSeatsLabel);
            this.Controls.Add(this.aircraftComboBox);
            this.Controls.Add(this.businessClassSeatsTextBox);
            this.Controls.Add(this.businessClassSeatsLabel);
            this.Controls.Add(this.aircraftLabel);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.tripDurationTextBox);
            this.Controls.Add(this.arrivalTimePicker);
            this.Controls.Add(this.departureTimePicker);
            this.Controls.Add(this.tripDurationLabel);
            this.Controls.Add(this.arrivalTimeLabel);
            this.Controls.Add(this.departureTimeLabel);
            this.Controls.Add(this.destinationTextBox);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.originTextBox);
            this.Controls.Add(this.originLabel);
            this.Controls.Add(this.flightNumberTextBox);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.flightNumberLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateFlightForm";
            this.Text = "Create Flight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addAircraftButton;
        private TextBox destinationTextBox;
        private Label destinationLabel;
        private TextBox originTextBox;
        private Label originLabel;
        private TextBox flightNumberTextBox;
        private Label headerLabel;
        private Label flightNumberLabel;
        private Label tripDurationLabel;
        private Label arrivalTimeLabel;
        private Label departureTimeLabel;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        private DateTimePicker departureTimePicker;
        private DateTimePicker arrivalTimePicker;
        private TextBox tripDurationTextBox;
        private TextBox costTextBox;
        private Label costLabel;
        private Label aircraftLabel;
        private TextBox businessClassSeatsTextBox;
        private Label businessClassSeatsLabel;
        private ComboBox aircraftComboBox;
        private TextBox economyClassSeatsTextBox;
        private Label economyClassSeatsLabel;
        private Button addFlightButton;
        private Label label1;
    }
}