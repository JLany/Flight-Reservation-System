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
    public partial class ManageFlights : Form
    {
        private List<FlightModel> Flights;
        private int selectedIndex = 0;

        public ManageFlights()
        {
            InitializeComponent();

            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            ModifyButton.Click += ModifyButton_Click;
            CancelFlightButton.Click += CancelFlightButton_Click;
            ReLoadFlightsListBox();
        }

        private void CancelFlightButton_Click(object? sender, EventArgs e)
        {
            if (Flights.Count == 0)
                return;

            var selectedFlight = Flights[selectedIndex];
            GlobalConfig.Connector.DeleteFlight_ById(selectedFlight.Id);
            ReLoadFlightsListBox();
        }

        private void ModifyButton_Click(object? sender, EventArgs e)
        {
            if (Flights.Count == 0)
                return;

            var selectedFlight = Flights[selectedIndex];
            GlobalConfig.Connector.UpdateFlightDate_ByID
                (DepartureTimePicker.Value, ArrivalTimePicker.Value, selectedFlight.Id);
            ReLoadFlightsListBox();
        }

        private void FlightsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {

            selectedIndex = FlightsListBox.SelectedIndex;
            var flight = Flights[selectedIndex];

            FlightNumberTextBox.Text = flight.FlightNumber.ToString();
            OriginTextBox.Text = flight.OriginAirport;
            DestinationTextBox.Text = flight.DestinationAirport;
            CostTextBox.Text = flight.Cost.ToString();
            DepartureTimePicker.Value = flight.DepartureTime;
            ArrivalTimePicker.Value = flight.ArrivalTime;
            TripDurationTextBox.Text = flight.TripDuration.ToString();
            BusinessClassSeatsTextBox.Text = flight.BusinessClassSeats.ToString();
            EconomyClassSeatsTextBox.Text = flight.EconomyClassSeats.ToString();
        }

        private void ReLoadFlightsListBox()
        {
            Flights = GlobalConfig.Connector.GetAllFlights();

            ResetFlightData();
            FlightsListBox.DataSource = Flights;
            FlightsListBox.DisplayMember = "FlightDetails";
        }

        private void ResetFlightData()
        {
            FlightNumberTextBox.Text = "";
            OriginTextBox.Text = "";
            DestinationTextBox.Text = "";
            TripDurationTextBox.Text = "";
            CostTextBox.Text = "";
            BusinessClassSeatsTextBox.Text = "";
            EconomyClassSeatsTextBox.Text = "";
        }
    }
}
