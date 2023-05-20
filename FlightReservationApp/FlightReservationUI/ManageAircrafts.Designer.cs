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
            this.AircraftListBox = new System.Windows.Forms.ListBox();
            this.DeleteAircraftButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextbox = new System.Windows.Forms.TextBox();
            this.SerialNumberLabel = new System.Windows.Forms.Label();
            this.SerialNTextbox = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ModelNameTextbox = new System.Windows.Forms.TextBox();
            this.nSeatsLabel = new System.Windows.Forms.Label();
            this.nSeatsTextBox = new System.Windows.Forms.TextBox();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AircraftListBox
            // 
            this.AircraftListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AircraftListBox.FormattingEnabled = true;
            this.AircraftListBox.ItemHeight = 20;
            this.AircraftListBox.Location = new System.Drawing.Point(41, 43);
            this.AircraftListBox.Name = "AircraftListBox";
            this.AircraftListBox.Size = new System.Drawing.Size(349, 362);
            this.AircraftListBox.TabIndex = 23;
            // 
            // DeleteAircraftButton
            // 
            this.DeleteAircraftButton.BackColor = System.Drawing.Color.Red;
            this.DeleteAircraftButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteAircraftButton.Location = new System.Drawing.Point(428, 381);
            this.DeleteAircraftButton.Name = "DeleteAircraftButton";
            this.DeleteAircraftButton.Size = new System.Drawing.Size(177, 46);
            this.DeleteAircraftButton.TabIndex = 32;
            this.DeleteAircraftButton.Text = "DELETE AIRCRAFT";
            this.DeleteAircraftButton.UseVisualStyleBackColor = false;
            // 
            // ModifyButton
            // 
            this.ModifyButton.BackColor = System.Drawing.Color.DarkGray;
            this.ModifyButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ModifyButton.Location = new System.Drawing.Point(634, 381);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(157, 46);
            this.ModifyButton.TabIndex = 34;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = false;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdLabel.Location = new System.Drawing.Point(18, 36);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(53, 46);
            this.IdLabel.TabIndex = 36;
            this.IdLabel.Text = "ID";
            // 
            // IdTextbox
            // 
            this.IdTextbox.Location = new System.Drawing.Point(238, 36);
            this.IdTextbox.Multiline = true;
            this.IdTextbox.Name = "IdTextbox";
            this.IdTextbox.ReadOnly = true;
            this.IdTextbox.Size = new System.Drawing.Size(174, 46);
            this.IdTextbox.TabIndex = 37;
            // 
            // SerialNumberLabel
            // 
            this.SerialNumberLabel.AutoSize = true;
            this.SerialNumberLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SerialNumberLabel.Location = new System.Drawing.Point(18, 107);
            this.SerialNumberLabel.Name = "SerialNumberLabel";
            this.SerialNumberLabel.Size = new System.Drawing.Size(162, 46);
            this.SerialNumberLabel.TabIndex = 38;
            this.SerialNumberLabel.Text = "Serial No.";
            // 
            // SerialNTextbox
            // 
            this.SerialNTextbox.Location = new System.Drawing.Point(238, 107);
            this.SerialNTextbox.Multiline = true;
            this.SerialNTextbox.Name = "SerialNTextbox";
            this.SerialNTextbox.Size = new System.Drawing.Size(174, 46);
            this.SerialNTextbox.TabIndex = 39;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(18, 178);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(215, 46);
            this.ModelLabel.TabIndex = 40;
            this.ModelLabel.Text = "Model Name";
            // 
            // ModelNameTextbox
            // 
            this.ModelNameTextbox.Location = new System.Drawing.Point(238, 178);
            this.ModelNameTextbox.Multiline = true;
            this.ModelNameTextbox.Name = "ModelNameTextbox";
            this.ModelNameTextbox.Size = new System.Drawing.Size(174, 46);
            this.ModelNameTextbox.TabIndex = 41;
            // 
            // nSeatsLabel
            // 
            this.nSeatsLabel.AutoSize = true;
            this.nSeatsLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nSeatsLabel.Location = new System.Drawing.Point(18, 250);
            this.nSeatsLabel.Name = "nSeatsLabel";
            this.nSeatsLabel.Size = new System.Drawing.Size(128, 46);
            this.nSeatsLabel.TabIndex = 42;
            this.nSeatsLabel.Text = "Seats #";
            // 
            // nSeatsTextBox
            // 
            this.nSeatsTextBox.Location = new System.Drawing.Point(238, 250);
            this.nSeatsTextBox.Multiline = true;
            this.nSeatsTextBox.Name = "nSeatsTextBox";
            this.nSeatsTextBox.Size = new System.Drawing.Size(174, 46);
            this.nSeatsTextBox.TabIndex = 43;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.nSeatsTextBox);
            groupBox1.Controls.Add(this.nSeatsLabel);
            groupBox1.Controls.Add(this.ModelNameTextbox);
            groupBox1.Controls.Add(this.ModelLabel);
            groupBox1.Controls.Add(this.SerialNTextbox);
            groupBox1.Controls.Add(this.SerialNumberLabel);
            groupBox1.Controls.Add(this.IdTextbox);
            groupBox1.Controls.Add(this.IdLabel);
            groupBox1.Location = new System.Drawing.Point(396, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(432, 332);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Aircraft Details";
            // 
            // ManageAircrafts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.DeleteAircraftButton);
            this.Controls.Add(this.AircraftListBox);
            this.Name = "ManageAircrafts";
            this.Text = "ManageAircrafts";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private TextBox IdTextbox;
        private Label IdLabel;
        private Button ModifyButton;
    }
}