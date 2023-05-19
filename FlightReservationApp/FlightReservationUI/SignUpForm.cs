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

        private bool ValidateSignUpForm()
        {
            // TODO - Implement the actual validation 

            return true;
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
    }
}
