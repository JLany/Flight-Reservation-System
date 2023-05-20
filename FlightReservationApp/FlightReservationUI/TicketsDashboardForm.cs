using FlightReservationLibrary;
using FlightReservationLibrary.Models;
using FlightReservationUI.Communication;
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
    public partial class TicketsDashboardForm : Form, ITicketRequester
    {
        private readonly CustomerModel currentCustomer;
        private List<FlightTicketModel> tickets;
        private bool hasChildren = false;

        public TicketsDashboardForm(string customerEmail, string message = "")
        {
            InitializeComponent();

            currentCustomer = GlobalConfig.Connector.GetCustomer_ByEmail(customerEmail);
            tickets = GlobalConfig.Connector.GetTickets_ByCustomer(currentCustomer);
            messageLabel.Text = message;

            WireUpTicketsListBox();
            SetUpTicketDetails();

            cancelTicketButton.Click += CancelTicketButton_Click;
            bookNewTicketButton.Click += BookNewTicketButton_Click;
            manageAccountLink.LinkClicked += ManageAccountLink_LinkClicked;
            this.FormClosed += TicketsDashboardForm_FormClosed;
        }

        private void CancelTicketButton_Click(object? sender, EventArgs e)
        {
            var ticket = (FlightTicketModel)ticketsListBox.SelectedItem;

            if (!IsAbleToCancel(ticket))
            {
                return;
            }

            var response = MessageBox.Show("Are you sure you want to cancel this ticket?", "Confirm"
                , MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                // Delete ticket from database
                GlobalConfig.Connector.DeleteTicket(ticket);

                // TODO - Implement a way to communicate back to customer about his refund (Payment)

                // Remove ticket from list of tickets
                tickets.Remove(ticket);

                // Wire up tickets list
                WireUpTicketsListBox();
            }
        }

        private bool IsAbleToCancel(FlightTicketModel ticket)
        {
            bool ableToCancel = true;

            if (ticket.Flight.DepartureTime.Subtract(DateTime.Now).TotalHours < 24) 
            {
                ableToCancel = false;
                MessageBox.Show("You can only cancel a flight before 24 hours or more of its departure time.",
                    "Denied", MessageBoxButtons.OK);
            }

            return ableToCancel;
        }

        private void ManageAccountLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ManageAccountForm(currentCustomer).Show();
            hasChildren = true;
            this.Close();
        }

        private void TicketsDashboardForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!hasChildren) 
            {
                new LoginForm().Show();
            }
        }

        private void BookNewTicketButton_Click(object? sender, EventArgs e)
        {
            new BookTicketForm(this, currentCustomer).Show();
            this.Enabled = false;
        }

        private void SetUpTicketDetails()
        {
            ticketsListBox.SelectedIndex = -1;
            ticketDetailsGroupBox.Enabled = false;
            ticketsListBox.SelectedValueChanged += TicketsListBox_SelectedValueChanged;
        }

        private void TicketsListBox_SelectedValueChanged(object? sender, EventArgs e)
        {
            if (ticketsListBox.SelectedItems.Count < 1)
            {
                return;
            }

            WireUpTicketDetails((FlightTicketModel)ticketsListBox.SelectedItem);
        }

        private void WireUpTicketsListBox()
        {
            ticketsListBox.DataSource = tickets.OrderBy(ticket => ticket.Flight.DepartureTime).ToList();
            ticketsListBox.DisplayMember = "TicketSummary";
        }

        private void WireUpTicketDetails(FlightTicketModel ticket)
        {
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

        void ITicketRequester.TicketResponse(FlightTicketModel ticket)
        {
            if (ticket != null)
            {
                tickets.Add(ticket);
                WireUpTicketsListBox();
            }

            this.Enabled = true;
        }
    }
}
