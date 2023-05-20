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
    public partial class BookTicketForm : Form
    {
        private readonly ITicketRequester clientProcess;
        private List<string> availableFlightClasses = new() { "Business", "Economy" };
        private readonly List<string> availableOrigins = GlobalConfig.Connector.Get_AllOrigins();
        private readonly List<string> availableDestinations = GlobalConfig.Connector.Get_AllDestinations();
        private List<FlightModel> flights = new();
        private readonly CustomerModel currentCustomer;

        public BookTicketForm(ITicketRequester client, CustomerModel customer)
        {
            InitializeComponent();

            clientProcess = client;
            currentCustomer = customer;

            SetUpForm();
        }

        private void SetUpForm()
        {
            // SET UP FORM CONTROLS
            datePicker.MinDate = DateTime.Now;
            datePicker.MaxDate = DateTime.Now.AddYears(1);

            classComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            errorLabel.Text = "";

            // populate origin/destination combo boxes
            originComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            originComboBox.Items.AddRange(availableOrigins.ToArray());

            destinationComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            destinationComboBox.Items.AddRange(availableDestinations.ToArray());

            // add event handlers
            findFlightsButton.Click += FindFlightsButton_Click;
            flightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            bookFlightButton.Click += BookFlightButton_Click;
        }

        private void BookFlightButton_Click(object? sender, EventArgs e)
        {
            if (!ValidateTicketForm())
            {
                return;
            }

            // aquire data from fields (build a ticket)
            var ticket = new FlightTicketModel
            {
                // TODO - Decide on how to generate unique ticket numbers
                TicketNumber = "XYZ123",

                Passenger = currentCustomer,
                Flight = (FlightModel)flightsListBox.SelectedItem,

                // TODO - (OPTIONAL) Could be better!
                FlightClass = ((string)classComboBox.SelectedItem
                    == "Business" ? FlightClass.Business : FlightClass.Economy)
            };

            bool bookedOnThisFlight = GlobalConfig.Connector.CheckTicket_Exists(ticket);
            if (bookedOnThisFlight)
            {
                errorLabel.Text = "You have already booked a ticket on this flight.";

                return;
            }

            // TODO - Payment
            // Remeber to handle the case where the user chooses business class,
            // this adds more cost to the ticket


            // save ticket to database
            ticket = GlobalConfig.Connector.CreateTicket(ticket);

            clientProcess.TicketResponse(ticket);

            this.Close();
        }

        private bool ValidateTicketForm()
        {
            // TODO - Implement necessary checks (e.g., there is a flight selected, there is a class selected, etc.)

            return true;
        }

        private void FlightsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (flightsListBox.SelectedItems.Count < 1)
            {
                return;
            }

            var flight = (FlightModel)flightsListBox.SelectedItem;

            WireUpFlightDetails(flight);
            WireUpClassComboBox(flight);
        }

        private void WireUpFlightDetails(FlightModel flight)
        {
            flightNumberTextBox.Text = flight.FlightNumber;
            flightDetailsOriginTextBox.Text = flight.OriginAirport;
            flightDetailsDestinationTextBox.Text = flight.DestinationAirport;
            departureTimeTextBox.Text = flight.DepartureTime.ToShortTimeString().ToString();
            arrivalTimeTextBox.Text = flight.ArrivalTime.ToShortTimeString().ToString();
            tripDurationTextBox.Text = flight.TripDurationString;
            costTextBox.Text = $"${flight.Cost:f2}";
            aircraftModelTextBox.Text = flight.Aircaft.ModelName;
        }

        private void WireUpClassComboBox(FlightModel flight)
        {
            availableFlightClasses = new List<string>();

            if (flight.BusinessClassSeats > 0)
            {
                availableFlightClasses.Add("Business");
            }

            if (flight.EconomyClassSeats > 0)
            {
                availableFlightClasses.Add("Economy");
            }

            classComboBox.DataSource = availableFlightClasses;
        }

        private void FindFlightsButton_Click(object? sender, EventArgs e)
        {
            // aquire data from fields
            var query = new FlightQuery
            {
                Date = datePicker.Value.Date.AddHours(DateTime.Now.Hour),
                OriginAirport = (string)originComboBox.SelectedItem,
                DestinationAirport = (string)destinationComboBox.SelectedItem
            };

            // load from database into flights list
            flights = GlobalConfig.Connector.GetFlights_DateOriginDestination(query);

            // WireUpFlightsListBox
            flightsListBox.DataSource = flights.OrderBy(flight => flight.DepartureTime).ToList();
            flightsListBox.DisplayMember = "FlightSummary";
        }
    }
}
