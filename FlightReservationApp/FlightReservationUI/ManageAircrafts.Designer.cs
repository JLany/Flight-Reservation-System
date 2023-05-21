namespace FlightReservationUI
{
    partial class ManageAircrafts
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
            GroupBox groupBox1;
            nSeatsTextBox = new TextBox();
            nSeatsLabel = new Label();
            ModelNameTextbox = new TextBox();
            ModelLabel = new Label();
            SerialNTextbox = new TextBox();
            SerialNumberLabel = new Label();
            AircraftListBox = new ListBox();
            ModifyButton = new Button();
            AddAircraftButton = new Button();
            ManageAircraftsLabel = new Label();
            ReplyMessageLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nSeatsTextBox);
            groupBox1.Controls.Add(nSeatsLabel);
            groupBox1.Controls.Add(ModelNameTextbox);
            groupBox1.Controls.Add(ModelLabel);
            groupBox1.Controls.Add(SerialNTextbox);
            groupBox1.Controls.Add(SerialNumberLabel);
            groupBox1.Location = new Point(348, 72);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(378, 187);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aircraft Details";
            // 
            // nSeatsTextBox
            // 
            nSeatsTextBox.Location = new Point(205, 138);
            nSeatsTextBox.Margin = new Padding(3, 2, 3, 2);
            nSeatsTextBox.Multiline = true;
            nSeatsTextBox.Name = "nSeatsTextBox";
            nSeatsTextBox.Size = new Size(153, 36);
            nSeatsTextBox.TabIndex = 43;
            // 
            // nSeatsLabel
            // 
            nSeatsLabel.AutoSize = true;
            nSeatsLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            nSeatsLabel.Location = new Point(12, 138);
            nSeatsLabel.Name = "nSeatsLabel";
            nSeatsLabel.Size = new Size(102, 37);
            nSeatsLabel.TabIndex = 42;
            nSeatsLabel.Text = "Seats #";
            // 
            // ModelNameTextbox
            // 
            ModelNameTextbox.Location = new Point(205, 84);
            ModelNameTextbox.Margin = new Padding(3, 2, 3, 2);
            ModelNameTextbox.Multiline = true;
            ModelNameTextbox.Name = "ModelNameTextbox";
            ModelNameTextbox.Size = new Size(153, 36);
            ModelNameTextbox.TabIndex = 41;
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            ModelLabel.Location = new Point(12, 84);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(172, 37);
            ModelLabel.TabIndex = 40;
            ModelLabel.Text = "Model Name";
            // 
            // SerialNTextbox
            // 
            SerialNTextbox.Location = new Point(205, 31);
            SerialNTextbox.Margin = new Padding(3, 2, 3, 2);
            SerialNTextbox.Multiline = true;
            SerialNTextbox.Name = "SerialNTextbox";
            SerialNTextbox.Size = new Size(153, 36);
            SerialNTextbox.TabIndex = 39;
            // 
            // SerialNumberLabel
            // 
            SerialNumberLabel.AutoSize = true;
            SerialNumberLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            SerialNumberLabel.Location = new Point(12, 31);
            SerialNumberLabel.Name = "SerialNumberLabel";
            SerialNumberLabel.Size = new Size(131, 37);
            SerialNumberLabel.TabIndex = 38;
            SerialNumberLabel.Text = "Serial No.";
            // 
            // AircraftListBox
            // 
            AircraftListBox.BorderStyle = BorderStyle.FixedSingle;
            AircraftListBox.FormattingEnabled = true;
            AircraftListBox.ItemHeight = 15;
            AircraftListBox.Location = new Point(38, 72);
            AircraftListBox.Margin = new Padding(3, 2, 3, 2);
            AircraftListBox.Name = "AircraftListBox";
            AircraftListBox.Size = new Size(306, 257);
            AircraftListBox.TabIndex = 23;
            // 
            // ModifyButton
            // 
            ModifyButton.BackColor = Color.DarkGray;
            ModifyButton.ForeColor = SystemColors.ActiveCaptionText;
            ModifyButton.Location = new Point(545, 263);
            ModifyButton.Margin = new Padding(3, 2, 3, 2);
            ModifyButton.Name = "ModifyButton";
            ModifyButton.Size = new Size(161, 34);
            ModifyButton.TabIndex = 34;
            ModifyButton.Text = "Modify";
            ModifyButton.UseVisualStyleBackColor = false;
            // 
            // AddAircraftButton
            // 
            AddAircraftButton.BackColor = Color.DarkGray;
            AddAircraftButton.ForeColor = SystemColors.ActiveCaptionText;
            AddAircraftButton.Location = new Point(360, 263);
            AddAircraftButton.Margin = new Padding(3, 2, 3, 2);
            AddAircraftButton.Name = "AddAircraftButton";
            AddAircraftButton.Size = new Size(162, 34);
            AddAircraftButton.TabIndex = 35;
            AddAircraftButton.Text = "Add Aircraft";
            AddAircraftButton.UseVisualStyleBackColor = false;
            // 
            // ManageAircraftsLabel
            // 
            ManageAircraftsLabel.AutoSize = true;
            ManageAircraftsLabel.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            ManageAircraftsLabel.ForeColor = Color.Red;
            ManageAircraftsLabel.Location = new Point(187, 7);
            ManageAircraftsLabel.Name = "ManageAircraftsLabel";
            ManageAircraftsLabel.Size = new Size(347, 59);
            ManageAircraftsLabel.TabIndex = 36;
            ManageAircraftsLabel.Text = "Manage Aircrafts";
            // 
            // ReplyMessageLabel
            // 
            ReplyMessageLabel.AutoSize = true;
            ReplyMessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ReplyMessageLabel.Location = new Point(545, 304);
            ReplyMessageLabel.Name = "ReplyMessageLabel";
            ReplyMessageLabel.Size = new Size(0, 25);
            ReplyMessageLabel.TabIndex = 37;
            // 
            // ManageAircrafts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 338);
            Controls.Add(ReplyMessageLabel);
            Controls.Add(ManageAircraftsLabel);
            Controls.Add(AddAircraftButton);
            Controls.Add(ModifyButton);
            Controls.Add(groupBox1);
            Controls.Add(AircraftListBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageAircrafts";
            Text = "ManageAircrafts";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox AircraftListBox;
        private GroupBox groupBox1;
        private TextBox nSeatsTextBox;
        private Label nSeatsLabel;
        private TextBox ModelNameTextbox;
        private Label ModelLabel;
        private TextBox SerialNTextbox;
        private Label SerialNumberLabel;
        private Button ModifyButton;
        private Button AddAircraftButton;
        private Label ManageAircraftsLabel;
        private Label ReplyMessageLabel;
    }
}