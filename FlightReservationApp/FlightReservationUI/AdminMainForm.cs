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
        public AdminMainForm()
        {
            InitializeComponent();

            ManageAircraftsButton.Click += ManageAircraftsButton_Click;
            ManageFlightsButton.Click += ManageFlightsButton_Click;
            
        }

        private void ManageFlightsButton_Click(object? sender, EventArgs e)
        {
            // Redirect to Manage Flights Form
            throw new NotImplementedException();
        }

        private void ManageAircraftsButton_Click(object? sender, EventArgs e)
        {
            // Redirect to Manage Aircrafts Form
            throw new NotImplementedException();
        }
    }
}
