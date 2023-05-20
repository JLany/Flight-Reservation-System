namespace FlightReservationUI
{
    partial class ManageAccountForm
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
            errorLabel = new Label();
            saveChangesButton = new Button();
            confirmPasswordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            phoneNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            passportNumberTextBox = new TextBox();
            passportLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            middleNameTextBox = new TextBox();
            middleNameLabel = new Label();
            firstNameTextBox = new TextBox();
            firstNameLabel = new Label();
            SuspendLayout();
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(172, 102);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(67, 21);
            errorLabel.TabIndex = 35;
            errorLabel.Text = "<error>";
            // 
            // saveChangesButton
            // 
            saveChangesButton.BackColor = Color.Silver;
            saveChangesButton.FlatStyle = FlatStyle.Flat;
            saveChangesButton.Location = new Point(139, 383);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(202, 75);
            saveChangesButton.TabIndex = 34;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = false;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Location = new Point(205, 331);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(231, 35);
            confirmPasswordTextBox.TabIndex = 33;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(12, 334);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(179, 30);
            confirmPasswordLabel.TabIndex = 32;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(205, 280);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(231, 35);
            passwordTextBox.TabIndex = 31;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(12, 283);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(147, 30);
            passwordLabel.TabIndex = 30;
            passwordLabel.Text = "New Password";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextBox.Location = new Point(205, 227);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(231, 35);
            phoneNumberTextBox.TabIndex = 29;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(12, 230);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(154, 30);
            phoneNumberLabel.TabIndex = 28;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // passportNumberTextBox
            // 
            passportNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            passportNumberTextBox.Location = new Point(205, 177);
            passportNumberTextBox.Name = "passportNumberTextBox";
            passportNumberTextBox.Size = new Size(231, 35);
            passportNumberTextBox.TabIndex = 27;
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new Point(10, 180);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new Size(173, 30);
            passportLabel.TabIndex = 26;
            passportLabel.Text = "Passport Number";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(205, 124);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(231, 35);
            emailTextBox.TabIndex = 25;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(12, 127);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(327, 64);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(140, 35);
            lastNameTextBox.TabIndex = 23;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(324, 31);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 30);
            lastNameLabel.TabIndex = 22;
            lastNameLabel.Text = "Last Name";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            middleNameTextBox.Location = new Point(172, 64);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(140, 35);
            middleNameTextBox.TabIndex = 21;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(168, 31);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(139, 30);
            middleNameLabel.TabIndex = 20;
            middleNameLabel.Text = "Middle Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(15, 64);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(140, 35);
            firstNameTextBox.TabIndex = 19;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 31);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(113, 30);
            firstNameLabel.TabIndex = 18;
            firstNameLabel.Text = "First Name";
            // 
            // ManageAccountForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(481, 474);
            Controls.Add(errorLabel);
            Controls.Add(saveChangesButton);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(confirmPasswordLabel);
            Controls.Add(passwordTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(passportNumberTextBox);
            Controls.Add(passportLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(middleNameTextBox);
            Controls.Add(middleNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ManageAccountForm";
            Text = "Manage Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errorLabel;
        private Button saveChangesButton;
        private TextBox confirmPasswordTextBox;
        private Label confirmPasswordLabel;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox phoneNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox passportNumberTextBox;
        private Label passportLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox middleNameTextBox;
        private Label middleNameLabel;
        private TextBox firstNameTextBox;
        private Label firstNameLabel;
    }
}