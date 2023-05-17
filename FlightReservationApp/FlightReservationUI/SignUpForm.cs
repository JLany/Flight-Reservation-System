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

            signUpButton.Click += SignUpButton_Click;
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
                EmailAddress = emailTextBox.Text,
                PassportNumber = passportNumberTextBox.Text,
                PhoneNumber = phoneNumberTextBox.Text,
                Password = passwordTextBox.Text
            };

            customer = GlobalConfig.Connector.CreateCustomer(customer);

            ResetSignUpForm();

            // TODO - Redirect to login form
        }

        private bool ValidateSignUpForm()
        {
            // TODO - Implement the actual validation 
            
            if (GlobalConfig.Connector.CheckCustomer_EmailExists(emailTextBox.Text))
            {
                return false;
            }

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
