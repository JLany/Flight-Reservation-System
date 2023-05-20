namespace FlightReservationUI
{
    partial class TicketsDashboardForm
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
            ticketsLabel = new Label();
            ticketsListBox = new ListBox();
            ticketDetailsGroupBox = new GroupBox();
            classComboBox = new ComboBox();
            cancelTicketButton = new Button();
            flightGroupBox = new GroupBox();
            tripDurationText = new Label();
            tripDurationLabel = new Label();
            destinationText = new Label();
            destinationLabel = new Label();
            originText = new Label();
            originLabel = new Label();
            aircraftModelText = new Label();
            aircraftModelLabel = new Label();
            flightNumberText = new Label();
            flightNumberLabel = new Label();
            arrivalTimeText = new Label();
            arrivalTimeLabel = new Label();
            departureTimeText = new Label();
            departureTimeLabel = new Label();
            ticketNumberTextBox = new TextBox();
            classLabel = new Label();
            ticketNumberLabel = new Label();
            bookNewTicketButton = new Button();
            manageAccountLink = new LinkLabel();
            messageLabel = new Label();
            ticketDetailsGroupBox.SuspendLayout();
            flightGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.IndianRed;
            headerLabel.Location = new Point(29, 22);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(183, 50);
            headerLabel.TabIndex = 20;
            headerLabel.Text = "My Tickets";
            // 
            // ticketsLabel
            // 
            ticketsLabel.AutoSize = true;
            ticketsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            ticketsLabel.Location = new Point(29, 121);
            ticketsLabel.Name = "ticketsLabel";
            ticketsLabel.Size = new Size(97, 37);
            ticketsLabel.TabIndex = 21;
            ticketsLabel.Text = "Tickets";
            // 
            // ticketsListBox
            // 
            ticketsListBox.BorderStyle = BorderStyle.FixedSingle;
            ticketsListBox.FormattingEnabled = true;
            ticketsListBox.ItemHeight = 30;
            ticketsListBox.Location = new Point(34, 161);
            ticketsListBox.Name = "ticketsListBox";
            ticketsListBox.Size = new Size(316, 362);
            ticketsListBox.TabIndex = 22;
            // 
            // ticketDetailsGroupBox
            // 
            ticketDetailsGroupBox.Controls.Add(classComboBox);
            ticketDetailsGroupBox.Controls.Add(cancelTicketButton);
            ticketDetailsGroupBox.Controls.Add(flightGroupBox);
            ticketDetailsGroupBox.Controls.Add(ticketNumberTextBox);
            ticketDetailsGroupBox.Controls.Add(classLabel);
            ticketDetailsGroupBox.Controls.Add(ticketNumberLabel);
            ticketDetailsGroupBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ticketDetailsGroupBox.Location = new Point(389, 121);
            ticketDetailsGroupBox.Name = "ticketDetailsGroupBox";
            ticketDetailsGroupBox.Size = new Size(763, 402);
            ticketDetailsGroupBox.TabIndex = 23;
            ticketDetailsGroupBox.TabStop = false;
            ticketDetailsGroupBox.Text = "Ticket Details";
            // 
            // classComboBox
            // 
            classComboBox.Enabled = false;
            classComboBox.FlatStyle = FlatStyle.System;
            classComboBox.FormattingEnabled = true;
            classComboBox.Location = new Point(196, 116);
            classComboBox.Name = "classComboBox";
            classComboBox.Size = new Size(185, 38);
            classComboBox.TabIndex = 27;
            // 
            // cancelTicketButton
            // 
            cancelTicketButton.BackColor = Color.IndianRed;
            cancelTicketButton.FlatStyle = FlatStyle.Flat;
            cancelTicketButton.ForeColor = Color.Black;
            cancelTicketButton.Location = new Point(506, 84);
            cancelTicketButton.Name = "cancelTicketButton";
            cancelTicketButton.Size = new Size(165, 46);
            cancelTicketButton.TabIndex = 26;
            cancelTicketButton.Text = "Cancel Ticket";
            cancelTicketButton.UseVisualStyleBackColor = false;
            // 
            // flightGroupBox
            // 
            flightGroupBox.Controls.Add(tripDurationText);
            flightGroupBox.Controls.Add(tripDurationLabel);
            flightGroupBox.Controls.Add(destinationText);
            flightGroupBox.Controls.Add(destinationLabel);
            flightGroupBox.Controls.Add(originText);
            flightGroupBox.Controls.Add(originLabel);
            flightGroupBox.Controls.Add(aircraftModelText);
            flightGroupBox.Controls.Add(aircraftModelLabel);
            flightGroupBox.Controls.Add(flightNumberText);
            flightGroupBox.Controls.Add(flightNumberLabel);
            flightGroupBox.Controls.Add(arrivalTimeText);
            flightGroupBox.Controls.Add(arrivalTimeLabel);
            flightGroupBox.Controls.Add(departureTimeText);
            flightGroupBox.Controls.Add(departureTimeLabel);
            flightGroupBox.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            flightGroupBox.Location = new Point(15, 178);
            flightGroupBox.Name = "flightGroupBox";
            flightGroupBox.Size = new Size(736, 213);
            flightGroupBox.TabIndex = 24;
            flightGroupBox.TabStop = false;
            flightGroupBox.Text = "Flight";
            // 
            // tripDurationText
            // 
            tripDurationText.AutoSize = true;
            tripDurationText.Location = new Point(184, 145);
            tripDurationText.Name = "tripDurationText";
            tripDurationText.Size = new Size(227, 30);
            tripDurationText.TabIndex = 13;
            tripDurationText.Text = "2 hour(s) 45 minute(s)";
            // 
            // tripDurationLabel
            // 
            tripDurationLabel.AutoSize = true;
            tripDurationLabel.Location = new Point(10, 145);
            tripDurationLabel.Name = "tripDurationLabel";
            tripDurationLabel.Size = new Size(144, 30);
            tripDurationLabel.TabIndex = 12;
            tripDurationLabel.Text = "Trip Duration:";
            // 
            // destinationText
            // 
            destinationText.AutoSize = true;
            destinationText.Location = new Point(598, 115);
            destinationText.Name = "destinationText";
            destinationText.Size = new Size(64, 30);
            destinationText.TabIndex = 11;
            destinationText.Text = "Cairo";
            // 
            // destinationLabel
            // 
            destinationLabel.AutoSize = true;
            destinationLabel.Location = new Point(434, 115);
            destinationLabel.Name = "destinationLabel";
            destinationLabel.Size = new Size(127, 30);
            destinationLabel.TabIndex = 10;
            destinationLabel.Text = "Destination:";
            // 
            // originText
            // 
            originText.AutoSize = true;
            originText.Location = new Point(598, 85);
            originText.Name = "originText";
            originText.Size = new Size(78, 30);
            originText.TabIndex = 9;
            originText.Text = "Riyadh";
            // 
            // originLabel
            // 
            originLabel.AutoSize = true;
            originLabel.Location = new Point(434, 85);
            originLabel.Name = "originLabel";
            originLabel.Size = new Size(79, 30);
            originLabel.TabIndex = 8;
            originLabel.Text = "Origin:";
            // 
            // aircraftModelText
            // 
            aircraftModelText.AutoSize = true;
            aircraftModelText.Location = new Point(598, 56);
            aircraftModelText.Name = "aircraftModelText";
            aircraftModelText.Size = new Size(121, 30);
            aircraftModelText.TabIndex = 7;
            aircraftModelText.Text = "Boeing 707";
            // 
            // aircraftModelLabel
            // 
            aircraftModelLabel.AutoSize = true;
            aircraftModelLabel.Location = new Point(434, 56);
            aircraftModelLabel.Name = "aircraftModelLabel";
            aircraftModelLabel.Size = new Size(158, 30);
            aircraftModelLabel.TabIndex = 6;
            aircraftModelLabel.Text = "Aircraft Model:";
            // 
            // flightNumberText
            // 
            flightNumberText.AutoSize = true;
            flightNumberText.Location = new Point(184, 56);
            flightNumberText.Name = "flightNumberText";
            flightNumberText.Size = new Size(115, 30);
            flightNumberText.TabIndex = 5;
            flightNumberText.Text = "GADDF104";
            // 
            // flightNumberLabel
            // 
            flightNumberLabel.AutoSize = true;
            flightNumberLabel.Location = new Point(10, 56);
            flightNumberLabel.Name = "flightNumberLabel";
            flightNumberLabel.Size = new Size(159, 30);
            flightNumberLabel.TabIndex = 4;
            flightNumberLabel.Text = "Flight Number:";
            // 
            // arrivalTimeText
            // 
            arrivalTimeText.AutoSize = true;
            arrivalTimeText.Location = new Point(184, 115);
            arrivalTimeText.Name = "arrivalTimeText";
            arrivalTimeText.Size = new Size(198, 30);
            arrivalTimeText.TabIndex = 3;
            arrivalTimeText.Text = "05/15/2023 8:15PM";
            // 
            // arrivalTimeLabel
            // 
            arrivalTimeLabel.AutoSize = true;
            arrivalTimeLabel.Location = new Point(10, 115);
            arrivalTimeLabel.Name = "arrivalTimeLabel";
            arrivalTimeLabel.Size = new Size(135, 30);
            arrivalTimeLabel.TabIndex = 2;
            arrivalTimeLabel.Text = "Arrival Time:";
            // 
            // departureTimeText
            // 
            departureTimeText.AutoSize = true;
            departureTimeText.Location = new Point(184, 85);
            departureTimeText.Name = "departureTimeText";
            departureTimeText.Size = new Size(202, 30);
            departureTimeText.TabIndex = 1;
            departureTimeText.Text = "05/15/2023 5:30PM";
            // 
            // departureTimeLabel
            // 
            departureTimeLabel.AutoSize = true;
            departureTimeLabel.Location = new Point(10, 85);
            departureTimeLabel.Name = "departureTimeLabel";
            departureTimeLabel.Size = new Size(172, 30);
            departureTimeLabel.TabIndex = 0;
            departureTimeLabel.Text = "Departure Time:";
            // 
            // ticketNumberTextBox
            // 
            ticketNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            ticketNumberTextBox.Enabled = false;
            ticketNumberTextBox.Location = new Point(196, 60);
            ticketNumberTextBox.Name = "ticketNumberTextBox";
            ticketNumberTextBox.Size = new Size(185, 35);
            ticketNumberTextBox.TabIndex = 21;
            // 
            // classLabel
            // 
            classLabel.AutoSize = true;
            classLabel.Location = new Point(21, 119);
            classLabel.Name = "classLabel";
            classLabel.Size = new Size(60, 30);
            classLabel.TabIndex = 1;
            classLabel.Text = "Class";
            // 
            // ticketNumberLabel
            // 
            ticketNumberLabel.AutoSize = true;
            ticketNumberLabel.Location = new Point(21, 62);
            ticketNumberLabel.Name = "ticketNumberLabel";
            ticketNumberLabel.Size = new Size(155, 30);
            ticketNumberLabel.TabIndex = 0;
            ticketNumberLabel.Text = "Ticket Number";
            // 
            // bookNewTicketButton
            // 
            bookNewTicketButton.BackColor = Color.Silver;
            bookNewTicketButton.FlatStyle = FlatStyle.Flat;
            bookNewTicketButton.ForeColor = Color.Black;
            bookNewTicketButton.Location = new Point(84, 541);
            bookNewTicketButton.Name = "bookNewTicketButton";
            bookNewTicketButton.Size = new Size(216, 46);
            bookNewTicketButton.TabIndex = 25;
            bookNewTicketButton.Text = "Book a New Ticket";
            bookNewTicketButton.UseVisualStyleBackColor = false;
            // 
            // manageAccountLink
            // 
            manageAccountLink.AutoSize = true;
            manageAccountLink.Location = new Point(980, 38);
            manageAccountLink.Name = "manageAccountLink";
            manageAccountLink.Size = new Size(172, 30);
            manageAccountLink.TabIndex = 26;
            manageAccountLink.TabStop = true;
            manageAccountLink.Text = "Manage Account";
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            messageLabel.ForeColor = Color.Green;
            messageLabel.Location = new Point(948, 68);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new Size(207, 21);
            messageLabel.TabIndex = 27;
            messageLabel.Text = "Changes Saved Successfully.";
            // 
            // TicketsDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1164, 622);
            Controls.Add(messageLabel);
            Controls.Add(manageAccountLink);
            Controls.Add(bookNewTicketButton);
            Controls.Add(ticketDetailsGroupBox);
            Controls.Add(ticketsListBox);
            Controls.Add(ticketsLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "TicketsDashboardForm";
            Text = "Tickets Dashboard";
            ticketDetailsGroupBox.ResumeLayout(false);
            ticketDetailsGroupBox.PerformLayout();
            flightGroupBox.ResumeLayout(false);
            flightGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label ticketsLabel;
        private ListBox ticketsListBox;
        private GroupBox ticketDetailsGroupBox;
        private Button bookNewTicketButton;
        private Button cancelTicketButton;
        private Label classLabel;
        private Label ticketNumberLabel;
        private TextBox ticketNumberTextBox;
        private GroupBox flightGroupBox;
        private Label arrivalTimeText;
        private Label arrivalTimeLabel;
        private Label departureTimeText;
        private Label departureTimeLabel;
        private Label flightNumberText;
        private Label flightNumberLabel;
        private Label aircraftModelText;
        private Label aircraftModelLabel;
        private Label destinationText;
        private Label destinationLabel;
        private Label originText;
        private Label originLabel;
        private Label tripDurationText;
        private Label tripDurationLabel;
        private ComboBox classComboBox;
        private LinkLabel manageAccountLink;
        private Label messageLabel;
    }
}