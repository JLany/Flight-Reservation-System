namespace FlightReservationUI
{
    partial class LoginForm
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
            emailLabel = new Label();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            noAccountLabel = new Label();
            signUpLink = new LinkLabel();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = Color.IndianRed;
            headerLabel.Location = new Point(228, 44);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(164, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Fly Kilany";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(90, 136);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(82, 37);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(90, 190);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(128, 37);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.BorderStyle = BorderStyle.FixedSingle;
            emailTextBox.Location = new Point(224, 139);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(277, 35);
            emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Location = new Point(224, 193);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(277, 35);
            passwordTextBox.TabIndex = 4;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Silver;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Location = new Point(236, 268);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(148, 57);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // noAccountLabel
            // 
            noAccountLabel.AutoSize = true;
            noAccountLabel.Location = new Point(199, 345);
            noAccountLabel.Name = "noAccountLabel";
            noAccountLabel.Size = new Size(130, 30);
            noAccountLabel.TabIndex = 6;
            noAccountLabel.Text = "No account?";
            // 
            // signUpLink
            // 
            signUpLink.AutoSize = true;
            signUpLink.Location = new Point(324, 345);
            signUpLink.Name = "signUpLink";
            signUpLink.Size = new Size(86, 30);
            signUpLink.TabIndex = 7;
            signUpLink.TabStop = true;
            signUpLink.Text = "sign up.";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(221, 231);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(67, 21);
            errorLabel.TabIndex = 8;
            errorLabel.Text = "<error>";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(621, 386);
            Controls.Add(errorLabel);
            Controls.Add(signUpLink);
            Controls.Add(noAccountLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "LoginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private Label noAccountLabel;
        private LinkLabel signUpLink;
        private Label errorLabel;
    }
}