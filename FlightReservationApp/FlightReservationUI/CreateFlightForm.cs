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
    public partial class CreateFlightForm : Form
    {

        List<AircaftModel> AvailableAircraft;
        public CreateFlightForm()
        {
            InitializeComponent();

            AvailableAircraft = new List<AircaftModel>();
            aircraftComboBox.DataSource = AvailableAircraft;
            aircraftComboBox.DisplayMember = "ModelData";
        }

        /*
         * Retrieve all available Aircrafts between Deprature Time and Arrival Time @ Constructor call
         * make ComboBox dataSource = AvailableAircrafts
         * Change Available Aircrafts Eachtime Time changes
         * 
         * First Let's Write Stored Procedure
         */

        private void departureTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AvailableAircraft = GlobalConfig.Connector.GetAircafts_ByDate(departureTimePicker.Value, arrivalTimePicker.Value);
            aircraftComboBox.DataSource = AvailableAircraft;
            aircraftComboBox.DisplayMember = "ModelData";
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            // TODO - validate TripDuration, Cost field

            var flight = new FlightModel
            {
                FlightNumber = flightNumberTextBox.Text,
                OriginAirport = originTextBox.Text,
                DestinationAirport = destinationTextBox.Text,
                DepartureTime = departureTimePicker.Value,
                ArrivalTime = arrivalTimePicker.Value,
                TripDuration = double.Parse(tripDurationTextBox.Text), // Try Parse, ??do we really need a field for Trip Duration??
                Cost = decimal.Parse(costTextBox.Text), // Try Parse
                Aircaft = (AircaftModel)aircraftComboBox.SelectedItem,
                BusinessClassSeats = int.Parse(businessClassSeatsTextBox.Text),
                EconomyClassSeats = int.Parse(economyClassSeatsTextBox.Text)
            };

            flight = GlobalConfig.Connector.CreateFlight(flight);

            ResetFlightForm();
        }

        private void ResetFlightForm()
        {
            flightNumberTextBox.Text = "";
            originTextBox.Text = "";
            destinationTextBox.Text = "";
            tripDurationTextBox.Text = ""; // Try Parse
            costTextBox.Text = ""; // Try Parse
            businessClassSeatsTextBox.Text = "";
            economyClassSeatsTextBox.Text = "";
        }
    }
}
