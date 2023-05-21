using FlightReservationLibrary;
using FlightReservationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightReservationUI
{
    public partial class ManageAccountForm : Form
    {
        private CustomerModel currentCustomer;
        private bool saved = false;

        public ManageAccountForm(CustomerModel customer)
        {
            InitializeComponent();

            currentCustomer = customer;

            errorLabel.Text = "";
            PopulateForm();

            saveChangesButton.Click += SaveChangesButton_Click;
            this.FormClosed += ManageAccountForm_FormClosed;
        }

        private void PopulateForm()
        {
            firstNameTextBox.Text = currentCustomer.FirstName;
            middleNameTextBox.Text = currentCustomer.MiddleName;
            lastNameTextBox.Text = currentCustomer.LastName;
            emailTextBox.Text = currentCustomer.Email;
            passportNumberTextBox.Text = currentCustomer.PassportNumber;
            phoneNumberTextBox.Text = currentCustomer.PhoneNumber;
            passwordTextBox.Text = currentCustomer.Password;
            confirmPasswordTextBox.Text = currentCustomer.Password;
        }

        private void ManageAccountForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            string message = "";
            if (saved)
            {
                message = "Changes Saved Successfully.";
            } 

            new TicketsDashboardForm(currentCustomer.Email, message).Show();
        }

        private void SaveChangesButton_Click(object? sender, EventArgs e)
        {
            // Validate form
            if (!ValidateForm())
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

            // Check if the new mail exists in the database (other than the old one)
            if (GlobalConfig.Connector.CheckCustomer_AnotherEmailExists(currentCustomer, customer.Email))
            {
                errorLabel.Text = "Another account already exists with this email.";
                return;
            }

            // Save changes to database (update)
            customer = GlobalConfig.Connector.UpdateCustomer(customer);

            saved = true;
            this.Close();
        }

        private bool ValidateForm()
        {
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

            if (!IsValidEmail(emailTextBox.Text))
            {
                errorLabel.Text = "Invalid email.";
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

        private bool IsValidEmail(string email)
        {
            var validEmail = new
                Regex("^[\\w!#$%&'*+/=?^`{|}~-]+(\\.[\\w!#$%&'*+/=?^`{|}~-]+)*@(?:[\\w-]+\\.)+[a-zA-Z]{2,63}$");
            return validEmail.IsMatch(email);
        }
    }
}
