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
using FlightReservationUI.Communication;

namespace FlightReservationUI
{
    public partial class CreateAirCraftForm : Form
    {
        public CreateAirCraftForm()
        {
            InitializeComponent();

            this.FormClosed += CreateAirCraftForm_FormClosed;
        }

        private void CreateAirCraftForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            new ManageAircrafts().Show();
        }

        private void addAircraftButton_Click(object sender, EventArgs e)
        {
            if (!CheckValidInputs())
                return;

            var aircraft = new AircaftModel
            {
                SerialNumber = serialNumberTextBox.Text,
                ModelName = modelTextBox.Text,
                NumberOfSeats = int.Parse(numberOfSeatsTextBox.Text) // TryParse remember
            };

            aircraft = GlobalConfig.Connector.CreateAircraft(aircraft);

            this.Close();
        }


        private bool CheckValidInputs()
        {
            if (serialNumberTextBox.Text.Length == 0)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Serial Number Is Not Valid");
                return false;
            }

            if (GlobalConfig.Connector.CheckAircraft_SerialNumberExists(serialNumberTextBox.Text))
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Serial Number Used");
                return false;
            }

            if (modelTextBox.Text.Length < 4 || modelTextBox.Text.Length > 50)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "ModelName is not valid");
                return false;
            }

            int nSeats;
            if (!int.TryParse(numberOfSeatsTextBox.Text, out nSeats))
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Number of Seats is Not Valid");
                return false;
            }

            if (nSeats > 180 || nSeats < 100)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Number of Seats is not Valid");
                return false;
            }

            return true;
        }

    }
}
