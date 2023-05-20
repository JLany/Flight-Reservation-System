using FlightReservationLibrary;
using FlightReservationLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            saveChangesButton.Click += SaveChangesButton_Click;
            this.FormClosed += ManageAccountForm_FormClosed;
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
            // TODO - Implement the actual validation (same as sign up form validation)

            return true;
        }
    }
}
