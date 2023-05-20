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
            System.Windows.Forms.GroupBox groupBox1;
            this.nSeatsTextBox = new System.Windows.Forms.TextBox();
            this.nSeatsLabel = new System.Windows.Forms.Label();
            this.ModelNameTextbox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.SerialNTextbox = new System.Windows.Forms.TextBox();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.AircraftListBox = new System.Windows.Forms.ListBox();
            this.DeleteAircraftButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.AddAircraftButton = new System.Windows.Forms.Button();
            this.ManageAircraftsLabel = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.nSeatsTextBox);
            groupBox1.Controls.Add(this.nSeatsLabel);
            groupBox1.Controls.Add(this.ModelNameTextbox);
            groupBox1.Controls.Add(this.ModelLabel);
            groupBox1.Controls.Add(this.SerialNTextbox);
            groupBox1.Controls.Add(this.SerialNumberLabel);
            groupBox1.Location = new System.Drawing.Point(398, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(432, 249);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aircraft Details";
            // 
            // nSeatsTextBox
            // 
            this.nSeatsTextBox.Location = new System.Drawing.Point(234, 184);
            this.nSeatsTextBox.Multiline = true;
            this.nSeatsTextBox.Name = "nSeatsTextBox";
            this.nSeatsTextBox.Size = new System.Drawing.Size(174, 46);
            this.nSeatsTextBox.TabIndex = 43;
            // 
            // nSeatsLabel
            // 
            this.nSeatsLabel.AutoSize = true;
            this.nSeatsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nSeatsLabel.Location = new System.Drawing.Point(14, 184);
            this.nSeatsLabel.Name = "nSeatsLabel";
            this.nSeatsLabel.Size = new System.Drawing.Size(128, 46);
            this.nSeatsLabel.TabIndex = 42;
            this.nSeatsLabel.Text = "Seats #";
            // 
            // ModelNameTextbox
            // 
            this.ModelNameTextbox.Location = new System.Drawing.Point(234, 112);
            this.ModelNameTextbox.Multiline = true;
            this.ModelNameTextbox.Name = "ModelNameTextbox";
            this.ModelNameTextbox.Size = new System.Drawing.Size(174, 46);
            this.ModelNameTextbox.TabIndex = 41;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(14, 112);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(215, 46);
            this.ModelLabel.TabIndex = 40;
            this.ModelLabel.Text = "Model Name";
            // 
            // SerialNTextbox
            // 
            this.SerialNTextbox.Location = new System.Drawing.Point(234, 41);
            this.SerialNTextbox.Multiline = true;
            this.SerialNTextbox.Name = "SerialNTextbox";
            this.SerialNTextbox.Size = new System.Drawing.Size(174, 46);
            this.SerialNTextbox.TabIndex = 39;
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SerialNumberLabel.Location = new System.Drawing.Point(14, 41);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(162, 46);
            this.SerialNumberLabel.TabIndex = 38;
            this.SerialNumberLabel.Text = "Serial No.";
            // 
            // AircraftListBox
            // 
            this.AircraftListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AircraftListBox.FormattingEnabled = true;
            this.AircraftListBox.ItemHeight = 20;
            this.AircraftListBox.Location = new System.Drawing.Point(43, 96);
            this.AircraftListBox.Name = "AircraftListBox";
            this.AircraftListBox.Size = new System.Drawing.Size(349, 342);
            this.AircraftListBox.TabIndex = 23;
            // 
            // DeleteAircraftButton
            // 
            this.DeleteAircraftButton.BackColor = System.Drawing.Color.Red;
            this.DeleteAircraftButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteAircraftButton.Location = new System.Drawing.Point(545, 369);
            this.DeleteAircraftButton.Name = "DeleteAircraftButton";
            this.DeleteAircraftButton.Size = new System.Drawing.Size(148, 46);
            this.DeleteAircraftButton.TabIndex = 32;
            this.DeleteAircraftButton.Text = "DELETE AIRCRAFT";
            this.DeleteAircraftButton.UseVisualStyleBackColor = false;
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.DarkGray;
            this.ModifyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyButton.Location = new System.Drawing.Point(699, 369);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(131, 46);
            this.ModifyButton.TabIndex = 34;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = false;
            // 
            // AddAircraftButton
            // 
            this.AddAircraftButton.BackColor = System.Drawing.Color.DarkGray;
            this.AddAircraftButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddAircraftButton.Location = new System.Drawing.Point(408, 369);
            this.AddAircraftButton.Name = "AddAircraftButton";
            this.AddAircraftButton.Size = new System.Drawing.Size(131, 46);
            this.AddAircraftButton.TabIndex = 35;
            this.AddAircraftButton.Text = "Add Aircraft";
            this.AddAircraftButton.UseVisualStyleBackColor = false;
            // 
            // ManageAircraftsLabel
            // 
            this.ManageAircraftsLabel.AutoSize = true;
            this.ManageAircraftsLabel.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ManageAircraftsLabel.ForeColor = System.Drawing.Color.Red;
            this.ManageAircraftsLabel.Location = new System.Drawing.Point(214, 9);
            this.ManageAircraftsLabel.Name = "ManageAircraftsLabel";
            this.ManageAircraftsLabel.Size = new System.Drawing.Size(434, 72);
            this.ManageAircraftsLabel.TabIndex = 36;
            this.ManageAircraftsLabel.Text = "Manage Aircrafts";
            // 
            // ManageAircrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.ManageAircraftsLabel);
            this.Controls.Add(this.AddAircraftButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.DeleteAircraftButton);
            this.Controls.Add(this.AircraftListBox);
            this.Name = "ManageAircrafts";
            this.Text = "ManageAircrafts";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox AircraftListBox;
        private Button DeleteAircraftButton;
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
    }
}