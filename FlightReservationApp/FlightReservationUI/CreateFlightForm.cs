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
    public partial class CreateFlightForm : Form
    {

        /*
         * Check DepDate < ArrivalDate
         * Remove Trip Duration
         * Validate nEconomy/Business Seats
         */

        List<AircaftModel> AvailableAircraft;
        public CreateFlightForm()
        {
            InitializeComponent();

            AvailableAircraft = new List<AircaftModel>();
            departureTimePicker.ValueChanged += DepartureTimePicker_ValueChanged;
            arrivalTimePicker.ValueChanged += ArrivalTimePicker_ValueChanged;
            this.FormClosed += CreateFlightForm_FormClosed;

            UpdateComboBox();
        }

        private void CreateFlightForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            new ManageFlights().Show();
        }

        private void ArrivalTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            UpdateComboBox();
        }

        private void DepartureTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            UpdateComboBox();
        }

        private void UpdateComboBox()
        {
            AvailableAircraft = GlobalConfig.Connector.GetAircafts_ByDate(departureTimePicker.Value, arrivalTimePicker.Value);
            aircraftComboBox.DataSource = new List<AircaftModel>();
            aircraftComboBox.DataSource = AvailableAircraft;
            aircraftComboBox.DisplayMember = "PartialModelData";
        }

        private void addFlightButton_Click(object sender, EventArgs e)
        {
            if (!CheckValidInput())
                return;

            var flight = new FlightModel()
            {
                FlightNumber = flightNumberTextBox.Text,
                OriginAirport = originTextBox.Text,
                DestinationAirport = destinationTextBox.Text,
                DepartureTime = departureTimePicker.Value,
                ArrivalTime = arrivalTimePicker.Value,
                TripDuration = arrivalTimePicker.Value.Subtract(departureTimePicker.Value).TotalHours, // Try Parse, ??do we really need a field for Trip Duration??
                Cost = decimal.Parse(costTextBox.Text), // Try Parse
                Aircaft = (AircaftModel)aircraftComboBox.SelectedItem,
                BusinessClassSeats = int.Parse(businessClassSeatsTextBox.Text),
                EconomyClassSeats = int.Parse(economyClassSeatsTextBox.Text)
            };

            flight = GlobalConfig.Connector.CreateFlight(flight);

            UpdateComboBox();

            this.Close();
        }




        // ------------------------- VALIDATION ---------------------------------
        private bool CheckValidInput()
        {

            var TripDuration = arrivalTimePicker.Value.Subtract(departureTimePicker.Value).TotalHours;
            if (TripDuration <= 0)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Times are invalid");
                return false;
            }

            if (departureTimePicker.Value.Subtract(DateTime.Now).TotalHours < 24)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Too Late to Make a new Flight");
                return false;
            }

            if (GlobalConfig.Connector.CheckFlight_NumberExists(flightNumberTextBox.Text))
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Flight Number Used");
                return false;
            }

            if (flightNumberTextBox.Text == "")
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Invalid Flight Number");
                return false;
            }

            if (originTextBox.Text.Length < 2 || originTextBox.Text.Length > 60)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Invalid Origin Country");
                return false;
            }

            if (destinationTextBox.Text.Length < 2 || destinationTextBox.Text.Length > 60)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Invalid Destination Country");
                return false;
            }

            decimal cost;
            if (!decimal.TryParse(costTextBox.Text, out cost) || cost <= 0)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Invalid Cost");
                return false;
            }


            int nBusinessSeats;
            if (!int.TryParse(businessClassSeatsTextBox.Text, out nBusinessSeats) || nBusinessSeats <= 0)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Invalid Business Seats Input");
                return false;
            }

            int nEconomySeats;
            if (!int.TryParse(economyClassSeatsTextBox.Text, out nEconomySeats) || nEconomySeats <= 0)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Invalid Economy Seats Input");
                return false;
            }

            return true;
        }
    }
}
