namespace FlightReservationUI
{
    partial class ManageFlights
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
            this.FlightBox = new System.Windows.Forms.GroupBox();
            this.AircraftTextBox = new System.Windows.Forms.TextBox();
            this.EconomyClassSeatsTextBox = new System.Windows.Forms.TextBox();
            this.TripDurationTextBox = new System.Windows.Forms.TextBox();
            this.ArrivalTimePicker = new System.Windows.Forms.DateTimePicker();
            this.economyClassSeatsLabel = new System.Windows.Forms.Label();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tripDurationLabel = new System.Windows.Forms.Label();
            this.BusinessClassSeatsTextBox = new System.Windows.Forms.TextBox();
            this.arrivalTimeLabel = new System.Windows.Forms.Label();
            this.businessClassSeatsLabel = new System.Windows.Forms.Label();
            this.departureTimeLabel = new System.Windows.Forms.Label();
            this.aircraftLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.flightNumberLabel = new System.Windows.Forms.Label();
            this.FlightNumberTextBox = new System.Windows.Forms.TextBox();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.originLabel = new System.Windows.Forms.Label();
            this.OriginTextBox = new System.Windows.Forms.TextBox();
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.CancelFlightButton = new System.Windows.Forms.Button();
            this.AddFlightButton = new System.Windows.Forms.Button();
            this.FlightBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlightBox
            // 
            this.FlightBox.Controls.Add(this.AircraftTextBox);
            this.FlightBox.Controls.Add(this.EconomyClassSeatsTextBox);
            this.FlightBox.Controls.Add(this.TripDurationTextBox);
            this.FlightBox.Controls.Add(this.ArrivalTimePicker);
            this.FlightBox.Controls.Add(this.economyClassSeatsLabel);
            this.FlightBox.Controls.Add(this.DepartureTimePicker);
            this.FlightBox.Controls.Add(this.tripDurationLabel);
            this.FlightBox.Controls.Add(this.BusinessClassSeatsTextBox);
            this.FlightBox.Controls.Add(this.arrivalTimeLabel);
            this.FlightBox.Controls.Add(this.businessClassSeatsLabel);
            this.FlightBox.Controls.Add(this.departureTimeLabel);
            this.FlightBox.Controls.Add(this.aircraftLabel);
            this.FlightBox.Controls.Add(this.CostTextBox);
            this.FlightBox.Controls.Add(this.costLabel);
            this.FlightBox.Controls.Add(this.DestinationTextBox);
            this.FlightBox.Controls.Add(this.flightNumberLabel);
            this.FlightBox.Controls.Add(this.FlightNumberTextBox);
            this.FlightBox.Controls.Add(this.destinationLabel);
            this.FlightBox.Controls.Add(this.originLabel);
            this.FlightBox.Controls.Add(this.OriginTextBox);
            this.FlightBox.Location = new System.Drawing.Point(429, -1);
            this.FlightBox.Name = "FlightBox";
            this.FlightBox.Size = new System.Drawing.Size(402, 503);
            this.FlightBox.TabIndex = 0;
            this.FlightBox.TabStop = false;
            this.FlightBox.Text = " Flight Details";
            // 
            // AircraftTextBox
            // 
            this.AircraftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AircraftTextBox.Location = new System.Drawing.Point(200, 354);
            this.AircraftTextBox.Name = "AircraftTextBox";
            this.AircraftTextBox.ReadOnly = true;
            this.AircraftTextBox.Size = new System.Drawing.Size(195, 27);
            this.AircraftTextBox.TabIndex = 55;
            // 
            // EconomyClassSeatsTextBox
            // 
            this.EconomyClassSeatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EconomyClassSeatsTextBox.Location = new System.Drawing.Point(201, 436);
            this.EconomyClassSeatsTextBox.Name = "EconomyClassSeatsTextBox";
            this.EconomyClassSeatsTextBox.ReadOnly = true;
            this.EconomyClassSeatsTextBox.Size = new System.Drawing.Size(195, 27);
            this.EconomyClassSeatsTextBox.TabIndex = 54;
            // 
            // TripDurationTextBox
            // 
            this.TripDurationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TripDurationTextBox.Location = new System.Drawing.Point(200, 309);
            this.TripDurationTextBox.Name = "TripDurationTextBox";
            this.TripDurationTextBox.ReadOnly = true;
            this.TripDurationTextBox.Size = new System.Drawing.Size(196, 27);
            this.TripDurationTextBox.TabIndex = 50;
            // 
            // ArrivalTimePicker
            // 
            this.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ArrivalTimePicker.Location = new System.Drawing.Point(201, 267);
            this.ArrivalTimePicker.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.ArrivalTimePicker.MinDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.ArrivalTimePicker.Name = "ArrivalTimePicker";
            this.ArrivalTimePicker.Size = new System.Drawing.Size(195, 27);
            this.ArrivalTimePicker.TabIndex = 49;
            // 
            // economyClassSeatsLabel
            // 
            this.economyClassSeatsLabel.AutoSize = true;
            this.economyClassSeatsLabel.Location = new System.Drawing.Point(15, 438);
            this.economyClassSeatsLabel.Name = "economyClassSeatsLabel";
            this.economyClassSeatsLabel.Size = new System.Drawing.Size(146, 20);
            this.economyClassSeatsLabel.TabIndex = 53;
            this.economyClassSeatsLabel.Text = "Economy Class Seats";
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DepartureTimePicker.Location = new System.Drawing.Point(201, 219);
            this.DepartureTimePicker.MaxDate = new System.DateTime(2025, 12, 25, 0, 0, 0, 0);
            this.DepartureTimePicker.MinDate = new System.DateTime(2023, 5, 16, 0, 0, 0, 0);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.Size = new System.Drawing.Size(195, 27);
            this.DepartureTimePicker.TabIndex = 48;
            // 
            // tripDurationLabel
            // 
            this.tripDurationLabel.AutoSize = true;
            this.tripDurationLabel.Location = new System.Drawing.Point(14, 309);
            this.tripDurationLabel.Name = "tripDurationLabel";
            this.tripDurationLabel.Size = new System.Drawing.Size(96, 20);
            this.tripDurationLabel.TabIndex = 47;
            this.tripDurationLabel.Text = "Trip Duration";
            // 
            // BusinessClassSeatsTextBox
            // 
            this.BusinessClassSeatsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BusinessClassSeatsTextBox.Location = new System.Drawing.Point(201, 393);
            this.BusinessClassSeatsTextBox.Name = "BusinessClassSeatsTextBox";
            this.BusinessClassSeatsTextBox.ReadOnly = true;
            this.BusinessClassSeatsTextBox.Size = new System.Drawing.Size(195, 27);
            this.BusinessClassSeatsTextBox.TabIndex = 52;
            // 
            // arrivalTimeLabel
            // 
            this.arrivalTimeLabel.AutoSize = true;
            this.arrivalTimeLabel.Location = new System.Drawing.Point(15, 267);
            this.arrivalTimeLabel.Name = "arrivalTimeLabel";
            this.arrivalTimeLabel.Size = new System.Drawing.Size(89, 20);
            this.arrivalTimeLabel.TabIndex = 46;
            this.arrivalTimeLabel.Text = "Arrival Time";
            // 
            // businessClassSeatsLabel
            // 
            this.businessClassSeatsLabel.AutoSize = true;
            this.businessClassSeatsLabel.Location = new System.Drawing.Point(14, 400);
            this.businessClassSeatsLabel.Name = "businessClassSeatsLabel";
            this.businessClassSeatsLabel.Size = new System.Drawing.Size(140, 20);
            this.businessClassSeatsLabel.TabIndex = 51;
            this.businessClassSeatsLabel.Text = "Business Class Seats";
            // 
            // departureTimeLabel
            // 
            this.departureTimeLabel.AutoSize = true;
            this.departureTimeLabel.Location = new System.Drawing.Point(15, 224);
            this.departureTimeLabel.Name = "departureTimeLabel";
            this.departureTimeLabel.Size = new System.Drawing.Size(113, 20);
            this.departureTimeLabel.TabIndex = 45;
            this.departureTimeLabel.Text = "Departure Time";
            // 
            // aircraftLabel
            // 
            this.aircraftLabel.AutoSize = true;
            this.aircraftLabel.Location = new System.Drawing.Point(15, 356);
            this.aircraftLabel.Name = "aircraftLabel";
            this.aircraftLabel.Size = new System.Drawing.Size(58, 20);
            this.aircraftLabel.TabIndex = 43;
            this.aircraftLabel.Text = "Aircraft";
            // 
            // CostTextBox
            // 
            this.CostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostTextBox.Location = new System.Drawing.Point(201, 168);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(195, 27);
            this.CostTextBox.TabIndex = 42;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(15, 170);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(38, 20);
            this.costLabel.TabIndex = 41;
            this.costLabel.Text = "Cost";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationTextBox.Location = new System.Drawing.Point(201, 126);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.ReadOnly = true;
            this.DestinationTextBox.Size = new System.Drawing.Size(195, 27);
            this.DestinationTextBox.TabIndex = 30;
            // 
            // flightNumberLabel
            // 
            this.flightNumberLabel.AutoSize = true;
            this.flightNumberLabel.Location = new System.Drawing.Point(15, 35);
            this.flightNumberLabel.Name = "flightNumberLabel";
            this.flightNumberLabel.Size = new System.Drawing.Size(104, 20);
            this.flightNumberLabel.TabIndex = 25;
            this.flightNumberLabel.Text = "Flight Number";
            // 
            // FlightNumberTextBox
            // 
            this.FlightNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightNumberTextBox.Location = new System.Drawing.Point(200, 33);
            this.FlightNumberTextBox.Name = "FlightNumberTextBox";
            this.FlightNumberTextBox.ReadOnly = true;
            this.FlightNumberTextBox.Size = new System.Drawing.Size(196, 27);
            this.FlightNumberTextBox.TabIndex = 26;
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Location = new System.Drawing.Point(15, 128);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(85, 20);
            this.destinationLabel.TabIndex = 29;
            this.destinationLabel.Text = "Destination";
            // 
            // originLabel
            // 
            this.originLabel.AutoSize = true;
            this.originLabel.Location = new System.Drawing.Point(15, 80);
            this.originLabel.Name = "originLabel";
            this.originLabel.Size = new System.Drawing.Size(50, 20);
            this.originLabel.TabIndex = 27;
            this.originLabel.Text = "Origin";
            // 
            // OriginTextBox
            // 
            this.OriginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginTextBox.Location = new System.Drawing.Point(200, 78);
            this.OriginTextBox.Name = "OriginTextBox";
            this.OriginTextBox.ReadOnly = true;
            this.OriginTextBox.Size = new System.Drawing.Size(196, 27);
            this.OriginTextBox.TabIndex = 28;
            // 
            // FlightsListBox
            // 
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.ItemHeight = 20;
            this.FlightsListBox.Location = new System.Drawing.Point(12, 32);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(402, 464);
            this.FlightsListBox.TabIndex = 1;
            this.FlightsListBox.SelectedIndexChanged += new System.EventHandler(this.FlightsListBox_SelectedIndexChanged);
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.DarkGray;
            this.ModifyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyButton.Location = new System.Drawing.Point(714, 508);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(117, 36);
            this.ModifyButton.TabIndex = 36;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = false;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // CancelFlightButton
            // 
            this.CancelFlightButton.BackColor = System.Drawing.Color.Red;
            this.CancelFlightButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelFlightButton.Location = new System.Drawing.Point(578, 508);
            this.CancelFlightButton.Name = "CancelFlightButton";
            this.CancelFlightButton.Size = new System.Drawing.Size(130, 36);
            this.CancelFlightButton.TabIndex = 35;
            this.CancelFlightButton.Text = "CANCEL FLIGHT";
            this.CancelFlightButton.UseVisualStyleBackColor = false;
            // 
            // AddFlightButton
            // 
            this.AddFlightButton.BackColor = System.Drawing.Color.DarkGray;
            this.AddFlightButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddFlightButton.Location = new System.Drawing.Point(443, 508);
            this.AddFlightButton.Name = "AddFlightButton";
            this.AddFlightButton.Size = new System.Drawing.Size(117, 36);
            this.AddFlightButton.TabIndex = 37;
            this.AddFlightButton.Text = "Add Flight";
            this.AddFlightButton.UseVisualStyleBackColor = false;
            // 
            // ManageFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 550);
            this.Controls.Add(this.AddFlightButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.CancelFlightButton);
            this.Controls.Add(this.FlightsListBox);
            this.Controls.Add(this.FlightBox);
            this.Name = "ManageFlights";
            this.Text = "ManageFlights";
            this.FlightBox.ResumeLayout(false);
            this.FlightBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox FlightBox;
        private ListBox FlightsListBox;
        private TextBox DestinationTextBox;
        private Label flightNumberLabel;
        private TextBox FlightNumberTextBox;
        private Label destinationLabel;
        private Label originLabel;
        private TextBox OriginTextBox;
        private Label aircraftLabel;
        private TextBox CostTextBox;
        private Label costLabel;
        private TextBox TripDurationTextBox;
        private DateTimePicker ArrivalTimePicker;
        private DateTimePicker DepartureTimePicker;
        private Label tripDurationLabel;
        private Label arrivalTimeLabel;
        private Label departureTimeLabel;
        private TextBox EconomyClassSeatsTextBox;
        private Label economyClassSeatsLabel;
        private TextBox BusinessClassSeatsTextBox;
        private Label businessClassSeatsLabel;
        private Button ModifyButton;
        private Button CancelFlightButton;
        private TextBox AircraftTextBox;
        private Button AddFlightButton;
    }
}