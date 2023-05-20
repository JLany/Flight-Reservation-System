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
            UpdateComboBox();
        }

        private void ArrivalTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            UpdateComboBox();
        }

        private void DepartureTimePicker_ValueChanged(object? sender, EventArgs e)
        {
            UpdateComboBox();
        }

        private void ResetFlightForm()
        {
            flightNumberTextBox.Text = "";
            originTextBox.Text = "";
            destinationTextBox.Text = "";
            tripDurationTextBox.Text = "";
            costTextBox.Text = "";
            businessClassSeatsTextBox.Text = "";
            economyClassSeatsTextBox.Text = "";
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
            UpdateComboBox();
        }
    }
}
