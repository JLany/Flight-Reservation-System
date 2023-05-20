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
    public partial class ManageAircrafts : Form
    {
        private List<AircaftModel> Aircrafts;
        private int selectedIndex = 0;

        public ManageAircrafts()
        {
            InitializeComponent();
            
            AircraftListBox.SelectedIndexChanged += AircraftListBox_SelectedIndexChanged;
            ModifyButton.Click += ModifyButton_Click;
            DeleteAircraftButton.Click += DeleteAircraftButton_Click;

            ReLoadAircraftsListBox();
        }

        private void DeleteAircraftButton_Click(object? sender, EventArgs e)
        {
            if (Aircrafts.Count == 0)
                return;

            var selectedAircraft = Aircrafts[selectedIndex];
            GlobalConfig.Connector.DeleteAircraft_ById(selectedAircraft.Id);
            Aircrafts.RemoveAt(selectedIndex);
            ReLoadAircraftsListBox();
        }

        private void ModifyButton_Click(object? sender, EventArgs e)
        {
            if (Aircrafts.Count == 0)
                return;

            var selectedAircraft = Aircrafts[selectedIndex];
            UpdateAircraftinMemory(selectedAircraft);
            GlobalConfig.Connector.UpdateAircraft(selectedAircraft);
            ReLoadAircraftsListBox();
        }

        private void AircraftListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            selectedIndex = AircraftListBox.SelectedIndex;
            var aircraft = Aircrafts[selectedIndex];

            IdTextbox.Text = aircraft.Id.ToString();
            SerialNTextbox.Text = aircraft.SerialNumber;
            ModelNameTextbox.Text = aircraft.ModelName;
            nSeatsTextBox.Text = aircraft.NumberOfSeats.ToString();
        }



        private void ReLoadAircraftsListBox()
        {
            AircraftListBox.Items.Clear();
            Aircrafts = GlobalConfig.Connector.GetAllAircrafts();

            foreach(var aircraft in Aircrafts)
                AircraftListBox.Items.Add(aircraft);
            
            AircraftListBox.DisplayMember = "FullModelData";
            if (Aircrafts.Count > 0)
                AircraftListBox.SelectedIndex = selectedIndex; // do i remove this from here?
        }

        // updates from text boxes
        private void UpdateAircraftinMemory(AircaftModel aircraft)
        {
            aircraft.SerialNumber = SerialNTextbox.Text;
            aircraft.ModelName = ModelNameTextbox.Text;
            aircraft.NumberOfSeats = int.Parse(nSeatsTextBox.Text);
        }
    }
}
