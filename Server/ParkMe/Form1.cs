using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkMe
{
    public partial class Form1 : Form
    {
        private SensorDataReceiver sensorReceiver;
        private ParkingSpaceLogic parkingSpaceLogic;

        public Form1()
        {
            InitializeComponent();

            sensorReceiver = new SensorDataReceiver();
            parkingSpaceLogic = new ParkingSpaceLogic();
            sensorReceiver.ParkingStatusUpdated += SensorReceiver_ParkingStatusUpdated;
        }

        private void SensorReceiver_ParkingStatusUpdated(object sender, ParkingStatusEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(() => SensorReceiver_ParkingStatusUpdated(sender, e)));
                return;
            }

            int spaceId = e.SpaceId;
            bool occupied = e.Occupied;
            string licensePlate = occupied ? e.LicensePlate : "N/A";
            Color panelColor = occupied ? Color.Red : Color.Green;

            lblNumberOfTakenSpaces.Text = parkingSpaceLogic.getAvailabilityOfGarage(occupied) + " zauzeto";

            switch (spaceId)
            {
                case 1:
                    panelSpace1.BackColor = panelColor;
                    labelSpace1.Text = $"1: {(occupied ? "Zauzeto" : "Slobodno")}";
                    labelPlate1.Text = $"Tablica: {licensePlate}";
                    break;
                case 2:
                    panelSpace2.BackColor = panelColor;
                    labelSpace2.Text = $"2: {(occupied ? "Zauzeto" : "Slobodno")}";
                    labelPlate2.Text = $"Tablica: {licensePlate}";
                    break;
                case 3:
                    panelSpace3.BackColor = panelColor;
                    labelSpace3.Text = $"3: {(occupied ? "Zauzeto" : "Slobodno")}";
                    labelPlate3.Text = $"Tablica: {licensePlate}";
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            sensorReceiver.Close();
            base.OnFormClosing(e);
        }
    }
}
