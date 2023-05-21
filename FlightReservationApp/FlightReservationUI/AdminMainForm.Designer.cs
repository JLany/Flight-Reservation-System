namespace FlightReservationUI
{
    partial class AdminMainForm
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
            this.ManageAircraftsButton = new System.Windows.Forms.Button();
            this.ManageFlightsButton = new System.Windows.Forms.Button();
            this.AdminLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ManageAircraftsButton
            // 
            this.ManageAircraftsButton.Location = new System.Drawing.Point(268, 189);
            this.ManageAircraftsButton.Name = "ManageAircraftsButton";
            this.ManageAircraftsButton.Size = new System.Drawing.Size(232, 95);
            this.ManageAircraftsButton.TabIndex = 0;
            this.ManageAircraftsButton.Text = "Manage Aircrafts";
            this.ManageAircraftsButton.UseVisualStyleBackColor = true;
            // 
            // ManageFlightsButton
            // 
            this.ManageFlightsButton.Location = new System.Drawing.Point(268, 308);
            this.ManageFlightsButton.Name = "ManageFlightsButton";
            this.ManageFlightsButton.Size = new System.Drawing.Size(232, 100);
            this.ManageFlightsButton.TabIndex = 1;
            this.ManageFlightsButton.Text = "Manage Flights";
            this.ManageFlightsButton.UseVisualStyleBackColor = true;
            // 
            // AdminLabel
            // 
            this.AdminLabel.AutoSize = true;
            this.AdminLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminLabel.ForeColor = System.Drawing.Color.Red;
            this.AdminLabel.Location = new System.Drawing.Point(200, 42);
            this.AdminLabel.Name = "AdminLabel";
            this.AdminLabel.Size = new System.Drawing.Size(371, 60);
            this.AdminLabel.TabIndex = 2;
            this.AdminLabel.Text = "ADMIN WINDOW";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminLabel);
            this.Controls.Add(this.ManageFlightsButton);
            this.Controls.Add(this.ManageAircraftsButton);
            this.Name = "AdminMainForm";
            this.Text = "AdminMainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ManageAircraftsButton;
        private Button ManageFlightsButton;
        private Label AdminLabel;
    }
}