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
            destinationTextBox = new TextBox();
            destinationLabel = new Label();
            originTextBox = new TextBox();
            originLabel = new Label();
            flightNumberTextBox = new TextBox();
            headerLabel = new Label();
            flightNumberLabel = new Label();
            tripDurationLabel = new Label();
            arrivalTimeLabel = new Label();
            departureTimeLabel = new Label();
            departureTimePicker = new DateTimePicker();
            arrivalTimePicker = new DateTimePicker();
            tripDurationTextBox = new TextBox();
            costTextBox = new TextBox();
            costLabel = new Label();
            aircraftLabel = new Label();
            businessClassSeatsTextBox = new TextBox();
            businessClassSeatsLabel = new Label();
            aircraftComboBox = new ComboBox();
            economyClassSeatsTextBox = new TextBox();
            economyClassSeatsLabel = new Label();
            addFlightButton = new Button();
            SuspendLayout();
            // 
            // destinationTextBox
            // 
            destinationTextBox.BorderStyle = BorderStyle.FixedSingle;
            destinationTextBox.Location = new Point(554, 174);
            destinationTextBox.Name = "destinationTextBox";
            destinationTextBox.Size = new Size(186, 35);
            destinationTextBox.TabIndex = 24;
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(420, 176);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(119, 30);
            destinationLabel.TabIndex = 23;
            destinationLabel.Text = "Destination";
            // 
            // originTextBox
            // 
            originTextBox.BorderStyle = BorderStyle.FixedSingle;
            originTextBox.Location = new Point(554, 122);
            originTextBox.Name = "originTextBox";
            originTextBox.Size = new Size(186, 35);
            originTextBox.TabIndex = 22;
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new Point(420, 125);
            originLabel.Name = "originLabel";
            originLabel.Size = new Size(70, 30);
            originLabel.TabIndex = 21;
            originLabel.Text = "Origin";
            // 
            // flightNumberTextBox
            // 
            flightNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            flightNumberTextBox.Location = new Point(183, 122);
            flightNumberTextBox.Name = "flightNumberTextBox";
            flightNumberTextBox.Size = new Size(185, 35);
            flightNumberTextBox.TabIndex = 20;
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.IndianRed;
            headerLabel.Location = new Point(288, 19);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(187, 50);
            headerLabel.TabIndex = 19;
            headerLabel.Text = "New Flight";
            // 
            // flightNumberLabel
            // 
            flightNumberLabel.AutoSize = true;
            flightNumberLabel.Location = new Point(12, 124);
            flightNumberLabel.Name = "flightNumberLabel";
            flightNumberLabel.Size = new Size(146, 30);
            flightNumberLabel.TabIndex = 18;
            flightNumberLabel.Text = "Flight Number";
            // 
            // tripDurationLabel
            // 
            tripDurationLabel.AutoSize = true;
            tripDurationLabel.Location = new Point(12, 328);
            tripDurationLabel.Name = "tripDurationLabel";
            tripDurationLabel.Size = new Size(133, 30);
            tripDurationLabel.TabIndex = 28;
            tripDurationLabel.Text = "Trip Duration";
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new Point(12, 278);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new Size(123, 30);
            arrivalTimeLabel.TabIndex = 27;
            arrivalTimeLabel.Text = "Arrival Time";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Location = new Point(12, 229);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new Size(157, 30);
            departureTimeLabel.TabIndex = 26;
            departureTimeLabel.Text = "Departure Time";
            // 
            // departureTimePicker
            // 
            departureTimePicker.Format = DateTimePickerFormat.Time;
            departureTimePicker.Location = new Point(183, 229);
            departureTimePicker.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            departureTimePicker.MinDate = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            departureTimePicker.Name = "departureTimePicker";
            departureTimePicker.Size = new Size(185, 35);
            departureTimePicker.TabIndex = 31;
            // 
            // arrivalTimePicker
            // 
            arrivalTimePicker.Format = DateTimePickerFormat.Time;
            arrivalTimePicker.Location = new Point(183, 274);
            arrivalTimePicker.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            arrivalTimePicker.MinDate = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            arrivalTimePicker.Name = "arrivalTimePicker";
            arrivalTimePicker.Size = new Size(185, 35);
            arrivalTimePicker.TabIndex = 32;
            // 
            // tripDurationTextBox
            // 
            tripDurationTextBox.BorderStyle = BorderStyle.FixedSingle;
            tripDurationTextBox.Location = new Point(183, 326);
            tripDurationTextBox.Name = "tripDurationTextBox";
            tripDurationTextBox.Size = new Size(185, 35);
            tripDurationTextBox.TabIndex = 33;
            // 
            // costTextBox
            // 
            costTextBox.BorderStyle = BorderStyle.FixedSingle;
            costTextBox.Location = new Point(554, 227);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(185, 35);
            costTextBox.TabIndex = 35;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(420, 229);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(54, 30);
            costLabel.TabIndex = 34;
            costLabel.Text = "Cost";
            // 
            // aircraftLabel
            // 
            aircraftLabel.AutoSize = true;
            aircraftLabel.Location = new Point(420, 279);
            aircraftLabel.Name = "aircraftLabel";
            aircraftLabel.Size = new Size(81, 30);
            aircraftLabel.TabIndex = 36;
            aircraftLabel.Text = "Aircraft";
            // 
            // businessClassSeatsTextBox
            // 
            businessClassSeatsTextBox.BorderStyle = BorderStyle.FixedSingle;
            businessClassSeatsTextBox.Location = new Point(17, 423);
            businessClassSeatsTextBox.Name = "businessClassSeatsTextBox";
            businessClassSeatsTextBox.Size = new Size(195, 35);
            businessClassSeatsTextBox.TabIndex = 39;
            // 
            // businessClassSeatsLabel
            // 
            businessClassSeatsLabel.AutoSize = true;
            businessClassSeatsLabel.Location = new Point(12, 390);
            businessClassSeatsLabel.Name = "businessClassSeatsLabel";
            businessClassSeatsLabel.Size = new Size(200, 30);
            businessClassSeatsLabel.TabIndex = 38;
            businessClassSeatsLabel.Text = "Business Class Seats";
            // 
            // aircraftComboBox
            // 
            aircraftComboBox.FlatStyle = FlatStyle.System;
            aircraftComboBox.FormattingEnabled = true;
            aircraftComboBox.Location = new Point(554, 276);
            aircraftComboBox.Name = "aircraftComboBox";
            aircraftComboBox.Size = new Size(185, 38);
            aircraftComboBox.TabIndex = 40;
            // 
            // economyClassSeatsTextBox
            // 
            economyClassSeatsTextBox.BorderStyle = BorderStyle.FixedSingle;
            economyClassSeatsTextBox.Location = new Point(237, 423);
            economyClassSeatsTextBox.Name = "economyClassSeatsTextBox";
            economyClassSeatsTextBox.Size = new Size(201, 35);
            economyClassSeatsTextBox.TabIndex = 42;
            // 
            // economyClassSeatsLabel
            // 
            economyClassSeatsLabel.AutoSize = true;
            economyClassSeatsLabel.Location = new Point(232, 390);
            economyClassSeatsLabel.Name = "economyClassSeatsLabel";
            economyClassSeatsLabel.Size = new Size(206, 30);
            economyClassSeatsLabel.TabIndex = 41;
            economyClassSeatsLabel.Text = "Economy Class Seats";
            // 
            // addFlightButton
            // 
            addFlightButton.BackColor = Color.Silver;
            addFlightButton.FlatStyle = FlatStyle.Flat;
            addFlightButton.Location = new Point(554, 376);
            addFlightButton.Name = "addFlightButton";
            addFlightButton.Size = new Size(178, 82);
            addFlightButton.TabIndex = 43;
            addFlightButton.Text = "Add Flight";
            addFlightButton.UseVisualStyleBackColor = false;
            // 
            // CreateFlightForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(762, 493);
            Controls.Add(addFlightButton);
            Controls.Add(economyClassSeatsTextBox);
            Controls.Add(economyClassSeatsLabel);
            Controls.Add(aircraftComboBox);
            Controls.Add(businessClassSeatsTextBox);
            Controls.Add(businessClassSeatsLabel);
            Controls.Add(aircraftLabel);
            Controls.Add(costTextBox);
            Controls.Add(costLabel);
            Controls.Add(tripDurationTextBox);
            Controls.Add(arrivalTimePicker);
            Controls.Add(departureTimePicker);
            Controls.Add(tripDurationLabel);
            Controls.Add(arrivalTimeLabel);
            Controls.Add(departureTimeLabel);
            Controls.Add(destinationTextBox);
            Controls.Add(destinationLabel);
            Controls.Add(originTextBox);
            Controls.Add(originLabel);
            Controls.Add(flightNumberTextBox);
            Controls.Add(headerLabel);
            Controls.Add(flightNumberLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateFlightForm";
            Text = "Create Flight";
            ResumeLayout(false);
            PerformLayout();
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