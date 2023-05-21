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
    public partial class AdminMainForm : Form
    {
        bool hasChildren = false;
        public AdminMainForm()
        {
            InitializeComponent();

            ManageAircraftsButton.Click += ManageAircraftsButton_Click;
            ManageFlightsButton.Click += ManageFlightsButton_Click;
            this.FormClosed += AdminMainForm_FormClosed;
        }

        private void AdminMainForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!hasChildren)
            {
                new LoginForm().Show();
            }
        }

        private void ManageFlightsButton_Click(object? sender, EventArgs e)
        {
            new ManageFlights().Show();
            hasChildren = true;
            this.Close();
        }

        private void ManageAircraftsButton_Click(object? sender, EventArgs e)
        {
            new ManageAircrafts().Show();
            hasChildren = true;
            this.Close();
        }
    }
}
