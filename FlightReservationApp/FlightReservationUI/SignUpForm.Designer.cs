namespace FlightReservationUI
{
    partial class SignUpForm
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
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            middleNameLabel = new Label();
            middleNameTextBox = new TextBox();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            passportLabel = new Label();
            passportNumberTextBox = new TextBox();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            confirmPasswordTextBox = new TextBox();
            confirmPasswordLabel = new Label();
            signUpButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(9, 28);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(113, 30);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            firstNameTextBox.Location = new Point(12, 61);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(140, 35);
            firstNameTextBox.TabIndex = 1;
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new Point(165, 28);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(139, 30);
            middleNameLabel.TabIndex = 2;
            middleNameLabel.Text = "Middle Name";
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            middleNameTextBox.Location = new Point(169, 61);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(140, 35);
            middleNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(321, 28);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 30);
            lastNameLabel.TabIndex = 4;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            lastNameTextBox.Location = new Point(324, 61);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(140, 35);
            lastNameTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(9, 124);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(202, 121);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(231, 35);
            emailTextBox.TabIndex = 7;
            // 
            // passportLabel
            // 
            passportLabel.AutoSize = true;
            passportLabel.Location = new Point(7, 177);
            passportLabel.Name = "passportLabel";
            passportLabel.Size = new Size(173, 30);
            passportLabel.TabIndex = 8;
            passportLabel.Text = "Passport Number";
            // 
            // passportNumberTextBox
            // 
            passportNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            passportNumberTextBox.Location = new Point(202, 174);
            passportNumberTextBox.Name = "passportNumberTextBox";
            passportNumberTextBox.Size = new Size(231, 35);
            passportNumberTextBox.TabIndex = 9;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(9, 227);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(154, 30);
            phoneNumberLabel.TabIndex = 10;
            phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.BorderStyle = BorderStyle.FixedSingle;
            phoneNumberTextBox.Location = new Point(202, 224);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(231, 35);
            phoneNumberTextBox.TabIndex = 11;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(202, 277);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(231, 35);
            passwordTextBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(9, 280);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 30);
            passwordLabel.TabIndex = 12;
            passwordLabel.Text = "Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordTextBox.Location = new Point(202, 328);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.Size = new Size(231, 35);
            confirmPasswordTextBox.TabIndex = 15;
            // 
            // confirmPasswordLabel
            // 
            confirmPasswordLabel.AutoSize = true;
            confirmPasswordLabel.Location = new Point(9, 331);
            confirmPasswordLabel.Name = "confirmPasswordLabel";
            confirmPasswordLabel.Size = new Size(179, 30);
            confirmPasswordLabel.TabIndex = 14;
            confirmPasswordLabel.Text = "Confirm Password";
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.Silver;
            signUpButton.FlatStyle = FlatStyle.Flat;
            signUpButton.Location = new Point(136, 380);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(202, 75);
            signUpButton.TabIndex = 16;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(169, 99);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(67, 21);
            errorLabel.TabIndex = 17;
            errorLabel.Text = "<error>";
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 467);
            Controls.Add(errorLabel);
            Controls.Add(signUpButton);
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
            Name = "SignUpForm";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Label middleNameLabel;
        private TextBox middleNameTextBox;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passportLabel;
        private TextBox passportNumberTextBox;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox confirmPasswordTextBox;
        private Label confirmPasswordLabel;
        private Button signUpButton;
        private Label errorLabel;
    }
}