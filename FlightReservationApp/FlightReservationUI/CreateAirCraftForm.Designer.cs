namespace FlightReservationUI
{
    partial class CreateAirCraftForm
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
            serialNumberLabel = new Label();
            headerLabel = new Label();
            serialNumberTextBox = new TextBox();
            modelTextBox = new TextBox();
            modelLabel = new Label();
            numberOfSeatsTextBox = new TextBox();
            numberOfSeatsLabel = new Label();
            addAircraftButton = new Button();
            ReplyMessageLabel = new Label();
            SuspendLayout();
            // 
            // serialNumberLabel
            // 
            serialNumberLabel.AutoSize = true;
            serialNumberLabel.Location = new Point(50, 91);
            serialNumberLabel.Name = "serialNumberLabel";
            serialNumberLabel.Size = new Size(102, 30);
            serialNumberLabel.TabIndex = 0;
            serialNumberLabel.Text = "Serial No.";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.IndianRed;
            headerLabel.Location = new Point(117, 9);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(212, 50);
            headerLabel.TabIndex = 1;
            headerLabel.Text = "New Aircraft";
            // 
            // serialNumberTextBox
            // 
            serialNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            serialNumberTextBox.Location = new Point(235, 86);
            serialNumberTextBox.Name = "serialNumberTextBox";
            serialNumberTextBox.Size = new Size(165, 35);
            serialNumberTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            modelTextBox.BorderStyle = BorderStyle.FixedSingle;
            modelTextBox.Location = new Point(235, 136);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(165, 35);
            modelTextBox.TabIndex = 4;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(50, 141);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(72, 30);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model";
            // 
            // numberOfSeatsTextBox
            // 
            numberOfSeatsTextBox.BorderStyle = BorderStyle.FixedSingle;
            numberOfSeatsTextBox.Location = new Point(235, 187);
            numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            numberOfSeatsTextBox.Size = new Size(165, 35);
            numberOfSeatsTextBox.TabIndex = 6;
            // 
            // numberOfSeatsLabel
            // 
            numberOfSeatsLabel.AutoSize = true;
            numberOfSeatsLabel.Location = new Point(50, 192);
            numberOfSeatsLabel.Name = "numberOfSeatsLabel";
            numberOfSeatsLabel.Size = new Size(169, 30);
            numberOfSeatsLabel.TabIndex = 5;
            numberOfSeatsLabel.Text = "Number of Seats";
            // 
            // addAircraftButton
            // 
            addAircraftButton.BackColor = Color.Silver;
            addAircraftButton.FlatStyle = FlatStyle.Flat;
            addAircraftButton.Location = new Point(117, 252);
            addAircraftButton.Name = "addAircraftButton";
            addAircraftButton.Size = new Size(202, 75);
            addAircraftButton.TabIndex = 17;
            addAircraftButton.Text = "Add Aircraft";
            addAircraftButton.UseVisualStyleBackColor = false;
            addAircraftButton.Click += addAircraftButton_Click;
            // 
            // ReplyMessageLabel
            // 
            ReplyMessageLabel.AutoSize = true;
            ReplyMessageLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ReplyMessageLabel.Location = new Point(122, 344);
            ReplyMessageLabel.Name = "ReplyMessageLabel";
            ReplyMessageLabel.Size = new Size(0, 25);
            ReplyMessageLabel.TabIndex = 38;
            // 
            // CreateAirCraftForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(446, 378);
            Controls.Add(ReplyMessageLabel);
            Controls.Add(addAircraftButton);
            Controls.Add(numberOfSeatsTextBox);
            Controls.Add(numberOfSeatsLabel);
            Controls.Add(modelTextBox);
            Controls.Add(modelLabel);
            Controls.Add(serialNumberTextBox);
            Controls.Add(headerLabel);
            Controls.Add(serialNumberLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateAirCraftForm";
            Text = "Create Aircraft";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label serialNumberLabel;
        private Label headerLabel;
        private TextBox serialNumberTextBox;
        private TextBox modelTextBox;
        private Label modelLabel;
        private TextBox numberOfSeatsTextBox;
        private Label numberOfSeatsLabel;
        private Button addAircraftButton;
        private Label ReplyMessageLabel;
    }
}