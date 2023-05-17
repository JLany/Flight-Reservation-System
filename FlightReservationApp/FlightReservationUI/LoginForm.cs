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
        public LoginForm()
        {
            InitializeComponent();

            loginButton.Click += LoginButton_Click;
        }

        private void LoginButton_Click(object? sender, EventArgs e)
        {
            var authentication = new AuthenticationModel 
            {
                UserEmail = emailTextBox.Text,
                Password = passwordTextBox.Text
            };

            bool authenticated = GlobalConfig.Connector.AuthenticateUser(authentication);

            if (authenticated)
            {
                // TODO - Redirect to TicketsDashboardForm with an attached user email
            }
            else
            {
                // TODO - Show "invalid credentials" message
            }
        }
    }
}
