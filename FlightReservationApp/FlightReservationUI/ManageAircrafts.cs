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
    public partial class ManageAircrafts : Form
    {
        private List<AircaftModel> Aircrafts;
        private int selectedIndex = 0;
        private bool hasChildren = false;


        // Make Confirmation Messages On Delete and Modify Btns
        // Validate Modified Input
        public ManageAircrafts()
        {
            InitializeComponent();

            AircraftListBox.SelectedIndexChanged += AircraftListBox_SelectedIndexChanged;
            ModifyButton.Click += ModifyButton_Click;
            AddAircraftButton.Click += AddAircraftButton_Click;
            this.FormClosed += ManageAircrafts_FormClosed;

            ReLoadAircraftsListBox();
        }

        private void ManageAircrafts_FormClosed(object? sender, FormClosedEventArgs e)
        {
            if (!hasChildren)
                new AdminMainForm().Show();
        }

        private void AddAircraftButton_Click(object? sender, EventArgs e)
        {
            new CreateAirCraftForm().Show();
            hasChildren = true;
            this.Close();
        }

        private void ModifyButton_Click(object? sender, EventArgs e)
        {
            if (!CheckValidInputs())
                return;

            const string questionMessage = "Do You Really want to Modify?";
            const string windowTitle = "Confirm Modification";
            if (!MessageController.ConfirmOperationMessageBox(questionMessage, windowTitle))
            {
                ReLoadAircraftsListBox();
                return;
            }

            var selectedAircraft = Aircrafts[selectedIndex];
            UpdateInMemory(selectedAircraft);
            GlobalConfig.Connector.UpdateAircraft(selectedAircraft);
            ReLoadAircraftsListBox();

            MessageController.DisplayLabelSuccessMessage(ReplyMessageLabel, "Modified Successfully");
        }

        private void AircraftListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectedIndex = AircraftListBox.SelectedIndex;
            var aircraft = Aircrafts[selectedIndex];

            SerialNTextbox.Text = aircraft.SerialNumber;
            ModelNameTextbox.Text = aircraft.ModelName;
            nSeatsTextBox.Text = aircraft.NumberOfSeats.ToString();
        }



        private void ReLoadAircraftsListBox()
        {
            Aircrafts = GlobalConfig.Connector.GetAllAircrafts(); // Doesn't work in constructor >> why?

            ResetAircraftData();
            AircraftListBox.DataSource = Aircrafts;
            AircraftListBox.DisplayMember = "FullModelData";
        }

        private void UpdateInMemory(AircaftModel aircraft)
        {
            aircraft.ModelName = ModelNameTextbox.Text;
            aircraft.SerialNumber = SerialNTextbox.Text;
            aircraft.NumberOfSeats = int.Parse(nSeatsTextBox.Text);
        }

        private void ResetAircraftData()
        {
            SerialNTextbox.Text = "";
            ModelNameTextbox.Text = "";
            nSeatsTextBox.Text = "";
        }


        // --------------------------- validation --------------------

        private bool CheckValidInputs()
        {
            if (Aircrafts.Count == 0)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "There are No Existing Aircrafts");
                return false;
            }

            var aircraft = Aircrafts[selectedIndex];
            if (CheckSerialNumberExistence(aircraft.Id, SerialNTextbox.Text))
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "Serial Number Used");
                return false;
            }

            if (ModelNameTextbox.Text.Length < 4 || ModelNameTextbox.Text.Length > 40)
            {
                MessageController.DisplayLabelErrorMessage(ReplyMessageLabel, "ModelName is not valid");
                return false;
            }

            int nSeats;
            if (!int.TryParse(nSeatsTextBox.Text, out nSeats))
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

        private bool CheckSerialNumberExistence(int ModifiedAircraftId, string newSerialNumber)
        {
            foreach (var aircraft in Aircrafts)
            {
                if (aircraft.Id != ModifiedAircraftId && aircraft.SerialNumber == newSerialNumber)
                    return true;
            }

            return false;
        }
    }
}
