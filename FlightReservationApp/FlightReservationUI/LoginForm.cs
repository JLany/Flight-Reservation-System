using FlightReservationLibrary;
using FlightReservationLibrary.Models;
using FlightReservationUI.Communication;
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
    public partial class LoginForm : Form
    {
        private bool hasChildren = false;

        public LoginForm()
        {
            InitializeComponent();

            errorLabel.Text = "";

            loginButton.Click += LoginButton_Click;
            signUpLink.LinkClicked += SignUpLink_LinkClicked;
            this.FormClosed += LoginForm_FormClosed;
        }

        private void SignUpLink_LinkClicked(object? sender, EventArgs e)
        {
            new SignUpForm().Show();
            hasChildren = true;
            this.Close();
        }

        private void LoginForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!hasChildren)
            {
                Application.Exit();
            }
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            var authentication = new AuthenticationModel
            {
                UserEmail = emailTextBox.Text,
                Password = passwordTextBox.Text
            };

            if (GlobalConfig.Connector.AuthenticateUser(authentication))
            {
                new TicketsDashboardForm(authentication.UserEmail).Show();
                hasChildren = true;
                this.Close();
            }
            else if (GlobalConfig.Connector.AuthenticateAdmin(authentication))
            {
                new AdminMainForm().Show();
                hasChildren = true;
                this.Close();
            }
            else
            {
                MessageController.DisplayLabelErrorMessage(errorLabel, "Invalid email or password.");
            }
        }
    }
}
