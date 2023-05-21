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
    public partial class LoginForm : Form
    {
        private bool hasChildren = false;

        public LoginForm()
        {
            InitializeComponent();

            errorLabel.Text = "";

            loginButton.Click += LoginButton_Click;
            signUpLink.Click += SignUpLink_Click;
            this.FormClosed += LoginForm_FormClosed;
        }

        private void SignUpLink_Click(object? sender, EventArgs e)
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
                errorLabel.Text = "Incorrect email or password.";
            }
        }
    }
}
