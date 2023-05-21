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
            FlightBox = new GroupBox();
            AircraftTextBox = new TextBox();
            EconomyClassSeatsTextBox = new TextBox();
            TripDurationTextBox = new TextBox();
            ArrivalTimePicker = new DateTimePicker();
            economyClassSeatsLabel = new Label();
            DepartureTimePicker = new DateTimePicker();
            tripDurationLabel = new Label();
            BusinessClassSeatsTextBox = new TextBox();
            arrivalTimeLabel = new Label();
            businessClassSeatsLabel = new Label();
            departureTimeLabel = new Label();
            aircraftLabel = new Label();
            CostTextBox = new TextBox();
            costLabel = new Label();
            DestinationTextBox = new TextBox();
            flightNumberLabel = new Label();
            FlightNumberTextBox = new TextBox();
            destinationLabel = new Label();
            originLabel = new Label();
            OriginTextBox = new TextBox();
            FlightsListBox = new ListBox();
            ModifyButton = new Button();
            CancelFlightButton = new Button();
            AddFlightButton = new Button();
            CancelReplyMessageLabel = new Label();
            ModifyReplyMessageLabel = new Label();
            FlightBox.SuspendLayout();
            SuspendLayout();
            // 
            // FlightBox
            // 
            FlightBox.Controls.Add(AircraftTextBox);
            FlightBox.Controls.Add(EconomyClassSeatsTextBox);
            FlightBox.Controls.Add(TripDurationTextBox);
            FlightBox.Controls.Add(ArrivalTimePicker);
            FlightBox.Controls.Add(economyClassSeatsLabel);
            FlightBox.Controls.Add(DepartureTimePicker);
            FlightBox.Controls.Add(tripDurationLabel);
            FlightBox.Controls.Add(BusinessClassSeatsTextBox);
            FlightBox.Controls.Add(arrivalTimeLabel);
            FlightBox.Controls.Add(businessClassSeatsLabel);
            FlightBox.Controls.Add(departureTimeLabel);
            FlightBox.Controls.Add(aircraftLabel);
            FlightBox.Controls.Add(CostTextBox);
            FlightBox.Controls.Add(costLabel);
            FlightBox.Controls.Add(DestinationTextBox);
            FlightBox.Controls.Add(flightNumberLabel);
            FlightBox.Controls.Add(FlightNumberTextBox);
            FlightBox.Controls.Add(destinationLabel);
            FlightBox.Controls.Add(originLabel);
            FlightBox.Controls.Add(OriginTextBox);
            FlightBox.Location = new Point(375, -1);
            FlightBox.Margin = new Padding(3, 2, 3, 2);
            FlightBox.Name = "FlightBox";
            FlightBox.Padding = new Padding(3, 2, 3, 2);
            FlightBox.Size = new Size(352, 360);
            FlightBox.TabIndex = 0;
            FlightBox.TabStop = false;
            FlightBox.Text = " Flight Details";
            // 
            // AircraftTextBox
            // 
            AircraftTextBox.BorderStyle = BorderStyle.FixedSingle;
            AircraftTextBox.Location = new Point(175, 266);
            AircraftTextBox.Margin = new Padding(3, 2, 3, 2);
            AircraftTextBox.Name = "AircraftTextBox";
            AircraftTextBox.ReadOnly = true;
            AircraftTextBox.Size = new Size(171, 23);
            AircraftTextBox.TabIndex = 55;
            // 
            // EconomyClassSeatsTextBox
            // 
            EconomyClassSeatsTextBox.BorderStyle = BorderStyle.FixedSingle;
            EconomyClassSeatsTextBox.Location = new Point(176, 327);
            EconomyClassSeatsTextBox.Margin = new Padding(3, 2, 3, 2);
            EconomyClassSeatsTextBox.Name = "EconomyClassSeatsTextBox";
            EconomyClassSeatsTextBox.ReadOnly = true;
            EconomyClassSeatsTextBox.Size = new Size(171, 23);
            EconomyClassSeatsTextBox.TabIndex = 54;
            // 
            // TripDurationTextBox
            // 
            TripDurationTextBox.BorderStyle = BorderStyle.FixedSingle;
            TripDurationTextBox.Location = new Point(175, 232);
            TripDurationTextBox.Margin = new Padding(3, 2, 3, 2);
            TripDurationTextBox.Name = "TripDurationTextBox";
            TripDurationTextBox.ReadOnly = true;
            TripDurationTextBox.Size = new Size(172, 23);
            TripDurationTextBox.TabIndex = 50;
            // 
            // ArrivalTimePicker
            // 
            ArrivalTimePicker.Format = DateTimePickerFormat.Time;
            ArrivalTimePicker.Location = new Point(176, 200);
            ArrivalTimePicker.Margin = new Padding(3, 2, 3, 2);
            ArrivalTimePicker.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            ArrivalTimePicker.MinDate = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            ArrivalTimePicker.Name = "ArrivalTimePicker";
            ArrivalTimePicker.Size = new Size(171, 23);
            ArrivalTimePicker.TabIndex = 49;
            // 
            // economyClassSeatsLabel
            // 
            economyClassSeatsLabel.AutoSize = true;
            economyClassSeatsLabel.Location = new Point(13, 328);
            economyClassSeatsLabel.Name = "economyClassSeatsLabel";
            economyClassSeatsLabel.Size = new Size(117, 15);
            economyClassSeatsLabel.TabIndex = 53;
            economyClassSeatsLabel.Text = "Economy Class Seats";
            // 
            // DepartureTimePicker
            // 
            DepartureTimePicker.Format = DateTimePickerFormat.Time;
            DepartureTimePicker.Location = new Point(176, 164);
            DepartureTimePicker.Margin = new Padding(3, 2, 3, 2);
            DepartureTimePicker.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            DepartureTimePicker.MinDate = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            DepartureTimePicker.Name = "DepartureTimePicker";
            DepartureTimePicker.Size = new Size(171, 23);
            DepartureTimePicker.TabIndex = 48;
            // 
            // tripDurationLabel
            // 
            tripDurationLabel.AutoSize = true;
            tripDurationLabel.Location = new Point(12, 232);
            tripDurationLabel.Name = "tripDurationLabel";
            tripDurationLabel.Size = new Size(75, 15);
            tripDurationLabel.TabIndex = 47;
            tripDurationLabel.Text = "Trip Duration";
            // 
            // BusinessClassSeatsTextBox
            // 
            BusinessClassSeatsTextBox.BorderStyle = BorderStyle.FixedSingle;
            BusinessClassSeatsTextBox.Location = new Point(176, 295);
            BusinessClassSeatsTextBox.Margin = new Padding(3, 2, 3, 2);
            BusinessClassSeatsTextBox.Name = "BusinessClassSeatsTextBox";
            BusinessClassSeatsTextBox.ReadOnly = true;
            BusinessClassSeatsTextBox.Size = new Size(171, 23);
            BusinessClassSeatsTextBox.TabIndex = 52;
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new Point(13, 200);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new Size(70, 15);
            arrivalTimeLabel.TabIndex = 46;
            arrivalTimeLabel.Text = "Arrival Time";
            // 
            // businessClassSeatsLabel
            // 
            businessClassSeatsLabel.AutoSize = true;
            businessClassSeatsLabel.Location = new Point(12, 300);
            businessClassSeatsLabel.Name = "businessClassSeatsLabel";
            businessClassSeatsLabel.Size = new Size(112, 15);
            businessClassSeatsLabel.TabIndex = 51;
            businessClassSeatsLabel.Text = "Business Class Seats";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Location = new Point(13, 168);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new Size(88, 15);
            departureTimeLabel.TabIndex = 45;
            departureTimeLabel.Text = "Departure Time";
            // 
            // aircraftLabel
            // 
            aircraftLabel.AutoSize = true;
            aircraftLabel.Location = new Point(13, 267);
            aircraftLabel.Name = "aircraftLabel";
            aircraftLabel.Size = new Size(46, 15);
            aircraftLabel.TabIndex = 43;
            aircraftLabel.Text = "Aircraft";
            // 
            // CostTextBox
            // 
            CostTextBox.BorderStyle = BorderStyle.FixedSingle;
            CostTextBox.Location = new Point(176, 126);
            CostTextBox.Margin = new Padding(3, 2, 3, 2);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.ReadOnly = true;
            CostTextBox.Size = new Size(171, 23);
            CostTextBox.TabIndex = 42;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(13, 128);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(31, 15);
            costLabel.TabIndex = 41;
            costLabel.Text = "Cost";
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.BorderStyle = BorderStyle.FixedSingle;
            DestinationTextBox.Location = new Point(176, 94);
            DestinationTextBox.Margin = new Padding(3, 2, 3, 2);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.ReadOnly = true;
            DestinationTextBox.Size = new Size(171, 23);
            DestinationTextBox.TabIndex = 30;
            // 
            // flightNumberLabel
            // 
            flightNumberLabel.AutoSize = true;
            flightNumberLabel.Location = new Point(13, 26);
            flightNumberLabel.Name = "flightNumberLabel";
            flightNumberLabel.Size = new Size(84, 15);
            flightNumberLabel.TabIndex = 25;
            flightNumberLabel.Text = "Flight Number";
            // 
            // FlightNumberTextBox
            // 
            FlightNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            FlightNumberTextBox.Location = new Point(175, 25);
            FlightNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            FlightNumberTextBox.Name = "FlightNumberTextBox";
            FlightNumberTextBox.ReadOnly = true;
            FlightNumberTextBox.Size = new Size(172, 23);
            FlightNumberTextBox.TabIndex = 26;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(13, 96);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(67, 15);
            destinationLabel.TabIndex = 29;
            destinationLabel.Text = "Destination";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new Point(13, 60);
            originLabel.Name = "originLabel";
            originLabel.Size = new Size(40, 15);
            originLabel.TabIndex = 27;
            originLabel.Text = "Origin";
            // 
            // OriginTextBox
            // 
            OriginTextBox.BorderStyle = BorderStyle.FixedSingle;
            OriginTextBox.Location = new Point(175, 58);
            OriginTextBox.Margin = new Padding(3, 2, 3, 2);
            OriginTextBox.Name = "OriginTextBox";
            OriginTextBox.ReadOnly = true;
            OriginTextBox.Size = new Size(172, 23);
            OriginTextBox.TabIndex = 28;
            // 
            // FlightsListBox
            // 
            FlightsListBox.FormattingEnabled = true;
            FlightsListBox.ItemHeight = 15;
            FlightsListBox.Location = new Point(10, 24);
            FlightsListBox.Margin = new Padding(3, 2, 3, 2);
            FlightsListBox.Name = "FlightsListBox";
            FlightsListBox.Size = new Size(352, 349);
            FlightsListBox.TabIndex = 1;
            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            // 
            // ModifyButton
            // 
            ModifyButton.BackColor = Color.DarkGray;
            ModifyButton.ForeColor = SystemColors.ActiveCaptionText;
            ModifyButton.Location = new Point(495, 363);
            ModifyButton.Margin = new Padding(3, 2, 3, 2);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(118, 27);
            ModifyButton.TabIndex = 36;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = false;
            // 
            // CancelFlightButton
            // 
            CancelFlightButton.BackColor = Color.Red;
            CancelFlightButton.ForeColor = SystemColors.ButtonHighlight;
            CancelFlightButton.Location = new Point(375, 363);
            CancelFlightButton.Margin = new Padding(3, 2, 3, 2);
            CancelFlightButton.Name = "CancelFlightButton";
            CancelFlightButton.Size = new Size(114, 27);
            CancelFlightButton.TabIndex = 35;
            CancelFlightButton.Text = "CANCEL FLIGHT";
            CancelFlightButton.UseVisualStyleBackColor = false;
            // 
            // AddFlightButton
            // 
            AddFlightButton.BackColor = Color.DarkGray;
            AddFlightButton.ForeColor = SystemColors.ActiveCaptionText;
            AddFlightButton.Location = new Point(619, 363);
            AddFlightButton.Margin = new Padding(3, 2, 3, 2);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(102, 27);
            AddFlightButton.TabIndex = 37;
            AddFlightButton.Text = "Add Flight";
            AddFlightButton.UseVisualStyleBackColor = false;
            // 
            // CancelReplyMessageLabel
            // 
            CancelReplyMessageLabel.AutoSize = true;
            CancelReplyMessageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            CancelReplyMessageLabel.Location = new Point(375, 392);
            CancelReplyMessageLabel.Name = "CancelReplyMessageLabel";
            CancelReplyMessageLabel.Size = new Size(0, 13);
            CancelReplyMessageLabel.TabIndex = 38;
            // 
            // ModifyReplyMessageLabel
            // 
            ModifyReplyMessageLabel.AutoSize = true;
            ModifyReplyMessageLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            ModifyReplyMessageLabel.Location = new Point(499, 392);
            ModifyReplyMessageLabel.Name = "ModifyReplyMessageLabel";
            ModifyReplyMessageLabel.Size = new Size(0, 13);
            ModifyReplyMessageLabel.TabIndex = 39;
            // 
            // ManageFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 412);
            Controls.Add(ModifyReplyMessageLabel);
            Controls.Add(CancelReplyMessageLabel);
            Controls.Add(AddFlightButton);
            Controls.Add(ModifyButton);
            Controls.Add(CancelFlightButton);
            Controls.Add(FlightsListBox);
            Controls.Add(FlightBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageFlights";
            Text = "ManageFlights";
            FlightBox.ResumeLayout(false);
            FlightBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label CancelReplyMessageLabel;
        private Label ModifyReplyMessageLabel;
    }
}