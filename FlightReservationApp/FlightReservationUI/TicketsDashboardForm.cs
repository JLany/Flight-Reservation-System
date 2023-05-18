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
    public partial class TicketsDashboardForm : Form
    {
        private CustomerModel currentCustomer;
        private List<FlightTicketModel> tickets;

        public TicketsDashboardForm(string customerEmail)
        {
            InitializeComponent();

            currentCustomer = GlobalConfig.Connector.GetCustomer_ByEmail(customerEmail);
            tickets = GlobalConfig.Connector.GetTickets_ByCustomer(currentCustomer);

            WireUpTicketsListBox();
            SetUpTicketDetails();
        }

        private void SetUpTicketDetails()
        {
            ticketsListBox.SelectedIndex = -1;
            ticketDetailsGroupBox.Enabled = false;
            ticketsListBox.SelectedValueChanged += TicketsListBox_SelectedValueChanged;
        }

        private void TicketsListBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            WireUpTicketDetails(((FlightTicketModel)ticketsListBox.SelectedItem));
        }

        private void WireUpTicketsListBox()
        {
            ticketsListBox.DataSource = tickets;
            ticketsListBox.DisplayMember = "Summary";
        }

        private void WireUpTicketDetails(FlightTicketModel ticket)
        {
            if (ticket == null)
            {
                return;
            }

            ticketDetailsGroupBox.Enabled = true;

            ticketNumberTextBox.Text = ticket.TicketNumber;
            classComboBox.Text = ticket.FlightClass.ToString();

            WireUpFlightDeatils(ticket.Flight);
        }

        private void WireUpFlightDeatils(FlightModel flight)
        {
            flightNumberText.Text = flight.FlightNumber;
            departureTimeText.Text = flight.DepartureTime.ToString();
            arrivalTimeText.Text = flight.ArrivalTime.ToString();
            aircraftModelText.Text = flight.Aircaft.ModelName;
            originText.Text = flight.OriginAirport;
            destinationText.Text = flight.DestinationAirport;
            tripDurationText.Text = flight.TripDurationString;
        }
    }
}
