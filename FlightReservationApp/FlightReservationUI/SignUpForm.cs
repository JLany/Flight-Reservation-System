using FlightReservationLibrary;
using FlightReservationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightReservationUI
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();

            errorLabel.Text = "";

            signUpButton.Click += SignUpButton_Click;
            this.FormClosed += SignUpForm_FormClosed;
        }

        private void SignUpForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }

        private void SignUpButton_Click(object? sender, EventArgs e)
        {
            if (!ValidateSignUpForm())
            {
                return;
            }

            var customer = new CustomerModel
            {
                FirstName = firstNameTextBox.Text,
                MiddleName = middleNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Email = emailTextBox.Text,
                PassportNumber = passportNumberTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Password = passwordTextBox.Text
            };

            if (GlobalConfig.Connector.CheckCustomer_EmailExists(customer.Email))
            {
                errorLabel.Text = "An account already exists with this email.";
                return;
            }

            customer = GlobalConfig.Connector.CreateCustomer(customer);

            ResetSignUpForm();

            this.Close();
        }

        private void ResetSignUpForm()
        {
            firstNameTextBox.Text = "";
            middleNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            passportNumberTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
        }

        private bool ValidateSignUpForm()
        {
            // This way we could show an error message for every mistake at once
            // but I am too lazy to do so now, may be later
            bool valid = true;

            if (firstNameTextBox.Text.Length < 1)
            {
                errorLabel.Text = "First name too short.";
                valid = false;
            }

            if (firstNameTextBox.Text.Length > 50)
            {
                errorLabel.Text = "First name too long.";
                valid = false;
            }

            if (middleNameTextBox.Text.Length < 1)
            {
                errorLabel.Text = "Middle name too short.";
                valid = false;
            }

            if (middleNameTextBox.Text.Length > 50)
            {
                errorLabel.Text = "Middle name too long.";
                valid = false;
            }

            if (lastNameTextBox.Text.Length < 1)
            {
                errorLabel.Text = "Last name too short.";
                valid = false;
            }

            if (lastNameTextBox.Text.Length > 50)
            {
                errorLabel.Text = "Last name too long.";
                valid = false;
            }

            if (emailTextBox.Text.Length < 1)
            {
                errorLabel.Text = "Email too short.";
                valid = false;
            }

            if (emailTextBox.Text.Length > 100)
            {
                errorLabel.Text = "Email too long.";
                valid = false;
            }

            if (passportNumberTextBox.Text.Length < 1)
            {
                errorLabel.Text = "Passport number too short.";
                valid = false;
            }

            if (passportNumberTextBox.Text.Length > 20)
            {
                errorLabel.Text = "Passport number too long.";
                valid = false;
            }

            if (passwordTextBox.Text.Length < 8)
            {
                errorLabel.Text = "Password too short.";
                valid = false;
            }

            if (passwordTextBox.Text.Length > 100)
            {
                errorLabel.Text = "Password too long.";
                valid = false;
            }

            if (confirmPasswordTextBox.Text != passwordTextBox.Text)
            {
                errorLabel.Text = "Passwords do not match.";
                valid = false;
            }

            return valid;
        }
    }
}
