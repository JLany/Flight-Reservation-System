using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightReservationLibrary;
using FlightReservationLibrary.Models;

namespace FlightReservationUI
{
    public partial class CreateAirCraftForm : Form
    {
        public CreateAirCraftForm()
        {
            InitializeComponent();
        }

        private void addAircraftButton_Click(object sender, EventArgs e)
        {

            // TODO - SerialNumber existence
            // TODO - validate nSeats
            var aircraft = new AircaftModel
            {
                SerialNumber = serialNumberTextBox.Text,
                ModelName = modelTextBox.Text,
                NumberOfSeats = int.Parse(numberOfSeatsTextBox.Text) // TryParse remember
            };

            aircraft = GlobalConfig.Connector.CreateAircraft(aircraft);

            resetAircraftForm();

            // TODO - Redirect To Dashboard
        }

        private void resetAircraftForm()
        {
            serialNumberTextBox.Text = "";
            modelTextBox.Text = "";
            numberOfSeatsTextBox.Text = "";
        }
    }
}
