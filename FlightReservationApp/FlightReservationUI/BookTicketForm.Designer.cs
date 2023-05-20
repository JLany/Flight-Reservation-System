namespace FlightReservationUI
{
    partial class BookTicketForm
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
            headerLabel = new Label();
            datePicker = new DateTimePicker();
            dateLabel = new Label();
            classLabel = new Label();
            classComboBox = new ComboBox();
            originComboBox = new ComboBox();
            originLabel = new Label();
            destinationComboBox = new ComboBox();
            destinationLabel = new Label();
            findFlightsButton = new Button();
            flightsListBox = new ListBox();
            flightsLabel = new Label();
            flightDetailsGroupBox = new GroupBox();
            aircraftModelTextBox = new TextBox();
            costTextBox = new TextBox();
            tripDurationTextBox = new TextBox();
            flightDetailsOriginTextBox = new TextBox();
            flightDetailsDestinationTextBox = new TextBox();
            arrivalTimeTextBox = new TextBox();
            departureTimeTextBox = new TextBox();
            flightNumberTextBox = new TextBox();
            aircraftModelLabel = new Label();
            costLabel = new Label();
            tripDurationLabel = new Label();
            arrivalTimeLabel = new Label();
            departureTimeLabel = new Label();
            flightDetailsDestinationLabel = new Label();
            flightDetailsOriginLabel = new Label();
            flightNumberLabel = new Label();
            bookFlightButton = new Button();
            errorLabel = new Label();
            flightDetailsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.IndianRed;
            headerLabel.Location = new Point(191, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(307, 50);
            headerLabel.TabIndex = 21;
            headerLabel.Text = "Book a New Ticket";
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(103, 93);
            datePicker.MaxDate = new DateTime(2025, 12, 25, 0, 0, 0, 0);
            datePicker.MinDate = new DateTime(2023, 5, 16, 0, 0, 0, 0);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(185, 35);
            datePicker.TabIndex = 33;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(12, 97);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(57, 30);
            dateLabel.TabIndex = 32;
            dateLabel.Text = "Date";
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new Point(12, 149);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(60, 30);
            classLabel.TabIndex = 34;
            classLabel.Text = "Class";
            // 
            // classComboBox
            // 
            classComboBox.FlatStyle = FlatStyle.System;
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(103, 146);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(185, 38);
            classComboBox.TabIndex = 35;
            classComboBox.Text = "Economy";
            // 
            // originComboBox
            // 
            originComboBox.FlatStyle = FlatStyle.System;
            originComboBox.FormattingEnabled = true;
            originComboBox.Location = new Point(484, 93);
            originComboBox.Name = "originComboBox";
            originComboBox.Size = new Size(185, 38);
            originComboBox.TabIndex = 37;
            originComboBox.Text = "Riyadh";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new Point(347, 93);
            originLabel.Name = "originLabel";
            originLabel.Size = new Size(70, 30);
            originLabel.TabIndex = 36;
            originLabel.Text = "Origin";
            // 
            // destinationComboBox
            // 
            destinationComboBox.FlatStyle = FlatStyle.System;
            destinationComboBox.FormattingEnabled = true;
            destinationComboBox.Location = new Point(484, 146);
            destinationComboBox.Name = "destinationComboBox";
            destinationComboBox.Size = new Size(185, 38);
            destinationComboBox.TabIndex = 39;
            destinationComboBox.Text = "Cairo";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(347, 146);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(119, 30);
            destinationLabel.TabIndex = 38;
            destinationLabel.Text = "Destination";
            // 
            // findFlightsButton
            // 
            findFlightsButton.BackColor = Color.White;
            findFlightsButton.FlatStyle = FlatStyle.Flat;
            findFlightsButton.Location = new Point(218, 203);
            findFlightsButton.Name = "findFlightsButton";
            findFlightsButton.Size = new Size(253, 57);
            findFlightsButton.TabIndex = 40;
            findFlightsButton.Text = "Find Flights";
            findFlightsButton.UseVisualStyleBackColor = false;
            // 
            // flightsListBox
            // 
            flightsListBox.BorderStyle = BorderStyle.FixedSingle;
            flightsListBox.FormattingEnabled = true;
            flightsListBox.ItemHeight = 30;
            flightsListBox.Location = new Point(12, 311);
            flightsListBox.Name = "flightsListBox";
            flightsListBox.Size = new Size(276, 332);
            flightsListBox.TabIndex = 41;
            // 
            // flightsLabel
            // 
            flightsLabel.AutoSize = true;
            flightsLabel.Location = new Point(12, 279);
            flightsLabel.Name = "flightsLabel";
            flightsLabel.Size = new Size(73, 30);
            flightsLabel.TabIndex = 42;
            flightsLabel.Text = "Flights";
            // 
            // flightDetailsGroupBox
            // 
            flightDetailsGroupBox.Controls.Add(aircraftModelTextBox);
            flightDetailsGroupBox.Controls.Add(costTextBox);
            flightDetailsGroupBox.Controls.Add(tripDurationTextBox);
            flightDetailsGroupBox.Controls.Add(flightDetailsOriginTextBox);
            flightDetailsGroupBox.Controls.Add(flightDetailsDestinationTextBox);
            flightDetailsGroupBox.Controls.Add(arrivalTimeTextBox);
            flightDetailsGroupBox.Controls.Add(departureTimeTextBox);
            flightDetailsGroupBox.Controls.Add(flightNumberTextBox);
            flightDetailsGroupBox.Controls.Add(aircraftModelLabel);
            flightDetailsGroupBox.Controls.Add(costLabel);
            flightDetailsGroupBox.Controls.Add(tripDurationLabel);
            flightDetailsGroupBox.Controls.Add(arrivalTimeLabel);
            flightDetailsGroupBox.Controls.Add(departureTimeLabel);
            flightDetailsGroupBox.Controls.Add(flightDetailsDestinationLabel);
            flightDetailsGroupBox.Controls.Add(flightDetailsOriginLabel);
            flightDetailsGroupBox.Controls.Add(flightNumberLabel);
            flightDetailsGroupBox.Location = new Point(332, 279);
            flightDetailsGroupBox.Name = "flightDetailsGroupBox";
            flightDetailsGroupBox.Size = new Size(344, 364);
            flightDetailsGroupBox.TabIndex = 43;
            flightDetailsGroupBox.TabStop = false;
            flightDetailsGroupBox.Text = "Flight Details";
            // 
            // aircraftModelTextBox
            // 
            aircraftModelTextBox.BorderStyle = BorderStyle.FixedSingle;
            aircraftModelTextBox.Location = new Point(175, 317);
            aircraftModelTextBox.Name = "aircraftModelTextBox";
            aircraftModelTextBox.ReadOnly = true;
            aircraftModelTextBox.Size = new Size(154, 35);
            aircraftModelTextBox.TabIndex = 15;
            // 
            // costTextBox
            // 
            costTextBox.BorderStyle = BorderStyle.FixedSingle;
            costTextBox.Location = new Point(175, 276);
            costTextBox.Name = "costTextBox";
            costTextBox.ReadOnly = true;
            costTextBox.Size = new Size(154, 35);
            costTextBox.TabIndex = 14;
            // 
            // tripDurationTextBox
            // 
            tripDurationTextBox.BorderStyle = BorderStyle.FixedSingle;
            tripDurationTextBox.Location = new Point(175, 235);
            tripDurationTextBox.Name = "tripDurationTextBox";
            tripDurationTextBox.ReadOnly = true;
            tripDurationTextBox.Size = new Size(154, 35);
            tripDurationTextBox.TabIndex = 13;
            // 
            // flightDetailsOriginTextBox
            // 
            flightDetailsOriginTextBox.BorderStyle = BorderStyle.FixedSingle;
            flightDetailsOriginTextBox.Location = new Point(175, 71);
            flightDetailsOriginTextBox.Name = "flightDetailsOriginTextBox";
            flightDetailsOriginTextBox.ReadOnly = true;
            flightDetailsOriginTextBox.Size = new Size(154, 35);
            flightDetailsOriginTextBox.TabIndex = 12;
            // 
            // flightDetailsDestinationTextBox
            // 
            flightDetailsDestinationTextBox.BorderStyle = BorderStyle.FixedSingle;
            flightDetailsDestinationTextBox.Location = new Point(175, 112);
            flightDetailsDestinationTextBox.Name = "flightDetailsDestinationTextBox";
            flightDetailsDestinationTextBox.ReadOnly = true;
            flightDetailsDestinationTextBox.Size = new Size(154, 35);
            flightDetailsDestinationTextBox.TabIndex = 11;
            // 
            // arrivalTimeTextBox
            // 
            arrivalTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
            arrivalTimeTextBox.Location = new Point(175, 194);
            arrivalTimeTextBox.Name = "arrivalTimeTextBox";
            arrivalTimeTextBox.ReadOnly = true;
            arrivalTimeTextBox.Size = new Size(154, 35);
            arrivalTimeTextBox.TabIndex = 10;
            // 
            // departureTimeTextBox
            // 
            departureTimeTextBox.BorderStyle = BorderStyle.FixedSingle;
            departureTimeTextBox.Location = new Point(175, 153);
            departureTimeTextBox.Name = "departureTimeTextBox";
            departureTimeTextBox.ReadOnly = true;
            departureTimeTextBox.Size = new Size(154, 35);
            departureTimeTextBox.TabIndex = 9;
            // 
            // flightNumberTextBox
            // 
            flightNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            flightNumberTextBox.Location = new Point(175, 29);
            flightNumberTextBox.Name = "flightNumberTextBox";
            flightNumberTextBox.ReadOnly = true;
            flightNumberTextBox.Size = new Size(154, 35);
            flightNumberTextBox.TabIndex = 8;
            // 
            // aircraftModelLabel
            // 
            aircraftModelLabel.AutoSize = true;
            aircraftModelLabel.Location = new Point(6, 319);
            aircraftModelLabel.Name = "aircraftModelLabel";
            aircraftModelLabel.Size = new Size(146, 30);
            aircraftModelLabel.TabIndex = 7;
            aircraftModelLabel.Text = "Aircraft Model";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new Point(6, 278);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(54, 30);
            costLabel.TabIndex = 6;
            costLabel.Text = "Cost";
            // 
            // tripDurationLabel
            // 
            tripDurationLabel.AutoSize = true;
            tripDurationLabel.Location = new Point(6, 237);
            tripDurationLabel.Name = "tripDurationLabel";
            tripDurationLabel.Size = new Size(133, 30);
            tripDurationLabel.TabIndex = 5;
            tripDurationLabel.Text = "Trip Duration";
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new Point(6, 196);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new Size(123, 30);
            arrivalTimeLabel.TabIndex = 4;
            arrivalTimeLabel.Text = "Arrival Time";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Location = new Point(6, 155);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new Size(157, 30);
            departureTimeLabel.TabIndex = 3;
            departureTimeLabel.Text = "Departure Time";
            // 
            // flightDetailsDestinationLabel
            // 
            flightDetailsDestinationLabel.AutoSize = true;
            flightDetailsDestinationLabel.Location = new Point(6, 114);
            flightDetailsDestinationLabel.Name = "flightDetailsDestinationLabel";
            flightDetailsDestinationLabel.Size = new Size(119, 30);
            flightDetailsDestinationLabel.TabIndex = 2;
            flightDetailsDestinationLabel.Text = "Destination";
            // 
            // flightDetailsOriginLabel
            // 
            flightDetailsOriginLabel.AutoSize = true;
            flightDetailsOriginLabel.Location = new Point(6, 73);
            flightDetailsOriginLabel.Name = "flightDetailsOriginLabel";
            flightDetailsOriginLabel.Size = new Size(70, 30);
            flightDetailsOriginLabel.TabIndex = 1;
            flightDetailsOriginLabel.Text = "Origin";
            // 
            // flightNumberLabel
            // 
            flightNumberLabel.AutoSize = true;
            flightNumberLabel.Location = new Point(6, 32);
            flightNumberLabel.Name = "flightNumberLabel";
            flightNumberLabel.Size = new Size(103, 30);
            flightNumberLabel.TabIndex = 0;
            flightNumberLabel.Text = "Flight No.";
            // 
            // bookFlightButton
            // 
            bookFlightButton.BackColor = Color.Silver;
            bookFlightButton.FlatStyle = FlatStyle.Flat;
            bookFlightButton.Location = new Point(218, 668);
            bookFlightButton.Name = "bookFlightButton";
            bookFlightButton.Size = new Size(253, 72);
            bookFlightButton.TabIndex = 44;
            bookFlightButton.Text = "Book Flight";
            bookFlightButton.UseVisualStyleBackColor = false;
            // 
            // errorLabel
            // 
            errorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(94, 742);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(500, 21);
            errorLabel.TabIndex = 45;
            errorLabel.Text = "<error>";
            errorLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BookTicketForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(688, 772);
            Controls.Add(errorLabel);
            Controls.Add(bookFlightButton);
            Controls.Add(flightDetailsGroupBox);
            Controls.Add(flightsLabel);
            Controls.Add(flightsListBox);
            Controls.Add(findFlightsButton);
            Controls.Add(destinationComboBox);
            Controls.Add(destinationLabel);
            Controls.Add(originComboBox);
            Controls.Add(originLabel);
            Controls.Add(classComboBox);
            Controls.Add(classLabel);
            Controls.Add(datePicker);
            Controls.Add(dateLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "BookTicketForm";
            Text = "Book a New Ticket";
            flightDetailsGroupBox.ResumeLayout(false);
            flightDetailsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private DateTimePicker datePicker;
        private Label dateLabel;
        private Label classLabel;
        private ComboBox classComboBox;
        private ComboBox originComboBox;
        private Label originLabel;
        private ComboBox destinationComboBox;
        private Label destinationLabel;
        private Button findFlightsButton;
        private ListBox flightsListBox;
        private Label flightsLabel;
        private GroupBox flightDetailsGroupBox;
        private Label aircraftModelLabel;
        private Label costLabel;
        private Label tripDurationLabel;
        private Label arrivalTimeLabel;
        private Label departureTimeLabel;
        private Label flightDetailsDestinationLabel;
        private Label flightDetailsOriginLabel;
        private Label flightNumberLabel;
        private Button bookFlightButton;
        private TextBox aircraftModelTextBox;
        private TextBox costTextBox;
        private TextBox tripDurationTextBox;
        private TextBox flightDetailsOriginTextBox;
        private TextBox flightDetailsDestinationTextBox;
        private TextBox arrivalTimeTextBox;
        private TextBox departureTimeTextBox;
        private TextBox flightNumberTextBox;
        private Label errorLabel;
    }
}