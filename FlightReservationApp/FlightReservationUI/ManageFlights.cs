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
    public partial class ManageFlights : Form
    {
        private List<FlightModel> Flights;
        private int selectedIndex = 0;
        private bool hasChildren = false;

        public ManageFlights()
        {
            InitializeComponent();

            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            ModifyButton.Click += ModifyButton_Click;
            CancelFlightButton.Click += CancelFlightButton_Click;
            AddFlightButton.Click += AddFlightButton_Click;
            this.FormClosed += ManageFlights_FormClosed;

            ReLoadFlightsListBox();
        }

        private void AddFlightButton_Click(object? sender, EventArgs e)
        {
            new CreateFlightForm().Show();
            hasChildren = true;
            this.Close();
        }

        private void ManageFlights_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!hasChildren)
                new AdminMainForm().Show();
        }

        private void CancelFlightButton_Click(object? sender, EventArgs e)
        {
            if (!IsAbleToCancelFlight())
                return;

            const string questionMessage = "Do You Really want to Cancel Flight?";
            const string windowTitle = "Confirm Cancelation";
            if (!MessageController.ConfirmOperationMessageBox(questionMessage, windowTitle))
            {
                ReLoadFlightsListBox();
                return;
            }

            var selectedFlight = Flights[selectedIndex];
            GlobalConfig.Connector.DeleteFlight_ById(selectedFlight.Id);
            ReLoadFlightsListBox();
            
            MessageController.DisplayLabelSuccessMessage(CancelReplyMessageLabel, "Canceled Successfully");
            MessageController.RemoveLabelText(ModifyReplyMessageLabel);
        }

        private void ModifyButton_Click(object? sender, EventArgs e)
        {
            if (!CheckValidInputs())
                return;

            const string questionMessage = "Do You Really want to Modify?";
            const string windowTitle = "Confirm Modification";
            if (!MessageController.ConfirmOperationMessageBox(questionMessage, windowTitle))
            {
                ReLoadFlightsListBox();
                return;
            }

            var selectedFlight = Flights[selectedIndex];
            GlobalConfig.Connector.UpdateFlightDate_ByID
                (DepartureTimePicker.Value, ArrivalTimePicker.Value, selectedFlight.Id);
            ReLoadFlightsListBox();

            MessageController.DisplayLabelSuccessMessage(ModifyReplyMessageLabel, "Modified Successfully");
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

            // this throws an exception
            /*AircraftTextBox.Text = (((AircaftModel)flight.Aircaft).PartialModelData);*/

            TripDurationTextBox.Text = flight.TripDuration.ToString();
            BusinessClassSeatsTextBox.Text = flight.BusinessClassSeats.ToString();
            EconomyClassSeatsTextBox.Text = flight.EconomyClassSeats.ToString();
        }

        private void ReLoadFlightsListBox()
        {
            Flights = GlobalConfig.Connector.GetAllFlights();

            FlightsListBox.DataSource = Flights;
            FlightsListBox.DisplayMember = "FlightDetails";
        }

        // ------------------------------ Validation -------------------------------------

        private bool CheckValidInputs()
        {
            if (Flights.Count == 0)
            {
                MessageController.DisplayLabelErrorMessage(ModifyReplyMessageLabel, "There are No Flights");
                MessageController.RemoveLabelText(CancelReplyMessageLabel);
                return false;
            }

            var TripDuration = ArrivalTimePicker.Value.Subtract(DepartureTimePicker.Value).TotalHours;
            if (TripDuration < 0)
            {
                MessageController.DisplayLabelErrorMessage(ModifyReplyMessageLabel, "Times are invalid");
                MessageController.RemoveLabelText(CancelReplyMessageLabel);
                return false;
            }

            if (DepartureTimePicker.Value.Subtract(DateTime.Now).TotalHours < 24)
            {
                MessageController.DisplayLabelErrorMessage(ModifyReplyMessageLabel, "Too Late to modify Time");
                MessageController.RemoveLabelText(CancelReplyMessageLabel);
                return false;
            }

            return true;
        }

        private bool IsAbleToCancelFlight()
        {

            if (Flights.Count == 0)
            {
                MessageController.DisplayLabelErrorMessage(CancelReplyMessageLabel, "There are No Flights");
                MessageController.RemoveLabelText(ModifyReplyMessageLabel);
                return false;
            }

            var selectedFlight = Flights[selectedIndex];
            if (selectedFlight.DepartureTime.Subtract(DateTime.Now).TotalHours < 24)
            {
                MessageController.DisplayLabelErrorMessage(CancelReplyMessageLabel, "Too Late to Cancel Flight");
                MessageController.RemoveLabelText(ModifyReplyMessageLabel);
                return false;
            }

            return true;
        }
    }
}
